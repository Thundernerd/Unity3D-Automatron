using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( char ) )]
    public class CharDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            var c = (char)value;
            var v = "";
            if ( c == '\0' ) {
                v = "";
            } else {
                v = c.ToString();
            }
            v = EditorGUI.TextField( GetControlRect(), v );
            if ( v.Length > 1 ) {
                v = v.Substring( 0, 1 );
                value = v[0];
            } else if ( v.Length == 0 ) {
                value = '\0';
            }
            EditorGUI.EndDisabledGroup();
        }
    }
}