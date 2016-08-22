using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

namespace Automatron {

    public class AutomatronEditor : EditorWindow {

        [MenuItem( "Window/Automatron" )]
        private static void Init() {
            var wnd = GetWindow<AutomatronEditor>( "Automatron" );
            wnd.minSize = new Vector2( 1280, 720 );
            wnd.Show( true );
        }

        void OnGUI() {
            if ( GUILayout.Button( "Execute!" ) ) {
                ExecutActions();
            }
        }

        private void ExecutActions() {
            var list = new List<Automation>();
            EditorCoroutine.Start( ExecuteActionsAsync( list ) );
        }

        private IEnumerator ExecuteActionsAsync( List<Automation> automations ) {
            foreach ( var item in automations ) {
                var routine = item.Execute();
                while ( routine.MoveNext() ) {
                    yield return routine.Current;
                }
                yield return null;
            }
            yield break;
        }
    }
}