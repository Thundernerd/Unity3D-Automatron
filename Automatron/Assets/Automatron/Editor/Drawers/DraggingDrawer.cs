#if UNITY_EDITOR
﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace TNRD.Automatron.Drawers {
    
    public class DraggingDrawer : AutomationDrawer {

        protected bool isDragging = false;
        protected float dragDelta;

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );

            var r = GetControlRect();

            dragDelta = 0;
            var e = Event.current;
            if ( isDragging ) {
                EditorGUIUtility.AddCursorRect( new Rect( 0, 0, 4000, 4000 ), MouseCursor.ResizeHorizontal );
                if ( e.type == EventType.MouseDrag ) {
                    dragDelta = e.delta.x;
                    Event.current.Use();
                }
            }
            if ( e.type == EventType.MouseDown && e.button == 0 ) {
                if ( r.Contains( e.mousePosition ) ) {
                    isDragging = true;
                    Event.current.Use();
                }
            } else if ( e.type == EventType.MouseUp ) {
                if ( isDragging ) {
                    isDragging = false;
                    Event.current.Use();
                }
            }

            ResetRect();
        }
    }
}
#endif