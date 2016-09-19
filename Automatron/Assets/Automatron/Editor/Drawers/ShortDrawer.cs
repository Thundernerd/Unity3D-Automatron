#if UNITY_EDITOR
﻿using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( short ) )]
    public class ShortDrawer : DraggingDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            var u = (short)value;

            EditorGUI.BeginDisabledGroup( IsReadOnly );

            if ( isDragging ) {
                var id = Mathf.RoundToInt( dragDelta );
                u += (short)id;
            }

            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            var v = EditorGUI.TextField( GetControlRect(), u.ToString() );
            try {
                v = Regex.Replace( v, @".[^0-9]", "" );
                value = short.Parse( v );
            } catch ( System.Exception ) { }

            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif