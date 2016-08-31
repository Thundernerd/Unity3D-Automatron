using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using System.Reflection;
using System;

public class FancyPopup : EditorWindow {

    #region Custom types
    private class Element : IComparable {
        public int level;
        public GUIContent content;

        public string name {
            get { return content.text; }
        }

        public int CompareTo( object obj ) {
            return name.CompareTo( ( obj as Element ).name );
        }
    }

    private class GroupElement : Element {
        public Vector2 scroll;
        public int selectedIndex;

        public GroupElement( int level, string name ) {
            this.level = level;
            content = new GUIContent( name );
        }
    }

    private class ExecuteElement : Element {

        public TreeItem item;
        public GUIContent content2;

        public ExecuteElement( int level, string name, TreeItem item ) {
            this.level = level;
            this.content = new GUIContent( "    " + name );
            this.content2 = new GUIContent( "    " + GetClearName( item.name ) );
            this.item = item;
        }

        private string GetClearName( string name ) {
            var count = 0;
            foreach ( var item in name ) {
                if ( item == '/' )
                    count++;
            }
            if ( count <= 1 ) {
                return name;
            }
            var foundFirst = false;
            var n = "";
            for ( int i = name.Length - 1; i >= 0; i-- ) {
                if ( name[i] == '/' ) {
                    if ( foundFirst ) break;
                    else foundFirst = true;
                }
                n = n.Insert( 0, name[i].ToString() );
            }
            return n;
        }
    }

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
    #endregion

    #region Creation
    public static void ShowAsContext( TreeItem[] items ) {
        var rect = new Rect( GUIUtility.GUIToScreenPoint( Event.current.mousePosition ), Vector2.zero );
        Event.current.Use();
        var popup = CreateInstance<FancyPopup>();
        popup.Init( rect, items );
    }
    public static void ShowAsContext( Rect rect, TreeItem[] items ) {
        rect = new Rect( GUIUtility.GUIToScreenPoint( rect.position ), rect.size );
        Event.current.Use();
        var popup = CreateInstance<FancyPopup>();
        popup.Init( rect, items );
    }
    #endregion

    private MethodInfo searchField;
    private string[] treePaths;
    private TreeItem[] treeItems;

    private bool dirtyList = true;
    private List<GroupElement> stack = new List<GroupElement>();
    private float anim = 1f;
    private int animTarget = 1;
    private string search = "";

    private Element[] tree;
    private Element[] searchResultTree;

    private long lastTime;
    private bool scrollToSelected;
    private string delayedSearch;

    private Styles styles;

    private bool hasSearch {
        get {
            return !string.IsNullOrEmpty( search );
        }
    }

    private GroupElement activeParent {
        get { return stack[stack.Count - 2 + animTarget]; }
    }

    private Element[] activeTree {
        get {
            if ( hasSearch ) return searchResultTree;
            return tree;
        }
    }

    private Element activeElement {
        get {
            if ( activeTree == null )
                return null;
            var children = GetChildren( activeTree, activeParent );
            if ( children.Count == 0 )
                return null;
            return children[activeParent.selectedIndex];
        }
    }

    private bool isAnimating {
        get { return anim != animTarget; }
    }

    private bool initializedGUI = false;

    private void Init( Rect rect, TreeItem[] items ) {
        position = rect;
        treeItems = items;
        treePaths = items.Select( t => "Automations/" + t.name ).ToArray();
        wantsMouseMove = true;
        CreateTree();
        ShowAsDropDown( rect, new Vector2( 230, 320 ) );
        Focus();

        searchField = typeof( EditorGUI ).GetMethod( "SearchField", BindingFlags.Static | BindingFlags.NonPublic );
    }

    private void InitializeGUI() {
        styles = new Styles();
    }

