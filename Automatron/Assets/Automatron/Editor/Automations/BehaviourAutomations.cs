using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Behaviour/Get Enabled" )]
	class BehaviourenabledGet0 : ConditionalAutomation {

		public UnityEngine.Behaviour Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Behaviour/Set Enabled" )]
	class BehaviourenabledSet0 : Automation {

		public UnityEngine.Behaviour Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Behaviour/Get Is Active And Enabled" )]
	class BehaviourisActiveAndEnabledGet1 : ConditionalAutomation {

		public UnityEngine.Behaviour Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isActiveAndEnabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
