using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Distance Joint 2D/Get Auto Configure Distance" )]
	class DistanceJoint2DautoConfigureDistanceGet0 : ConditionalAutomation {

		public UnityEngine.DistanceJoint2D Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.autoConfigureDistance;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Distance Joint 2D/Set Auto Configure Distance" )]
	class DistanceJoint2DautoConfigureDistanceSet0 : Automation {

		public UnityEngine.DistanceJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureDistance = Value;
			yield break;
		}

	}

	[Automation( "Distance Joint 2D/Get Distance" )]
	class DistanceJoint2DdistanceGet1 : Automation {

		public UnityEngine.DistanceJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.distance;
			yield break;
		}

	}

	[Automation( "Distance Joint 2D/Set Distance" )]
	class DistanceJoint2DdistanceSet1 : Automation {

		public UnityEngine.DistanceJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.distance = Value;
			yield break;
		}

	}

	[Automation( "Distance Joint 2D/Get Max Distance Only" )]
	class DistanceJoint2DmaxDistanceOnlyGet2 : ConditionalAutomation {

		public UnityEngine.DistanceJoint2D Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.maxDistanceOnly;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Distance Joint 2D/Set Max Distance Only" )]
	class DistanceJoint2DmaxDistanceOnlySet2 : Automation {

		public UnityEngine.DistanceJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.maxDistanceOnly = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
