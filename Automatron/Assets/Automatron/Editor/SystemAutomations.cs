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

        protected override void OnDestroy() {
            base.OnDestroy();

            if ( LineOut2 != null ) {
                LineOut2.Remove();
                LineOut2 = null;
            }
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

        public override List<Automation> GetNextAutomations() {
            var list = new List<Automation>();
            var result = GetConditionalResult();

            if ( result ) {
                if ( LineOut != null ) {
                    LineOut.Right.GetAutomations( ref list, false );
                }
            } else {
                if ( LineOut2 != null ) {
                    LineOut2.Right.GetAutomations( ref list, false );
                }
            }

            return list;
        }
        
        public abstract bool GetConditionalResult();
    }

    public abstract class LoopableAutomation : Automation {
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