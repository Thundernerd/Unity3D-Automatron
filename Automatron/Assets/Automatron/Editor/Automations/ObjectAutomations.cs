using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Object/Get Name" )]
	class ObjectnameGet0 : Automation {

		public UnityEngine.Object Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.name;
			yield break;
		}

	}

	[Automation( "Object/Set Name" )]
	class ObjectnameSet0 : Automation {

		public UnityEngine.Object Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.name = Value;
			yield break;
		}

	}

	[Automation( "Object/Get Hide Flags" )]
	class ObjecthideFlagsGet1 : Automation {

		public UnityEngine.Object Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.HideFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.hideFlags;
			yield break;
		}

	}

	[Automation( "Object/Set Hide Flags" )]
	class ObjecthideFlagsSet1 : Automation {

		public UnityEngine.Object Instance;
		public UnityEngine.HideFlags Value;

		public override IEnumerator Execute() {
			Instance.hideFlags = Value;
			yield break;
		}

	}

	[Automation( "Object/Destroy" )]
	class ObjectDestroy0 : Automation {

		public UnityEngine.Object obj;
		public System.Single t;

		public override IEnumerator Execute() {
			UnityEngine.Object.Destroy(obj,t);
			yield break;
		}

	}

	[Automation( "Object/Destroy Immediate" )]
	class ObjectDestroyImmediate1 : Automation {

		public UnityEngine.Object obj;
		public System.Boolean allowDestroyingAssets;

		public override IEnumerator Execute() {
			UnityEngine.Object.DestroyImmediate(obj,allowDestroyingAssets);
			yield break;
		}

	}

	[Automation( "Object/Find Objects Of Type" )]
	class ObjectFindObjectsOfType2 : Automation {

        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Object.FindObjectsOfType(type);
			yield break;
		}

	}

	[Automation( "Object/Destroy Object" )]
	class ObjectDestroyObject3 : Automation {

		public UnityEngine.Object obj;
		public System.Single t;

		public override IEnumerator Execute() {
			UnityEngine.Object.DestroyObject(obj,t);
			yield break;
		}

	}

	[Automation( "Object/Equals" )]
	class ObjectEquals4 : ConditionalAutomation {

		public UnityEngine.Object Instance;
		public System.Object o;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(o);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Object/Instantiate" )]
	class ObjectInstantiate5 : Automation {

		public UnityEngine.Object original;
		public UnityEngine.Vector3 position;
		public UnityEngine.Quaternion rotation;
		public UnityEngine.Transform parent;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Object.Instantiate(original,position,rotation,parent);
			yield break;
		}

	}

	[Automation( "Object/Find Object Of Type" )]
	class ObjectFindObjectOfType6 : Automation {

        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Object.FindObjectOfType(type);
			yield break;
		}

	}


#pragma warning restore 0649
}
