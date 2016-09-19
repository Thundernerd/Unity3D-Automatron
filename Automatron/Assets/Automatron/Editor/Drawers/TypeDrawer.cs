#if UNITY_EDITOR
﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( Type ) )]
    public class TypeDrawer : AutomationDrawer {

        private int index;
        private string[] displayedOptions;
        private List<Type> types;

        public override void Initialize() {
            base.Initialize();

            var typeLimit = CustomAttributes.Where( a => a is TypeLimitAttribute ).FirstOrDefault();
            if ( typeLimit != null ) {
                var type = ( typeLimit as TypeLimitAttribute ).Type;

                types = Globals.Types
                    .Where( t => t == type || t.IsSubclassOf( type ) )
                    .OrderBy( t => t.Namespace ).ThenBy( t => t.FullName )
                    .ToList();

            } else {
                types = Globals.Types;
            }

            displayedOptions = types.Select( t => t.FullName.Trim( '&' ).Replace( "+", "." ).Replace( ".", "/" ) ).ToArray();
        }

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            index = EditorGUI.Popup( GetControlRect(), index, displayedOptions );
            value = types[index];
            EditorGUI.EndDisabledGroup();
        }
    }
}
#endif