    private void CreateTree() {
        var list1 = new List<string>();
        var list2 = new List<Element>();
        for ( int index = 0; index < treePaths.Length; index++ ) {
            var menuPath = treePaths[index];
            var strArray = menuPath.Split( '/' );
            while ( strArray.Length - 1 < list1.Count )
                list1.RemoveAt( list1.Count - 1 );
            while ( list1.Count > 0 && strArray[list1.Count - 1] != list1[list1.Count - 1] )
                list1.RemoveAt( list1.Count - 1 );
            while ( strArray.Length - 1 > list1.Count ) {
                list2.Add( new GroupElement( list1.Count, strArray[list1.Count] ) );
                list1.Add( strArray[list1.Count] );
            }
            list2.Add( new ExecuteElement( list1.Count, strArray[strArray.Length - 1], treeItems[index] ) );
        }
        tree = list2.ToArray();
        if ( stack.Count == 0 ) {
            stack.Add( (GroupElement)tree[0] );
        } else {
            var mTree = tree[0] as GroupElement;
            var num = 0;
            while ( true ) {
                var item = stack[num];
                stack[num] = mTree;
                stack[num].selectedIndex = item.selectedIndex;
                stack[num].scroll = item.scroll;
                num++;
                if ( num == stack.Count )
                    break;
                var children = GetChildren( activeTree, mTree );
                var element = children.FirstOrDefault( c => c.name == stack[num].name );
                if ( element == null || !( element is GroupElement ) ) {
                    while ( stack.Count > num ) {
                        stack.RemoveAt( num );
                    }
                } else {
                    mTree = element as GroupElement;
                }
            }
        }
        dirtyList = false;
        RebuildSearch();
    }

    private List<Element> GetChildren( Element[] tree, Element parent ) {
        var list = new List<Element>();
        int num = -1;
        int index;
        for ( index = 0; index < tree.Length; ++index ) {
            if ( tree[index] == parent ) {
                num = parent.level + 1;
                ++index;
                break;
            }

        }
        if ( num == -1 )
            return list;
        for ( ; index < tree.Length; ++index ) {
            var element = tree[index];
            if ( element.level >= num ) {
                if ( element.level <= num || hasSearch ) {
                    list.Add( element );
                }
            } else
                break;
        }
        return list;
    }

    private GroupElement GetElementRelative( int rel ) {
        var index = stack.Count + rel - 1;
        if ( index < 0 )
            return null;
        return stack[index];
    }

    private bool hasPreviousSearch = false;

    private void GoToChild( Element e, bool addIfComponent ) {
        if ( e is ExecuteElement ) {
            if ( addIfComponent ) {
                var element = e as ExecuteElement;
                element.item.ExecuteCallback();
                Close();
            }
            return;
        }

        hasPreviousSearch = hasSearch;

        lastTime = DateTime.Now.Ticks;
        if ( animTarget == 0 ) {
            animTarget = 1;
        } else if ( anim == 1f ) {
            anim = 0;
            stack.Add( (GroupElement)e );
        }
    }

    private void GoToParent() {
        if ( stack.Count <= 1 )
            return;
        if ( hasPreviousSearch ) {
            hasPreviousSearch = false;
        }
        animTarget = 0;
        lastTime = DateTime.Now.Ticks;
    }

    private void HandleKeyboard() {
        var evt = Event.current;
        if ( evt.type == EventType.KeyDown ) {
            if ( evt.keyCode == KeyCode.DownArrow ) {
                var el = activeParent;
                el.selectedIndex = el.selectedIndex + 1;
                activeParent.selectedIndex = Mathf.Min( activeParent.selectedIndex, GetChildren( activeTree, activeParent ).Count - 1 );
                scrollToSelected = true;
                evt.Use();
            }
            if ( evt.keyCode == KeyCode.UpArrow ) {
                var el = activeParent;
                el.selectedIndex = el.selectedIndex - 1;
                activeParent.selectedIndex = Mathf.Max( activeParent.selectedIndex, 0 );
                scrollToSelected = true;
                evt.Use();
            }
            if ( evt.keyCode == KeyCode.Return || evt.keyCode == KeyCode.KeypadEnter ) {
                GoToChild( activeElement, true );
                evt.Use();
            }

            if ( evt.keyCode == KeyCode.LeftArrow || evt.keyCode == KeyCode.Backspace ) {
                GoToParent();
                evt.Use();
            }
            if ( evt.keyCode == KeyCode.RightArrow ) {
                GoToChild( activeElement, false );
                evt.Use();
            }
            if ( evt.keyCode == KeyCode.Escape ) {
                Close();
                evt.Use();
            }
        }
    }

