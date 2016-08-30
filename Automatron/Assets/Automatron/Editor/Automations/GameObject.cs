using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Game Object/Transform/Get" )]
	class GameObjecttransformGet0 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.transform;
			yield break;
		}

	}

	[Automation( "Game Object/Layer/Get" )]
	class GameObjectlayerGet1 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.layer;
			yield break;
		}

	}

	[Automation( "Game Object/Layer/Set" )]
	class GameObjectlayerSet1 : Automation {

		public UnityEngine.GameObject Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.layer = Value;
			yield break;
		}

	}

	[Automation( "Game Object/Active Self/Get" )]
	class GameObjectactiveSelfGet2 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.activeSelf;
			yield break;
		}

	}

	[Automation( "Game Object/Active In Hierarchy/Get" )]
	class GameObjectactiveInHierarchyGet3 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.activeInHierarchy;
			yield break;
		}

	}

	[Automation( "Game Object/Is Static/Get" )]
	class GameObjectisStaticGet4 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isStatic;
			yield break;
		}

	}

	[Automation( "Game Object/Is Static/Set" )]
	class GameObjectisStaticSet4 : Automation {

		public UnityEngine.GameObject Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isStatic = Value;
			yield break;
		}

	}

	[Automation( "Game Object/Tag/Get" )]
	class GameObjecttagGet5 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.tag;
			yield break;
		}

	}

	[Automation( "Game Object/Tag/Set" )]
	class GameObjecttagSet5 : Automation {

		public UnityEngine.GameObject Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.tag = Value;
			yield break;
		}

	}

	[Automation( "Game Object/Scene/Get" )]
	class GameObjectsceneGet6 : Automation {

		public UnityEngine.GameObject Instance;
		[ReadOnly]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = Instance.scene;
			yield break;
		}

	}

	[Automation( "Game Object/Create Primitive" )]
	class GameObjectCreatePrimitive0 : Automation {

		public UnityEngine.PrimitiveType type;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.CreatePrimitive(type);
			yield break;
		}

	}

	[Automation( "Game Object/Get Component" )]
	class GameObjectGetComponent1 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponent(type);
			yield break;
		}

	}

	[Automation( "Game Object/Get Component In Children" )]
	class GameObjectGetComponentInChildren3 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		public System.Boolean includeInactive;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentInChildren(type,includeInactive);
			yield break;
		}

	}

	[Automation( "Game Object/Get Component In Parent" )]
	class GameObjectGetComponentInParent5 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentInParent(type);
			yield break;
		}

	}

	[Automation( "Game Object/Get Components" )]
	class GameObjectGetComponents6 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		[ReadOnly]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponents(type);
			yield break;
		}

	}

	[Automation( "Game Object/Get Components In Children" )]
	class GameObjectGetComponentsInChildren9 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		public System.Boolean includeInactive;
		[ReadOnly]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentsInChildren(type,includeInactive);
			yield break;
		}

	}

	[Automation( "Game Object/Get Components In Parent" )]
	class GameObjectGetComponentsInParent11 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		public System.Boolean includeInactive;
		[ReadOnly]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentsInParent(type,includeInactive);
			yield break;
		}

	}

	[Automation( "Game Object/Set Active" )]
	class GameObjectSetActive12 : Automation {

		public UnityEngine.GameObject Instance;
		public System.Boolean value;

		public override IEnumerator Execute() {
			Instance.SetActive(value);
			yield break;
		}

	}

	[Automation( "Game Object/Compare Tag" )]
	class GameObjectCompareTag13 : Automation {

		public UnityEngine.GameObject Instance;
		public System.String tag;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.CompareTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Find Game Object With Tag" )]
	class GameObjectFindGameObjectWithTag14 : Automation {

		public System.String tag;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.FindGameObjectWithTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Find With Tag" )]
	class GameObjectFindWithTag15 : Automation {

		public System.String tag;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.FindWithTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Find Game Objects With Tag" )]
	class GameObjectFindGameObjectsWithTag16 : Automation {

		public System.String tag;
		[ReadOnly]
		public UnityEngine.GameObject[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GameObject.FindGameObjectsWithTag(tag);
			yield break;
		}

	}

	[Automation( "Game Object/Add Component" )]
	class GameObjectAddComponent29 : Automation {

		public UnityEngine.GameObject Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type componentType;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.AddComponent(componentType);
			yield break;
		}

	}

	[Automation( "Game Object/Find" )]
	class GameObjectFind30 : Automation {

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
