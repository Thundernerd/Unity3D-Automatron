using System.Collections;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Utilities/Entry Point" )]
    class QueueStart : Automation {

        private GUIStyle textStyle;

        public bool IsInitial { get; set; }

        public QueueStart() {

        }

        protected override void OnInitialize() {
            base.OnInitialize();

            if ( IsInitial ) {
                showCloseButton = false;
            }
            showInArrow = false;
            AnchorPoint = Editor.EAnchor.MiddleCenter;
        }

        protected override void OnInitializeGUI() {
            CreateStyle();
        }

        protected override void OnAfterSerialize() {
            base.OnAfterSerialize();
            RunOnGUIThread( CreateStyle );
            if ( IsInitial ) {
                showCloseButton = false;
            }
            showInArrow = false;
            AnchorPoint = Editor.EAnchor.MiddleCenter;
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

            GUI.Label( rect, "Entry Point", textStyle );
        }

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Utilities/Delay" )]
    class Delay : Automation {

        public float Duration;

        public override IEnumerator Execute() {
            var end = EditorApplication.timeSinceStartup + Duration;
            while ( EditorApplication.timeSinceStartup < end ) {
                Progress = 1 - (float)( end - EditorApplication.timeSinceStartup ) / Duration;
                yield return null;
            }
            yield break;
        }
    }


#pragma warning restore 0649
}