    private void ListGUI( Element[] tree, float anim, GroupElement parent, GroupElement grandParent ) {
        var pos1 = position;
        pos1.x = position.width * ( 1 - anim ) + 1f;
        pos1.y = 30;
        pos1.height -= 30;
        pos1.width -= 2;
        GUILayout.BeginArea( pos1 );
        var rect = GUILayoutUtility.GetRect( 10, 25 );
        var name = parent.name;
        GUI.Label( rect, name, styles.header );
        if ( grandParent != null ) {
            var pos2 = new Rect( rect.x + 4, rect.y + 7, 13, 13 );
            if ( Event.current.type == EventType.Repaint )
                styles.leftArrow.Draw( pos2, false, false, false, false );
            if ( Event.current.type == EventType.MouseDown && rect.Contains( Event.current.mousePosition ) ) {
                GoToParent();
                Event.current.Use();
            }
        }
        ListGUI( tree, parent );
        GUILayout.EndArea();
    }

    private void ListGUI( Element[] tree, GroupElement parent ) {
        parent.scroll = GUILayout.BeginScrollView( parent.scroll );
        EditorGUIUtility.SetIconSize( new Vector2( 16, 16 ) );
        List<Element> children;
        var hasDouble = false;
        if ( hasPreviousSearch ) {
            children = GetChildren( this.tree, parent );
        } else {
            children = GetChildren( tree, parent );
            if ( hasSearch ) {
                hasDouble = false;
                for ( int i = 0; i < children.Count; i++ ) {
                    var name = children[i].content.text;
                    for ( int j = i + 1; j < children.Count; j++ ) {
                        var name2 = children[j].content.text;
                        if ( name == name2 ) {
                            hasDouble = true;
                            break;
                        }
                    }
                }
            }
        }
        var rect1 = new Rect();
        for ( int index = 0; index < children.Count; index++ ) {
            var e = children[index];
            var rect2 = GUILayoutUtility.GetRect( 16, 20, GUILayout.ExpandWidth( true ) );
            if ( ( Event.current.type == EventType.MouseMove || Event.current.type == EventType.MouseDown ) && ( parent.selectedIndex != index && rect2.Contains( Event.current.mousePosition ) ) ) {
                parent.selectedIndex = index;
                Repaint();
            }
            var flag = false;
            if ( index == parent.selectedIndex ) {
                flag = true;
                rect1 = rect2;
            }
            if ( Event.current.type == EventType.Repaint ) {
                var isExecuteElement = e is ExecuteElement;
                if ( isExecuteElement ) {
                    styles.componentButton.Draw( rect2, hasDouble ? ( e as ExecuteElement ).content2 : e.content, false, false, flag, flag );
                } else {
                    styles.groupButton.Draw( rect2, e.content, false, false, flag, flag );
                    var position = new Rect( rect2.x + rect2.width - 13, rect2.y + 4, 13, 13 );
                    styles.rightArrow.Draw( position, false, false, false, false );
                }
            }
            if ( Event.current.type == EventType.MouseDown && rect2.Contains( Event.current.mousePosition ) ) {
                Event.current.Use();
                parent.selectedIndex = index;
                GoToChild( e, true );
            }
        }
        EditorGUIUtility.SetIconSize( Vector2.zero );
        GUILayout.EndScrollView();
        if ( !scrollToSelected || Event.current.type != EventType.Repaint )
            return;
        scrollToSelected = false;
        var lastRect = GUILayoutUtility.GetLastRect();
        if ( rect1.yMax - lastRect.height > parent.scroll.y ) {
            parent.scroll.y = rect1.yMax - lastRect.height;
            Repaint();
        }
        if ( rect1.y >= parent.scroll.y )
            return;
        parent.scroll.y = rect1.y;
        Repaint();
    }

