using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Joints/Character Joint/Get Swing Axis" )]
	class CharacterJointswingAxisGet0 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.swingAxis;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Swing Axis" )]
	class CharacterJointswingAxisSet0 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.swingAxis = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Twist Limit Spring" )]
	class CharacterJointtwistLimitSpringGet1 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimitSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.twistLimitSpring;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Twist Limit Spring" )]
	class CharacterJointtwistLimitSpringSet1 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.SoftJointLimitSpring Value;

		public override IEnumerator Execute() {
			Instance.twistLimitSpring = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Swing Limit Spring" )]
	class CharacterJointswingLimitSpringGet2 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimitSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.swingLimitSpring;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Swing Limit Spring" )]
	class CharacterJointswingLimitSpringSet2 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.SoftJointLimitSpring Value;

		public override IEnumerator Execute() {
			Instance.swingLimitSpring = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Low Twist Limit" )]
	class CharacterJointlowTwistLimitGet3 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.lowTwistLimit;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Low Twist Limit" )]
	class CharacterJointlowTwistLimitSet3 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.lowTwistLimit = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get High Twist Limit" )]
	class CharacterJointhighTwistLimitGet4 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.highTwistLimit;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set High Twist Limit" )]
	class CharacterJointhighTwistLimitSet4 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.highTwistLimit = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Swing 1 Limit" )]
	class CharacterJointswing1LimitGet5 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.swing1Limit;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Swing 1 Limit" )]
	class CharacterJointswing1LimitSet5 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.swing1Limit = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Swing 2 Limit" )]
	class CharacterJointswing2LimitGet6 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public UnityEngine.SoftJointLimit Result;

		public override IEnumerator Execute() {
			Result = Instance.swing2Limit;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Swing 2 Limit" )]
	class CharacterJointswing2LimitSet6 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public UnityEngine.SoftJointLimit Value;

		public override IEnumerator Execute() {
			Instance.swing2Limit = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Enable Projection" )]
	class CharacterJointenableProjectionGet7 : ConditionalAutomation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.enableProjection;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Joints/Character Joint/Set Enable Projection" )]
	class CharacterJointenableProjectionSet7 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableProjection = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Projection Distance" )]
	class CharacterJointprojectionDistanceGet8 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionDistance;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Projection Distance" )]
	class CharacterJointprojectionDistanceSet8 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.projectionDistance = Value;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Get Projection Angle" )]
	class CharacterJointprojectionAngleGet9 : Automation {

		public UnityEngine.CharacterJoint Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.projectionAngle;
			yield break;
		}

	}

	[Automation( "Joints/Character Joint/Set Projection Angle" )]
	class CharacterJointprojectionAngleSet9 : Automation {

		public UnityEngine.CharacterJoint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.projectionAngle = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
