#if UNITY_EDITOR
using UnityEngine;
using TNRD.Automatron.Editor.Serialization;
using TNRD.Automatron.Editor;
using UnityEditor;

namespace TNRD.Automatron {

    public class LoopableLine : AutomationLine {

        public static LoopableLine HookLineOut2( LoopableAutomation auto ) {
            if ( Globals.TempFieldLine != null ) {
                Globals.TempFieldLine.Remove();
                Globals.TempFieldLine = null;
            }

            if ( Globals.TempAutomationLine == null ) {
                var f = new LoopableLine();
                f.Left = auto;
                Globals.TempAutomationLine = f;
                return f;
            } else {
                if ( Globals.TempAutomationLine.Left == null && Globals.TempAutomationLine.Right != auto ) {
                    var line = new LoopableLine( auto, Globals.TempAutomationLine.Right );
                    Globals.TempAutomationLine.Remove();
                    Globals.TempAutomationLine = null;
                    return line;
                } else {
                    Globals.TempAutomationLine.Remove();
                    Globals.TempAutomationLine = null;
                    return HookLineOut2( auto );
                }
            }
        }

        [IgnoreSerialization]
        new public LoopableAutomation Left;

        [RequireSerialization]
        private string idLeft;
        [RequireSerialization]
        private string idRight;

        private Vector2 p1 = new Vector2( 0, 50 );
        private Vector2 p2 = new Vector2( -50, 0 );

        private bool doMouseCheck = false;

        public LoopableLine() { }

        public LoopableLine( LoopableAutomation left, Automation right ) {
            Left = left;
            Right = right;

            left.LineOut2 = this;
            Right.LinesIn.Add( this );
        }

        protected override void OnInitialize() {
            if ( Left == null || Right == null ) {
                SortingOrder = ESortingOrder.LineNoEnd;
            } else {
                SortingOrder = ESortingOrder.Line;
            }
        }

        protected override void OnAfterSerialize() {
            if ( string.IsNullOrEmpty( idLeft ) ) {
                Remove();
                return;
            }


            var automations = Window.GetControls<Automation>();
            foreach ( var item in automations ) {
                if ( Left == null && item.ID == idLeft ) {
                    Left = (LoopableAutomation)item;
                    continue;
                }

                if ( Right == null && item.ID == idRight ) {
                    Right = item;
                    continue;
                }

                if ( Left != null && Right != null ) {
                    break;
                }
            }

            if ( Left == null || Right == null ) {
                Remove();
                return;
            }

            Left.LineOut2 = this;
            Right.LinesIn.Add( this );

            SortingOrder = ESortingOrder.Line;
        }

        protected override void OnBeforeSerialize() {
            if ( Left == null || Right == null ) return;

            idLeft = Left.ID;
            idRight = Right.ID;

            SortingOrder = ESortingOrder.LineNoEnd;
        }

        protected override void OnDestroy() {
            if ( Left != null && Left.LineOut2 == this ) {
                Left.LineOut = null;
            }

            if ( Right != null ) {
                Right.LinesIn.Remove( this );
            }
        }

        protected override void OnGUI() {
            if ( Left == null && Right == null ) {
                Remove();
                return;
            }

            if ( ( Left == null || Right == null ) && Input.KeyReleased( KeyCode.Escape ) ) {
                Remove();
            }

            var mpos = Input.MousePosition;

            if ( Left == null ) {
                Start = mpos;
            } else {
                var r = Left.Rectangle;
                Start = r.position;
                Start.x += r.width / 2;
                Start.y += r.height + 15;
            }

            if ( Right == null ) {
                End = mpos;
            } else {
                var r = Right.Rectangle;
                End = r.position;
                End.x -= 12;
                End.y += 8;
            }

            if ( Left == null ) {
                P2 = End + p2;
                P1 = mpos - ( mpos - End ).normalized * 50;
            } else if ( Right == null ) {
                P1 = Start + p1;
                P2 = mpos - ( mpos - Start ).normalized * 50;
            } else {
                P1 = Start + p1;
                P2 = End + p2;
            }

            // Base ONGUI
            Handles.BeginGUI();
            var temp = Handles.color;
            Handles.color = Color;
            Handles.DrawAAPolyLine( GetBezierPoints( Start, End, P1, P2 ) );
            Handles.color = temp;
            Handles.EndGUI();
            // Base ONGUI

            if ( doMouseCheck ) {
                if ( Left == null || Right == null ) {
                    Globals.TempAutomationLine = null;
                    Remove();
                }

                doMouseCheck = false;
            }

            if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                doMouseCheck = true;
                if ( Left == null || Right == null )
                    Input.Use();
            }
        }
    }
}
#endif