using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Resources/Load" )]
    class LoadResource : Automation {

        public string Path;
        [ReadOnly]
        public Object Resource;

        public override void Reset() {
            base.Reset();
            Resource = null;
        }

        public override IEnumerator Execute() {
            Resource = Resources.Load( Path );
            yield break;
        }
    }

    [Automation( "Resources/Load Multiple" )]
    class LoadResourceM : Automation {

        public string[] Paths;
        [ReadOnly]
        public Object[] Resources;

        public override void Reset() {
            base.Reset();
            Resources = new Object[0];
        }

        public override IEnumerator Execute() {
            var t = new List<Object>();
            for ( int i = 0; i < Paths.Length; i++ ) {
                t.Add( UnityEngine.Resources.Load( Paths[i] ) );
                Progress = i / (float)Paths.Length;
                yield return null;
            }
            Resources = t.ToArray();
            yield break;
        }
    }

    [Automation( "Resources/Load All Multiple" )]
    class LoadAllResourcesM : Automation {

        public string[] Paths;
        [ReadOnly]
        public Object[] Resources;

        public override void Reset() {
            base.Reset();
            Resources = new Object[0];
        }

        public override IEnumerator Execute() {
            var t = new List<Object>();
            for ( int i = 0; i < Paths.Length; i++ ) {
                t.AddRange( UnityEngine.Resources.LoadAll( Paths[i] ) );
                Progress = i / (float)Paths.Length;
                yield return null;
            }
            Resources = t.ToArray();
            yield break;
        }
    }

    [Automation( "Resources/Load All" )]
    class LoadAllResources : Automation {

        public string Path;
        [ReadOnly]
        public Object[] Resources;

        public override void Reset() {
            base.Reset();
            Resources = new Object[0];
        }

        public override IEnumerator Execute() {
            Resources = UnityEngine.Resources.LoadAll( Path );
            yield break;
        }
    }

    [Automation( "Resources/Unload Asset" )]
    class UnloadAsset : Automation {

        public Object Asset;

        public override IEnumerator Execute() {
            Resources.UnloadAsset( Asset );
            yield break;
        }
    }

    [Automation( "Resources/Unload Unused Assets" )]
    class UnloadUnusedAssets : Automation {

        public override IEnumerator Execute() {
            Resources.UnloadUnusedAssets();
            yield break;
        }
    }

#pragma warning restore 0649
}