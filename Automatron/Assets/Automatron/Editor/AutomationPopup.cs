using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using System.Reflection;
using System;

namespace TNRD.Automatron {

    public class AutomationPopup : EditorWindow {

        #region Custom Types
        private class Styles {
            public GUIStyle header = new GUIStyle( EditorGUIUtility.GetBuiltinSkin( EditorSkin.Scene ).FindStyle( "In BigTitle" ) );
            public GUIStyle componentButton = new GUIStyle( (GUIStyle)"PR Label" );
            public GUIStyle background = (GUIStyle)"grey_border";
            public GUIStyle previewBackground = (GUIStyle)"PopupCurveSwatchBackground";
            public GUIStyle previewHeader = new GUIStyle( EditorStyles.label );
            public GUIStyle previewText = new GUIStyle( EditorStyles.wordWrappedLabel );
            public GUIStyle rightArrow = (GUIStyle)"AC RightArrow";
            public GUIStyle leftArrow = (GUIStyle)"AC LeftArrow";
            public GUIStyle groupButton;

            public Styles() {
                this.header.font = EditorStyles.boldLabel.font;
                this.componentButton.alignment = TextAnchor.MiddleLeft;
                this.componentButton.padding.left -= 15;
                this.componentButton.fixedHeight = 20f;
                this.groupButton = new GUIStyle( this.componentButton );
                this.groupButton.padding.left += 17;
                this.previewText.padding.left += 3;
                this.previewText.padding.right += 3;
                ++this.previewHeader.padding.left;
                this.previewHeader.padding.right += 3;
                this.previewHeader.padding.top += 3;
                this.previewHeader.padding.bottom += 2;
            }
        }

        public class TreeItem {
            public string name;

            private object data;
            private Action callback;
            private Action<object> callback1;

            public TreeItem( string name ) {
                this.name = name;
            }

            public TreeItem( string name, Action callback ) {
                this.name = name;
                this.callback = callback;
            }

            public TreeItem( string name, object data, Action<object> callback ) {
                this.name = name;
                this.data = data;
                this.callback1 = callback;
            }

            public virtual void ExecuteCallback() {
                if ( callback == null ) {
                    callback1( data );
                } else {
                    callback();
                }
            }
        }
        public class TreeItem<T> : TreeItem {
            public T value;
            public Action<T> callback;

            public TreeItem( string name, T value, Action<T> callback ) : base( name ) {
                this.value = value;
                this.callback = callback;
            }

            public override void ExecuteCallback() {
                callback( value );
            }
        }
        public class TreeItem<T, T2> : TreeItem {
            public T value;
            public T2 value2;
            public Action<T, T2> callback;

            public TreeItem( string name, T value, T2 value2, Action<T, T2> callback ) : base( name ) {
                this.value = value;
                this.value2 = value2;
                this.callback = callback;
            }

            public override void ExecuteCallback() {
                callback( value, value2 );
            }
        }
        public class TreeItem<T, T2, T3> : TreeItem {
            public T value;
            public T2 value2;
            public T3 value3;
            public Action<T, T2, T3> callback;

            public TreeItem( string name, T value, T2 value2, T3 value3, Action<T, T2, T3> callback ) : base( name ) {
                this.value = value;
                this.value2 = value2;
                this.value3 = value3;
                this.callback = callback;
            }

            public override void ExecuteCallback() {
                callback( value, value2, value3 );
            }
        }
        public class TreeItem<T, T2, T3, T4> : TreeItem {
            public T value;
            public T2 value2;
            public T3 value3;
            public T4 value4;
            public Action<T, T2, T3, T4> callback;

            public TreeItem( string name, T value, T2 value2, T3 value3, T4 value4, Action<T, T2, T3, T4> callback ) : base( name ) {
                this.value = value;
                this.value2 = value2;
                this.value3 = value3;
                this.value4 = value4;
                this.callback = callback;
            }

            public override void ExecuteCallback() {
                callback( value, value2, value3, value4 );
            }
        }

        public class Element : IComparable {
            public string Name;
            public Element Parent;

            public int CompareTo( object obj ) {
                return Name.CompareTo( ( obj as Element ).Name );
            }

            public override string ToString() {
                return Name;
            }
        }

