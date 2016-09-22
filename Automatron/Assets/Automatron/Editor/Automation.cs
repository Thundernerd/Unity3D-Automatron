#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TNRD.Automatron.Automations;
using TNRD.Automatron.Editor;
using TNRD.Automatron.Editor.Core;
using TNRD.Automatron.Editor.Serialization;
using TNRD.Automatron.Editor.Utilities;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron {

    public abstract class Automation : ExtendedControl {

        private static Automation dragger = null;

        new public Rect Rectangle {
            get {
                var rect = base.Rectangle;
                rect.position += Globals.Camera;
                return rect;
            }
        }

        [RequireSerialization]
        private string name;
        private GUIStyle headerStyle;

        protected List<AutomationField> fields = new List<AutomationField>();
        protected Dictionary<string, AutomationField> sortedFields = new Dictionary<string, AutomationField>();

        [RequireSerialization]
        protected bool showCloseButton = true;
        [RequireSerialization]
        protected bool showOutArrow = true;
        [RequireSerialization]
        protected bool showInArrow = true;

        [IgnoreSerialization]
        public float Progress;

        [IgnoreSerialization]
        public List<AutomationLine> LinesIn = new List<AutomationLine>();
        [IgnoreSerialization]
        public AutomationLine LineOut;

        [IgnoreSerialization]
        public ErrorType ErrorType = ErrorType.None;

        [IgnoreSerialization]
        public bool HasRun = false;

        private double previousTicks = 0;

        protected override void OnInitialize() {
            Size = new Vector2( 250, 300 );

            AnchorPoint = EAnchor.TopLeft;
            SortingOrder = ESortingOrder.Automation;

            GetName();
            LoadFields();
            UpdateSize();
            RunOnGUIThread( CreateStyles );
        }

        protected override void OnAfterSerialize() {
            GetName();
            LoadFields();
            UpdateSize();
            RunOnGUIThread( CreateStyles );
        }

        private void GetName() {
            try {
                name = ( GetType().GetCustomAttributes( typeof( AutomationAttribute ), false )[0] as AutomationAttribute ).Name;
                if ( name.Contains( "/" ) && name.Length > 35 ) {
                    var foundFirst = false;
                    int ind = -1;
                    for ( int i = name.Length - 1; i >= 0; i-- ) {
                        if ( name[i] == '/' ) {
                            if ( !foundFirst ) {
                                ind = i;
                                foundFirst = true;
                                continue;
                            }

                            ind = i;
                            break;
                        }
                    }

                    if ( ind != -1 ) {
                        name = name.Substring( ind + 1 );
                    }

                    if ( name.Contains( "/" ) && name.Length > 35 ) {
                        var index = name.LastIndexOf( '/' );
                        name = name.Substring( index + 1 );
                    }
                }
            } catch ( IndexOutOfRangeException ) {
                name = "";
                // This is for the internal queue start
            }
        }

        protected override void OnDestroy() {
            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    item.LineIn.Remove();
                }

                for ( int i = item.LinesOut.Count - 1; i >= 0; i-- ) {
                    item.LinesOut[i].Remove();
                }
            }

            if ( LinesIn.Count > 0 ) {
                for ( int i = LinesIn.Count - 1; i >= 0; i-- ) {
                    LinesIn[i].Remove();
                }
            }

            if ( LineOut != null ) {
                LineOut.Remove();
                LineOut = null;
            }
        }

        public void LoadFields() {
            fields.Clear();
            sortedFields.Clear();

            var type = GetType();
            var infos = type.GetFields( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly );
            for ( int i = 0; i < infos.Length; i++ ) {
                var field = infos[i];
                var id = string.Format( "{0}_{1}_{2}", ID, field.Name, i );
                var instance = new AutomationField( this, field, id );
                fields.Add( instance );
                sortedFields.Add( id, instance );
            }
        }

        private void UpdateSize() {
            float height = 24;
            foreach ( var item in fields ) {
                height += item.GetHeight();
            }
            Size.y = Mathf.Max( height, 34 );
        }

        private void CreateStyles() {
            headerStyle = new GUIStyle( EditorStyles.label );
            headerStyle.alignment = TextAnchor.MiddleCenter;

        }

        private void RemoveIncomingLines() {
            if ( LinesIn.Count > 0 ) {
                for ( int i = LinesIn.Count - 1; i >= 0; i-- ) {
                    LinesIn[i].Remove();
                }
            }

            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    item.LineIn.Remove();
                }
            }
        }

        private void RemoveOutgoingLines() {
            if ( LineOut != null ) {
                LineOut.Remove();
                LineOut = null;
            }

            foreach ( var item in fields ) {
                if ( item.LinesOut.Count > 0 ) {
                    for ( int i = item.LinesOut.Count - 1; i >= 0; i-- ) {
                        item.LinesOut[i].Remove();
                    }
                }
            }
        }

        protected override void OnGUI() {
            var rect = Rectangle;

            GUI.Box( rect, "", ExtendedGUI.DefaultWindowStyle );
            if ( Progress > 0 && ErrorType == ErrorType.None ) {
                GUI.DrawTexture( new Rect( rect.x, rect.y, rect.width * Progress, 15 ), Assets["progressBar"] );
            }
            switch ( ErrorType ) {
                case ErrorType.Generic:
                    GUI.DrawTexture( new Rect( rect.x, rect.y, rect.width, 15 ), Assets["genericException"] );
                    break;
                case ErrorType.Arugment:
                    GUI.DrawTexture( new Rect( rect.x, rect.y, rect.width, 15 ), Assets["argumentException"] );
                    break;
            }
            var topRect = new Rect( rect.x, rect.y, rect.width, 16 );
            GUI.Label( topRect, name, headerStyle );

            if ( Input.ButtonReleased( EMouseButton.Left ) && topRect.Contains( Input.MousePosition ) ) {
                var n = DateTime.Now.Ticks;
                var t = n - previousTicks;
                if ( t <= 5000000 ) {
                    ( Window as AutomatronEditor ).LookAtAutomationSmooth( this );
                    n = 0;
                }
                previousTicks = n;
            }

            if ( !Globals.IsError && Input.ButtonReleased( EMouseButton.Right ) && topRect.Contains( Input.MousePosition ) ) {
                var gm = GenericMenuBuilder.CreateMenu();
                gm.AddItem( "Remove Incoming Lines", false, RemoveIncomingLines );
                gm.AddItem( "Remove Outgoing Lines", false, RemoveOutgoingLines );
                gm.ShowAsContext();
            }

            if ( showCloseButton && !Globals.IsExecuting ) {
                var cRect = new Rect( rect.x + rect.width - 14, rect.y + 1, 13, 13 );
                if ( cRect.Contains( Input.MousePosition ) ) {
                    GUI.DrawTexture( cRect, Assets["crossActive"] );

                    if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                        Remove();
                        Input.Use();
                    }
                } else {
                    GUI.DrawTexture( cRect, Assets["crossNormal"] );
                }
            }

            var lArrow = new Rect( rect.x - 15, rect.y, 15, 15 );
            var rArrow = new Rect( rect.x + rect.width, rect.y, 15, 15 );

            if ( showInArrow ) {
                GUI.DrawTexture( lArrow, Assets["arrowleft"] );

                if ( !Globals.IsExecuting ) {
                    if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                        if ( lArrow.Contains( Input.MousePosition ) ) {
                            var line = AutomationLine.HookLineIn( this );
                            if ( LinesIn.Contains( line ) ) {
                                LinesIn.Remove( line );
                            }

                            LinesIn.Add( line );
                            Window.AddControl( line );
                            Input.Use();
                        }
                    } else if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                        if ( lArrow.Contains( Input.MousePosition ) ) {
                            if ( LinesIn.Count > 0 ) {
                                for ( int i = LinesIn.Count - 1; i >= 0; i-- ) {
                                    LinesIn[i].Remove();
                                }
                            }

                            Input.Use();
                        }
                    }
                }
            }

            if ( showOutArrow ) {
                GUI.DrawTexture( rArrow, Assets["arrowright"] );

                if ( !Globals.IsExecuting ) {
                    if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                        if ( rArrow.Contains( Input.MousePosition ) ) {
                            if ( LineOut != null ) {
                                LineOut.Remove();
                                LineOut = null;
                            }

                            LineOut = AutomationLine.HookLineOut( this );
                            Window.AddControl( LineOut );
                            Input.Use();
                        }
                    } else if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                        if ( rArrow.Contains( Input.MousePosition ) ) {
                            if ( LineOut != null ) {
                                LineOut.Remove();
                                LineOut = null;
                            }

                            Input.Use();
                        }
                    }
                }
            }

            if ( !Globals.IsExecuting ) {
                if ( Input.ButtonPressed( EMouseButton.Left ) ) {
                    dragger = null;

                    switch ( SortingOrder ) {
                        case ESortingOrder.Automation:
                            if ( rect.Contains( Input.MousePosition ) ) {
                                SortingOrder = ESortingOrder.AutomationSelected;
                            }
                            break;
                        case ESortingOrder.AutomationSelected:
                            if ( !rect.Contains( Input.MousePosition ) ) {
                                SortingOrder = ESortingOrder.Automation;
                            }
                            break;
                    }
                }

                if ( Input.ButtonDown( EMouseButton.Left ) ) {
                    if ( dragger == null ) {
                        var dragRect = new Rect( rect.x, rect.y, rect.width - 16, 16 );
                        if ( dragRect.Contains( Input.MousePosition ) ) {
                            dragger = this;
                            GUIUtility.keyboardControl = 0;
                        }
                    }
                }

                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    dragger = null;
                }

                if ( dragger == this ) {
                    Position += Input.DragDelta;
                }
            }

            var fieldRect = new Rect( rect.x, rect.y + 18, rect.width, rect.height );
            foreach ( var item in fields ) {
                var height = item.GetHeight();
                fieldRect.height = height;
                item.OnGUI( fieldRect );
                fieldRect.y += height;
            }

            if ( Input.ButtonReleased( EMouseButton.Right ) && rect.Contains( Input.MousePosition ) ) {
                Input.Use();
            }

            if ( Input.ButtonDown( EMouseButton.Middle ) && rect.Contains( Input.MousePosition ) ) {
                Input.Use();
            }

            UpdateSize();
        }

        public bool HasField( string id ) {
            return sortedFields.ContainsKey( id );
        }

        public AutomationField GetField( string id ) {
            return sortedFields[id];
        }

        public List<AutomationField> GetFields() {
            return new List<AutomationField>( fields );
        }

        public virtual List<Automation> GetNextAutomations() {
            var list = new List<Automation>();

            if ( LineOut != null ) {
                LineOut.Right.GetAutomations( ref list, false );
            }

            return list;
        }

        public void GetAutomations( ref List<Automation> automations, bool goNext ) {
            foreach ( var field in fields ) {
                if ( field.LineIn != null ) {
                    var parent = field.LineIn.Left.Parent;
                    if ( !parent.HasRun && !( parent is LoopableAutomation ) && !automations.Contains( parent ) ) {
                        parent.GetAutomations( ref automations, true );
                    }
                }
            }

            if ( !automations.Contains( this ) ) {
                automations.Add( this );
            }

            if ( goNext && LineOut != null ) {
                LineOut.Right.GetAutomations( ref automations, true );
            }
        }

        public void ResetFields() {
            foreach ( var item in fields ) {
                var type = item.GetFieldType();
                var tcode = Type.GetTypeCode( type );
                object value = null;

                switch ( tcode ) {
                    case TypeCode.Empty:
                    case TypeCode.Object:
                        value = null;
                        break;
                    case TypeCode.Boolean:
                    case TypeCode.Char:
                    case TypeCode.SByte:
                    case TypeCode.Byte:
                    case TypeCode.Int16:
                    case TypeCode.UInt16:
                    case TypeCode.Int32:
                    case TypeCode.UInt32:
                    case TypeCode.Int64:
                    case TypeCode.UInt64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                    case TypeCode.DateTime:
                        value = Activator.CreateInstance( type );
                        break;
                    case TypeCode.String:
                        value = "";
                        break;
                }

                if ( value == null && !type.IsClass ) {
                    value = Activator.CreateInstance( type );
                }

                try {
                    item.SetValue( value );
                } catch ( Exception ) {
                    Debug.LogWarningFormat( "Unable to reset field \"{0}\" on \"{1}\"", item.Name, name );
                }
            }
        }

        public virtual void Reset() {
            HasRun = false;
            Progress = 0;
            ErrorType = ErrorType.None;

            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    item.LineIn.Color = Color.white;
                }
            }
        }

        public virtual void ResetLoop() {
            HasRun = false;

            foreach ( var field in fields ) {
                if ( field.LineIn != null ) {
                    var parent = field.LineIn.Left.Parent;
                    if ( !( parent is LoopableAutomation ) && parent.HasRun ) {
                        parent.ResetLoop();
                    }
                }
            }

            if ( LineOut != null && !( LineOut.Right is LoopableAutomation ) && LineOut.Right.HasRun ) {
                LineOut.Right.ResetLoop();
            }
        }

        public void GetDependencies() {
            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    var value = item.LineIn.Left.GetValue();
                    try {
                        var type = value.GetType();
                        var myType = item.GetFieldType();

                        if ( type.IsArray() ) {
                            if ( !myType.IsArray() && myType.IsList() ) {
                                var list = Converter.ArrayToList( (Array)value );
                                value = list;
                            }
                        } else if ( type.IsList() ) {
                            if ( !myType.IsList() && myType.IsArray() ) {
                                var array = Converter.ListToArray( (IList)value );
                                value = array;
                            }
                        } else if ( IsNumeric( type, myType ) ) {
                            value = Convert.ChangeType( value, myType );
                        }

                        item.SetValue( value );
                    } catch ( ArgumentException ex ) {
                        item.LineIn.Color = new Color( 0.72f, 0.72f, 0.047f, 1 );
                        ErrorType = ErrorType.Arugment;
                        Globals.LastAutomation = this;
                        Globals.LastError = ex;
                        Globals.IsError = true;
                    } catch ( Exception ex ) {
                        item.LineIn.Color = new Color( 0.36f, 0.0235f, 0.0235f, 1 );
                        ErrorType = ErrorType.Generic;
                        Globals.LastAutomation = this;
                        Globals.LastError = ex;
                        Globals.IsError = true;
                    }
                }
            }
        }

        private bool IsNumeric( Type a, Type b ) {
            var at = Type.GetTypeCode( a );
            var bt = Type.GetTypeCode( b );

            var ar = false;
            var br = false;

            switch ( at ) {
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                    ar = true;
                    break;
            }

            switch ( bt ) {
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                    br = true;
                    break;
            }

            return ar && br && at != bt;
        }

        public virtual void PreExecute() { }

        public abstract IEnumerator Execute();

        public virtual void PostExecute() { }
    }
}

#endif