using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TNRD.Editor;
using TNRD.Editor.Core;
using TNRD.Editor.Serialization;
using TNRD.Editor.Utilities;
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
        public AutomationLine LineIn;
        [IgnoreSerialization]
        public AutomationLine LineOut;

        [IgnoreSerialization]
        public ErrorType ErrorType = ErrorType.None;

        [IgnoreSerialization]
        public bool HasRun = false;
        [IgnoreSerialization]
        public bool IsInLoop = false;

        public bool ExecuteEveryLoop = false;

        protected override void OnInitialize() {
            Size = new Vector2( 250, 300 );

            AnchorPoint = EAnchor.TopLeft;
            SortingOrder = ESortingOrder.Automation;

            GetName();
            GetFields();
            UpdateSize();
            RunOnGUIThread( CreateStyles );
        }

        protected override void OnAfterSerialize() {
            GetName();
            GetFields();
            UpdateSize();
            RunOnGUIThread( CreateStyles );
        }

        private void GetName() {
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

            if ( LineIn != null ) {
                LineIn.Remove();
                LineIn = null;
            }

            if ( LineOut != null ) {
                LineOut.Remove();
                LineOut = null;
            }
        }

        private void GetFields() {
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

        private void ToggleExecuteEveryLoop() {
            ExecuteEveryLoop = !ExecuteEveryLoop;
        }

        private void RemoveIncomingLines() {
            if ( LineIn != null ) {
                LineIn.Remove();
                LineIn = null;
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

            if ( Input.ButtonReleased( EMouseButton.Right ) && topRect.Contains( Input.MousePosition ) ) {
                var gm = GenericMenuBuilder.CreateMenu();
                gm.AddItem( "Execute Every Loop", ExecuteEveryLoop, ToggleExecuteEveryLoop );
                gm.AddSeparator();
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

                if ( Input.ButtonReleased( EMouseButton.Left ) ) {
                    if ( lArrow.Contains( Input.MousePosition ) ) {
                        if ( LineIn != null ) {
                            LineIn.Remove();
                            LineIn = null;
                        }

                        LineIn = AutomationLine.HookLineIn( this );
                        Window.AddControl( LineIn );
                        Input.Use();
                    }
                } else if ( Input.ButtonReleased( EMouseButton.Right ) ) {
                    if ( lArrow.Contains( Input.MousePosition ) ) {
                        if ( LineIn != null ) {
                            LineIn.Remove();
                            LineIn = null;
                        }

                        Input.Use();
                    }
                }
            }

            if ( showOutArrow ) {
                GUI.DrawTexture( rArrow, Assets["arrowright"] );

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
                    if ( ( ExecuteEveryLoop || ( !parent.HasRun && !IsInLoop ) ) && !automations.Contains( parent ) ) {
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

        public virtual void Reset() {
            HasRun = false;
            IsInLoop = false;
            Progress = 0;
            ErrorType = ErrorType.None;

            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    item.LineIn.Color = Color.white;
                }
            }
        }

        public void PrepareForExecute() {
            foreach ( var item in fields ) {
                if ( item.LineIn != null ) {
                    var value = item.LineIn.Left.GetValue();
                    try {
                        var type = value.GetType();

                        if ( type.IsArray ) {
                            var myType = item.GetFieldType();
                            if ( myType.GetInterfaces().Contains( typeof( IList ) ) ) {
                                var list = Converter.ArrayToList( (Array)value );
                                value = list;
                            }
                        } else if ( type.GetInterfaces().Contains( typeof( IList ) ) ) {
                            var myType = item.GetFieldType();
                            if ( myType.IsArray ) {
                                var array = Converter.ListToArray( (IList)value );
                                value = array;
                            }
                        }

                        item.SetValue( value );
                    } catch ( System.ArgumentException ex ) {
                        item.LineIn.Color = new Color( 0.72f, 0.72f, 0.047f, 1 );
                        ErrorType = ErrorType.Arugment;
                        Globals.LastAutomation = this;
                        Globals.LastError = ex;
                        Globals.IsError = true;
                    } catch ( System.Exception ex ) {
                        item.LineIn.Color = new Color( 0.36f, 0.0235f, 0.0235f, 1 );
                        ErrorType = ErrorType.Generic;
                        Globals.LastAutomation = this;
                        Globals.LastError = ex;
                        Globals.IsError = true;
                    }
                }
            }
        }

        public abstract IEnumerator Execute();
    }
}
