#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Wheel Collider/Get Center" )]
	class WheelCollidercenterGet0 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Center" )]
	class WheelCollidercenterSet0 : Automation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Radius" )]
	class WheelColliderradiusGet1 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Radius" )]
	class WheelColliderradiusSet1 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Suspension Distance" )]
	class WheelCollidersuspensionDistanceGet2 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.suspensionDistance;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Suspension Distance" )]
	class WheelCollidersuspensionDistanceSet2 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.suspensionDistance = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Suspension Spring" )]
	class WheelCollidersuspensionSpringGet3 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.JointSpring Result;

		public override IEnumerator Execute() {
			Result = Instance.suspensionSpring;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Suspension Spring" )]
	class WheelCollidersuspensionSpringSet3 : Automation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.JointSpring Value;

		public override IEnumerator Execute() {
			Instance.suspensionSpring = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Force App Point Distance" )]
	class WheelColliderforceAppPointDistanceGet4 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceAppPointDistance;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Force App Point Distance" )]
	class WheelColliderforceAppPointDistanceSet4 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceAppPointDistance = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Mass" )]
	class WheelCollidermassGet5 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.mass;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Mass" )]
	class WheelCollidermassSet5 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.mass = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Wheel Damping Rate" )]
	class WheelColliderwheelDampingRateGet6 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.wheelDampingRate;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Wheel Damping Rate" )]
	class WheelColliderwheelDampingRateSet6 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.wheelDampingRate = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Forward Friction" )]
	class WheelColliderforwardFrictionGet7 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.WheelFrictionCurve Result;

		public override IEnumerator Execute() {
			Result = Instance.forwardFriction;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Forward Friction" )]
	class WheelColliderforwardFrictionSet7 : Automation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.WheelFrictionCurve Value;

		public override IEnumerator Execute() {
			Instance.forwardFriction = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Sideways Friction" )]
	class WheelCollidersidewaysFrictionGet8 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.WheelFrictionCurve Result;

		public override IEnumerator Execute() {
			Result = Instance.sidewaysFriction;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Sideways Friction" )]
	class WheelCollidersidewaysFrictionSet8 : Automation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.WheelFrictionCurve Value;

		public override IEnumerator Execute() {
			Instance.sidewaysFriction = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Motor Torque" )]
	class WheelCollidermotorTorqueGet9 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.motorTorque;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Motor Torque" )]
	class WheelCollidermotorTorqueSet9 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.motorTorque = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Brake Torque" )]
	class WheelColliderbrakeTorqueGet10 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.brakeTorque;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Brake Torque" )]
	class WheelColliderbrakeTorqueSet10 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.brakeTorque = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Steer Angle" )]
	class WheelCollidersteerAngleGet11 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.steerAngle;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Set Steer Angle" )]
	class WheelCollidersteerAngleSet11 : Automation {

		public UnityEngine.WheelCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.steerAngle = Value;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Is Grounded" )]
	class WheelColliderisGroundedGet12 : ConditionalAutomation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isGrounded;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Wheel Collider/Get Sprung Mass" )]
	class WheelCollidersprungMassGet13 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sprungMass;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Get Rpm" )]
	class WheelColliderrpmGet14 : Automation {

		public UnityEngine.WheelCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.rpm;
			yield break;
		}

	}

	[Automation( "Wheel Collider/Configure Vehicle Substeps" )]
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

	[Automation( "Wheel Collider/Get Ground Hit" )]
	class WheelColliderGetGroundHit1 : ConditionalAutomation {

		public UnityEngine.WheelCollider Instance;
		public UnityEngine.WheelHit hit;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetGroundHit(out hit);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Wheel Collider/Get World Pose" )]
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

#endif