        private class GroupElement : Element {
            public List<Element> Children = new List<Element>();
            private Dictionary<string, Element> keyedChildren = new Dictionary<string, Element>();
            public int SelectedIndex;

            public GroupElement( string name ) {
                Name = name;
            }

            public GroupElement( string name, List<Element> children ) {
                Name = name;
                Children = children;
            }

            public ExecuteElement AddChild( string name, TreeItem item ) {
                var splits = name.Split( '/' );
                var key = splits[0];
                ExecuteElement r;

                if ( splits.Length == 1 ) {
                    if ( !keyedChildren.ContainsKey( key ) ) {
                        var e = new ExecuteElement( key, item );
                        Children.Add( e );
                        keyedChildren.Add( key, e );
                        r = e;
                    } else {
                        var e = keyedChildren[key];
                        if ( e is ExecuteElement )
                            r = (ExecuteElement)e;
                        else
                            r = null;
                    }
                } else {
                    GroupElement gElement;

                    if ( keyedChildren.ContainsKey( key ) ) {
                        gElement = (GroupElement)keyedChildren[key];
                    } else {
                        gElement = new GroupElement( key );
                        Children.Add( gElement );
                        keyedChildren.Add( key, gElement );
                    }

                    var index = item.name.IndexOf( '/' );
                    var n = item.name.Substring( index + 1 );

                    r = gElement.AddChild( n, item );
                }

                Children.Sort();

                r.Parent = this;
                return r;
            }
        }

        private class ExecuteElement : Element {
            public TreeItem Item;

            public ExecuteElement( string name, TreeItem item ) {
                Name = name;
                Item = item;
            }
        }

        public struct TreeGenerationData {
            public Dictionary<string, List<Element>> SearchTree;
            public List<Element> MainTree;
            public Element MainElement;
        }
        #endregion

        public static TreeGenerationData GenerateTreeData( List<TreeItem> items ) {
            var keyedTree = new SortedDictionary<string, Element>();
            var searchTree = new Dictionary<string, List<Element>>();
            foreach ( var item in items ) {
                var splits = item.name.Split( '/' );
                var key = splits[0];
                ExecuteElement e = null;

                if ( splits.Length == 1 ) { // Top level
                    if ( !keyedTree.ContainsKey( key ) ) {
                        e = new ExecuteElement( item.name, item );
                        keyedTree.Add( key, e );
                    }
                } else {
                    GroupElement gElement;

                    if ( keyedTree.ContainsKey( key ) ) {
                        gElement = (GroupElement)keyedTree[key];
                    } else {
                        gElement = new GroupElement( key );
                        keyedTree.Add( key, gElement );
                    }

                    var index = item.name.IndexOf( '/' );
                    var name = item.name.Substring( index + 1 );

                    e = gElement.AddChild( name, item );
                }

                if ( e != null ) {
                    key = splits[splits.Length - 1].Replace( " ", "" ).ToLower();
                    var s = "";
                    var length = key.Length;

                    for ( int i = 0; i < length; i++ ) {
                        s += key[i].ToString();
                        if ( !searchTree.ContainsKey( s ) ) {
                            searchTree.Add( s, new List<Element>() );
                        }
                        searchTree[s].Add( e );
                    }
                }
            }

            return new TreeGenerationData() {
                MainTree = keyedTree.Select( kv => kv.Value ).ToList(),
                SearchTree = searchTree,
                MainElement = new GroupElement( "Automations", keyedTree.Select( kv => kv.Value ).ToList() )
            };
        }

        #region Creation
        public static void ShowAsContext( List<TreeItem> items ) {
            var rect = new Rect( Event.current.mousePosition, Vector2.zero );
            ShowAsContext( rect, items );
        }
        public static void ShowAsContext( Rect rect, List<TreeItem> items ) {
            rect = new Rect( GUIUtility.GUIToScreenPoint( rect.position ), rect.size );
            Event.current.Use();
            var popup = CreateInstance<AutomationPopup>();
            popup.CreateTree( items );
            popup.Initialize( rect );
        }
        public static void ShowAsContext( TreeGenerationData data ) {
            var rect = new Rect( Event.current.mousePosition, Vector2.zero );
            ShowAsContext( rect, data );
        }
        public static void ShowAsContext( Rect rect, TreeGenerationData data ) {
            rect = new Rect( GUIUtility.GUIToScreenPoint( rect.position ), rect.size );
            Event.current.Use();
            var popup = CreateInstance<AutomationPopup>();
            popup.mainTree = data.MainTree;
            popup.searchTree = data.SearchTree;
            popup.Initialize( rect );
        }
        #endregion

