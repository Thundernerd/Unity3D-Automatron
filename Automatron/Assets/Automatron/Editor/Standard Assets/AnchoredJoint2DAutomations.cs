using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Joints/Anchored Joint 2D/Get Anchor" )]
	class AnchoredJoint2DanchorGet0 : Automation {

		public UnityEngine.AnchoredJoint2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchor;
			yield break;
		}

	}

	[Automation( "Joints/Anchored Joint 2D/Set Anchor" )]
	class AnchoredJoint2DanchorSet0 : Automation {

		public UnityEngine.AnchoredJoint2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.anchor = Value;
			yield break;
		}

	}

	[Automation( "Joints/Anchored Joint 2D/Get Connected Anchor" )]
	class AnchoredJoint2DconnectedAnchorGet1 : Automation {

		public UnityEngine.AnchoredJoint2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.connectedAnchor;
			yield break;
		}

	}

	[Automation( "Joints/Anchored Joint 2D/Set Connected Anchor" )]
	class AnchoredJoint2DconnectedAnchorSet1 : Automation {

		public UnityEngine.AnchoredJoint2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.connectedAnchor = Value;
			yield break;
		}

	}

	[Automation( "Joints/Anchored Joint 2D/Get Auto Configure Connected Anchor" )]
	class AnchoredJoint2DautoConfigureConnectedAnchorGet2 : ConditionalAutomation {

		public UnityEngine.AnchoredJoint2D Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.autoConfigureConnectedAnchor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Joints/Anchored Joint 2D/Set Auto Configure Connected Anchor" )]
	class AnchoredJoint2DautoConfigureConnectedAnchorSet2 : Automation {

		public UnityEngine.AnchoredJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureConnectedAnchor = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
