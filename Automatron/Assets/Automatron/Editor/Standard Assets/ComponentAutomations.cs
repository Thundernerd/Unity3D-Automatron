using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Component/Get Game Object" )]
	class ComponentgameObjectGet0 : Automation {

		public UnityEngine.Component Instance;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = Instance.gameObject;
			yield break;
		}

	}

	[Automation( "Component/Get Component" )]
	class ComponentGetComponent0 : Automation {

		public UnityEngine.Component Instance;
		public System.Type type;
		[ReadOnly]
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
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponent(type);
			yield break;
		}

	}

	[Automation( "Component/Get Component In Children" )]
	class ComponentGetComponentInChildren2 : Automation {

		public UnityEngine.Component Instance;
		public System.Type t;
		public System.Boolean includeInactive;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentInChildren(t,includeInactive);
			yield break;
		}

	}

	[Automation( "Component/Get Components In Children" )]
	class ComponentGetComponentsInChildren3 : Automation {

		public UnityEngine.Component Instance;
		public System.Type t;
		public System.Boolean includeInactive;
		[ReadOnly]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentsInChildren(t,includeInactive);
			yield break;
		}

	}

	[Automation( "Component/Get Component In Parent" )]
	class ComponentGetComponentInParent4 : Automation {

		public UnityEngine.Component Instance;
		public System.Type t;
		[ReadOnly]
		public UnityEngine.Component Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentInParent(t);
			yield break;
		}

	}

	[Automation( "Component/Get Components In Parent" )]
	class ComponentGetComponentsInParent5 : Automation {

		public UnityEngine.Component Instance;
		public System.Type t;
		public System.Boolean includeInactive;
		[ReadOnly]
		public UnityEngine.Component[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetComponentsInParent(t,includeInactive);
			yield break;
		}

	}

	[Automation( "Component/Get Components" )]
	class ComponentGetComponents6 : Automation {

		public UnityEngine.Component Instance;
		public System.Type type;
		[ReadOnly]
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.CompareTag(tag);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
