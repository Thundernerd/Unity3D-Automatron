#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Slider Joint 2D/Get Auto Configure Angle" )]
	class SliderJoint2DautoConfigureAngleGet0 : ConditionalAutomation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoConfigureAngle;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Slider Joint 2D/Set Auto Configure Angle" )]
	class SliderJoint2DautoConfigureAngleSet0 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureAngle = Value;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Angle" )]
	class SliderJoint2DangleGet1 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angle;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Set Angle" )]
	class SliderJoint2DangleSet1 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angle = Value;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Use Motor" )]
	class SliderJoint2DuseMotorGet2 : ConditionalAutomation {

		public UnityEngine.SliderJoint2D Instance;
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

	[Automation( "Slider Joint 2D/Set Use Motor" )]
	class SliderJoint2DuseMotorSet2 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useMotor = Value;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Use Limits" )]
	class SliderJoint2DuseLimitsGet3 : ConditionalAutomation {

		public UnityEngine.SliderJoint2D Instance;
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

	[Automation( "Slider Joint 2D/Set Use Limits" )]
	class SliderJoint2DuseLimitsSet3 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useLimits = Value;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Motor" )]
	class SliderJoint2DmotorGet4 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointMotor2D Result;

		public override IEnumerator Execute() {
			Result = Instance.motor;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Set Motor" )]
	class SliderJoint2DmotorSet4 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public UnityEngine.JointMotor2D Value;

		public override IEnumerator Execute() {
			Instance.motor = Value;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Limits" )]
	class SliderJoint2DlimitsGet5 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointTranslationLimits2D Result;

		public override IEnumerator Execute() {
			Result = Instance.limits;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Set Limits" )]
	class SliderJoint2DlimitsSet5 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public UnityEngine.JointTranslationLimits2D Value;

		public override IEnumerator Execute() {
			Instance.limits = Value;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Limit State" )]
	class SliderJoint2DlimitStateGet6 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointLimitState2D Result;

		public override IEnumerator Execute() {
			Result = Instance.limitState;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Reference Angle" )]
	class SliderJoint2DreferenceAngleGet7 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.referenceAngle;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Joint Translation" )]
	class SliderJoint2DjointTranslationGet8 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.jointTranslation;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Joint Speed" )]
	class SliderJoint2DjointSpeedGet9 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.jointSpeed;
			yield break;
		}

	}

	[Automation( "Slider Joint 2D/Get Motor Force" )]
	class SliderJoint2DGetMotorForce0 : Automation {

		public UnityEngine.SliderJoint2D Instance;
		public System.Single timeStep;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMotorForce(timeStep);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif