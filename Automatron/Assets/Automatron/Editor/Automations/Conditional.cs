using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

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


    [Automation( "Conditional/Simple Condition" )]
    public class SimpleConditional : ConditionalAutomation {

        public bool Condition;

        public override IEnumerator ExecuteCondition() {
            yield break;
        }

        public override bool GetConditionalResult() {
            return Condition;
        }
    }

#pragma warning restore 0649
}