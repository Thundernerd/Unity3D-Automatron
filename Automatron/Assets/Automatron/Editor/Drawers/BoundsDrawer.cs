using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Bounds ) )]
    public class BoundsDrawer : AutomationDrawer {

        public override float GetFieldHeight() {
            // 18 for label, 34 for the bounds field
            return 54;
        }

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.BoundsField( GetControlRect(32), (Bounds)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}