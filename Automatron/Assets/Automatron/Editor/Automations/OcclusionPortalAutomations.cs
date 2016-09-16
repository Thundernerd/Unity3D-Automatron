using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Occlusion Portal/Get Open" )]
	class OcclusionPortalopenGet0 : ConditionalAutomation {

		public UnityEngine.OcclusionPortal Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.open;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Occlusion Portal/Set Open" )]
	class OcclusionPortalopenSet0 : Automation {

		public UnityEngine.OcclusionPortal Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.open = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
