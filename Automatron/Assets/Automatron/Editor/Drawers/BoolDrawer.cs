#if UNITY_EDITOR
﻿using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( bool ) )]
    public class BoolDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.Toggle( GetControlRect(), (bool)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif