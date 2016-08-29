using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Editor;
using TNRD.Editor.Core;
using TNRD.Editor.Serialization;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public abstract class Automation : ExtendedControl {

        private static Automation dragger = null;

        private string name;
        private GUIStyle headerStyle;

        private List<AutomationField> fields = new List<AutomationField>();
        private Dictionary<string, AutomationField> sortedFields = new Dictionary<string, AutomationField>();

        [RequireSerialization]
        protected bool showCloseButton = true;
        [RequireSerialization]
        protected bool showOutArrow = true;
        [RequireSerialization]
        protected bool showInArrow = true;

        private Texture2D progressTexture;

        public float Progress;

        public AutomationLine LineIn;
        public AutomationLine LineOut;

        protected override void OnInitialize() {
            Size = new Vector2( 250, 300 );

            AnchorPoint = EAnchor.TopLeft;
            SortingOrder = ESortingOrder.Automation;

            name = ( GetType().GetCustomAttributes( typeof( AutomationAttribute ), false )[0] as AutomationAttribute ).Name;
            GetFields();
            UpdateSize();
            RunOnGUIThread( CreateStyles );
        }

        protected override void OnAfterSerialize() {
            name = ( GetType().GetCustomAttributes( typeof( AutomationAttribute ), false )[0] as AutomationAttribute ).Name;
            GetFields();
            UpdateSize();
            RunOnGUIThread( CreateStyles );
        }

        protected override void OnDestroy() {
            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    item.LineIn.Remove();
                }

                for ( int i = item.LinesOut.Count - 1; i >= 0; i-- ) {
                    item.LinesOut[i].Remove();
                }
            }

            if ( LineIn != null ) {
                LineIn.Remove();
                LineIn = null;
            }

            if ( LineOut != null ) {
                LineOut.Remove();
                LineOut = null;
            }
        }

        private void GetFields() {
            var type = GetType();
            var infos = type.GetFields( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly );
            for ( int i = 0; i < infos.Length; i++ ) {
                var field = infos[i];
                var id = string.Format( "{0}_{1}_{2}", ID, field.Name, i );
                var instance = new AutomationField( this, field, id );
                fields.Add( instance );
                sortedFields.Add( id, instance );
            }
        }

        private void UpdateSize() {
            float height = 24;
            foreach ( var item in fields ) {
                height += item.GetHeight();
            }
            Size.y = Mathf.Max( height, 34 );
        }

        private void CreateStyles() {
            headerStyle = new GUIStyle( EditorStyles.label );
            headerStyle.alignment = TextAnchor.MiddleCenter;

            var tex = new Texture2D( 1, 1, TextureFormat.RGBA32, false );
            tex.hideFlags = HideFlags.HideAndDontSave;

            tex.SetPixel( 0, 0, new Color( 0.0235f, 0.3568f, 0.0235f, 0.65f ) );
            tex.Apply();

            progressTexture = tex;
        }

        protected override void OnGUI() {
            var rect = Rectangle;

            GUI.Box( rect, "", ExtendedGUI.DefaultWindowStyle );
            if ( Progress > 0 ) {
                GUI.DrawTexture( new Rect( rect.x, rect.y, rect.width * Progress, 15 ), progressTexture );
            }
            GUI.Label( new Rect( rect.x, rect.y, rect.width, 16 ), name, headerStyle );

            if ( showCloseButton && !AutomatronEditor.IsExecuting ) {
                var cRect = new Rect( rect.x + rect.width - 14, rect.y + 1, 13, 13 );
                if ( cRect.Contains( Input.MousePosition ) ) {
                    GUI.DrawTexture( cRect, Assets["crossActive"] );

                    if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                        Remove();
                        Input.Use();
                    }
                } else {
                    GUI.DrawTexture( cRect, Assets["crossNormal"] );
                }
            }

            var lArrow = new Rect( rect.x - 15, rect.y, 15, 15 );
            var rArrow = new Rect( rect.x + rect.width, rect.y, 15, 15 );

            if ( showInArrow ) {
                GUI.DrawTexture( lArrow, Assets["toparrowleft"] );

                if ( Input.ButtonReleased( EMouseButton.Left ) && lArrow.Contains( Input.MousePosition ) ) {
                    if ( LineIn != null ) {
                        LineIn.Remove();
                        LineIn = null;
                    }

                    LineIn = AutomationLine.HookLineIn( this );
                    Window.AddControl( LineIn );
                    Input.Use();
                }
            }

            if ( showOutArrow ) {
                GUI.DrawTexture( rArrow, Assets["toparrowright"] );

                if ( Input.ButtonReleased( EMouseButton.Left ) && rArrow.Contains( Input.MousePosition ) ) {
                    if ( LineOut != null ) {
                        LineOut.Remove();
                        LineOut = null;
                    }

                    LineOut = AutomationLine.HookLineOut( this );
                    Window.AddControl( LineOut );
                    Input.Use();
                }
            }

            if ( Input.ButtonPressed( EMouseButton.Left ) ) {
                dragger = null;

                switch ( SortingOrder ) {
                    case ESortingOrder.Automation:
                        if ( rect.Contains( Input.MousePosition ) ) {
                            SortingOrder = ESortingOrder.AutomationSelected;
                        }
                        break;
                    case ESortingOrder.AutomationSelected:
                        if ( !rect.Contains( Input.MousePosition ) ) {
                            SortingOrder = ESortingOrder.Automation;
                        }
                        break;
                }
            }

            if ( Input.ButtonDown( EMouseButton.Left ) ) {
                if ( dragger == null ) {
                    var dragRect = new Rect( rect.x, rect.y, rect.width - 16, 16 );
                    if ( dragRect.Contains( Input.MousePosition ) ) {
                        dragger = this;
                        GUIUtility.keyboardControl = 0;
                    }
                }
            }

            if ( dragger == this ) {
                Position += Input.DragDelta;
            }

            var fieldRect = new Rect( rect.x, rect.y + 18, rect.width, rect.height );
            foreach ( var item in fields ) {
                var height = item.GetHeight();
                fieldRect.height = height;
                item.OnGUI( fieldRect );
                fieldRect.y += height;
            }

            UpdateSize();
        }

        public bool HasField( string id ) {
            return sortedFields.ContainsKey( id );
        }

        public AutomationField GetField( string id ) {
            return sortedFields[id];
        }

        public virtual void GetAutomations( ref List<Automation> automations ) {
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
                LineOut.Right.GetAutomations( ref automations );
            }
        }

        public virtual void Reset() { }

        public void PrepareForExecute() {
            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    var value = item.LineIn.Left.GetValue();
                    item.SetValue( value );
                }
            }
        }

        public abstract IEnumerator Execute();
    }
}
