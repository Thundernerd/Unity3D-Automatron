using System.Collections.Generic;
using System.Reflection;
using TNRD.Editor;
using TNRD.Editor.Core;
using UnityEngine;

namespace TNRD.Automatron {

    public class Automation : ExtendedControl {

        private List<AutomationField> fields = new List<AutomationField>();
        private static Automation dragger = null;

        protected override void OnInitialize() {
            Size = new Vector2( 250, 300 );

            AnchorPoint = EAnchor.TopLeft;
            SortingOrder = ESortingOrder.Automation;

            GetFields();
            UpdateSize();
        }

        protected override void OnAfterSerialize() {
            GetFields();
            UpdateSize();
        }

        private void GetFields() {
            var type = GetType();
            var fields = type.GetFields( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly );
            foreach ( var item in fields ) {
                this.fields.Add( new AutomationField( this, item ) );
            }
        }

        private void UpdateSize() {
            float height = 24;
            foreach ( var item in fields ) {
                height += item.GetHeight();
            }
            Size.y = Mathf.Max( height, 34 );
        }


        protected override void OnGUI() {
            var rect = Rectangle;
            
            GUI.Box( rect, "", ExtendedGUI.DefaultWindowStyle );

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
                    var dragRect = new Rect( rect.x, rect.y, rect.width, 16 );
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
    }
}