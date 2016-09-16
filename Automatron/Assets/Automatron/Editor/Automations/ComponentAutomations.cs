using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Component/Get Transform" )]
	class ComponenttransformGet0 : Automation {

		public UnityEngine.Component Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.transform;
			yield break;
		}

	}

	[Automation( "Component/Get Game Object" )]
	class ComponentgameObjectGet1 : Automation {

		public UnityEngine.Component Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = Instance.gameObject;
			yield break;
		}

	}

	[Automation( "Component/Get Tag" )]
	class ComponenttagGet2 : Automation {

		public UnityEngine.Component Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.tag;
			yield break;
		}

	}

	[Automation( "Component/Set Tag" )]
	class ComponenttagSet2 : Automation {

		public UnityEngine.Component Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.tag = Value;
			yield break;
		}

	}

	[Automation( "Component/Get Component" )]
	class ComponentGetComponent0 : Automation {

		public UnityEngine.Component Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponent(type);
			yield break;
		}

	}

	[Automation( "Component/Get Component By Name" )]
	class ComponentGetComponent1 : Automation {

		public UnityEngine.Component Instance;
		public System.String type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponent(type);
			yield break;
		}

	}

	[Automation( "Component/Get Component In Children" )]
	class ComponentGetComponentInChildren2 : Automation {

		public UnityEngine.Component Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type t;
		public System.Boolean includeInactive;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentInChildren(t,includeInactive);
			yield break;
		}

	}

	[Automation( "Component/Get Components In Children" )]
	class ComponentGetComponentsInChildren3 : Automation {

		public UnityEngine.Component Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type t;
		public System.Boolean includeInactive;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentsInChildren(t,includeInactive);
			yield break;
		}

	}

	[Automation( "Component/Get Component In Parent" )]
	class ComponentGetComponentInParent4 : Automation {

		public UnityEngine.Component Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentInParent(t);
			yield break;
		}

	}

	[Automation( "Component/Get Components In Parent" )]
	class ComponentGetComponentsInParent5 : Automation {

		public UnityEngine.Component Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type t;
		public System.Boolean includeInactive;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentsInParent(t,includeInactive);
			yield break;
		}

	}

	[Automation( "Component/Get Components" )]
	class ComponentGetComponents6 : Automation {

		public UnityEngine.Component Instance;
        [TypeLimit( typeof( UnityEngine.Component ) )]
        public System.Type type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponents(type);
			yield break;
		}

	}

	[Automation( "Component/Compare Tag" )]
	class ComponentCompareTag7 : ConditionalAutomation {

		public UnityEngine.Component Instance;
		public System.String tag;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.CompareTag(tag);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
