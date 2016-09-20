#if UNITY_EDITOR
﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using TNRD.Automatron.Editor;
using TNRD.Automatron.Editor.Core;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class AutomatronMenu : ExtendedWindow {

        [MenuItem( "Window/Automatron" )]
        private static void Init() {
            var wnd = CreateEditor( "Automatron" );
            wnd.AssetPath = Path.Combine( AutomatronSettings.AutomatronFolder, "Assets" );
            wnd.minSize = new Vector2( 960, 540 );
            wnd.Show( true );
        }

        private GUIStyle headerStyle;
        private GUIStyle noneStyle;
        private GUIStyle labelStyle;
        private GUIStyle subLabelStyle;
        private GUIStyle buttonStyle;
        private GUIStyle textboxStyle;

        private List<string> configs = new List<string>();
        private Vector2 scroll = new Vector2();

        private string automatronName = "";
        private string automatronPath = "";
        private bool createAutomatron = false;
        private bool loadAutomatron = false;
        private bool deleteAutomatron = false;
        private bool addAutomatrons = false;
        private List<string> automatrons;
        private string automatron = "";

        private int target = 0;
        private float anim = 0;

        public AutomatronMenu() { }
        public AutomatronMenu( int target ) {
            this.target = target;
        }

        protected override void OnInitialize() {
            WindowStyle = EWindowStyle.NoToolbarLight;
            WindowSettings.IsFullscreen = true;
            automatronPath = AutomatronSettings.ConfigFolder;

            LoadRecents();
        }

        protected override void OnInitializeGUI() {
            CreateStyles();
        }

        protected override void OnAfterSerialized() {
            WindowSettings.IsFullscreen = true;
            automatronPath = AutomatronSettings.ConfigFolder;
            RunOnGUIThread( CreateStyles );

            LoadRecents();
        }

        private void LoadRecents() {
            configs.Clear();

            if ( !EditorPrefs.HasKey( "TNRD.Automatron.RecentAmount" ) ) {
                EditorPrefs.SetInt( "TNRD.Automatron.RecentAmount", 0 );
            }

            var amount = EditorPrefs.GetInt( "TNRD.Automatron.RecentAmount", 0 );
            for ( int i = 0; i < amount; i++ ) {
                var key = string.Format( "TNRD.Automatron.Recent_{0}", i );
                var path = EditorPrefs.GetString( key, "" );
                if ( !string.IsNullOrEmpty( path ) ) {
                    configs.Add( path );
                }
                EditorPrefs.DeleteKey( key );
            }

            for ( int i = 0; i < configs.Count; i++ ) {
                EditorPrefs.SetString( string.Format( "TNRD.Automatron.Recent_{0}", i ), configs[i] );
            }
        }

        private void SaveRecents() {
            var amount = EditorPrefs.GetInt( "TNRD.Automatron.RecentAmount", 0 );
            for ( int i = 0; i < amount; i++ ) {
                EditorPrefs.DeleteKey( string.Format( "TNRD.Automatron.Recent_{0}", i ) );
            }

            EditorPrefs.SetInt( "TNRD.Automatron.RecentAmount", configs.Count );
            for ( int i = 0; i < configs.Count; i++ ) {
                EditorPrefs.SetString( string.Format( "TNRD.Automatron.Recent_{0}", i ), configs[i] );
            }
        }

        private void CreateStyles() {
            headerStyle = new GUIStyle( EditorStyles.label );
            headerStyle.alignment = TextAnchor.UpperCenter;
            headerStyle.fontSize = 64;

            buttonStyle = new GUIStyle( EditorStyles.label );
            buttonStyle.alignment = TextAnchor.MiddleCenter;
            buttonStyle.fontSize = 14;
            buttonStyle.hover.textColor = new Color( 0.243f, 0.372f, 0.588f, 1 );

            labelStyle = new GUIStyle( EditorStyles.label );
            labelStyle.hover.textColor = new Color( 0.243f, 0.372f, 0.588f, 1 );
            labelStyle.fontSize = 18;

            subLabelStyle = new GUIStyle( EditorStyles.centeredGreyMiniLabel );
            subLabelStyle.alignment = TextAnchor.LowerLeft;
            subLabelStyle.fontSize = 14;

            textboxStyle = new GUIStyle( EditorStyles.textField );
            textboxStyle.fontSize = 16;

            noneStyle = new GUIStyle( labelStyle );
            noneStyle.fontStyle = FontStyle.Italic;
        }

        protected override void OnUpdate() {
            if ( target == 1 && anim < 1 ) {
                anim = Mathf.MoveTowards( anim, 1, ExtendedEditor.DeltaTime * 3 );
                if ( anim > 1 ) {
                    anim = 1;
                }
            } else if ( target == 0 && anim > 0 ) {
                anim = Mathf.MoveTowards( anim, 0, ExtendedEditor.DeltaTime * 3 );
                if ( anim < 0 ) {
                    anim = 0;
                }
            }
        }

        private void ListGUI() {
            var area = new Rect( 50 + ( Size.x * anim ), 125, Size.x - 100, Size.y - 200 );
            GUILayout.BeginArea( area );

            GUILayout.BeginArea( new Rect( area.width - 125, 35, 125, 16 ) );
            ExtendedGUI.HorizontalLine();
            GUILayout.EndArea();

            var cbr = new Rect( area.width - 115, 7.5f, 50, 20 );
            var isHover = cbr.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                buttonStyle.Draw( cbr, "Create", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    target = 1;
                }
            }

            var obr = new Rect( area.width - 60, 7.5f, 50, 20 );
            isHover = obr.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                buttonStyle.Draw( obr, "Open", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    var p = EditorUtility.OpenFilePanel( "Select Automation", "", "acfg" );
                    if ( !string.IsNullOrEmpty( p ) ) {
                        var a = AutomatronSerializer.Load( p );
                        if ( a != null ) {
                            loadAutomatron = true;
                            automatron = p;
                        }
                    }
                }
            }

            GUILayout.Space( 50 );

            if ( configs.Count == 0 ) {
                EditorGUILayout.LabelField( "It seems pretty empty over here", noneStyle, GUILayout.ExpandHeight( true ) );
            } else {
                scroll = EditorGUILayout.BeginScrollView( scroll );

                for ( int i = 0; i < configs.Count; i++ ) {
                    var p = configs[i];
                    var l = Path.GetFileNameWithoutExtension( p );
                    var s = p.Replace( "\\", "/" );

                    GUILayout.Space( 5 );
                    var r = EditorGUILayout.GetControlRect( false, 48 );
                    isHover = r.Contains( Input.MousePosition );
                    if ( Event.current.type == EventType.Repaint )
                        labelStyle.Draw( r, l, isHover, isHover, false, false );
                    EditorGUI.LabelField( new Rect( r.x + 12, r.y + 24, r.width, 20 ), s, subLabelStyle );

                    if ( isHover ) {
                        EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                        if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                            automatron = p;

                            if ( File.Exists( p ) ) {
                                loadAutomatron = true;
                            } else {
                                if ( EditorUtility.DisplayDialog( "Automatron", string.Format( "\"{0}\" could not be opened. Do you want to remove the reference from the list?", l ), "Yes", "No" ) ) {
                                    deleteAutomatron = true;
                                }
                            }
                        }
                    }
                }

                EditorGUILayout.EndScrollView();
            }

            GUILayout.EndArea();
        }

        private void CreateGUI() {
            var area = new Rect( 54 - ( ( 1 - anim ) * Size.x ), 125, Size.x - 100, Size.y - 200 );
            GUILayout.BeginArea( area );

            GUILayout.BeginArea( new Rect( area.width - 129, 35, 125, 16 ) );
            ExtendedGUI.HorizontalLine();
            GUILayout.EndArea();

            var cbr = new Rect( area.width - 119, 7.5f, 50, 20 );
            var isHover = cbr.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                buttonStyle.Draw( cbr, "Create", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    if ( !string.IsNullOrEmpty( automatronName ) ) {
                        createAutomatron = true;
                    }
                }
            }

            var obr = new Rect( area.width - 64, 7.5f, 50, 20 );
            isHover = obr.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                buttonStyle.Draw( obr, "Cancel", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    target = 0;
                    automatronName = "";
                    GUIUtility.keyboardControl = -1;
                }
            }

            GUILayout.Space( 55 );

            EditorGUILayout.LabelField( "Name", labelStyle, GUILayout.Height( 28 ) );
            var nId = GUIUtility.GetControlID( FocusType.Passive ) + 1;
            automatronName = EditorGUILayout.TextField( automatronName, textboxStyle, GUILayout.Height( 24 ), GUILayout.Width( area.width / 2 ) );

            if ( GUIUtility.keyboardControl == nId && anim == 1 ) {
                if ( Input.KeyReleased( KeyCode.KeypadEnter ) || Input.KeyReleased( KeyCode.Return ) ) {
                    createAutomatron = true;
                }
            }

            var path = Path.Combine( automatronPath, automatronName + ".acfg" );
            if ( File.Exists( path ) ) {
                EditorGUILayout.LabelField( string.Format( "'{0}' already exists. Proceeding will overwrite it", automatronName ), subLabelStyle, GUILayout.Height( 20 ) );
            } else {
                GUILayout.Space( 22 );
            }

            EditorGUILayout.LabelField( "Path", labelStyle, GUILayout.Height( 28 ) );
            var r = EditorGUILayout.GetControlRect( GUILayout.Height( 24 ), GUILayout.Width( area.width / 2 ) );
            automatronPath = EditorGUI.TextField( r, automatronPath, textboxStyle );

            r.x += r.width + 5; r.width = 50;
            isHover = r.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                labelStyle.Draw( r, "•••", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    GUIUtility.keyboardControl = -1;
                    var p = EditorUtility.OpenFolderPanel( "Automatron Path", automatronPath, "" );
                    if ( !string.IsNullOrEmpty( p ) ) {
                        automatronPath = p;
                    }
                }
            }

            GUILayout.EndArea();
        }

        protected override void OnGUI() {
            EditorGUI.LabelField( new Rect( 0, 10, Size.x, Size.y ), "AUTOMATRON", headerStyle );

            GUILayout.BeginArea( new Rect( 50, 125, Size.x - 100, 16 ) );
            ExtendedGUI.HorizontalLine();
            GUILayout.EndArea();

            ListGUI();
            if ( anim > 0 ) {
                CreateGUI();
            }

            switch ( Event.current.type ) {
                case EventType.DragUpdated:
                case EventType.DragPerform: {
                        var paths = DragAndDrop.paths.Where( p => p.EndsWith( ".acfg" ) ).ToList();

                        if ( paths.Count > 0 ) {
                            DragAndDrop.visualMode = DragAndDropVisualMode.Link;
                        }

                        if ( Event.current.type == EventType.DragPerform ) {
                            DragAndDrop.AcceptDrag();

                            if ( paths.Count == 1 ) {
                                loadAutomatron = true;
                                automatron = paths[0];
                            } else {
                                addAutomatrons = true;
                                automatrons = paths;
                            }
                        }
                    }
                    break;
            }

            if ( Event.current.type == EventType.Repaint ) {
                if ( createAutomatron ) {
                    createAutomatron = false;

                    var p = Path.Combine( automatronPath, automatronName ).Replace( "\\", "/" ) + ".acfg";

                    var i = -1;
                    while ( ( i = configs.IndexOf( p ) ) != -1 ) {
                        configs.RemoveAt( i );
                    }

                    configs.Insert( 0, p );
                    SaveRecents();

                    Remove();
                    var wnd = new AutomatronEditor();
                    AddWindow( wnd );
                    wnd.NewAutomatron( automatronPath, automatronName );

                    return;
                } else if ( loadAutomatron ) {
                    loadAutomatron = false;

                    var i = configs.IndexOf( automatron );
                    if ( i != -1 ) {
                        configs.RemoveAt( i );
                    }

                    configs.Insert( 0, automatron );
                    SaveRecents();

                    Remove();
                    var wnd = new AutomatronEditor();
                    AddWindow( wnd );
                    wnd.LoadAutomatron( automatron );

                    return;
                } else if ( deleteAutomatron ) {
                    deleteAutomatron = false;

                    var i = configs.IndexOf( automatron );
                    if ( i != -1 ) {
                        configs.RemoveAt( i );
                        SaveRecents();
                    }

                    return;
                } else if ( addAutomatrons ) {
                    addAutomatrons = false;

                    foreach ( var item in automatrons ) {
                        if ( configs.Contains( item ) ) continue;
                        configs.Insert( 0, item );
                    }

                    SaveRecents();
                }
            }

            Repaint();
        }
    }
}
#endif