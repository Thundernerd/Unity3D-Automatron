using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class AutomationDrawer {

        public List<object> CustomAttributes = new List<object>();
        public bool IsReadOnly = false;
        public AutomationField Parent;
        public Type ValueType;

        public virtual float GetFieldHeight() {
            return ( EditorGUIUtility.singleLineHeight + 2 ) * 2;
        }

        public virtual void Initialize() { }
        public virtual void OnGUI( Rect rect, string name, ref object value ) {
            totalRect = rect;
            lastY = totalRect.y;
        }

        private Rect totalRect;
        private float lastY = 0;

        protected Rect GetControlRect( float height = 16 ) {
            var rect = new Rect( totalRect.x, lastY, totalRect.width - 1, height );
            lastY += height + 2;
            return rect;
        }
    }
}