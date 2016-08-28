using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Object ) )]
    public class ObjectDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            try {
                var t = EditorGUI.ObjectField( GetControlRect(), (Object)value, Type, true );
                if ( t != null ) {
                    value = t;
                }
            } catch ( ExitGUIException ) { }
            EditorGUI.EndDisabledGroup();
        }
    }
}