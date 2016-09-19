#if UNITY_EDITOR
﻿using UnityEngine;
using UnityEditor;
using System;

namespace TNRD.Automatron.Drawers {

    public class EnumDrawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );            
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.EnumPopup( GetControlRect(), (Enum)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif