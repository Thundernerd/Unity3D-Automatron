using System.Collections;
using TNRD.Editor.Serialization;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Prefab/Create Empty" )]
    class CreateEmptyPrefab : Automation {

        public string Path;
        [ReadOnly]
        [IgnoreSerialization]
        public Object Prefab;

        public override void Reset() {
            Prefab = null;
        }

        public override IEnumerator Execute() {
            Prefab = PrefabUtility.CreateEmptyPrefab( Path );
            yield break;
        }
    }

    [Automation( "Prefab/Create" )]
    class CreatePrefab : Automation {

        public string Path;
        [IgnoreSerialization]
        public GameObject GameObject;
        public ReplacePrefabOptions Options;
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject Prefab;

        public override void Reset() {
            Prefab = null;
        }

        public override IEnumerator Execute() {
            Prefab = PrefabUtility.CreatePrefab( Path, GameObject, Options );
            yield break;
        }
    }

    [Automation( "Prefab/Disconnect Instance" )]
    class DisconnectPrefabInstance : Automation {

        [IgnoreSerialization]
        public Object Target;

        public override IEnumerator Execute() {
            PrefabUtility.DisconnectPrefabInstance( Target );
            yield break;
        }
    }

    [Automation( "Prefab/Find Root" )]
    class FindPrefabRoot : Automation {

        [IgnoreSerialization]
        public GameObject Source;
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject Root;

        public override void Reset() {
            Root = null;
        }

        public override IEnumerator Execute() {
            Root = PrefabUtility.FindPrefabRoot( Source );
            yield break;
        }
    }

    [Automation( "Prefab/Get Object" )]
    class GetPrefabObject : Automation {

        [IgnoreSerialization]
        public Object Target;
        [ReadOnly]
        [IgnoreSerialization]
        public Object Object;

        public override void Reset() {
            Object = null;
        }

        public override IEnumerator Execute() {
            Object = PrefabUtility.GetPrefabObject( Target );
            yield break;
        }
    }

    [Automation( "Prefab/Get Parent" )]
    class GetPrefabParent : Automation {

        [IgnoreSerialization]
        public Object Source;
        [ReadOnly]
        [IgnoreSerialization]
        public Object Parent;

        public override void Reset() {
            Parent = null;
        }

        public override IEnumerator Execute() {
            Parent = PrefabUtility.GetPrefabParent( Source );
            yield break;
        }
    }

    [Automation( "Prefab/Get Type" )]
    class GetPrefabType : Automation {

        [IgnoreSerialization]
        public Object Target;
        [ReadOnly]
        public PrefabType Type;

        public override void Reset() {
            Type = PrefabType.None;
        }

        public override IEnumerator Execute() {
            Type = PrefabUtility.GetPrefabType( Target );
            yield break;
        }
    }

    [Automation( "Prefab/Instantiate" )]
    class Instantiate : Automation {

        [IgnoreSerialization]
        public GameObject Original;
        public string Name = "";
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject gameObject;

        public override void Reset() {
            gameObject = null;
        }

        public override IEnumerator Execute() {
            gameObject = Object.Instantiate( Original );

            if ( !string.IsNullOrEmpty( Name ) ) {
                gameObject.name = Name;
            }

            yield break;
        }
    }

    [Automation( "Prefab/Instantiate Detailed" )]
    class InstantiateDetailed : Automation {

        [IgnoreSerialization]
        public GameObject Original;
        public string Name = "";
        public Vector3 position = Vector3.zero;
        public Vector3 Rotation = Vector3.zero;
        public Vector3 Scale = Vector3.one;
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject gameObject;

        public override void Reset() {
            gameObject = null;
        }

        public override IEnumerator Execute() {
            gameObject = (GameObject)Object.Instantiate( Original, position, Quaternion.Euler( Rotation ) );
            gameObject.transform.localScale = Scale;

            if ( !string.IsNullOrEmpty( Name ) ) {
                gameObject.name = Name;
            }

            yield break;
        }
    }

    [Automation( "Prefab/Reset to Prefab State" )]
    class ResetToPrefabState : Automation {

        [IgnoreSerialization]
        public Object Obj;

        public override IEnumerator Execute() {
            PrefabUtility.ResetToPrefabState( Obj );
            yield break;
        }
    }

    [Automation( "Prefab/Revert instance" )]
    class RevertPrevabInstance : Automation {

        [IgnoreSerialization]
        public GameObject Go;

        public override IEnumerator Execute() {
            PrefabUtility.RevertPrefabInstance( Go );
            yield break;
        }
    }

#pragma warning restore 0649
}