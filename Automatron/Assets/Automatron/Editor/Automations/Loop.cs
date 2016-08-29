using System;
using System.Collections;
using System.Collections.Generic;
using TNRD.Editor.Serialization;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    public abstract class LoopableAutomation : Automation {

        public List<Automation> LoopList { get; set; }

        public sealed override IEnumerator Execute() {
            while ( !IsDone() ) {
                var myRoutine = ExecuteLoop();

                while ( true ) {
                    var moveNext = false;

                    try {
                        moveNext = myRoutine.MoveNext();
                    } catch ( Exception ex ) {
                        Globals.LastError = ex;
                        Globals.IsError = true;
                        ErrorType = ErrorType.Generic;
                        break;
                    }

                    if ( !moveNext ) break;

                    yield return myRoutine.Current;
                }

                if ( Globals.IsError ) break;

                foreach ( var item in LoopList ) {
                    item.Progress = 0;
                }

                foreach ( var item in LoopList ) {
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
                }

                yield return null;
            }
        }

        public abstract IEnumerator ExecuteLoop();
        public abstract bool IsDone();
    }

    [Automation( "Loop/Game Objects" )]
    class LoopGameObjects : LoopableAutomation {

        [ReadOnly]
        public GameObject Result;
        public GameObject[] GameObjects;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = null;
        }

        public override IEnumerator ExecuteLoop() {
            Result = GameObjects[index];
            index++;
            Progress = (float)index / GameObjects.Length;
            yield break;
        }

        public override bool IsDone() {
            return index == GameObjects.Length;
        }
    }

    [Automation( "Loop/List" )]
    class LoopList : LoopableAutomation {

        [ReadOnly]
        [IgnoreSerialization]
        public object Result;
        [IgnoreSerialization]
        public List<object> Items;

        private int index = 0;

        public override IEnumerator ExecuteLoop() {
            Result = Items[index];
            index++;
            Progress = (float)index / Items.Count;
            yield break;
        }

        public override bool IsDone() {
            return index == Items.Count;
        }
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