    private void OnGUI() {
        if ( !initializedGUI ) {
            InitializeGUI();
            initializedGUI = true;
        }

        GUI.Label( new Rect( 0, 0, position.width, position.height ), GUIContent.none, styles.background );
        if ( dirtyList )
            CreateTree();
        HandleKeyboard();
        GUILayout.Space( 7 );
        var rect = GUILayoutUtility.GetRect( 10, 20 );
        rect.x += 8;
        rect.width -= 16;
        var str = SearchField( rect, search );
        if ( str != search || delayedSearch != null ) {
            if ( !isAnimating ) {
                search = delayedSearch ?? str;
                RebuildSearch();
                delayedSearch = null;
            } else {
                delayedSearch = str;
            }
        }

        ListGUI( activeTree, anim, GetElementRelative( 0 ), GetElementRelative( -1 ) );
        if ( anim < 1 )
            ListGUI( activeTree, anim + 1, GetElementRelative( -1 ), GetElementRelative( -2 ) );
        if ( !isAnimating || Event.current.type != EventType.Repaint )
            return;
        var ticks = DateTime.Now.Ticks;
        var num = ( ticks - lastTime ) / 1E+07f;
        lastTime = ticks;
        anim = Mathf.MoveTowards( anim, animTarget, num * 4 );
        if ( animTarget == 0 && anim == 0 ) {
            anim = 1;
            animTarget = 1;
            stack.RemoveAt( stack.Count - 1 );
        }
        Repaint();
    }

    private void RebuildSearch() {
        if ( !hasSearch ) {
            searchResultTree = null;
            if ( stack[stack.Count - 1].name == "Search" ) {
                stack.Clear();
                stack.Add( tree[0] as GroupElement );
            }
            animTarget = 1;
            lastTime = DateTime.Now.Ticks;
            return;
        }
        var strArrays = search.ToLower().Split( new char[] { ' ' } );
        var elements = new List<Element>();
        var elements1 = new List<Element>();
        var gElements = new List<Element>();
        var gElements2 = new List<Element>();
        var mTree = tree;
        for ( int i = 0; i < mTree.Length; i++ ) {
            var element = mTree[i];
            var isExecute = element is ExecuteElement;

            var str = element.name.ToLower().Replace( " ", string.Empty );
            var flag = true;
            var flag1 = false;
            var num = 0;
            while ( num < strArrays.Length ) {
                var str1 = strArrays[num];
                if ( !str.Contains( str1 ) ) {
                    flag = false;
                    break;
                } else {
                    if ( num == 0 && str.StartsWith( str1 ) ) {
                        flag1 = true;
                    }
                    num++;
                }
            }
            if ( flag ) {
                if ( !flag1 ) {
                    if ( isExecute )
                        elements1.Add( element );
                    else
                        gElements2.Add( element );
                } else {
                    if ( isExecute )
                        elements.Add( element );
                    else
                        gElements.Add( element );
                }
            }
        }
        elements.Sort();
        elements1.Sort();
        gElements.Sort();
        gElements2.Sort();
        var elements2 = new List<Element>() {
            new GroupElement(0,"Search")
        };
        elements2.AddRange( gElements );
        elements2.AddRange( gElements2 );
        elements2.AddRange( elements );
        elements2.AddRange( elements1 );
        elements2.Add( tree[mTree.Length - 1] );
        searchResultTree = elements2.ToArray();
        stack.Clear();
        stack.Add( searchResultTree[0] as GroupElement );
        if ( this.GetChildren( activeTree, activeParent ).Count < 1 ) {
            activeParent.selectedIndex = -1;
        } else {
            activeParent.selectedIndex = 0;
        }
    }

    private string SearchField( Rect rect, string value ) {
        return (string)searchField.Invoke( null, new object[] { rect, value } );
    }
}