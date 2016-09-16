﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {

    public abstract class ConditionalAutomation : Automation {

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

        public override void ResetLoop() {
            base.ResetLoop();

            if ( LineOut2 != null && !( LineOut2.Right is LoopableAutomation ) && LineOut2.Right.HasRun ) {
                LineOut2.Right.ResetLoop();
            }
        }

        public abstract bool GetConditionalResult();
    }

    public abstract class LoopableAutomation : Automation {

        public LoopableLine LineOut2 { get; set; }

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

                    LineOut2 = LoopableLine.HookLineOut2( this );
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
            var result = IsDone();

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

        public override void ResetLoop() {
            HasRun = false;

            if ( LineOut2 != null && !( LineOut2.Right is LoopableAutomation ) && LineOut2.Right.HasRun ) {
                LineOut2.Right.ResetLoop();
            }
        }

        public abstract bool IsDone();
        public abstract void MoveNext();
    }

    [Automation( "Entry Point" )]
    class QueueStart : Automation {

        private GUIStyle textStyle;

        public QueueStart() {

        }

        protected override void OnInitialize() {
            base.OnInitialize();

            showInArrow = false;
            AnchorPoint = Editor.EAnchor.MiddleCenter;
        }

        protected override void OnInitializeGUI() {
            CreateStyle();
        }

        protected override void OnAfterSerialize() {
            base.OnAfterSerialize();
            RunOnGUIThread( CreateStyle );
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

    [Automation( "Entry Point" )]
    class InternalQueueStart : QueueStart {

        public InternalQueueStart() {

        }

        protected override void OnInitialize() {
            base.OnInitialize();
            showCloseButton = false;
        }

        protected override void OnAfterSerialize() {
            base.OnAfterSerialize();
            showCloseButton = false;
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