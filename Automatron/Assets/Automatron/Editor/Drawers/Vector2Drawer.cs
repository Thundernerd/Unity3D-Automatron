using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Vector2 ) )]
    public class Vector2Drawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.Vector2Field( GetControlRect(), "", (Vector2)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}