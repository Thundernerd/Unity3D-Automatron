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
                } else {
                    Debug.Log( "Double for " + name );
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

        public static float DeltaTime = 0;
        private float previousTime = 0;

        private QueueStart entryPoint;
        [RequireSerialization]
        private string entryId;

        private GUIContent executeContent;
        private GUIContent stopContent;
        private GUIContent trashContent;
        private GUIContent resetContent;

        private EditorCoroutine executionRoutine = null;
        private EditorCoroutine lookAtRoutine = null;

        protected override void OnInitialize() {
            WindowStyle = EWindowStyle.NoToolbarLight;
            WindowSettings.IsFullscreen = true;

            entryPoint = new QueueStart() {
                IsInitial = true,
                Position = WindowRect.center
            };

            AddControl( entryPoint );

            CreateIcons();

            Globals.Camera = new Vector2();
            Globals.IsError = false;
            Globals.IsExecuting = false;
            Globals.LastError = null;
            Globals.TempAutomationLine = null;
            Globals.TempFieldLine = null;
        }

        protected override void OnBeforeSerialize() {
            entryId = entryPoint.ID;

            if ( lookAtRoutine != null ) {
                lookAtRoutine.Stop();
            }
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

        protected override void OnUpdate() {
            var time = Time.realtimeSinceStartup;
            // Min-Maxing this to make sure it's between 0 and 1/60
            DeltaTime = Mathf.Min( Mathf.Max( 0, time - previousTime ), 0.016f );
            previousTime = time;
        }

        protected override void OnGUI() {
            EditorGUILayout.BeginHorizontal( EditorStyles.toolbar );
            if ( GUILayout.Button( "File", EditorStyles.toolbarDropDown ) ) {

            }

            if ( GUILayout.Button( "Automations", EditorStyles.toolbarDropDown ) ) {
                ShowAutomationPopup();
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
                        entryPoint.Reset();
                        Globals.Camera = new Vector2();
                        entryPoint.Position = WindowRect.center;
                    }
                } ) );
            }

            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();

            if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                ShowAutomationPopup();
            }

            if ( Input.ButtonDown( EMouseButton.Middle ) ) {
                Globals.Camera += Input.DragDelta;
            }

            Repaint();
        }

        private void ShowAutomationPopup() {
            var items = new List<FancyPopup.TreeItem>();
            foreach ( var item in automations ) {
                items.Add( new FancyPopup.TreeItem<Vector2, Type>( item.Key, Input.MousePosition, item.Value, CreateAutomation ) );
            }
            FancyPopup.ShowAsContext( items.ToArray() );
        }

        private void CreateAutomation( Vector2 mpos, Type type ) {
            var instance = (Automation)Activator.CreateInstance( type );
            instance.Position = mpos - Globals.Camera;

            AddControl( instance );
        }

        private void ExecuteAutomations() {
            executionRoutine = EditorCoroutine.Start( ExecuteAutomationsAsync() );
        }

        private IEnumerator ExecuteAutomationsAsync() {
            var autos = GetControls<Automation>();
            foreach ( var item in autos ) {
                item.Reset();
            }

            Globals.LastError = null;
            Globals.LastAutomation = null;
            Globals.IsError = false;
            Globals.IsExecuting = true;

            var errors = GetControls<AutomationError>();
            foreach ( var item in errors ) {
                item.Remove();
            }

            yield return null;

            var entries = new List<QueueStart>() {
                entryPoint
            };

            var entryPoints = GetControls<QueueStart>();
            foreach ( var item in entryPoints ) {
                if ( !entries.Contains( item ) ) {
                    entries.Add( item );
                }
            }

            foreach ( var item in entries ) {
                var automations = item.GetNextAutomations();
                var loops = new List<LoopableAutomation>();
                LoopEnd lEnd = null;

                while ( true ) {
                    if ( automations == null || automations.Count == 0 ) break;

                    foreach ( var auto in automations ) {
                        if ( auto is LoopableAutomation ) {
                            var lAuto = (LoopableAutomation)auto;
                            if ( !loops.Contains( lAuto ) ) {
                                loops.Add( lAuto );
                            }
                        } else if ( auto is LoopEnd ) {
                            lEnd = (LoopEnd)auto;
                        }

                        auto.IsInLoop = loops.Count > 0;
                        auto.PrepareForExecute();
                        if ( Globals.IsError ) break;

                        var routine = auto.Execute();
                        while ( true ) {
                            var moveNext = false;

                            try {
                                moveNext = routine.MoveNext();
                            } catch ( Exception ex ) {
                                Globals.LastError = ex;
                                Globals.LastAutomation = auto;
                                Globals.IsError = true;
                                auto.ErrorType = ErrorType.Generic;
                                break;
                            }

                            if ( !moveNext ) break;

                            yield return routine.Current;
                        }

                        if ( Globals.IsError ) break;
                        if ( !( auto is LoopableAutomation ) && !( auto is LoopEnd ) ) {
                            auto.Progress = 1;
                            auto.HasRun = true;
                        }
                    }

                    if ( Globals.IsError ) break;

                    if ( lEnd != null ) {
                        var lastLoop = loops[loops.Count - 1];
                        var done = lastLoop.IsDone();

                        lEnd.Progress = lastLoop.Progress;
                        if ( done ) {
                            automations = lEnd.GetNextAutomations();
                            loops.RemoveAt( loops.Count - 1 );
                            lEnd = null;
                        } else {
                            automations = lastLoop.GetNextAutomations();
                            automations.Insert( 0, lastLoop );
                        }
                    } else {
                        automations = automations[automations.Count - 1].GetNextAutomations();
                    }
                }

                if ( Globals.IsError ) break;
                yield return null;
            }

            if ( Globals.IsError ) {
                LookAtAutomationSmooth( Globals.LastAutomation );
                AddControl( new AutomationError( Globals.LastError ) );
            }

            Globals.IsExecuting = false;

            yield break;
        }

        private void CreateAutomation( object data ) {
            var mpos = (Vector2)( data as object[] )[0] - Globals.Camera;
            var type = (Type)( data as object[] )[1];

            var instance = (Automation)Activator.CreateInstance( type );
            instance.Position = mpos;

            AddControl( instance );
        }

        private void LookAtAutomation( Automation auto ) {
            var rect = auto.Rectangle;
            Globals.Camera -= rect.position - new Vector2( Size.x / 2, Size.y / 2 ) + ( rect.size / 2 );
        }

        private void LookAtAutomationSmooth( Automation auto ) {
            if ( lookAtRoutine != null ) {
                lookAtRoutine.Stop();
                lookAtRoutine = null;
            }
            var rect = auto.Rectangle;
            var npos = rect.position - new Vector2( Size.x / 2, Size.y / 2 ) + ( rect.size / 2 );

            lookAtRoutine = EditorCoroutine.Start( LookAtAutomationSmoothAsync( npos ) );
        }

        private IEnumerator LookAtAutomationSmoothAsync( Vector2 pos ) {
            var dest = Globals.Camera - pos;
            var timer = 0f;
            var tween = new TinyTween.Vector2Tween();
            tween.Start( Globals.Camera, dest, 1, TinyTween.ScaleFuncs.CubicEaseOut );

            while ( timer < 1 ) {
                tween.Update( timer );
                Globals.Camera = tween.CurrentValue;
                timer += DeltaTime;
                yield return null;
            }

            Globals.Camera = dest;

            yield break;
        }
    }
}