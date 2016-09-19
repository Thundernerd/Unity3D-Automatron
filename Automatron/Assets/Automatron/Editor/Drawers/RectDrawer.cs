#if UNITY_EDITOR
﻿using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Rect ) )]
    public class RectDrawer : AutomationDrawer {

        public override float GetFieldHeight() {
            // 18 for label, 34 for the rect field
            return 52;
        }

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            value = EditorGUI.RectField( GetControlRect( 32 ), (Rect)value );
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif