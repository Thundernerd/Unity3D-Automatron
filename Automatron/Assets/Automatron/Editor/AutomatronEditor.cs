using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using TNRD.Editor.Core;
using System;
using System.Linq;
using TNRD.Automatron.Drawers;
using TNRD.Editor;
using TNRD.Editor.Utilities;
using TNRD.Automatron.Automations;
using TNRD.Editor.Serialization;
using System.Collections;
using TNRD.Editor.Windows;
using System.Reflection;

namespace TNRD.Automatron {

    public class AutomatronEditor : ExtendedWindow {

        #region Automation Loading
        private static Dictionary<string, Type> automations = new Dictionary<string, Type>();

        [InitializeOnLoadMethod]
        private static void LoadAutomations() {
            var mush = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                       from type in assembly.GetTypes()
                       let attributes = type.GetCustomAttributes( typeof( AutomationAttribute ), true )
                       where attributes != null && attributes.Length > 0
                       select new { AutomationType = type, Attributes = attributes.Cast<AutomationAttribute>() };

            mush = mush.OrderBy( m => m.Attributes.ElementAt( 0 ).Name );

            foreach ( var item in mush ) {
                var name = item.Attributes.ElementAt( 0 ).Name;
                if ( !automations.ContainsKey( name ) ) {
                    automations.Add( name, item.AutomationType );
                }
            }
        }
        #endregion

        #region Drawer Loading
        private static Dictionary<Type, Type> drawers = new Dictionary<Type, Type>();


        [InitializeOnLoadMethod]
        private static void LoadDrawers() {
            var mush = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                       from type in assembly.GetTypes()
                       let attributes = type.GetCustomAttributes( typeof( CustomDrawerAttribute ), true )
                       where attributes != null && attributes.Length > 0
                       select new { DrawerType = type, Attributes = attributes.Cast<CustomDrawerAttribute>() };

            foreach ( var item in mush ) {
                var type = item.Attributes.ElementAt( 0 ).Type;
                if ( !drawers.ContainsKey( type ) ) {
                    drawers.Add( type, item.DrawerType );
                }
            }
        }

        public static Type GetDrawerType( Type fieldType ) {
            if ( drawers.ContainsKey( fieldType ) ) {
                return drawers[fieldType];
            } else {
                return typeof( HelpDrawer );
            }
        }
        #endregion

        #region Type Loading
        [InitializeOnLoadMethod]
        private static void LoadTypes() {
            Globals.Types = GetAssemblyTypes( 
                "Assembly-CSharp", 
                "Assembly-CSharp-Editor", 
                "UnityEngine", 
                "UnityEditor" );
        }

        private static List<Type> GetAssemblyTypes( params string[] names ) {
            var list = new List<Type>();
            foreach ( var item in names ) {
                var assembly = Assembly.Load( item );
                list.AddRange( assembly.GetTypes()
                    .Where( t => t.IsPublic )
                    .Where( t => !t.Name.StartsWith( "<" ) && !t.Name.StartsWith( "$" ) ) );
            }
            return list;
        }
        #endregion

        [MenuItem( "Window/Automatron" )]
        private static void Init() {
            var wnd = CreateEditor( "Automatron" );
            wnd.minSize = new Vector2( 960, 540 );
            wnd.Show( true );
        }

        private QueueStart entryPoint;
        [RequireSerialization]
        private string entryId;

        private GUIContent executeContent;
        private GUIContent stopContent;
        private GUIContent trashContent;
        private GUIContent resetContent;

        private EditorCoroutine executionRoutine = null;

        protected override void OnInitialize() {
            WindowStyle = EWindowStyle.NoToolbarLight;

            entryPoint = new QueueStart() {
                IsInitial = true,
                Position = WindowRect.center - new Vector2( 75, 50 )
            };

            AddControl( entryPoint );

            WindowSettings.IsFullscreen = true;
            Globals.Camera = new Vector2();

            CreateIcons();
        }

        protected override void OnBeforeSerialize() {
            entryId = entryPoint.ID;
        }

        protected override void OnAfterSerialized() {
            var entries = GetControls<QueueStart>();
            foreach ( var item in entries ) {
                if ( item.ID == entryId ) {
                    entryPoint = item;
                    break;
                }
            }

            WindowSettings.IsFullscreen = true;
            Globals.Camera = new Vector2();

            CreateIcons();
        }

        private void CreateIcons() {
            // Secretly reusing the foldOut
            executeContent = new GUIContent( Assets["foldOut"], "Execute the automation sequence" );
            stopContent = new GUIContent( Assets["stop"], "Stop the active automation sequence" );
            resetContent = new GUIContent( Assets["reset"], "Reset the values and progress of the automations" );
            trashContent = new GUIContent( Assets["trash"], "Remove all the automations" );
        }

