using System.Collections;
using UnityEditor;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Lightmapping/Bake" )]
    class Bake : Automation {

        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = Lightmapping.Bake();
            yield break;
        }
    }

    [Automation( "Lightmapping/Bake Async" )]
    class BakeAsync : Automation {

        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = Lightmapping.BakeAsync();
            yield break;
        }
    }

    [Automation( "Lightmapping/Bake Light Probes Only" )]
    class BakeProbesOnly : Automation {

        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = Lightmapping.BakeLightProbesOnly();
            yield break;
        }
    }

    [Automation( "Lightmapping/Bake Light Probes Only Async" )]
    class BakeProbesOnlyAsync : Automation {

        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = Lightmapping.BakeLightProbesOnlyAsync();
            yield break;
        }
    }

    [Automation( "Lightmapping/Cancel" )]
    class BakeCancel : Automation {

        public override IEnumerator Execute() {
            Lightmapping.Cancel();
            yield break;
        }
    }

    [Automation( "Lightmapping/Clear" )]
    class BakeClear : Automation {

        public override IEnumerator Execute() {
            Lightmapping.Clear();
            yield break;
        }
    }

    [Automation( "Lightmapping/Clear Disk Cache" )]
    class BakeClearDiskCache : Automation {

        public override IEnumerator Execute() {
            Lightmapping.ClearDiskCache();
            yield break;
        }
    }

    [Automation( "Lightmapping/Clear Lighting Data Asset" )]
    class BakeClearLightingDataAsset : Automation {

        public override IEnumerator Execute() {
            Lightmapping.ClearLightingDataAsset();
            yield break;
        }
    }

#pragma warning restore 0649
}