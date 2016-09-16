using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Wheel Joint 2D/Get Suspension" )]
	class WheelJoint2DsuspensionGet0 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointSuspension2D Result;

		public override IEnumerator Execute() {
			Result = Instance.suspension;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Set Suspension" )]
	class WheelJoint2DsuspensionSet0 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		public UnityEngine.JointSuspension2D Value;

		public override IEnumerator Execute() {
			Instance.suspension = Value;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Get Use Motor" )]
	class WheelJoint2DuseMotorGet1 : ConditionalAutomation {

		public UnityEngine.WheelJoint2D Instance;
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

	[Automation( "Wheel Joint 2D/Set Use Motor" )]
	class WheelJoint2DuseMotorSet1 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useMotor = Value;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Get Motor" )]
	class WheelJoint2DmotorGet2 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointMotor2D Result;

		public override IEnumerator Execute() {
			Result = Instance.motor;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Set Motor" )]
	class WheelJoint2DmotorSet2 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		public UnityEngine.JointMotor2D Value;

		public override IEnumerator Execute() {
			Instance.motor = Value;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Get Joint Translation" )]
	class WheelJoint2DjointTranslationGet3 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.jointTranslation;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Get Joint Speed" )]
	class WheelJoint2DjointSpeedGet4 : Automation {

		public UnityEngine.WheelJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.jointSpeed;
			yield break;
		}

	}

	[Automation( "Wheel Joint 2D/Get Motor Torque" )]
	class WheelJoint2DGetMotorTorque0 : Automation {

		public UnityEngine.WheelJoint2D Instance;
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
