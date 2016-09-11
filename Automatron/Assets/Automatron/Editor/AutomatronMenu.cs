using UnityEngine;
using System.Collections;
using TNRD.Editor.Core;
using UnityEditor;
using TNRD.Editor;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TNRD.Editor.Windows;

namespace TNRD.Automatron {

    public class AutomatronMenu : ExtendedWindow {

        [MenuItem( "Window/Automatron" )]
        private static void Init() {
            var wnd = CreateEditor( "Automatron" );
            wnd.minSize = new Vector2( 960, 540 );
            wnd.Show( true );
        }

        private GUIStyle headerStyle;
        private GUIStyle noneStyle;
        private GUIStyle labelStyle;
        private GUIStyle subLabelStyle;
        private GUIStyle buttonStyle;

        private List<string> configs = new List<string>();
        private Vector2 scroll = new Vector2();

        private int target = 0;
        private float anim = 0;

        protected override void OnInitialize() {
            WindowStyle = EWindowStyle.NoToolbarLight;
            WindowSettings.IsFullscreen = true;

            configs = Directory.GetFiles( Path.Combine( Application.dataPath, AutomatronSettings.ConfigFolder ), "*.cfg" )
                .OrderByDescending( f => File.GetLastWriteTime( f ).Ticks )
                .ToList();
        }

        protected override void OnInitializeGUI() {
            CreateStyles();
        }

        protected override void OnAfterSerialized() {
            WindowSettings.IsFullscreen = true;
            RunOnGUIThread( CreateStyles );

            configs = Directory.GetFiles( Path.Combine( Application.dataPath, AutomatronSettings.ConfigFolder ), "*.cfg" )
                .OrderByDescending( f => File.GetLastWriteTime( f ).Ticks )
                .ToList();
        }

        private void CreateStyles() {
            headerStyle = new GUIStyle( EditorStyles.whiteLabel );
            headerStyle.alignment = TextAnchor.UpperCenter;
            headerStyle.fontSize = 64;

            noneStyle = new GUIStyle( EditorStyles.label );
            noneStyle.alignment = TextAnchor.UpperLeft;
            noneStyle.fontStyle = FontStyle.Italic;
            noneStyle.fontSize = 24;

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
        }

        protected override void OnUpdate() {
            if ( target == 1 && anim < 1 ) {
                anim = Mathf.MoveTowards( anim, 1, ExtendedEditor.DeltaTime * 5 );
                //anim += ExtendedEditor.DeltaTime * 2;
                if ( anim > 1 ) {
                    anim = 1;
                }
            } else if ( target == 0 && anim > 0 ) {
                anim = Mathf.MoveTowards( anim, 0, ExtendedEditor.DeltaTime * 5 );
                if ( anim < 0 ) {
                    anim = 0;
                }
            }
        }

        protected override void OnGUI() {
            EditorGUI.LabelField( new Rect( 0, 10, Size.x, Size.y ), "AUTOMATRON", headerStyle );

            GUILayout.BeginArea( new Rect( 50, 125, Size.x - 100, 16 ) );
            ExtendedGUI.HorizontalLine();
            GUILayout.EndArea();

            GUILayout.BeginArea( new Rect( Size.x - 175, 160, 125, 16 ) );
            ExtendedGUI.HorizontalLine();
            GUILayout.EndArea();

            var cbr = new Rect( Size.x - 165, 132.5f, 50, 20 );
            var isHover = cbr.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                buttonStyle.Draw( cbr, "Create", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    
                }
            }

            if ( Input.KeyPressed( KeyCode.Alpha1 ) ) {
                target = 1;
            } else if ( Input.KeyPressed( KeyCode.Alpha2 ) ) {
                target = 0;
            }


            var obr = new Rect( Size.x - 110, 132.5f, 50, 20 );
            isHover = obr.Contains( Input.MousePosition );
            if ( Event.current.type == EventType.Repaint )
                buttonStyle.Draw( obr, "Open", isHover, isHover, false, false );
            if ( isHover ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    // Open file dialog
                }
            }

            GUILayout.BeginArea( new Rect( 50 + ( Size.x * anim ), 175, Size.x - 100, Size.y - 200 ) );

            if ( configs.Count == 0 ) {
                EditorGUILayout.LabelField( "No Automatrons found!", noneStyle, GUILayout.ExpandHeight( true ) );
            } else {
                scroll = EditorGUILayout.BeginScrollView( scroll );

                for ( int i = 0; i < configs.Count; i++ ) {
                    var p = configs[i];
                    var l = Path.GetFileNameWithoutExtension( p );
                    var s = p.Replace( Application.dataPath, "" ).Replace( "\\", "/" );

                    GUILayout.Space( 5 );
                    var r = EditorGUILayout.GetControlRect( false, 48 );
                    isHover = r.Contains( Input.MousePosition );
                    if ( Event.current.type == EventType.Repaint )
                        labelStyle.Draw( r, l, isHover, isHover, false, false );
                    EditorGUI.LabelField( new Rect( r.x + 12, r.y + 24, r.width, 20 ), s, subLabelStyle );

                    if ( isHover ) {
                        EditorGUIUtility.AddCursorRect( new Rect( 0, 0, Size.x, Size.y ), MouseCursor.Link );
                        if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                            var wnd = new AutomatronEditor();
                            AddWindow( wnd );
                            wnd.LoadAutomatron( p );
                            Remove();
                        }
                    }
                }

                EditorGUILayout.EndScrollView();
            }

            GUILayout.EndArea();

            GUILayout.BeginArea( new Rect( 50 - ( ( 1 - anim ) * Size.x ), 175, Size.x - 100, Size.y - 200 ) );
            EditorGUILayout.LabelField( "Name of the fucking thing", noneStyle, GUILayout.ExpandHeight( true ) );
            EditorGUILayout.LabelField( "Name of the fucking thing", noneStyle, GUILayout.ExpandHeight( true ) );
            EditorGUILayout.LabelField( "Name of the fucking thing", noneStyle, GUILayout.ExpandHeight( true ) );
            GUILayout.EndArea();

            Repaint();
        }
    }
}