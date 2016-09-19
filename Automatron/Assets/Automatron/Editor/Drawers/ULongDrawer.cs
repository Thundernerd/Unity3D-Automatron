#if UNITY_EDITOR
﻿using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( ulong ) )]
    public class ULongDrawer : DraggingDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            var u = (ulong)value;

            EditorGUI.BeginDisabledGroup( IsReadOnly );

            if ( isDragging ) {
                var delta = Mathf.RoundToInt( dragDelta );
                if ( delta > 0 ) {
                    u += (ulong)delta;
                } else {
                    u -= (ulong)( delta *= -1 );
                }
            }

            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            var v = EditorGUI.TextField( GetControlRect(), u.ToString() );
            try {
                v = Regex.Replace( v, @".[^0-9]", "" );
                value = ulong.Parse( v );
            } catch ( System.Exception ) { }

            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif