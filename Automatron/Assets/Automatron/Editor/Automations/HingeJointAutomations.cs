using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Hinge Joint/Get Motor" )]
	class HingeJointmotorGet0 : Automation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public UnityEngine.JointMotor Result;

		public override IEnumerator Execute() {
			Result = Instance.motor;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Set Motor" )]
	class HingeJointmotorSet0 : Automation {

		public UnityEngine.HingeJoint Instance;
		public UnityEngine.JointMotor Value;

		public override IEnumerator Execute() {
			Instance.motor = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Limits" )]
	class HingeJointlimitsGet1 : Automation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public UnityEngine.JointLimits Result;

		public override IEnumerator Execute() {
			Result = Instance.limits;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Set Limits" )]
	class HingeJointlimitsSet1 : Automation {

		public UnityEngine.HingeJoint Instance;
		public UnityEngine.JointLimits Value;

		public override IEnumerator Execute() {
			Instance.limits = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Spring" )]
	class HingeJointspringGet2 : Automation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public UnityEngine.JointSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.spring;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Set Spring" )]
	class HingeJointspringSet2 : Automation {

		public UnityEngine.HingeJoint Instance;
		public UnityEngine.JointSpring Value;

		public override IEnumerator Execute() {
			Instance.spring = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Use Motor" )]
	class HingeJointuseMotorGet3 : ConditionalAutomation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useMotor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Hinge Joint/Set Use Motor" )]
	class HingeJointuseMotorSet3 : Automation {

		public UnityEngine.HingeJoint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useMotor = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Use Limits" )]
	class HingeJointuseLimitsGet4 : ConditionalAutomation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useLimits;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Hinge Joint/Set Use Limits" )]
	class HingeJointuseLimitsSet4 : Automation {

		public UnityEngine.HingeJoint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useLimits = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Use Spring" )]
	class HingeJointuseSpringGet5 : ConditionalAutomation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useSpring;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Hinge Joint/Set Use Spring" )]
	class HingeJointuseSpringSet5 : Automation {

		public UnityEngine.HingeJoint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useSpring = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Velocity" )]
	class HingeJointvelocityGet6 : Automation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Hinge Joint/Get Angle" )]
	class HingeJointangleGet7 : Automation {

		public UnityEngine.HingeJoint Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angle;
			yield break;
		}

	}


#pragma warning restore 0649
}
