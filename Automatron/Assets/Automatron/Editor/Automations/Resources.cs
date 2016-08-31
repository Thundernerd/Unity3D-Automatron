using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Resources/Find Objects Of Type All" )]
    class ResourcesFindObjectsOfTypeAll0 : Automation {
        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
        [ReadOnly]
        public UnityEngine.Object[] Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Resources.FindObjectsOfTypeAll( type );
            yield break;
        }

    }

    [Automation( "Resources/Load" )]
    class ResourcesLoad1 : Automation {

        public System.String path;
        [ReadOnly]
        public UnityEngine.Object Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Resources.Load( path );
            yield break;
        }

    }

    [Automation( "Resources/Load Typed" )]
    class ResourcesLoad2 : Automation {

        public System.String path;
        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type systemTypeInstance;
        [ReadOnly]
        public UnityEngine.Object Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Resources.Load( path, systemTypeInstance );
            yield break;
        }

    }

    [Automation( "Resources/Load All Typed" )]
    class ResourcesLoadAll5 : Automation {

        public System.String path;
        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type systemTypeInstance;
        [ReadOnly]
        public UnityEngine.Object[] Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Resources.LoadAll( path, systemTypeInstance );
            yield break;
        }

    }

    [Automation( "Resources/Load All" )]
    class ResourcesLoadAll6 : Automation {

        public System.String path;
        [ReadOnly]
        public UnityEngine.Object[] Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Resources.LoadAll( path );
            yield break;
        }

    }

    [Automation( "Resources/Get Builtin Resource" )]
    class ResourcesGetBuiltinResource7 : Automation {

        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
        public System.String path;
        [ReadOnly]
        public UnityEngine.Object Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Resources.GetBuiltinResource( type, path );
            yield break;
        }

    }

    [Automation( "Resources/Unload Asset" )]
    class ResourcesUnloadAsset8 : Automation {

        public UnityEngine.Object assetToUnload;

        public override IEnumerator Execute() {
            UnityEngine.Resources.UnloadAsset( assetToUnload );
            yield break;
        }

    }

#pragma warning restore 0649
}