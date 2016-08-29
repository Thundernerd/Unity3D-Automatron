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

        public static bool IsExecuting { get; private set; }

        [MenuItem( "Window/Automatron" )]
        private static void Init() {
            var wnd = CreateEditor( "Automatron" );
            wnd.minSize = new Vector2( 960, 540 );
            wnd.Show( true );
        }

        private QueueStart entryPoint;
        [RequireSerialization]
        private string entryId;

        protected override void OnInitialize() {
            WindowStyle = EWindowStyle.NoToolbarLight;

            entryPoint = new QueueStart() {
                IsInitial = true,
                Position = WindowRect.center - new Vector2( 375, 75 )
            };

            AddControl( entryPoint );

            WindowSettings.IsFullscreen = true;
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
        }

        protected override void OnGUI() {
            if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                var menu = GenericMenuBuilder.CreateMenu();
                foreach ( var item in automations ) {
                    menu.AddItem( item.Key, false, CreateAutomation, new object[] { Input.MousePosition, item.Value } );
                }
                menu.ShowAsContext();
            }

            Repaint();
        }

        private void ExecuteAutomations() {
            var list = GetAutomations();
            EditorCoroutine.Start( ExecuteAutomationsAsync( list ) );
        }

        private IEnumerator ExecuteAutomationsAsync( List<Automation> list ) {
            Globals.IsError = false;
            Globals.IsExecuting = true;

            foreach ( var item in list ) {
                item.PrepareForExecute();
                var routine = item.Execute();
                while ( routine.MoveNext() ) {
                    yield return routine.Current;
                }
                item.Progress = 1;
                if ( Globals.IsError ) break;
            }

            Globals.IsExecuting = false;
            yield break;
        }

        private List<Automation> GetAutomations() {
            var fullList = new List<Automation>();
            entryPoint.GetAutomations( ref fullList );

            foreach ( var item in fullList ) {
                item.Progress = 0;
                item.Reset();
            }

            var newList = new List<Automation>();
            for ( int i = 0; i < fullList.Count; i++ ) {
                var item = fullList[i];

                newList.Add( item );

                if ( item is LoopableAutomation ) {
                    i = FixLoops( fullList, i );
                }
            }

            return newList;
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

            throw new Exception( "No loop end found!" );
        }

        private void CreateAutomation( object data ) {
            var mpos = (Vector2)( data as object[] )[0];
            var type = (Type)( data as object[] )[1];

            var instance = (Automation)Activator.CreateInstance( type );
            instance.Position = mpos;

            AddControl( instance );
        }
    }
}