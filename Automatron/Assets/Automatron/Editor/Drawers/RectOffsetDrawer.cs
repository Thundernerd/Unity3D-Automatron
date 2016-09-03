using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( RectOffset ) )]
    public class RectOffsetDrawer : AutomationDrawer {

        private GUIContent[] horizontalNames;
        private GUIContent[] verticalNames;

        public override void Initialize() {
            horizontalNames = new GUIContent[] {
                new GUIContent("left"),
                new GUIContent("right")
            };
            verticalNames = new GUIContent[] {
                new GUIContent("top"),
                new GUIContent("bottom")
            };
        }

        public override float GetFieldHeight() {
            // 18 for label, 34 for the rect field
            return 54;
        }

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );

            var r = (RectOffset)value ?? new RectOffset();
            var h = new float[] { r.left, r.right };
            var v = new float[] { r.top, r.bottom };

            var hrect = GetControlRect();
            r.left = DrawBox( hrect, "left", r.left, 0 );
            r.right = DrawBox( hrect, "right", r.right, hrect.width / 2 );

            var vrect = GetControlRect();
            r.top = DrawBox( vrect, "top", r.top, 0 );
            r.bottom = DrawBox( vrect, "bottom", r.bottom, vrect.width / 2 );
            
            value = r;
            EditorGUI.EndDisabledGroup();
        }

        private int DrawBox( Rect f, string label, int value, float offset ) {
            var r = new Rect( f.x + offset, f.y, f.width / 2, f.height );
            var g = EditorGUIUtility.labelWidth;
            EditorGUIUtility.labelWidth = 50f;
            value = EditorGUI.IntField( r, label, value );
            EditorGUIUtility.labelWidth = g;
            return value;
        }
    }
}