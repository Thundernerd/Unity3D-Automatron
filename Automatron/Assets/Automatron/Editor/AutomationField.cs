using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Automatron.Drawers;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class AutomationField {

        public string ID;
        public readonly string Name;

        private Automation parent;
        private FieldInfo info;
        private AutomationDrawer drawer;

        public AutomationField( Automation parent, FieldInfo info ) {
            this.parent = parent;
            this.info = info;

            var fieldType = info.FieldType;
            var drawerType = AutomatronEditor.GetDrawerType( fieldType );

            if ( drawerType == typeof( HelpDrawer ) ) {
                if ( fieldType.IsEnum ) {
                    drawerType = typeof( EnumDrawer );
                } else if ( fieldType.IsArray || fieldType.GetInterfaces().Contains( typeof( IList ) ) ) {
                    // Set type when I finally made a good list drawer :)
                } else {
                    var t = typeof( UnityEngine.Object );
                    if ( fieldType == t || fieldType.IsSubclassOf( t ) ) {
                        drawerType = typeof( ObjectDrawer );
                    }
                }
            }

            drawer = (AutomationDrawer)Activator.CreateInstance( drawerType );
            drawer.CustomAttributes = info.GetCustomAttributes( false ).ToList();
            drawer.IsReadOnly = info.GetCustomAttributes( typeof( ReadOnlyAttribute ), false ).FirstOrDefault() != null;
            drawer.Parent = this;
            drawer.Type = fieldType;
            drawer.Initialize();

            Name = Utils.GetPrettyName( info.Name );
        }

        public float GetHeight() {
            return drawer.GetFieldHeight();
        }

        public void OnGUI( Rect rect ) {
            object value = info.GetValue( parent );
            drawer.OnGUI( rect, Name, ref value );
            info.SetValue( parent, value );
        }
    }
}