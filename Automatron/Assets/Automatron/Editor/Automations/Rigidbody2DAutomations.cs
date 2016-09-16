using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rigidbody 2D/Get Position" )]
	class Rigidbody2DpositionGet0 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.position;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Position" )]
	class Rigidbody2DpositionSet0 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.position = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Rotation" )]
	class Rigidbody2DrotationGet1 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.rotation;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Rotation" )]
	class Rigidbody2DrotationSet1 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.rotation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Velocity" )]
	class Rigidbody2DvelocityGet2 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.velocity;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Velocity" )]
	class Rigidbody2DvelocitySet2 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.velocity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Angular Velocity" )]
	class Rigidbody2DangularVelocityGet3 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularVelocity;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Angular Velocity" )]
	class Rigidbody2DangularVelocitySet3 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularVelocity = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Use Auto Mass" )]
	class Rigidbody2DuseAutoMassGet4 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useAutoMass;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody 2D/Set Use Auto Mass" )]
	class Rigidbody2DuseAutoMassSet4 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useAutoMass = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Mass" )]
	class Rigidbody2DmassGet5 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.mass;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Mass" )]
	class Rigidbody2DmassSet5 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.mass = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Center Of Mass" )]
	class Rigidbody2DcenterOfMassGet6 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.centerOfMass;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Center Of Mass" )]
	class Rigidbody2DcenterOfMassSet6 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.centerOfMass = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get World Center Of Mass" )]
	class Rigidbody2DworldCenterOfMassGet7 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldCenterOfMass;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Inertia" )]
	class Rigidbody2DinertiaGet8 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.inertia;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Inertia" )]
	class Rigidbody2DinertiaSet8 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.inertia = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Drag" )]
	class Rigidbody2DdragGet9 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.drag;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Drag" )]
	class Rigidbody2DdragSet9 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.drag = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Angular Drag" )]
	class Rigidbody2DangularDragGet10 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularDrag;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Angular Drag" )]
	class Rigidbody2DangularDragSet10 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularDrag = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Gravity Scale" )]
	class Rigidbody2DgravityScaleGet11 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.gravityScale;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Gravity Scale" )]
	class Rigidbody2DgravityScaleSet11 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.gravityScale = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Is Kinematic" )]
	class Rigidbody2DisKinematicGet12 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
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

	[Automation( "Rigidbody 2D/Set Is Kinematic" )]
	class Rigidbody2DisKinematicSet12 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isKinematic = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Freeze Rotation" )]
	class Rigidbody2DfreezeRotationGet13 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
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

	[Automation( "Rigidbody 2D/Set Freeze Rotation" )]
	class Rigidbody2DfreezeRotationSet13 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.freezeRotation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Constraints" )]
	class Rigidbody2DconstraintsGet14 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RigidbodyConstraints2D Result;

		public override IEnumerator Execute() {
			Result = Instance.constraints;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Constraints" )]
	class Rigidbody2DconstraintsSet14 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.RigidbodyConstraints2D Value;

		public override IEnumerator Execute() {
			Instance.constraints = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Simulated" )]
	class Rigidbody2DsimulatedGet15 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.simulated;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody 2D/Set Simulated" )]
	class Rigidbody2DsimulatedSet15 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.simulated = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Interpolation" )]
	class Rigidbody2DinterpolationGet16 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RigidbodyInterpolation2D Result;

		public override IEnumerator Execute() {
			Result = Instance.interpolation;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Interpolation" )]
	class Rigidbody2DinterpolationSet16 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.RigidbodyInterpolation2D Value;

		public override IEnumerator Execute() {
			Instance.interpolation = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Sleep Mode" )]
	class Rigidbody2DsleepModeGet17 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RigidbodySleepMode2D Result;

		public override IEnumerator Execute() {
			Result = Instance.sleepMode;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Sleep Mode" )]
	class Rigidbody2DsleepModeSet17 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.RigidbodySleepMode2D Value;

		public override IEnumerator Execute() {
			Instance.sleepMode = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Collision Detection Mode" )]
	class Rigidbody2DcollisionDetectionModeGet18 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.CollisionDetectionMode2D Result;

		public override IEnumerator Execute() {
			Result = Instance.collisionDetectionMode;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Set Collision Detection Mode" )]
	class Rigidbody2DcollisionDetectionModeSet18 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.CollisionDetectionMode2D Value;

		public override IEnumerator Execute() {
			Instance.collisionDetectionMode = Value;
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Move Position" )]
	class Rigidbody2DMovePosition0 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 position;

		public override IEnumerator Execute() {
			Instance.MovePosition(position);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Move Rotation" )]
	class Rigidbody2DMoveRotation1 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single angle;

		public override IEnumerator Execute() {
			Instance.MoveRotation(angle);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Is Sleeping" )]
	class Rigidbody2DIsSleeping2 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
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

	[Automation( "Rigidbody 2D/Is Awake" )]
	class Rigidbody2DIsAwake3 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsAwake();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody 2D/Sleep" )]
	class Rigidbody2DSleep4 : Automation {

		public UnityEngine.Rigidbody2D Instance;

		public override IEnumerator Execute() {
			Instance.Sleep();
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Wake Up" )]
	class Rigidbody2DWakeUp5 : Automation {

		public UnityEngine.Rigidbody2D Instance;

		public override IEnumerator Execute() {
			Instance.WakeUp();
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Is Touching" )]
	class Rigidbody2DIsTouching6 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Collider2D collider;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsTouching(collider);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody 2D/Is Touching Layers" )]
	class Rigidbody2DIsTouchingLayers7 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Int32 layerMask;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsTouchingLayers(layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody 2D/Overlap Point" )]
	class Rigidbody2DOverlapPoint8 : ConditionalAutomation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.OverlapPoint(point);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rigidbody 2D/Cast" )]
	class Rigidbody2DCast9 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Cast(direction,results,distance);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Add Force" )]
	class Rigidbody2DAddForce10 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 force;
		public UnityEngine.ForceMode2D mode;

		public override IEnumerator Execute() {
			Instance.AddForce(force,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Add Relative Force" )]
	class Rigidbody2DAddRelativeForce11 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 relativeForce;
		public UnityEngine.ForceMode2D mode;

		public override IEnumerator Execute() {
			Instance.AddRelativeForce(relativeForce,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Add Force At Position" )]
	class Rigidbody2DAddForceAtPosition12 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 force;
		public UnityEngine.Vector2 position;
		public UnityEngine.ForceMode2D mode;

		public override IEnumerator Execute() {
			Instance.AddForceAtPosition(force,position,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Add Torque" )]
	class Rigidbody2DAddTorque13 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public System.Single torque;
		public UnityEngine.ForceMode2D mode;

		public override IEnumerator Execute() {
			Instance.AddTorque(torque,mode);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Point" )]
	class Rigidbody2DGetPoint14 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPoint(point);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Relative Point" )]
	class Rigidbody2DGetRelativePoint15 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 relativePoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRelativePoint(relativePoint);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Vector" )]
	class Rigidbody2DGetVector16 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 vector;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetVector(vector);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Relative Vector" )]
	class Rigidbody2DGetRelativeVector17 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 relativeVector;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRelativeVector(relativeVector);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Point Velocity" )]
	class Rigidbody2DGetPointVelocity18 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPointVelocity(point);
			yield break;
		}

	}

	[Automation( "Rigidbody 2D/Get Relative Point Velocity" )]
	class Rigidbody2DGetRelativePointVelocity19 : Automation {

		public UnityEngine.Rigidbody2D Instance;
		public UnityEngine.Vector2 relativePoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRelativePointVelocity(relativePoint);
			yield break;
		}

	}


#pragma warning restore 0649
}
