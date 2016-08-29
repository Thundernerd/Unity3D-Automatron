using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    public abstract class LoopableAutomation : Automation {

        public List<Automation> LoopList { get; set; }

        protected override void OnGUI() {
            base.OnGUI();
        }

        public sealed override IEnumerator Execute() {
            while ( !IsDone() ) {
                var myRoutine = ExecuteLoop();
                while ( myRoutine.MoveNext() ) {
                    yield return myRoutine.Current;
                }

                foreach ( var item in LoopList ) {
                    item.PrepareForExecute();
                    var routine = item.Execute();
                    while ( routine.MoveNext() ) {
                        yield return routine.Current;
                    }
                }

                yield return null;
            }
        }

        public abstract IEnumerator ExecuteLoop();
        public abstract bool IsDone();
    }

    [Automation( "Loop/End" )]
    class LoopEnd : Automation {

        private GUIStyle textStyle;

        public bool IsInitial { get; set; }

        public LoopEnd() {

        }

        protected override void OnInitialize() {
            base.OnInitialize();

            if ( IsInitial ) {
                showCloseButton = false;
                showInArrow = false;
            }
        }

        protected override void OnInitializeGUI() {
            CreateStyle();
        }

        protected override void OnAfterSerialize() {
            base.OnAfterSerialize();
            RunOnGUIThread( CreateStyle );
            if ( IsInitial ) {
                showCloseButton = false;
                showInArrow = false;
            }
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

            GUI.Label( rect, "Loop End", textStyle );
        }

        public override IEnumerator Execute() {
            yield break;
        }
    }


#pragma warning restore 0649
}