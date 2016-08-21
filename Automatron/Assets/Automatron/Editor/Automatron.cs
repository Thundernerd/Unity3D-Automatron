using UnityEngine;
using UnityEditor;

public class Automatron : EditorWindow {

    [MenuItem( "Window/Automatron" )]
    private static void Init() {
        var wnd = GetWindow<Automatron>( "Automatron" );
        wnd.minSize = new Vector2( 1280, 720 );
        wnd.Show( true );
    }
}
