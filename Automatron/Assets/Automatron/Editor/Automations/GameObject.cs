using System.Collections;
using System.Collections.Generic;
using TNRD.Editor.Serialization;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Game Object/Create" )]
    class CreateGameObject : Automation {

        public string Name = "GameObject";
        public Vector3 position = Vector3.zero;
        public Vector3 Rotation = Vector3.zero;
        public Vector3 Scale = Vector3.one;
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject GameObject;

        public override IEnumerator Execute() {
            GameObject = new GameObject( Name );
            GameObject.transform.position = position;
            GameObject.transform.rotation = Quaternion.Euler( Rotation );
            GameObject.transform.localScale = Scale;
            yield break;
        }
    }

    [Automation( "Game Object/Create Child" )]
    class CreateChildGameObject : Automation {

        public GameObject Parent;
        public string Name = "GameObject";
        public Vector3 position = Vector3.zero;
        public Vector3 Rotation = Vector3.zero;
        public Vector3 Scale = Vector3.one;
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject GameObject;

        public override IEnumerator Execute() {
            GameObject = new GameObject( Name );
            if ( Parent != null ) {
                GameObject.transform.SetParent( Parent.transform );
            }

            GameObject.transform.position = position;
            GameObject.transform.rotation = Quaternion.Euler( Rotation );
            GameObject.transform.localScale = Scale;
            yield break;
        }
    }

    [Automation( "Game Object/Destroy" )]
    class DestroyGameObject : Automation {

        [IgnoreSerialization]
        public GameObject GameObject;

        public override IEnumerator Execute() {
            Object.DestroyImmediate( GameObject );
            yield break;
        }
    }

    [Automation( "Game Object/Destroy Multiple" )]
    class DestroyGameObjects : Automation {

        [IgnoreSerialization]
        public GameObject[] GameObjects;

        public override IEnumerator Execute() {
            for ( int i = 0; i < GameObjects.Length; i++ ) {
                Object.DestroyImmediate( GameObjects[i] );
                Progress = i / (float)GameObjects.Length;
                yield return null;
            }
            yield break;
        }
    }

    [Automation( "Game Object/Create Primitive" )]
    class CreatePrimitive : Automation {

        public PrimitiveType Type = PrimitiveType.Cube;
        public string Name = "Primitive GameObject";
        public Vector3 position = Vector3.zero;
        public Vector3 Rotation = Vector3.zero;
        public Vector3 Scale = Vector3.one;
        [ReadOnly]
        [IgnoreSerialization]
        public GameObject Primitive;

        public override IEnumerator Execute() {
            Primitive = GameObject.CreatePrimitive( Type );
            Primitive.name = Name;
            Primitive.transform.position = position;
            Primitive.transform.rotation = Quaternion.Euler( Rotation );
            Primitive.transform.localScale = Scale;
            yield break;
        }
    }

	[Automation( "Game Object/Find Game Object With Tag" )]
	class GameObjectFindGameObjectWithTag1 : Automation {

		public System.String tag;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.FindGameObjectWithTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Find With Tag" )]
	class GameObjectFindWithTag2 : Automation {

		public System.String tag;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.FindWithTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Find Game Objects With Tag" )]
	class GameObjectFindGameObjectsWithTag3 : Automation {

		public System.String tag;
		[ReadOnly]
		public UnityEngine.GameObject[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.FindGameObjectsWithTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Find" )]
	class GameObjectFind4 : Automation {

		public System.String name;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.Find(name);
			yield break;
		}

	}

#pragma warning restore 0649
}