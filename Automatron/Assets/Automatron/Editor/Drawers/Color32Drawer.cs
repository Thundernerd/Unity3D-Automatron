#if UNITY_EDITOR
﻿using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Color32 ) )]
    public class Color32Drawer : AutomationDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            try {
                var c = (Color32)value;
                var c2 = new Color( c.r / 255f, c.g / 255f, c.b / 255f, c.a / 255f );
                c2 = EditorGUI.ColorField( GetControlRect(), c2 );
                value = new Color32( (byte)( c2.r * 255f ), (byte)( c2.g * 255f ), (byte)( c2.b * 255f ), (byte)( c2.a * 255f ) );
            } catch ( ExitGUIException ) { }
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif