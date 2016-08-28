using UnityEngine;
using System.Collections.Generic;
using TNRD.Editor.Core;
using System.Reflection;
using TNRD.Editor;

namespace TNRD.Automatron {

    public class Automation : ExtendedControl {

        private List<AutomationField> fields = new List<AutomationField>();

        protected override void OnInitialize() {
            Size = new Vector2( 250, 300 );

            AnchorPoint = EAnchor.TopLeft;

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
            base.OnGUI();
            var rect = Rectangle;

            GUI.Box( rect, "", ExtendedGUI.DefaultWindowStyle );

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