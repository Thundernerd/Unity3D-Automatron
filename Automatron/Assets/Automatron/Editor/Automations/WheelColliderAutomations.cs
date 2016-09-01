using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Colliders/Wheel Collider/Get Center" )]
	class WheelCollidercenterGet0 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Center" )]
	class WheelCollidercenterSet0 : Automation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Radius" )]
	class WheelColliderradiusGet1 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Radius" )]
	class WheelColliderradiusSet1 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Suspension Distance" )]
	class WheelCollidersuspensionDistanceGet2 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.suspensionDistance;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Suspension Distance" )]
	class WheelCollidersuspensionDistanceSet2 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.suspensionDistance = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Force App Point Distance" )]
	class WheelColliderforceAppPointDistanceGet3 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceAppPointDistance;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Force App Point Distance" )]
	class WheelColliderforceAppPointDistanceSet3 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceAppPointDistance = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Mass" )]
	class WheelCollidermassGet4 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.mass;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Mass" )]
	class WheelCollidermassSet4 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.mass = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Wheel Damping Rate" )]
	class WheelColliderwheelDampingRateGet5 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.wheelDampingRate;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Wheel Damping Rate" )]
	class WheelColliderwheelDampingRateSet5 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.wheelDampingRate = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Motor Torque" )]
	class WheelCollidermotorTorqueGet6 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.motorTorque;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Motor Torque" )]
	class WheelCollidermotorTorqueSet6 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.motorTorque = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Brake Torque" )]
	class WheelColliderbrakeTorqueGet7 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.brakeTorque;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Brake Torque" )]
	class WheelColliderbrakeTorqueSet7 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.brakeTorque = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Steer Angle" )]
	class WheelCollidersteerAngleGet8 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.steerAngle;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Set Steer Angle" )]
	class WheelCollidersteerAngleSet8 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.steerAngle = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Is Grounded" )]
	class WheelColliderisGroundedGet9 : ConditionalAutomation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isGrounded;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Colliders/Wheel Collider/Get Sprung Mass" )]
	class WheelCollidersprungMassGet10 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sprungMass;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Rpm" )]
	class WheelColliderrpmGet11 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.rpm;
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Configure Vehicle Substeps" )]
	class WheelColliderConfigureVehicleSubsteps0 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single speedThreshold;
		public System.Int32 stepsBelowThreshold;
		public System.Int32 stepsAboveThreshold;

		public override IEnumerator Execute() {
			Instance.ConfigureVehicleSubsteps(speedThreshold,stepsBelowThreshold,stepsAboveThreshold);
			yield break;
		}

	}

	[Automation( "Colliders/Wheel Collider/Get Ground Hit" )]
	class WheelColliderGetGroundHit1 : ConditionalAutomation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.WheelHit hit;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.GetGroundHit(out hit);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Colliders/Wheel Collider/Get World Pose" )]
	class WheelColliderGetWorldPose2 : Automation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.Vector3 pos;
		public UnityEngine.Quaternion quat;

		public override IEnumerator Execute() {
			Instance.GetWorldPose(out pos,out quat);
			yield break;
		}

	}


#pragma warning restore 0649
}
