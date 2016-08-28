using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( int ) )]
    public class IntDrawer : SliderDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            if ( hasSlider ) {
                value = EditorGUI.IntSlider( GetControlRect(), (int)value, min, max );
            } else {
                value = EditorGUI.IntField( GetControlRect(), (int)value );
            }
            EditorGUI.EndDisabledGroup();
        }
    }
}