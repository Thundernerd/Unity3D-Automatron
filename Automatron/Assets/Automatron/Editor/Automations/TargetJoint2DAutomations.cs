using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Target Joint 2D/Get Anchor" )]
	class TargetJoint2DanchorGet0 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchor;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Set Anchor" )]
	class TargetJoint2DanchorSet0 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.anchor = Value;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Get Target" )]
	class TargetJoint2DtargetGet1 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.target;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Set Target" )]
	class TargetJoint2DtargetSet1 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.target = Value;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Get Auto Configure Target" )]
	class TargetJoint2DautoConfigureTargetGet2 : ConditionalAutomation {

		public UnityEngine.TargetJoint2D Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.autoConfigureTarget;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Target Joint 2D/Set Auto Configure Target" )]
	class TargetJoint2DautoConfigureTargetSet2 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureTarget = Value;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Get Max Force" )]
	class TargetJoint2DmaxForceGet3 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxForce;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Set Max Force" )]
	class TargetJoint2DmaxForceSet3 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxForce = Value;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Get Damping Ratio" )]
	class TargetJoint2DdampingRatioGet4 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dampingRatio;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Set Damping Ratio" )]
	class TargetJoint2DdampingRatioSet4 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dampingRatio = Value;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Get Frequency" )]
	class TargetJoint2DfrequencyGet5 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.frequency;
			yield break;
		}

	}

	[Automation( "Target Joint 2D/Set Frequency" )]
	class TargetJoint2DfrequencySet5 : Automation {

		public UnityEngine.TargetJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.frequency = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
