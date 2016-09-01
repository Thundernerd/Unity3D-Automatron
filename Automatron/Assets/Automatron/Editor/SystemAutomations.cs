using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {

    public abstract class ConditionalAutomation : Automation {

        public List<Automation> TrueList { get; set; }
        public List<Automation> FalseList { get; set; }

        public ConditionalLine LineOut2 { get; set; }

        public sealed override IEnumerator Execute() {
            var myRoutine = ExecuteCondition();

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

            if ( Globals.IsError ) yield break;

            var condition = GetConditionalResult();
            var list = condition ? TrueList : FalseList;

            foreach ( var item in list ) {
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

            yield break;
        }

        protected override void OnGUI() {
            base.OnGUI();

            var rect = Rectangle;
            var arrow = new Rect( rect.x + rect.width / 2 - 7, rect.y + rect.height, 15, 15 );
            GUI.DrawTexture( arrow, Assets["arrowdown"] );
            if ( Input.ButtonReleased( Editor.EMouseButton.Left ) ) {
                if ( arrow.Contains( Input.MousePosition ) ) {
                    if ( LineOut2 != null ) {
                        LineOut2.Remove();
                        LineOut2 = null;
                    }

                    LineOut2 = ConditionalLine.HookLineOut2( this );
                    Window.AddControl( LineOut2 );
                    Input.Use();
                }
            } else if ( Input.ButtonReleased( Editor.EMouseButton.Right ) ) {
                if ( arrow.Contains( Input.MousePosition ) ) {
                    if ( LineOut2 != null ) {
                        LineOut2.Remove();
                        LineOut2 = null;
                    }

                    Input.Use();
                }
            }
        }

        public override void GetAutomations( ref List<Automation> automations ) {
            foreach ( var field in fields ) {
                if ( field.LineIn != null ) {
                    var parent = field.LineIn.Left.Parent;
                    if ( !automations.Contains( parent ) ) {
                        parent.GetAutomations( ref automations );
                    }
                }
            }

            if ( !automations.Contains( this ) ) {
                automations.Add( this );
            }

            if ( LineOut != null ) {
                TrueList = AutomatronEditor.GetAutomations( LineOut.Right );
            }

            if ( LineOut2 != null ) {
                FalseList = AutomatronEditor.GetAutomations( LineOut2.Right );
            }
        }

        public abstract IEnumerator ExecuteCondition();
        public abstract bool GetConditionalResult();
    }

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

                    if ( item is LoopEnd ) {
                        item.Progress = Progress;
                    } else {
                        item.Progress = 1;
                    }
                }

                yield return null;
            }
        }

        public abstract IEnumerator ExecuteLoop();
        public abstract bool IsDone();
    }

    [Automation( "Entry Point" )]
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
}