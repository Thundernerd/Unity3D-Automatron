#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rigidbody/Get Velocity" )]
	class RigidbodyvelocityGet0 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Velocity" )]
	class RigidbodyvelocitySet0 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.velocity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Angular Velocity" )]
	class RigidbodyangularVelocityGet1 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.angularVelocity;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Angular Velocity" )]
	class RigidbodyangularVelocitySet1 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.angularVelocity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Drag" )]
	class RigidbodydragGet2 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.drag;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Drag" )]
	class RigidbodydragSet2 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.drag = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Angular Drag" )]
	class RigidbodyangularDragGet3 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularDrag;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Angular Drag" )]
	class RigidbodyangularDragSet3 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularDrag = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Mass" )]
	class RigidbodymassGet4 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.mass;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Mass" )]
	class RigidbodymassSet4 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.mass = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Use Gravity" )]
	class RigidbodyuseGravityGet5 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useGravity;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Set Use Gravity" )]
	class RigidbodyuseGravitySet5 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useGravity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Max Depenetration Velocity" )]
	class RigidbodymaxDepenetrationVelocityGet6 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxDepenetrationVelocity;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Max Depenetration Velocity" )]
	class RigidbodymaxDepenetrationVelocitySet6 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxDepenetrationVelocity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Is Kinematic" )]
	class RigidbodyisKinematicGet7 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isKinematic;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Set Is Kinematic" )]
	class RigidbodyisKinematicSet7 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isKinematic = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Freeze Rotation" )]
	class RigidbodyfreezeRotationGet8 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.freezeRotation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Set Freeze Rotation" )]
	class RigidbodyfreezeRotationSet8 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.freezeRotation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Constraints" )]
	class RigidbodyconstraintsGet9 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RigidbodyConstraints Result;

		public override IEnumerator Execute() {
			Result = Instance.constraints;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Constraints" )]
	class RigidbodyconstraintsSet9 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.RigidbodyConstraints Value;

		public override IEnumerator Execute() {
			Instance.constraints = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Collision Detection Mode" )]
	class RigidbodycollisionDetectionModeGet10 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.CollisionDetectionMode Result;

		public override IEnumerator Execute() {
			Result = Instance.collisionDetectionMode;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Collision Detection Mode" )]
	class RigidbodycollisionDetectionModeSet10 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.CollisionDetectionMode Value;

		public override IEnumerator Execute() {
			Instance.collisionDetectionMode = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Center Of Mass" )]
	class RigidbodycenterOfMassGet11 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.centerOfMass;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Center Of Mass" )]
	class RigidbodycenterOfMassSet11 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.centerOfMass = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get World Center Of Mass" )]
	class RigidbodyworldCenterOfMassGet12 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldCenterOfMass;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Inertia Tensor Rotation" )]
	class RigidbodyinertiaTensorRotationGet13 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.inertiaTensorRotation;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Inertia Tensor Rotation" )]
	class RigidbodyinertiaTensorRotationSet13 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.inertiaTensorRotation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Inertia Tensor" )]
	class RigidbodyinertiaTensorGet14 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.inertiaTensor;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Inertia Tensor" )]
	class RigidbodyinertiaTensorSet14 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.inertiaTensor = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Detect Collisions" )]
	class RigidbodydetectCollisionsGet15 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.detectCollisions;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Set Detect Collisions" )]
	class RigidbodydetectCollisionsSet15 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.detectCollisions = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Use Cone Friction" )]
	class RigidbodyuseConeFrictionGet16 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useConeFriction;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Set Use Cone Friction" )]
	class RigidbodyuseConeFrictionSet16 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useConeFriction = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Position" )]
	class RigidbodypositionGet17 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.position;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Position" )]
	class RigidbodypositionSet17 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.position = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Rotation" )]
	class RigidbodyrotationGet18 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = Instance.rotation;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Rotation" )]
	class RigidbodyrotationSet18 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Quaternion Value;

		public override IEnumerator Execute() {
			Instance.rotation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Interpolation" )]
	class RigidbodyinterpolationGet19 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RigidbodyInterpolation Result;

		public override IEnumerator Execute() {
			Result = Instance.interpolation;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Interpolation" )]
	class RigidbodyinterpolationSet19 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.RigidbodyInterpolation Value;

		public override IEnumerator Execute() {
			Instance.interpolation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Solver Iterations" )]
	class RigidbodysolverIterationsGet20 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.solverIterations;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Solver Iterations" )]
	class RigidbodysolverIterationsSet20 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.solverIterations = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Solver Velocity Iterations" )]
	class RigidbodysolverVelocityIterationsGet21 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.solverVelocityIterations;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Solver Velocity Iterations" )]
	class RigidbodysolverVelocityIterationsSet21 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.solverVelocityIterations = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Sleep Threshold" )]
	class RigidbodysleepThresholdGet22 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sleepThreshold;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Sleep Threshold" )]
	class RigidbodysleepThresholdSet22 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.sleepThreshold = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Max Angular Velocity" )]
	class RigidbodymaxAngularVelocityGet23 : Automation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxAngularVelocity;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Max Angular Velocity" )]
	class RigidbodymaxAngularVelocitySet23 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxAngularVelocity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody/Set Density" )]
	class RigidbodySetDensity0 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single density;

		public override IEnumerator Execute() {
			Instance.SetDensity(density);
			yield break;
		}

	}

	[Automation( "Rigidbody/Add Force" )]
	class RigidbodyAddForce1 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 force;
		public UnityEngine.ForceMode mode;

		public override IEnumerator Execute() {
			Instance.AddForce(force,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody/Add Relative Force" )]
	class RigidbodyAddRelativeForce2 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 force;
		public UnityEngine.ForceMode mode;

		public override IEnumerator Execute() {
			Instance.AddRelativeForce(force,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody/Add Torque" )]
	class RigidbodyAddTorque3 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 torque;
		public UnityEngine.ForceMode mode;

		public override IEnumerator Execute() {
			Instance.AddTorque(torque,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody/Add Relative Torque" )]
	class RigidbodyAddRelativeTorque4 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 torque;
		public UnityEngine.ForceMode mode;

		public override IEnumerator Execute() {
			Instance.AddRelativeTorque(torque,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody/Add Force At Position" )]
	class RigidbodyAddForceAtPosition5 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 force;
		public UnityEngine.Vector3 position;
		public UnityEngine.ForceMode mode;

		public override IEnumerator Execute() {
			Instance.AddForceAtPosition(force,position,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody/Add Explosion Force" )]
	class RigidbodyAddExplosionForce6 : Automation {

		public UnityEngine.Rigidbody Instance;
		public System.Single explosionForce;
		public UnityEngine.Vector3 explosionPosition;
		public System.Single explosionRadius;
		public System.Single upwardsModifier;
		public UnityEngine.ForceMode mode;

		public override IEnumerator Execute() {
			Instance.AddExplosionForce(explosionForce,explosionPosition,explosionRadius,upwardsModifier,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody/Closest Point On Bounds" )]
	class RigidbodyClosestPointOnBounds7 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ClosestPointOnBounds(position);
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Relative Point Velocity" )]
	class RigidbodyGetRelativePointVelocity8 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 relativePoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRelativePointVelocity(relativePoint);
			yield break;
		}

	}

	[Automation( "Rigidbody/Get Point Velocity" )]
	class RigidbodyGetPointVelocity9 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 worldPoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPointVelocity(worldPoint);
			yield break;
		}

	}

	[Automation( "Rigidbody/Move Position" )]
	class RigidbodyMovePosition10 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 position;

		public override IEnumerator Execute() {
			Instance.MovePosition(position);
			yield break;
		}

	}

	[Automation( "Rigidbody/Move Rotation" )]
	class RigidbodyMoveRotation11 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Quaternion rot;

		public override IEnumerator Execute() {
			Instance.MoveRotation(rot);
			yield break;
		}

	}

	[Automation( "Rigidbody/Sleep" )]
	class RigidbodySleep12 : Automation {

		public UnityEngine.Rigidbody Instance;

		public override IEnumerator Execute() {
			Instance.Sleep();
			yield break;
		}

	}

	[Automation( "Rigidbody/Is Sleeping" )]
	class RigidbodyIsSleeping13 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsSleeping();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Wake Up" )]
	class RigidbodyWakeUp14 : Automation {

		public UnityEngine.Rigidbody Instance;

		public override IEnumerator Execute() {
			Instance.WakeUp();
			yield break;
		}

	}

	[Automation( "Rigidbody/Reset Center Of Mass" )]
	class RigidbodyResetCenterOfMass15 : Automation {

		public UnityEngine.Rigidbody Instance;

		public override IEnumerator Execute() {
			Instance.ResetCenterOfMass();
			yield break;
		}

	}

	[Automation( "Rigidbody/Reset Inertia Tensor" )]
	class RigidbodyResetInertiaTensor16 : Automation {

		public UnityEngine.Rigidbody Instance;

		public override IEnumerator Execute() {
			Instance.ResetInertiaTensor();
			yield break;
		}

	}

	[Automation( "Rigidbody/Sweep Test" )]
	class RigidbodySweepTest17 : ConditionalAutomation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SweepTest(direction,out hitInfo,maxDistance,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody/Sweep Test All" )]
	class RigidbodySweepTestAll18 : Automation {

		public UnityEngine.Rigidbody Instance;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = Instance.SweepTestAll(direction,maxDistance,queryTriggerInteraction);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif