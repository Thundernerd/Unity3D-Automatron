using System.Collections.Generic;
using System.Reflection;
using TNRD.Editor;
using TNRD.Editor.Core;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class Automation : ExtendedControl {

        private static Automation dragger = null;

        private string name;
        private GUIStyle headerStyle;

        private List<AutomationField> fields = new List<AutomationField>();
        private Dictionary<string, AutomationField> sortedFields = new Dictionary<string, AutomationField>();

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
        }

        protected override void OnGUI() {
            var rect = Rectangle;

            GUI.Box( rect, "", ExtendedGUI.DefaultWindowStyle );
            GUI.Label( new Rect( rect.x, rect.y, rect.width, 16 ), name, headerStyle );

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

        public bool HasField( string id ) {
            return sortedFields.ContainsKey( id );
        }

        public AutomationField GetField( string id ) {
            return sortedFields[id];
        }
    }
}