#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Spring Joint 2D/Get Auto Configure Distance" )]
	class SpringJoint2DautoConfigureDistanceGet0 : ConditionalAutomation {

		public UnityEngine.SpringJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoConfigureDistance;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Spring Joint 2D/Set Auto Configure Distance" )]
	class SpringJoint2DautoConfigureDistanceSet0 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureDistance = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint 2D/Get Distance" )]
	class SpringJoint2DdistanceGet1 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.distance;
			yield break;
		}

	}

	[Automation( "Spring Joint 2D/Set Distance" )]
	class SpringJoint2DdistanceSet1 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.distance = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint 2D/Get Damping Ratio" )]
	class SpringJoint2DdampingRatioGet2 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dampingRatio;
			yield break;
		}

	}

	[Automation( "Spring Joint 2D/Set Damping Ratio" )]
	class SpringJoint2DdampingRatioSet2 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dampingRatio = Value;
			yield break;
		}

	}

	[Automation( "Spring Joint 2D/Get Frequency" )]
	class SpringJoint2DfrequencyGet3 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.frequency;
			yield break;
		}

	}

	[Automation( "Spring Joint 2D/Set Frequency" )]
	class SpringJoint2DfrequencySet3 : Automation {

		public UnityEngine.SpringJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.frequency = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif