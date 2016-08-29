using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "System/Start" )]
    class QueueStart : Automation {

        private GUIStyle textStyle;

        public QueueStart() : this( true ) {

        }

        public QueueStart( bool showCloseButton ) {
            this.showCloseButton = showCloseButton;
            showInArrow = showCloseButton;
        }

        protected override void OnInitializeGUI() {
            CreateStyle();
        }

        protected override void OnAfterSerialize() {
            base.OnAfterSerialize();
            RunOnGUIThread( CreateStyle );
        }

        private void CreateStyle() {
            textStyle = new GUIStyle( EditorStyles.label );
            textStyle.alignment = TextAnchor.MiddleCenter;
            textStyle.fontSize = 22;
            textStyle.fontStyle = FontStyle.Italic;
        }

        protected override void OnGUI() {
            base.OnGUI();

            Size.x = 150;
            Size.y = 100;

            var rect = Rectangle;
            //rect.position += ( Window as AutomatronEditor ).Camera;

            GUI.Label( rect, "Entry Point", textStyle );
        }

        public override IEnumerator Execute() {
            yield break;
        }
    }


#pragma warning restore 0649
}