﻿using UnityEngine;
using TNRD.Editor.Serialization;
using TNRD.Editor;

namespace TNRD.Automatron {

    public class AutomationLine : BezierLine {

        public static AutomationLine HookLineIn( Automation auto ) {
            if ( Globals.TempFieldLine != null ) {
                Globals.TempFieldLine.Remove();
                Globals.TempFieldLine = null;
            }

            if ( Globals.TempAutomationLine == null ) {
                var f = new AutomationLine();
                f.Right = auto;
                Globals.TempAutomationLine = f;
                return f;
            } else {
                if ( Globals.TempAutomationLine.Right == null && Globals.TempAutomationLine.Left != auto ) {
                    var line = new AutomationLine( Globals.TempAutomationLine.Left, auto );
                    Globals.TempAutomationLine.Remove();
                    Globals.TempAutomationLine = null;
                    return line;
                } else {
                    Globals.TempAutomationLine.Remove();
                    Globals.TempAutomationLine = null;
                    return HookLineIn( auto );
                }
            }
        }

        public static AutomationLine HookLineOut( Automation auto ) {
            if ( Globals.TempFieldLine != null ) {
                Globals.TempFieldLine.Remove();
                Globals.TempFieldLine = null;
            }

            if ( Globals.TempAutomationLine == null ) {
                var f = new AutomationLine();
                f.Left = auto;
                Globals.TempAutomationLine = f;
                return f;
            } else {
                if ( Globals.TempAutomationLine.Left == null && Globals.TempAutomationLine.Right != auto ) {
                    var line = new AutomationLine( auto, Globals.TempAutomationLine.Right );
                    Globals.TempAutomationLine.Remove();
                    Globals.TempAutomationLine = null;
                    return line;
                } else {
                    Globals.TempAutomationLine.Remove();
                    Globals.TempAutomationLine = null;
                    return HookLineOut( auto );
                }
            }
        }

        [IgnoreSerialization]
        public Automation Left;
        [IgnoreSerialization]
        public Automation Right;

        [RequireSerialization]
        private string idLeft;
        [RequireSerialization]
        private string idRight;

        private Vector2 p1 = new Vector2( 50, 0 );
        private Vector2 p2 = new Vector2( -50, 0 );

        private bool doMouseCheck = false;

        public AutomationLine() { }

        public AutomationLine( Automation left, Automation right ) {
            Left = left;
            Right = right;

            left.LineOut = this;
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
                    Left = item;
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

        protected override void OnDestroy() {
            if ( Left != null && Left.LineOut == this ) {
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
                Start.x += r.width + 12;
                Start.y += 8;
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

            base.OnGUI();

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