        protected override void OnGUI() {
            EditorGUILayout.BeginHorizontal( EditorStyles.toolbar );
            if ( GUILayout.Button( "File", EditorStyles.toolbarDropDown ) ) {

            }

            if ( GUILayout.Button( "Automations", EditorStyles.toolbarDropDown ) ) {
                var menu = GenericMenuBuilder.CreateMenu();
                foreach ( var item in automations ) {
                    menu.AddItem( item.Key, false, CreateAutomation, new object[] { Input.MousePosition, item.Value } );
                }
                menu.ShowAsContext();
            }

            // Spacer
            GUILayout.Button( "", EditorStyles.toolbarButton );

            if ( Globals.IsExecuting ) {
                if ( GUILayout.Button( stopContent, EditorStyles.toolbarButton ) ) {
                    executionRoutine.Stop();
                    executionRoutine = null;
                    Globals.IsExecuting = false;
                }
            } else {
                if ( GUILayout.Button( executeContent, EditorStyles.toolbarButton ) ) {
                    ExecuteAutomations();
                }
            }

            if ( GUILayout.Button( resetContent, EditorStyles.toolbarButton ) ) {
                var list = GetControls<Automation>();
                foreach ( var item in list ) {
                    item.Reset();
                }
            }

            if ( GUILayout.Button( trashContent, EditorStyles.toolbarButton ) ) {
                ShowPopup( new MessageBox( "Watch Out!", "You're about to empty this Automatron...\nAre you sure you want to do this?", EMessageBoxButtons.YesNo, ( EDialogResult result ) => {
                    if ( result == EDialogResult.Yes ) {
                        var controls = GetControls<ExtendedControl>();
                        for ( int i = controls.Count - 1; i >= 0; i-- ) {
                            var item = controls[i];
                            if ( item != entryPoint ) {
                                item.Remove();
                            }
                        }
                    }
                } ) );
            }

            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();

            if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                var menu = GenericMenuBuilder.CreateMenu();
                foreach ( var item in automations ) {
                    menu.AddItem( item.Key, false, CreateAutomation, new object[] { Input.MousePosition, item.Value } );
                }
                menu.ShowAsContext();
            }

            if ( Input.ButtonDown( EMouseButton.Middle ) ) {
                Globals.Camera += Input.DragDelta;
            }

            Repaint();
        }

        private void ExecuteAutomations() {
            executionRoutine = EditorCoroutine.Start( ExecuteAutomationsAsync() );
        }

        private IEnumerator ExecuteAutomationsAsync() {
            var entries = new List<QueueStart>() {
                entryPoint
            };

            var entryPoints = GetControls<QueueStart>();
            foreach ( var item in entryPoints ) {
                if ( !entries.Contains( item ) ) {
                    entries.Add( item );
                }
            }

            var list = new List<Automation>();
            foreach ( var item in entries ) {
                list.AddRange( GetAutomations( item ) );
            }

            Globals.LastError = null;
            Globals.IsError = false;
            Globals.IsExecuting = true;

            foreach ( var item in list ) {
                item.PrepareForExecute();
                if ( Globals.IsError ) break;

                var routine = item.Execute();
                while ( true ) {
                    var moveNext = false;

                    try {
                        moveNext = routine.MoveNext();
                    } catch ( Exception ex ) {
                        Globals.LastError = ex;
                        Globals.IsError = true;
                        item.ErrorType = ErrorType.Generic;
                        break;
                    }

                    if ( !moveNext ) break;

                    yield return routine.Current;
                }

                if ( Globals.IsError ) break;

                item.Progress = 1;
                if ( Globals.IsError ) break;
            }

            Globals.IsExecuting = false;
            yield break;
        }

        private List<Automation> GetAutomations( Automation start ) {
            try {
                var list = new List<Automation>();
                start.GetAutomations( ref list );

                foreach ( var item in list ) {
                    item.Reset();
                }

                var newList = new List<Automation>();
                for ( int i = 0; i < list.Count; i++ ) {
                    var item = list[i];

                    newList.Add( item );

                    if ( item is LoopableAutomation ) {
                        i = FixLoops( list, i );
                    }
                }

                return newList;
            } catch ( Exception ) {
                Debug.Log( "OH noe!" );
                throw;
            }
        }

        private int FixLoops( List<Automation> list, int index ) {
            var loopList = new List<Automation>();
            var loopStart = (LoopableAutomation)list[index];

            for ( int i = index + 1; i < list.Count; i++ ) {
                var item = list[i];
                if ( item is LoopableAutomation ) {
                    loopList.Add( item );
                    i = FixLoops( list, i );
                } else if ( item is LoopEnd ) {
                    loopList.Add( item );
                    loopStart.LoopList = loopList;
                    return i;
                } else {
                    loopList.Add( item );
                }
            }

            // Improve this
            throw new Exception( "No loop end found!" );
        }

        private void CreateAutomation( object data ) {
            var mpos = (Vector2)( data as object[] )[0] - Globals.Camera;
            var type = (Type)( data as object[] )[1];

            var instance = (Automation)Activator.CreateInstance( type );
            instance.Position = mpos;

            AddControl( instance );
        }
    }
}