        private MethodInfo searchField = null;
        private Styles styles = new Styles();

        private Dictionary<string, List<Element>> searchTree = new Dictionary<string, List<Element>>();
        private List<Element> mainTree = new List<Element>();
        private GroupElement mainElement;

        private string search = "";
        private float anim;

        GroupElement currentElement = null;

        private void Initialize( Rect rect ) {
            position = rect;
            wantsMouseMove = true;
            searchField = typeof( EditorGUI ).GetMethod( "SearchField", BindingFlags.Static | BindingFlags.NonPublic );
            currentElement = mainElement;
            ShowAsDropDown( rect, new Vector2( 230, 320 ) );
            Focus();
        }

        private void CreateTree( List<TreeItem> items ) {
            var keyedTree = new SortedDictionary<string, Element>();
            foreach ( var item in items ) {
                var splits = item.name.Split( '/' );
                var key = splits[0];
                ExecuteElement e = null;

                if ( splits.Length == 1 ) { // Top level
                    if ( !keyedTree.ContainsKey( key ) ) {
                        e = new ExecuteElement( item.name, item );
                        keyedTree.Add( key, e );
                    }
                } else {
                    GroupElement gElement;

                    if ( keyedTree.ContainsKey( key ) ) {
                        gElement = (GroupElement)keyedTree[key];
                    } else {
                        gElement = new GroupElement( key );
                        keyedTree.Add( key, gElement );
                    }

                    var index = item.name.IndexOf( '/' );
                    var name = item.name.Substring( index + 1 );

                    e = gElement.AddChild( name, item );
                }

                if ( e != null ) {
                    key = splits[splits.Length - 1].Replace( " ", "" ).ToLower();
                    var s = "";
                    var length = key.Length;

                    for ( int i = 0; i < length; i++ ) {
                        s += key[i].ToString();
                        if ( !searchTree.ContainsKey( s ) ) {
                            searchTree.Add( s, new List<Element>() );
                        }
                        searchTree[s].Add( e );
                    }
                }
            }

            mainTree = keyedTree.Select( kv => kv.Value ).ToList();
            mainElement = new GroupElement( "Automations", mainTree );
        }

        private void OnGUI() {
            GUI.Label( new Rect( 0, 0, position.width, position.height ), GUIContent.none, styles.background );
            GUILayout.Space( 7 );
            var rect = GUILayoutUtility.GetRect( 10, 20 );
            rect.x += 8;
            rect.width -= 16;
            var str = SearchField( rect, search );

            ListGUI( 1, currentElement );
        }

        private void ListGUI( float anim, GroupElement element ) {
            var pos1 = position;
            pos1.x = 0;// position.width * ( 1 - anim ) + 1f;
            pos1.y = 30;
            pos1.height -= 30;
            pos1.width -= 2;
            GUILayout.BeginArea( pos1 );
            var rect = GUILayoutUtility.GetRect( 10, 25 );
            GUI.Label( rect, name, styles.header );
            if ( currentElement != null ) {
                var pos2 = new Rect( rect.x + 4, rect.y + 7, 13, 13 );
                if ( Event.current.type == EventType.Repaint )
                    styles.leftArrow.Draw( pos2, false, false, false, false );
                if ( Event.current.type == EventType.MouseDown && rect.Contains( Event.current.mousePosition ) ) {
                    //GoToParent();
                    Event.current.Use();
                }
            }

            //if ( grandParent != null ) {
            //    var pos2 = new Rect( rect.x + 4, rect.y + 7, 13, 13 );
            //    if ( Event.current.type == EventType.Repaint )
            //        styles.leftArrow.Draw( pos2, false, false, false, false );
            //    if ( Event.current.type == EventType.MouseDown && rect.Contains( Event.current.mousePosition ) ) {
            //        GoToParent();
            //        Event.current.Use();
            //    }
            //}
            //ListGUI( tree, parent );
            GUILayout.EndArea();
        }

        private string SearchField( Rect rect, string value ) {
            return (string)searchField.Invoke( null, new object[] { rect, value } );
        }
    }
}