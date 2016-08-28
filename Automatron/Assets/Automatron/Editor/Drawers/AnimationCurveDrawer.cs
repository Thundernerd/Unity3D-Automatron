using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( AnimationCurve ) )]
    public class AnimationCurveDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            if ( value == null ) {
                value = new AnimationCurve();
            }
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.CurveField( GetControlRect(), (AnimationCurve)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}