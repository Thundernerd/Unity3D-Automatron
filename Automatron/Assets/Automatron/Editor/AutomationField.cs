#if UNITY_EDITOR
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Automatron.Drawers;
using TNRD.Automatron.Editor.Core;
using TNRD.Automatron.Editor.Serialization;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public class AutomationField {

        public string ID;
        public readonly string Name;
        public Automation Parent { get { return parent; } }

        [IgnoreSerialization]
        public FieldLine LineIn;
        [IgnoreSerialization]
        public List<FieldLine> LinesOut = new List<FieldLine>();

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
                } else if ( fieldType.IsArray ) {
                    drawerType = typeof( ArrayDrawer );
                } else if ( fieldType.GetInterfaces().Contains( typeof( IList ) ) ) {
                    drawerType = typeof( ListDrawer );
                } else {
                    var t = typeof( UnityEngine.Object );
                    if ( fieldType == t || fieldType.IsSubclassOf( t ) ) {
                        drawerType = typeof( ObjectDrawer );
                    }
                }
            }

            drawer = (AutomationDrawer)Activator.CreateInstance( drawerType );
            drawer.CustomAttributes = info.GetCustomAttributes( false ).ToList();
            drawer.HasReadOnlyAttribute = info.GetCustomAttributes( typeof( ReadOnlyAttribute ), false ).FirstOrDefault() != null;
            drawer.Parent = this;
            drawer.Type = fieldType;
            drawer.Initialize();

            Name = ObjectNames.NicifyVariableName( info.Name );

            Rectangle = new Rect( parent.Position.x, parent.Position.y, parent.Size.x, drawer.GetFieldHeight() );
        }

        public float GetHeight() {
            return drawer.GetFieldHeight();
        }

        public object GetValue() {
            return info.GetValue( parent );
        }

        public void SetValue( object value ) {
            info.SetValue( parent, value );
        }

        public Type GetFieldType() {
            return info.FieldType;
        }

        public void OnGUI( Rect rect ) {
            Rectangle = rect;

            object value = info.GetValue( parent );
            drawer.OnGUI( rect, Name, ref value );
            info.SetValue( parent, value );

            var rightRect = new Rect( rect.x + rect.width, rect.y + rect.height / 2 - 5, 12, 10 );
            var leftRect = new Rect( rect.x - 12, rect.y + rect.height / 2 - 5, 12, 10 );

            GUI.Box( leftRect, "", ExtendedGUI.BoxStyle );
            GUI.Box( rightRect, "", ExtendedGUI.BoxStyle );

            var mpos = parent.Input.MousePosition;

            if ( parent.Input.ButtonReleased( Editor.EMouseButton.Left ) ) {
                if ( leftRect.Contains( mpos ) ) {
                    if ( LineIn != null ) {
                        LineIn.Remove();
                        LineIn = null;
                    }

                    LineIn = FieldLine.HookLineIn( this );
                    parent.Window.AddControl( LineIn );
                    parent.Input.Use();
                } else if ( rightRect.Contains( mpos ) ) {
                    var line = FieldLine.HookLineOut( this );
                    if ( LinesOut.Contains( line ) ) {
                        LinesOut.Remove( line );
                    }

                    LinesOut.Add( line );
                    parent.Window.AddControl( line );
                    parent.Input.Use();
                }
            }

            if ( parent.Input.ButtonReleased( Editor.EMouseButton.Right ) ) {
                if ( leftRect.Contains( mpos ) ) {
                    if ( LineIn != null ) {
                        LineIn.Remove();
                        LineIn = null;
                    }
                    parent.Input.Use();
                } else if ( rightRect.Contains( mpos ) ) {
                    for ( int i = LinesOut.Count - 1; i >= 0; i-- ) {
                        LinesOut[i].Remove();
                    }
                    LinesOut.Clear();
                    parent.Input.Use();
                }
            }
        }
    }
}
#endif