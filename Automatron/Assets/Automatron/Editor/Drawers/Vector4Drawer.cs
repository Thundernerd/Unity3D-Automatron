using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Vector4 ) )]
    public class Vector4Drawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.Vector4Field( new Rect( rect.x, rect.y, rect.width - 1, rect.height ), "", (Vector4)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}