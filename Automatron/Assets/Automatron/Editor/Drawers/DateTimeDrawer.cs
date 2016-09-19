#if UNITY_EDITOR
﻿using System;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( DateTime ) )]
    public class DateTimeDrawer : AutomationDrawer {

        private DateTime? ndt = null;
        private object initial = null;

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            var dt = (DateTime)value;
            if ( initial == null ) {
                if ( dt.Year == 1 && dt.Month == 1 && dt.Day == 1 ) {
                    dt = DateTime.Now;
                }
                initial = new object();
            }
            if ( ndt != null ) {
                dt = ndt.Value;
                ndt = null;
            }
            var r = GetControlRect();
            EditorGUI.LabelField( r, string.Format( "{1} {0}", dt.ToShortTimeString(), dt.ToShortDateString() ) );
            var e = Event.current;
            var nr = new Rect( r );
            nr.x += r.width - 32;
            nr.y += 1;
            nr.width = 13;
            nr.height = 13;
            GUI.DrawTexture( nr, Parent.Parent.Assets["clock"] );
            if ( e.type == EventType.MouseDown && e.button == 0 && nr.Contains( e.mousePosition ) )
                TimePopup.Show( r, dt, ( DateTime d ) => { ndt = d; } );
            nr.x += 16;
            GUI.DrawTexture( nr, Parent.Parent.Assets["calendar"] );
            if ( e.type == EventType.MouseDown && e.button == 0 && nr.Contains( e.mousePosition ) )
                DatePopup.Show( r, dt, ( DateTime d ) => { ndt = d; } );
            value = dt;
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif