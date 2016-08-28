using UnityEngine;
using TNRD.Editor;
using TNRD.Editor.Serialization;

namespace TNRD.Automatron {

    public class FieldLine : BezierLine {

        public static FieldLine HookLineIn( AutomationField field ) {
            if ( tempLine == null ) {
                var f = new FieldLine();
                f.Right = field;
                tempLine = f;
                return f;
            } else {
                if ( tempLine.Right == null && tempLine.Left != field ) {
                    var line = new FieldLine( tempLine.Left, field );
                    tempLine.Remove();
                    tempLine = null;
                    return line;
                } else {
                    tempLine.Remove();
                    tempLine = null;
                    return HookLineIn( field );
                }
            }
        }

        public static FieldLine HookLineOut( AutomationField field ) {
            if ( tempLine == null ) {
                var f = new FieldLine();
                f.Left = field;
                tempLine = f;
                return f;
            } else {
                if ( tempLine.Left == null && tempLine.Right != field ) {
                    var line = new FieldLine( field, tempLine.Right );
                    tempLine.Remove();
                    tempLine = null;
                    return line;
                } else {
                    tempLine.Remove();
                    tempLine = null;
                    return HookLineOut( field );
                }
            }
        }

        private static FieldLine tempLine;

        [IgnoreSerialization]
        public AutomationField Left;
        [IgnoreSerialization]
        public AutomationField Right;

        [RequireSerialization]
        private string idLeft;
        [RequireSerialization]
        private string idRight;

        private Vector2 p1 = new Vector2( 50, 0 );
        private Vector2 p2 = new Vector2( -50, 0 );

        private bool doMouseCheck = false;

        public FieldLine() { }

        public FieldLine( AutomationField left, AutomationField right ) {
            Left = left;
            Right = right;

            Left.LineOut = this;
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
                if ( Left == null && item.HasField( idLeft ) ) {
                    Left = item.GetField( idLeft );
                    continue;
                }

                if ( Right == null && item.HasField( idRight ) ) {
                    Right = item.GetField( idRight );
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

            Left.LineOut = this;
            Right.LineIn = this;

            SortingOrder = ESortingOrder.Line;
        }

        protected override void OnBeforeSerialize() {
            if ( Left == null || Right == null ) return;

            idLeft = Left.ID;
            idRight = Right.ID;

            SortingOrder = ESortingOrder.LineNoEnd;
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
                Start.x += r.width + 12;
                Start.y += r.height / 2;
            }

            if ( Right == null ) {
                End = mpos;
            } else {
                var r = Right.Rectangle;
                End = r.position;
                End.x -= 12;
                End.y += r.height / 2;
            }

            P1 = Start + p1;
            P2 = End + p2;

            base.OnGUI();

            if ( doMouseCheck ) {
                if ( Left == null || Right == null ) {
                    tempLine = null;
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