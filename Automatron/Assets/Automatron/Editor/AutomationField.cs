using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Automatron.Drawers;
using TNRD.Editor.Core;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class AutomationField {

        public string ID;
        public readonly string Name;

        public FieldLine LineIn;
        public FieldLine LineOut;

        // This is for the connection lines
        public Rect Rectangle { get; private set; }

        private Automation parent;
        private FieldInfo info;
        private AutomationDrawer drawer;

        public AutomationField( Automation parent, FieldInfo info, string id ) {
            this.parent = parent;
            this.info = info;
            this.ID = id;

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

            Rectangle = new Rect( parent.Position.x, parent.Position.y, parent.Size.x, drawer.GetFieldHeight() );
        }

        public float GetHeight() {
            return drawer.GetFieldHeight();
        }

        public void OnGUI( Rect rect ) {
            Rectangle = rect;

            object value = info.GetValue( parent );
            drawer.OnGUI( rect, Name, ref value );
            info.SetValue( parent, value );

            if ( GUI.Button( new Rect( rect.x + rect.width, rect.y + rect.height / 2 - 5, 12, 10 ), "", ExtendedGUI.BoxStyle ) ) {
                if ( LineOut != null ) {
                    LineOut.Remove();
                    LineOut = null;
                }

                LineOut = FieldLine.HookLineOut( this );
                parent.Window.AddControl( LineOut );
            }

            if ( GUI.Button( new Rect( rect.x - 12, rect.y + rect.height / 2 - 5, 12, 10 ), "", ExtendedGUI.BoxStyle ) ) {
                if ( LineIn != null ) {
                    LineIn.Remove();
                    LineIn = null;
                }

                LineIn = FieldLine.HookLineIn( this );
                parent.Window.AddControl( LineIn );
            }
        }
    }
}