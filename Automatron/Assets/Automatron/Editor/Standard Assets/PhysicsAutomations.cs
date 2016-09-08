using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Physics/Get Ignore Raycast Layer" )]
	class PhysicsIgnoreRaycastLayerGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.IgnoreRaycastLayer;
			yield break;
		}

	}

	[Automation( "Physics/Get Default Raycast Layers" )]
	class PhysicsDefaultRaycastLayersGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.DefaultRaycastLayers;
			yield break;
		}

	}

	[Automation( "Physics/Get All Layers" )]
	class PhysicsAllLayersGet2 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.AllLayers;
			yield break;
		}

	}

	[Automation( "Physics/Get Gravity" )]
	class PhysicsgravityGet0 : Automation {

		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.gravity;
			yield break;
		}

	}

	[Automation( "Physics/Set Gravity" )]
	class PhysicsgravitySet0 : Automation {

		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.gravity = Value;
			yield break;
		}

	}

	[Automation( "Physics/Get Default Contact Offset" )]
	class PhysicsdefaultContactOffsetGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.defaultContactOffset;
			yield break;
		}

	}

	[Automation( "Physics/Set Default Contact Offset" )]
	class PhysicsdefaultContactOffsetSet1 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.defaultContactOffset = Value;
			yield break;
		}

	}

	[Automation( "Physics/Get Bounce Threshold" )]
	class PhysicsbounceThresholdGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.bounceThreshold;
			yield break;
		}

	}

	[Automation( "Physics/Set Bounce Threshold" )]
	class PhysicsbounceThresholdSet2 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.bounceThreshold = Value;
			yield break;
		}

	}

	[Automation( "Physics/Get Solver Iteration Count" )]
	class PhysicssolverIterationCountGet3 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.solverIterationCount;
			yield break;
		}

	}

	[Automation( "Physics/Set Solver Iteration Count" )]
	class PhysicssolverIterationCountSet3 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.solverIterationCount = Value;
			yield break;
		}

	}

	[Automation( "Physics/Get Sleep Threshold" )]
	class PhysicssleepThresholdGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.sleepThreshold;
			yield break;
		}

	}

	[Automation( "Physics/Set Sleep Threshold" )]
	class PhysicssleepThresholdSet4 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.sleepThreshold = Value;
			yield break;
		}

	}

	[Automation( "Physics/Get Queries Hit Triggers" )]
	class PhysicsqueriesHitTriggersGet5 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.queriesHitTriggers;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Set Queries Hit Triggers" )]
	class PhysicsqueriesHitTriggersSet5 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.queriesHitTriggers = Value;
			yield break;
		}

	}

	[Automation( "Physics/Raycast" )]
	class PhysicsRaycast0 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,out hitInfo,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Raycast Ray" )]
	class PhysicsRaycast1 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,out hitInfo,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Raycast All Ray" )]
	class PhysicsRaycastAll2 : Automation {

		public UnityEngine.Ray ray;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(ray,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Raycast All" )]
	class PhysicsRaycastAll3 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(origin,direction,maxDistance,layermask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Linecast" )]
	class PhysicsLinecast4 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public UnityEngine.RaycastHit hitInfo;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Linecast(start,end,out hitInfo,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Overlap Sphere" )]
	class PhysicsOverlapSphere5 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapSphere(position,radius,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Capsule Cast" )]
	class PhysicsCapsuleCast6 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,out hitInfo,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Sphere Cast" )]
	class PhysicsSphereCast7 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(origin,radius,direction,out hitInfo,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Sphere Cast Ray" )]
	class PhysicsSphereCast8 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,out hitInfo,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Capsule Cast All" )]
	class PhysicsCapsuleCastAll9 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastAll(point1,point2,radius,direction,maxDistance,layermask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll10 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(origin,radius,direction,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Sphere Cast All Ray" )]
	class PhysicsSphereCastAll11 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(ray,radius,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Check Sphere" )]
	class PhysicsCheckSphere12 : ConditionalAutomation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckSphere(position,radius,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Check Capsule" )]
	class PhysicsCheckCapsule13 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Single radius;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckCapsule(start,end,radius,layermask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Check Box" )]
	class PhysicsCheckBox14 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckBox(center,halfExtents,orientation,layermask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Overlap Box" )]
	class PhysicsOverlapBox15 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBox(center,halfExtents,orientation,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Box Cast All" )]
	class PhysicsBoxCastAll16 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastAll(center,halfExtents,direction,orientation,maxDistance,layermask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Physics/Box Cast" )]
	class PhysicsBoxCast17 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo,orientation,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics/Ignore Collision" )]
	class PhysicsIgnoreCollision18 : Automation {

		public UnityEngine.Collider collider1;
		public UnityEngine.Collider collider2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreCollision(collider1,collider2,ignore);
			yield break;
		}

	}

	[Automation( "Physics/Ignore Layer Collision" )]
	class PhysicsIgnoreLayerCollision19 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreLayerCollision(layer1,layer2,ignore);
			yield break;
		}

	}

	[Automation( "Physics/Get Ignore Layer Collision" )]
	class PhysicsGetIgnoreLayerCollision20 : ConditionalAutomation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.GetIgnoreLayerCollision(layer1,layer2);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
