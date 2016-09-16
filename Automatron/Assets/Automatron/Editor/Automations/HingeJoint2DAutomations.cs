using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Hinge Joint 2D/Get Use Motor" )]
	class HingeJoint2DuseMotorGet0 : ConditionalAutomation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useMotor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Hinge Joint 2D/Set Use Motor" )]
	class HingeJoint2DuseMotorSet0 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useMotor = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Use Limits" )]
	class HingeJoint2DuseLimitsGet1 : ConditionalAutomation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useLimits;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Hinge Joint 2D/Set Use Limits" )]
	class HingeJoint2DuseLimitsSet1 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useLimits = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Motor" )]
	class HingeJoint2DmotorGet2 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointMotor2D Result;

		public override IEnumerator Execute() {
			Result = Instance.motor;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Set Motor" )]
	class HingeJoint2DmotorSet2 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		public UnityEngine.JointMotor2D Value;

		public override IEnumerator Execute() {
			Instance.motor = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Limits" )]
	class HingeJoint2DlimitsGet3 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointAngleLimits2D Result;

		public override IEnumerator Execute() {
			Result = Instance.limits;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Set Limits" )]
	class HingeJoint2DlimitsSet3 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		public UnityEngine.JointAngleLimits2D Value;

		public override IEnumerator Execute() {
			Instance.limits = Value;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Limit State" )]
	class HingeJoint2DlimitStateGet4 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointLimitState2D Result;

		public override IEnumerator Execute() {
			Result = Instance.limitState;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Reference Angle" )]
	class HingeJoint2DreferenceAngleGet5 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.referenceAngle;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Joint Angle" )]
	class HingeJoint2DjointAngleGet6 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.jointAngle;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Joint Speed" )]
	class HingeJoint2DjointSpeedGet7 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.jointSpeed;
			yield break;
		}

	}

	[Automation( "Hinge Joint 2D/Get Motor Torque" )]
	class HingeJoint2DGetMotorTorque0 : Automation {

		public UnityEngine.HingeJoint2D Instance;
		public System.Single timeStep;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMotorTorque(timeStep);
			yield break;
		}

	}


#pragma warning restore 0649
}
