#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Automatron.Drawers;
using TNRD.Automatron.Editor;
using TNRD.Automatron.Editor.Core;
using TNRD.Automatron.Editor.Serialization;
using TNRD.Automatron.Editor.Utilities;
using TNRD.Automatron.Editor.Windows;
using UnityEditor;
using UnityEngine;

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
                try {
                    var assembly = Assembly.Load( item );
                    list.AddRange( assembly.GetTypes()
                        .Where( t => t.IsPublic )
                        .Where( t => !t.Name.StartsWith( "<" ) && !t.Name.StartsWith( "$" ) ) );
                } catch ( System.IO.FileNotFoundException ) {
                    // this library doesn't exist (yet)
                    continue;
                }

            }
            return list;
        }
        #endregion

        public string Name;
        public string Path;

        private InternalQueueStart entryPoint;
        [RequireSerialization]
        public string EntryId;

        private GUIContent executeContent;
        private GUIContent stopContent;
        private GUIContent trashContent;
        private GUIContent resetContent;

        private EditorCoroutine executionRoutine = null;
        private EditorCoroutine lookAtRoutine = null;

        [IgnoreSerialization]
        private AutomationTemplator templator;

        [RequireSerialization]
        private Vector2 camera;

        private bool spacePan = false;
        private bool mousePan = false;

        public void NewAutomatron( string path, string name ) {
            Name = name;
            Path = path;

            entryPoint = new InternalQueueStart() {
                Position = WindowRect.center
            };
            AddControl( entryPoint );

            EntryId = entryPoint.ID;
            Globals.Camera = new Vector2();

            Save();
        }

        public void LoadAutomatron( string path ) {
            var a = AutomatronSerializer.Load( path );
            if ( a == null ) {
                return;
            }

            Globals.Camera = a.Camera;
            Name = a.Name;
            Path = a.Path;

            foreach ( var item in a.Automations ) {
                var type = Globals.Types.Where( t => t.FullName == item.Type ).FirstOrDefault();
                if ( type == null ) {
                    type = Type.GetType( item.Type );
                }
                if ( type == null ) continue;

                var pos = item.Position;

                var instance = (Automation)Activator.CreateInstance( type );
                instance.Position = pos;

                AddControl( instance );
                instance.ID = item.ID;
                instance.LoadFields();

                foreach ( var f in item.Fields ) {
                    var fid = instance.GetField( f.ID );
                    if ( fid != null ) {
                        fid.SetValue( f.Value );
                    }
                }

                if ( item.ID == a.EntryID ) {
                    entryPoint = (InternalQueueStart)instance;
                    EntryId = entryPoint.ID;
                }
            }

            var automations = GetControls<Automation>();
            foreach ( var item in a.Lines ) {
                if ( item.LineType == ELineType.FieldLine ) {
                    var left = automations.Where( auto => auto.HasField( item.IdLeft ) ).FirstOrDefault();
                    var right = automations.Where( auto => auto.HasField( item.IdRight ) ).FirstOrDefault();

                    if ( left == null || right == null ) continue;

                    var line = new FieldLine( left.GetField( item.IdLeft ), right.GetField( item.IdRight ) );
                    AddControl( line );
                } else {
                    var left = automations.Where( auto => auto.ID == item.IdLeft ).FirstOrDefault();
                    var right = automations.Where( auto => auto.ID == item.IdRight ).FirstOrDefault();

                    if ( left == null || right == null ) continue;

                    BezierLine line = null;

                    switch ( item.LineType ) {
                        case ELineType.AutomationLine:
                            line = new AutomationLine( left, right );
                            break;
                        case ELineType.ConditionalLine:
                            line = new ConditionalLine( (ConditionalAutomation)left, right );
                            break;
                        case ELineType.LoopableLine:
                            line = new LoopableLine( (LoopableAutomation)left, right );
                            break;
                    }

                    if ( line != null ) {
                        AddControl( line );
                        line.ID = item.ID;
                    }
                }
            }

            var id = GetControlID();
            if ( id < a.ControlID ) {
                var amount = a.ControlID - id;
                for ( int i = 0; i < amount; i++ ) {
                    GetControlID();
                }
            }

            if ( entryPoint == null ) {
                entryPoint = new InternalQueueStart() {
                    Position = WindowRect.center
                };
                AddControl( entryPoint );

                EntryId = entryPoint.ID;
            }
        }

        protected override void OnInitialize() {
            WindowStyle = EWindowStyle.NoToolbarLight;
            WindowSettings.IsFullscreen = true;

            CreateIcons();

            Globals.IsError = false;
            Globals.IsExecuting = false;
            Globals.LastError = null;
            Globals.TempAutomationLine = null;
            Globals.TempFieldLine = null;

            templator = new AutomationTemplator( this );
        }

        protected override void OnBeforeSerialize() {
            EntryId = entryPoint.ID;

            if ( lookAtRoutine != null ) {
                lookAtRoutine.Stop();
            }

            camera = Globals.Camera;
        }

        protected override void OnAfterSerialized() {
            var entries = GetControls<InternalQueueStart>();
            foreach ( var item in entries ) {
                if ( item.ID == EntryId ) {
                    entryPoint = item;
                    break;
                }
            }

            WindowSettings.IsFullscreen = true;
            Globals.Camera = camera;

            CreateIcons();
            templator = new AutomationTemplator( this );
        }

        protected override void OnGUI() {
            EditorGUILayout.BeginHorizontal( EditorStyles.toolbar );
            EditorGUI.BeginDisabledGroup( Globals.IsExecuting );
            if ( GUILayout.Button( "File", EditorStyles.toolbarDropDown ) ) {
                var gm = GenericMenuBuilder.CreateMenu();
                gm.AddItem( "New Automatron", false, () => {
                    AddWindow( new AutomatronMenu( 1 ) );
                    Remove();
                } );
                gm.AddItem( "Open Automatron", false, () => {
                    AddWindow( new AutomatronMenu() );
                    Remove();
                } );
                gm.AddSeparator();
                gm.AddItem( "Save Automatron", false, () => {
                    AutomatronSerializer.Save( this );
                    ShowNotification( "Automatron saved" );
                } );
                gm.AddItem( "Save Automatron As...", false, () => {
                    ShowPopup( new InputBox(
                        "Save Automatron As...",
                        "Please insert a new name for the Automatron",
                        ( EDialogResult result, string input ) => {
                            if ( result == EDialogResult.OK && !string.IsNullOrEmpty( input ) ) {
                                Name = input;
                                Save();
                                ShowNotification( string.Format( "Automatron saved as '{0}'", input ) );
                            }
                        } ) );
                } );
                gm.AddSeparator();
                gm.AddItem( "Create.../Automation", false, () => {
                    ShowPopup( new InputBox(
                        "Create Automation",
                        "Please insert the name for your Automation",
                        ( EDialogResult result, string input ) => {
                            if ( result == EDialogResult.OK && !string.IsNullOrEmpty( input ) ) {
                                templator.CreateAutomation( input );
                            }
                        } ) );
                } );
                gm.AddItem( "Create.../Conditional Automation", false, () => {
                    ShowPopup( new InputBox(
                        "Create Conditional Automation",
                        "Please insert the name for your Automation",
                        ( EDialogResult result, string input ) => {
                            if ( result == EDialogResult.OK && !string.IsNullOrEmpty( input ) ) {
                                templator.CreateConditionalAutomation( input );
                            }
                        } ) );
                } );
                gm.AddItem( "Create.../Loopable Automation", false, () => {
                    ShowPopup( new InputBox(
                        "Create Loopable Automation",
                        "Please insert the name for your Automation",
                        ( EDialogResult result, string input ) => {
                            if ( result == EDialogResult.OK && !string.IsNullOrEmpty( input ) ) {
                                templator.CreateLoopableAutomation( input );
                            }
                        } ) );
                } );
                gm.AddSeparator( "Create.../" );
                gm.AddItem( "Create.../Generator", false, () => {
                    Generation.Generator.CreateMe();
                } );
                gm.AddSeparator();
                gm.AddItem( "Settings", false, () => {
                    PreferencesWindow.Show( "Automatron" );
                } );
                gm.AddSeparator();
                gm.AddItem( "Exit", false, () => {
                    Editor.Close();
                } );
                gm.ShowAsContext();
            }

            if ( GUILayout.Button( "Automations", EditorStyles.toolbarDropDown ) ) {
                ShowAutomationPopup();
            }
            EditorGUI.EndDisabledGroup();

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

            EditorGUI.BeginDisabledGroup( Globals.IsExecuting );
            if ( GUILayout.Button( resetContent, EditorStyles.toolbarButton ) ) {
                var list = GetControls<Automation>();
                foreach ( var item in list ) {
                    item.Reset();
                    item.ResetFields();
                }
            }

            if ( GUILayout.Button( trashContent, EditorStyles.toolbarButton ) ) {
                ShowPopup( new MessageBox( "Caution!", "You're about to empty this Automatron...\nAre you sure you want to do this?", EMessageBoxButtons.YesNo, ( EDialogResult result ) => {
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
            EditorGUI.EndDisabledGroup();

            GUILayout.FlexibleSpace();

            if ( GUILayout.Button( "Help", EditorStyles.toolbarDropDown ) ) {
                GenericMenuBuilder.CreateMenu()
                    .AddItem( "Documentation", false, OpenDocumentation )
                    .AddItem( "Reference", false, OpenReference )
                    .ShowAsContext();
            }

            EditorGUILayout.EndHorizontal();

            if ( Input.KeyReleased( KeyCode.F1 ) ) {
                OpenDocumentation();
            } else if ( Input.KeyReleased( KeyCode.F2 ) ) {
                OpenReference();
            }

            if ( Event.current.keyCode == KeyCode.Space ) {
                if ( Event.current.type == EventType.KeyDown ) {
                    spacePan = true;
                    Event.current.Use();
                } else if ( Event.current.type == EventType.KeyUp ) {
                    spacePan = false;
                    Event.current.Use();
                }
            }

            if ( Input.ButtonPressed( EMouseButton.Middle ) ) {
                mousePan = true;
            } else if ( Input.ButtonDown( EMouseButton.Middle ) ) {
                Globals.Camera += Input.DragDelta;
            } else if ( Input.ButtonReleased( EMouseButton.Middle ) || Input.ButtonUp( EMouseButton.Middle ) ) {
                mousePan = false;
            }

            if ( spacePan || mousePan ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Pan );

                if ( !mousePan && ( Input.ButtonDown( EMouseButton.Left ) || Input.ButtonDown( EMouseButton.Right ) ) ) {
                    Globals.Camera += Input.DragDelta;
                }
            } else if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                ShowAutomationPopup();
                Input.Use();
            }

            if ( AutomatronSettings.AutoSave ) {
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    Save();
                    Input.Use();
                }
            }

            Repaint();
        }

        private void OpenDocumentation() {
            Application.OpenURL( "http://tnrd.net/automatron" );
        }

        private void OpenReference() {
            Application.OpenURL( "http://tnrd.net/automatron/reference" );
        }

        private void CreateIcons() {
            // Secretly reusing the foldOut
            executeContent = new GUIContent( Assets["foldOut"], "Execute the automation sequence" );
            stopContent = new GUIContent( Assets["stop"], "Stop the active automation sequence" );
            resetContent = new GUIContent( Assets["reset"], "Reset the values and progress of the automations" );
            trashContent = new GUIContent( Assets["trash"], "Remove all the automations" );
        }

        private void ShowAutomationPopup() {
            if ( Globals.IsExecuting ) return;

            var items = new List<AutomationPopup.TreeItem>();
            foreach ( var item in automations ) {
                items.Add( new AutomationPopup.TreeItem<Vector2, Type>( item.Key, Input.MousePosition, item.Value, CreateAutomation ) );
            }
            AutomationPopup.ShowAsContext( items.ToArray() );
        }

        private void CreateAutomation( Vector2 mpos, Type type ) {
            var instance = (Automation)Activator.CreateInstance( type );
            instance.Position = mpos - Globals.Camera;

            AddControl( instance );

            if ( AutomatronSettings.FocusNewAutomation ) {
                LookAtAutomationSmooth( instance );
            }
        }

        private void ExecuteAutomations() {
            executionRoutine = EditorCoroutine.Start( ExecuteAutomationsAsync() );
        }

        private IEnumerator ExecuteAutomationsAsync() {
            AutomatronLogger.Start( Name );

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

                while ( true ) {
                    if ( automations == null || automations.Count == 0 ) break;

                    foreach ( var auto in automations ) {
                        AutomatronLogger.Log( string.Format( "Start {0}", auto.Name ) );

                        auto.GetDependencies();
                        if ( Globals.IsError ) break;

                        yield return null;

                        if ( auto is LoopableAutomation ) {
                            var l = (LoopableAutomation)auto;
                            if ( !loops.Contains( l ) ) {
                                try {
                                    auto.PreExecute();
                                } catch ( Exception ex ) {
                                    SetErrorInfo( ex, auto, ErrorType.PreExecute );
                                    break;
                                }

                                loops.Add( l );
                            } else {
                                l.MoveNext();
                            }

                            l.ResetLoop();
                        } else {
                            try {
                                auto.PreExecute();
                            } catch ( Exception ex ) {
                                SetErrorInfo( ex, auto, ErrorType.PreExecute );
                                break;
                            }
                        }

                        if ( AutomatronSettings.FocusActiveAutomation ) {
                            LookAtAutomationSmooth( auto );
                        }

                        IEnumerator routine = null;

                        try {
                            routine = auto.Execute();
                        } catch ( Exception ex ) {
                            SetErrorInfo( ex, auto, ErrorType.Execute );
                            break;
                        }

                        while ( true ) {
                            var moveNext = false;

                            try {
                                moveNext = routine.MoveNext();
                            } catch ( Exception ex ) {
                                SetErrorInfo( ex, auto, ErrorType.Execute );
                                break;
                            }

                            if ( !moveNext ) break;

                            yield return routine.Current;
                        }

                        if ( Globals.IsError ) break;
                        if ( !( auto is LoopableAutomation ) ) {
                            try {
                                auto.PostExecute();
                            } catch ( Exception ex ) {
                                SetErrorInfo( ex, auto, ErrorType.PostExecute );
                                break;
                            }

                            auto.Progress = 1;
                        }

                        auto.HasRun = true;
                        AutomatronLogger.Log( string.Format( "End {0}", auto.Name ) );
                    }

                    if ( Globals.IsError ) break;

                    automations = automations[automations.Count - 1].GetNextAutomations();

                    if ( automations.Count > 0 && loops.Count > 0 ) {
                        var l = loops[loops.Count - 1];
                        if ( l.IsDone() ) {
                            try {
                                l.PostExecute();
                            } catch ( Exception ex ) {
                                SetErrorInfo( ex, l, ErrorType.PostExecute );
                                break;
                            }
                            l.Progress = 1;
                            loops.Remove( l );
                        }
                    } else {
                        while ( automations.Count == 0 && loops.Count > 0 ) {
                            var l = loops[loops.Count - 1];
                            if ( l.IsDone() ) {
                                try {
                                    l.PostExecute();
                                } catch ( Exception ex ) {
                                    SetErrorInfo( ex, l, ErrorType.PostExecute );
                                    break;
                                }
                                l.Progress = 1;
                                automations = l.GetNextAutomations();
                                loops.Remove( l );
                            } else {
                                l.GetAutomations( ref automations, false );
                            }

                            yield return null;
                        }
                    }

                    yield return null;
                }

                if ( Globals.IsError ) break;
                yield return null;
            }

            if ( Globals.IsError ) {
                LookAtAutomationSmooth( Globals.LastAutomation );
                AddControl( new AutomationError( Globals.LastError ) );
            } else {
                ShowNotification( "Automatron executed" );
            }

            Globals.IsExecuting = false;

            if ( AutomatronSettings.AutoLog ) {
                AutomatronLogger.Save();
            }

            yield break;
        }

        private void SetErrorInfo( Exception ex, Automation auto, ErrorType type ) {
            Globals.LastError = ex;
            Globals.LastAutomation = auto;
            Globals.IsError = true;
            auto.ErrorType = type;

            AutomatronLogger.Log( string.Format( "{0} caused an exception: {1}\n{2}", auto.Name, ex.Message, ex ) );
        }

        private void CreateAutomation( object data ) {
            var mpos = (Vector2)( data as object[] )[0] - Globals.Camera;
            var type = (Type)( data as object[] )[1];

            var instance = (Automation)Activator.CreateInstance( type );
            instance.Position = mpos;

            AddControl( instance );
        }

        public void LookAtAutomation( Automation auto ) {
            var rect = auto.Rectangle;
            Globals.Camera -= rect.position - new Vector2( Size.x / 2, Size.y / 2 ) + ( rect.size / 2 );
        }

        public void LookAtAutomationSmooth( Automation auto ) {
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
                timer += ExtendedEditor.DeltaTime;
                tween.Update( timer );
                if ( tween.CurrentValue == dest )
                    break;
                Globals.Camera = tween.CurrentValue;
                yield return null;
            }

            Globals.Camera = dest;

            yield break;
        }

        public void Save() {
            AutomatronSerializer.Save( this );
        }
    }
}
#endif