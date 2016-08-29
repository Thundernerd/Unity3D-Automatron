using System;
using System.Collections;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    public class ListDrawer : AutomationDrawer {

        private GUIStyle headerStyle;
        private GUIStyle headerLabelStyle;
        private GUIStyle backgroundStyle;
        private GUIStyle elementStyle;
        private GUIStyle footerStyle;
        private GUIStyle buttonStyle;
        private GUIContent plusButton;
        private GUIContent minusButton;

        private Utils.DrawElementAction drawElement;
        private Type elementType;

        private float elementHeight = 16;
        private float elementBackgroundHeight = 20;

        private int selectedIndex = -1;
        private int keyboardIndex = -1;

        private bool updateValue = false;
        private bool fold = false;

        private IList list;

        public override float GetFieldHeight() {
            // 16 = header
            // 2  = spacing
            // 15 = footer
            return 16 + 2 + GetContentHeight() + 2 + 15;
        }

        private float GetContentHeight() {
            if ( fold ) return 36;

            if ( list == null ) {
                return 36;
            } else {
                return Mathf.Max( elementBackgroundHeight * list.Count, 36 );
            }
        }

        public override void Initialize() {
            CreateListStyles();

            elementType = Type.GetGenericArguments()[0];
            Utils.SetupTypeSwitch( elementType, ref drawElement );

            if ( elementType != null ) {
                if ( elementType == typeof( Bounds ) || elementType == typeof( Rect ) ) {
                    elementHeight = 32;
                }
            }

            elementBackgroundHeight = elementHeight + 4;
        }

        private void CreateListStyles() {
            headerStyle = new GUIStyle() {
                alignment = TextAnchor.UpperCenter,
                border = new RectOffset( 4, 4, 3, 2 ),
                clipping = TextClipping.Clip,
                contentOffset = new Vector2( 0, -1 ),
                fixedHeight = 18f,
                stretchHeight = false,
                stretchWidth = false,
                normal = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListHeader"]
                }
            };

            backgroundStyle = new GUIStyle() {
                border = new RectOffset( 6, 3, 1, 6 ),
                normal = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListBackground"]
                }
            };

            elementStyle = new GUIStyle() {
                border = new RectOffset( 2, 3, 0, 3 ),
                clipping = TextClipping.Clip,
                onNormal = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListElementNormal"]
                },
                onActive = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListElementActive"]
                },
                onHover = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListElementActive"]
                },
                onFocused = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListElementActive"]
                }
            };

            footerStyle = new GUIStyle() {
                alignment = TextAnchor.MiddleCenter,
                border = new RectOffset( 4, 4, 3, 4 ),
                clipping = TextClipping.Clip,
                stretchHeight = false,
                normal = new GUIStyleState() {
                    background = Parent.Parent.Assets["ListFooter"]
                }
            };

            buttonStyle = new GUIStyle() {
                alignment = TextAnchor.MiddleCenter,
                border = new RectOffset( 4, 4, 3, 2 ),
                clipping = TextClipping.Clip,
                fixedHeight = 17f,
                stretchHeight = false
            };

            plusButton = new GUIContent( Parent.Parent.Assets["ListPlusButton"] );
            minusButton = new GUIContent( Parent.Parent.Assets["ListMinusButton"] );

            try {
                headerLabelStyle = new GUIStyle( EditorStyles.label ) { alignment = TextAnchor.MiddleCenter };
            } catch ( Exception ) { }
        }

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );

            if ( updateValue ) {
                value = list;
                updateValue = false;
            }

            if ( value != list ) {
                list = (Array)value;
            }

            if ( list == null ) {
                if ( value == null ) {
                    list = (IList)Activator.CreateInstance( Type );
                } else {
                    list = (IList)value;
                }

                updateValue = true;
            }

            if ( headerLabelStyle == null ) {
                CreateListStyles();
                return;
            }

            EditorGUI.BeginDisabledGroup( IsReadOnly );

            var contentHeight = GetContentHeight();
            var headerRect = new Rect( rect.x, rect.y, rect.width, 16 );
            var contentRect = new Rect( rect.x, rect.y + 18, rect.width, contentHeight + 4 );
            var footerRect = new Rect( rect.x + rect.width - 50, rect.y + 20 + contentHeight, 50, 15 );
            var plusRect = new Rect( footerRect.x, footerRect.y - 2, 25, 13 );
            var minusRect = new Rect( footerRect.x + 23, footerRect.y - 2, 25, 13 );
            var foldRect = new Rect( rect.x + 3, rect.y + 3, 13, 13 );

            GUI.Box( headerRect, "", headerStyle );
            GUI.Label( headerRect, name, headerLabelStyle );
            EditorGUI.EndDisabledGroup();

            if ( fold ) {
                GUI.DrawTexture( foldRect, Parent.Parent.Assets["foldOut"] );
            } else {
                GUI.DrawTexture( foldRect, Parent.Parent.Assets["foldIn"] );
            }

            var evt = Event.current;
            if ( evt.isMouse ) {
                if ( evt.type == EventType.MouseUp && evt.button == 0 ) {
                    if ( foldRect.Contains( evt.mousePosition ) ) {
                        fold = !fold;
                    }
                }
            }

            EditorGUI.BeginDisabledGroup( IsReadOnly );

            GUI.Box( contentRect, "", backgroundStyle );

            var elementBackgroundRect = new Rect( contentRect.x, contentRect.y, contentRect.width, elementBackgroundHeight );
            var elementRect = new Rect( contentRect.x + 6, contentRect.y + 1, contentRect.width - 12, elementHeight );
            var tGotKeyboardIndex = false;

            if ( !fold ) {
                for ( int i = 0; i < list.Count; i++ ) {
                    var selected = i == selectedIndex;
                    var keyboard = i == keyboardIndex;

                    if ( Event.current.type == EventType.Repaint ) {
                        elementStyle.Draw( elementBackgroundRect, false, false, selected, keyboard );
                    }

                    if ( evt.isMouse ) {
                        if ( evt.type == EventType.MouseUp && evt.button == 0 ) {
                            if ( elementRect.Contains( evt.mousePosition ) ) {
                                selectedIndex = i;
                            }
                        }
                    }

                    var cId = GUIUtility.GetControlID( FocusType.Keyboard ) + 1;
                    EditorGUI.BeginChangeCheck();

                    var aValue = list[i];
                    try {
                        drawElement( ref aValue, elementRect );
                    } catch ( ExitGUIException ) { }
                    list[i] = aValue;

                    if ( EditorGUI.EndChangeCheck() ) {
                        updateValue = true;
                    }

                    var hId = GUIUtility.keyboardControl;

                    if ( cId == hId ) {
                        keyboardIndex = i;
                        tGotKeyboardIndex = true;
                    }

                    elementBackgroundRect.y += elementBackgroundHeight;
                    elementRect.y = elementBackgroundRect.y + 1;
                }
            }


            if ( updateValue ) {
                value = list;
                updateValue = false;
            }

            if ( !tGotKeyboardIndex ) {
                keyboardIndex = -1;
            }

            GUI.Box( footerRect, "", footerStyle );
            if ( GUI.Button( plusRect, plusButton, buttonStyle ) ) { AddElement(); }
            if ( GUI.Button( minusRect, minusButton, buttonStyle ) ) { RemoveElement(); }

            EditorGUI.EndDisabledGroup();
        }

        private void AddElement() {
            if ( elementType == typeof( string ) ) {
                list.Add( "" );
            } else if ( elementType.IsSubclassOf( typeof( Component ) ) || elementType == typeof( GameObject ) ) {
                list.Add( null );
            } else {
                list.Add( Activator.CreateInstance( elementType ) );
            }
            updateValue = true;
        }

        private void RemoveElement() {
            if ( selectedIndex < 0 || selectedIndex > list.Count - 1 ) return;
            list.RemoveAt( selectedIndex );
            updateValue = true;
        }
    }
}