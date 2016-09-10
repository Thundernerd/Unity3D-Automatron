using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( uint ) )]
    public class UIntDrawer : DraggingDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            var u = (uint)value;

            EditorGUI.BeginDisabledGroup( IsReadOnly );

            if ( isDragging ) {
                var delta = Mathf.RoundToInt( dragDelta );
                if ( delta > 0 ) {
                    u += (uint)delta;
                } else {
                    u -= (uint)( delta *= -1 );
                }
            }

            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            var v = EditorGUI.TextField( GetControlRect(), u.ToString() );
            try {
                v = Regex.Replace( v, @".[^0-9]", "" );
                value = uint.Parse( v );
            } catch ( System.Exception ) { }

            EditorGUI.EndDisabledGroup();
        }
    }
}