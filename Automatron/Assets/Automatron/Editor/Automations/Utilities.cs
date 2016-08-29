using System.Collections;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Utilities/Delay" )]
    class Delay : Automation {

        public float Duration;

        public override IEnumerator Execute() {
            var end = EditorApplication.timeSinceStartup + Duration;
            while ( EditorApplication.timeSinceStartup < end ) {
                Progress = 1 - (float)( end - EditorApplication.timeSinceStartup ) / Duration;
                yield return null;
            }

            Debug.Log( "Delay done" );
            yield break;
        }
    }


    [Automation( "Utilities/Log" )]
    class DebugLog : Automation {

        public object Value;

        public override IEnumerator Execute() {
            Debug.Log( Value );
            yield break;
        }
    }


#pragma warning restore 0649
}