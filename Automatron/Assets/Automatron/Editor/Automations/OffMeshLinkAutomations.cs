using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Off Mesh Link/Get Activated" )]
	class OffMeshLinkactivatedGet0 : ConditionalAutomation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.activated;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Off Mesh Link/Set Activated" )]
	class OffMeshLinkactivatedSet0 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.activated = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Get Occupied" )]
	class OffMeshLinkoccupiedGet1 : ConditionalAutomation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.occupied;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Off Mesh Link/Get Cost Override" )]
	class OffMeshLinkcostOverrideGet2 : Automation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.costOverride;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Set Cost Override" )]
	class OffMeshLinkcostOverrideSet2 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.costOverride = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Get Bi Directional" )]
	class OffMeshLinkbiDirectionalGet3 : ConditionalAutomation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.biDirectional;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Off Mesh Link/Set Bi Directional" )]
	class OffMeshLinkbiDirectionalSet3 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.biDirectional = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Get Area" )]
	class OffMeshLinkareaGet4 : Automation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.area;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Set Area" )]
	class OffMeshLinkareaSet4 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.area = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Get Auto Update Positions" )]
	class OffMeshLinkautoUpdatePositionsGet5 : ConditionalAutomation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoUpdatePositions;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Off Mesh Link/Set Auto Update Positions" )]
	class OffMeshLinkautoUpdatePositionsSet5 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoUpdatePositions = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Get Start Transform" )]
	class OffMeshLinkstartTransformGet6 : Automation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.startTransform;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Set Start Transform" )]
	class OffMeshLinkstartTransformSet6 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public UnityEngine.Transform Value;

		public override IEnumerator Execute() {
			Instance.startTransform = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Get End Transform" )]
	class OffMeshLinkendTransformGet7 : Automation {

		public UnityEngine.OffMeshLink Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.endTransform;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Set End Transform" )]
	class OffMeshLinkendTransformSet7 : Automation {

		public UnityEngine.OffMeshLink Instance;
		public UnityEngine.Transform Value;

		public override IEnumerator Execute() {
			Instance.endTransform = Value;
			yield break;
		}

	}

	[Automation( "Off Mesh Link/Update Positions" )]
	class OffMeshLinkUpdatePositions0 : Automation {

		public UnityEngine.OffMeshLink Instance;

		public override IEnumerator Execute() {
			Instance.UpdatePositions();
			yield break;
		}

	}


#pragma warning restore 0649
}
