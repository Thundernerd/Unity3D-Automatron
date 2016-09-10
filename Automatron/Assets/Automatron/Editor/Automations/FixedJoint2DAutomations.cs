using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Joints/Fixed Joint 2D/Get Damping Ratio" )]
	class FixedJoint2DdampingRatioGet0 : Automation {

		public UnityEngine.FixedJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dampingRatio;
			yield break;
		}

	}

	[Automation( "Joints/Fixed Joint 2D/Set Damping Ratio" )]
	class FixedJoint2DdampingRatioSet0 : Automation {

		public UnityEngine.FixedJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dampingRatio = Value;
			yield break;
		}

	}

	[Automation( "Joints/Fixed Joint 2D/Get Frequency" )]
	class FixedJoint2DfrequencyGet1 : Automation {

		public UnityEngine.FixedJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.frequency;
			yield break;
		}

	}

	[Automation( "Joints/Fixed Joint 2D/Set Frequency" )]
	class FixedJoint2DfrequencySet1 : Automation {

		public UnityEngine.FixedJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.frequency = Value;
			yield break;
		}

	}

	[Automation( "Joints/Fixed Joint 2D/Get Reference Angle" )]
	class FixedJoint2DreferenceAngleGet2 : Automation {

		public UnityEngine.FixedJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.referenceAngle;
			yield break;
		}

	}


#pragma warning restore 0649
}
