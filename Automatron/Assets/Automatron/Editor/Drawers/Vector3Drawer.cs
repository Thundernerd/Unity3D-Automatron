using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawerss {

    [CustomDrawer( typeof( Vector3 ) )]
    public class Vector3Drawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.Vector3Field( GetControlRect(), "", (Vector3)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}