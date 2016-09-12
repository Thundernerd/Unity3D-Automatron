using UnityEngine;
using TNRD.Editor.Core;
using System;

namespace TNRD.Automatron {

    public class AutomationError : ExtendedControl {

        private GUIStyle background;
        private GUIStyle text;
        private Color color = new Color( 1, 1, 1, 0 );

        private bool fadeIn = true;
        private float timer = 5;

        private string message;

        public AutomationError( Exception ex ) {
            if ( ex != null ) {
                message = ex.Message;
            }
        }

        public AutomationError( string message ) {
            this.message = message;
        }

        protected override void OnInitialize() {
            AnchorPoint = Editor.EAnchor.BottomCenter;
            Position = new Vector2( Window.Size.x / 2, Window.Size.y - 20 );
            SortingOrder = int.MaxValue;
        }

        protected override void OnInitializeGUI() {
            background = new GUIStyle( "NotificationBackground" );
            text = new GUIStyle( "NotificationText" );
            text.padding = new RectOffset( 20, 20, 20, 20 );
            text.fontSize = 17;

            Size = text.CalcSize( new GUIContent( message ) );
        }

        protected override void OnAfterSerialize() {
            Remove();
        }

        protected override void OnUpdate() {
            if ( fadeIn ) {
                color.a += ExtendedEditor.DeltaTime * 2;
                if ( color.a > 1 ) {
                    color.a = 1;
                    fadeIn = false;
                }
            } else {
                if ( timer > 0 ) {
                    timer -= ExtendedEditor.DeltaTime;
                } else if ( color.a > 0 ) {
                    color.a -= ExtendedEditor.DeltaTime * 2;
                } else {
                    Remove();
                }
            }
        }

        protected override void OnGUI() {
            if ( Event.current.type == EventType.Repaint ) {
                var c = GUI.color;
                GUI.color = color;
                background.Draw( Rectangle, "", false, false, false, false );
                text.Draw( Rectangle, message, false, false, false, false );
                GUI.color = c;
            }
        }
    }
}