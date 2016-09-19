#if UNITY_EDITOR
﻿using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Color ) )]
    public class ColorDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            try {
                value = EditorGUI.ColorField( GetControlRect(), (Color)value );
            } catch ( ExitGUIException ) { }
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif