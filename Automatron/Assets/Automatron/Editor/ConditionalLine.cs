using UnityEngine;
using TNRD.Editor.Serialization;
using TNRD.Editor;
using TNRD.Automatron.Automations;
using UnityEditor;

namespace TNRD.Automatron {

    public class ConditionalLine : AutomationLine {

        public static ConditionalLine HookLineOut2( ConditionalAutomation auto ) {
            if ( Globals.TempFieldLine != null ) {
                Globals.TempFieldLine.Remove();
                Globals.TempFieldLine = null;
            }

            if ( Globals.TempAutomationLine == null ) {
                var f = new ConditionalLine();
                f.Left = auto;
                Globals.TempAutomationLine = f;
                return f;
            } else {
                if ( Globals.TempAutomationLine.Left == null && Globals.TempAutomationLine.Right != auto ) {
                    var line = new ConditionalLine( auto, Globals.TempAutomationLine.Right );
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
        new public ConditionalAutomation Left;

        [RequireSerialization]
        private string idLeft;
        [RequireSerialization]
        private string idRight;

        private Vector2 p1 = new Vector2( 0, 50 );
        private Vector2 p2 = new Vector2( -50, 0 );

        private bool doMouseCheck = false;

        public ConditionalLine() { }

        public ConditionalLine( ConditionalAutomation left, Automation right ) {
            Left = left;
            Right = right;

            left.LineOut2 = this;
            Right.LineIn = this;
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
                    Left = (ConditionalAutomation)item;
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
            Right.LineIn = this;

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

            if ( Right != null && Right.LineIn == this ) {
                Right.LineIn = null;
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

            P1 = Start + p1;
            P2 = End + p2;

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
            }
        }
    }
}