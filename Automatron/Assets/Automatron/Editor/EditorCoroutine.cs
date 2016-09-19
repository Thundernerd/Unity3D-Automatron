#if UNITY_EDITOR
﻿using System.Collections;
using UnityEditor;

namespace TNRD.Automatron {

    public class EditorCoroutine {

        public static EditorCoroutine Start( IEnumerator routine ) {
            var coroutine = new EditorCoroutine( routine );
            coroutine.Start();
            return coroutine;
        }

        public static EditorCoroutine StartMultiple( params IEnumerator[] routines ) {
            var coroutine = new EditorCoroutine( MultipleRoutines( routines ) );
            coroutine.Start();
            return coroutine;
        }

        private static IEnumerator MultipleRoutines( params IEnumerator[] routines ) {
            foreach ( var item in routines ) {
                while ( item.MoveNext() ) yield return item.Current;
            }
            yield break;
        }

        readonly IEnumerator routine;

        private EditorCoroutine( IEnumerator routine ) {
            this.routine = routine;
        }

        private void Start() {
            EditorApplication.update += Update;
        }

        public void Stop() {
            EditorApplication.update -= Update;
        }

        private void Update() {
            if ( !routine.MoveNext() ) {
                Stop();
            }
        }
    }
}
#endif