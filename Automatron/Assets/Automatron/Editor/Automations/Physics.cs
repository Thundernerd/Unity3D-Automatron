using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Generated/Physics/Get Ignore Raycast Layer" )]
	class PhysicsIgnoreRaycastLayerGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.IgnoreRaycastLayer;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Default Raycast Layers" )]
	class PhysicsDefaultRaycastLayersGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.DefaultRaycastLayers;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get All Layers" )]
	class PhysicsAllLayersGet2 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.AllLayers;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Gravity" )]
	class PhysicsgravityGet0 : Automation {

		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.gravity;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Set Gravity" )]
	class PhysicsgravitySet0 : Automation {

		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.gravity = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Default Contact Offset" )]
	class PhysicsdefaultContactOffsetGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.defaultContactOffset;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Set Default Contact Offset" )]
	class PhysicsdefaultContactOffsetSet1 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.defaultContactOffset = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Bounce Threshold" )]
	class PhysicsbounceThresholdGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.bounceThreshold;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Set Bounce Threshold" )]
	class PhysicsbounceThresholdSet2 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.bounceThreshold = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Solver Iteration Count" )]
	class PhysicssolverIterationCountGet3 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.solverIterationCount;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Set Solver Iteration Count" )]
	class PhysicssolverIterationCountSet3 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.solverIterationCount = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Sleep Threshold" )]
	class PhysicssleepThresholdGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.sleepThreshold;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Set Sleep Threshold" )]
	class PhysicssleepThresholdSet4 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.sleepThreshold = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Queries Hit Triggers" )]
	class PhysicsqueriesHitTriggersGet5 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.queriesHitTriggers;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Set Queries Hit Triggers" )]
	class PhysicsqueriesHitTriggersSet5 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics.queriesHitTriggers = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast0 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast1 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast2 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast3 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast4 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,out hitInfo,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast5 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,out hitInfo,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast6 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(origin,direction,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast7 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast8 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast9 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast10 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast11 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast12 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,out hitInfo,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast13 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,out hitInfo,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast14 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Raycast(ray,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Raycast" )]
	class PhysicsRaycast15 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll16 : Automation {

		public UnityEngine.Ray ray;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(ray,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll17 : Automation {

		public UnityEngine.Ray ray;
		public System.Single maxDistance;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(ray,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll18 : Automation {

		public UnityEngine.Ray ray;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(ray);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll19 : Automation {

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

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll20 : Automation {

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

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll21 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layermask;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(origin,direction,maxDistance,layermask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll22 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(origin,direction,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast All" )]
	class PhysicsRaycastAll23 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastAll(origin,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc24 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(ray,results,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc25 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(ray,results,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc26 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(ray,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc27 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(ray,results,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc28 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(origin,direction,results,maxDistance,layermask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc29 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(origin,direction,results,maxDistance,layermask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc30 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(origin,direction,results,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Raycast Non Alloc" )]
	class PhysicsRaycastNonAlloc31 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.RaycastNonAlloc(origin,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Linecast" )]
	class PhysicsLinecast32 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Linecast(start,end,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Linecast" )]
	class PhysicsLinecast33 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Linecast(start,end);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Linecast" )]
	class PhysicsLinecast34 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Linecast(start,end,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Linecast" )]
	class PhysicsLinecast35 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public UnityEngine.RaycastHit hitInfo;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Linecast(start,end,out hitInfo,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Linecast" )]
	class PhysicsLinecast36 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.Linecast(start,end,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Linecast" )]
	class PhysicsLinecast37 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Overlap Sphere" )]
	class PhysicsOverlapSphere38 : Automation {

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

	[Automation( "Generated/Physics/Overlap Sphere" )]
	class PhysicsOverlapSphere39 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapSphere(position,radius,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Sphere" )]
	class PhysicsOverlapSphere40 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapSphere(position,radius);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Sphere Non Alloc" )]
	class PhysicsOverlapSphereNonAlloc41 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public UnityEngine.Collider[] results;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapSphereNonAlloc(position,radius,results,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Sphere Non Alloc" )]
	class PhysicsOverlapSphereNonAlloc42 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public UnityEngine.Collider[] results;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapSphereNonAlloc(position,radius,results,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Sphere Non Alloc" )]
	class PhysicsOverlapSphereNonAlloc43 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public UnityEngine.Collider[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapSphereNonAlloc(position,radius,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast44 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast45 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast46 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast47 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast48 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,out hitInfo,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast49 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,out hitInfo,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast50 : ConditionalAutomation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Capsule Cast" )]
	class PhysicsCapsuleCast51 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast52 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(origin,radius,direction,out hitInfo,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast53 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(origin,radius,direction,out hitInfo,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast54 : ConditionalAutomation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(origin,radius,direction,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast55 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast56 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast57 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast58 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast59 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast60 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,out hitInfo,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast61 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,out hitInfo,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast62 : ConditionalAutomation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.SphereCast(ray,radius,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Sphere Cast" )]
	class PhysicsSphereCast63 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Capsule Cast All" )]
	class PhysicsCapsuleCastAll64 : Automation {

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

	[Automation( "Generated/Physics/Capsule Cast All" )]
	class PhysicsCapsuleCastAll65 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layermask;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastAll(point1,point2,radius,direction,maxDistance,layermask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast All" )]
	class PhysicsCapsuleCastAll66 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastAll(point1,point2,radius,direction,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast All" )]
	class PhysicsCapsuleCastAll67 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastAll(point1,point2,radius,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast Non Alloc" )]
	class PhysicsCapsuleCastNonAlloc68 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastNonAlloc(point1,point2,radius,direction,results,maxDistance,layermask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast Non Alloc" )]
	class PhysicsCapsuleCastNonAlloc69 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastNonAlloc(point1,point2,radius,direction,results,maxDistance,layermask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast Non Alloc" )]
	class PhysicsCapsuleCastNonAlloc70 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastNonAlloc(point1,point2,radius,direction,results,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Capsule Cast Non Alloc" )]
	class PhysicsCapsuleCastNonAlloc71 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCastNonAlloc(point1,point2,radius,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll72 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(origin,radius,direction,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll73 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(origin,radius,direction,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll74 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(origin,radius,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll75 : Automation {

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

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll76 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(ray,radius,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll77 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public System.Single maxDistance;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(ray,radius,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll78 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastAll(ray,radius);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast All" )]
	class PhysicsSphereCastAll79 : Automation {

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

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc80 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(origin,radius,direction,results,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc81 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(origin,radius,direction,results,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc82 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(origin,radius,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc83 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(origin,radius,direction,results,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc84 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(ray,radius,results,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc85 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(ray,radius,results,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc86 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(ray,radius,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Sphere Cast Non Alloc" )]
	class PhysicsSphereCastNonAlloc87 : Automation {

		public UnityEngine.Ray ray;
		public System.Single radius;
		public UnityEngine.RaycastHit[] results;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCastNonAlloc(ray,radius,results,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Check Sphere" )]
	class PhysicsCheckSphere88 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Check Sphere" )]
	class PhysicsCheckSphere89 : ConditionalAutomation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckSphere(position,radius,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Check Sphere" )]
	class PhysicsCheckSphere90 : ConditionalAutomation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckSphere(position,radius);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Check Capsule" )]
	class PhysicsCheckCapsule91 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Check Capsule" )]
	class PhysicsCheckCapsule92 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Single radius;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckCapsule(start,end,radius,layermask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Check Capsule" )]
	class PhysicsCheckCapsule93 : ConditionalAutomation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Single radius;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckCapsule(start,end,radius);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Check Box" )]
	class PhysicsCheckBox94 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Check Box" )]
	class PhysicsCheckBox95 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckBox(center,halfExtents,orientation,layermask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Check Box" )]
	class PhysicsCheckBox96 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckBox(center,halfExtents,orientation);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Check Box" )]
	class PhysicsCheckBox97 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.CheckBox(center,halfExtents);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Overlap Box" )]
	class PhysicsOverlapBox98 : Automation {

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

	[Automation( "Generated/Physics/Overlap Box" )]
	class PhysicsOverlapBox99 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBox(center,halfExtents,orientation,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Box" )]
	class PhysicsOverlapBox100 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBox(center,halfExtents,orientation);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Box" )]
	class PhysicsOverlapBox101 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		[ReadOnly]
		public UnityEngine.Collider[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBox(center,halfExtents);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Box Non Alloc" )]
	class PhysicsOverlapBoxNonAlloc102 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Collider[] results;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBoxNonAlloc(center,halfExtents,results,orientation,layerMask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Box Non Alloc" )]
	class PhysicsOverlapBoxNonAlloc103 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Collider[] results;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBoxNonAlloc(center,halfExtents,results,orientation,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Box Non Alloc" )]
	class PhysicsOverlapBoxNonAlloc104 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Collider[] results;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBoxNonAlloc(center,halfExtents,results,orientation);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Overlap Box Non Alloc" )]
	class PhysicsOverlapBoxNonAlloc105 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Collider[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.OverlapBoxNonAlloc(center,halfExtents,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast All" )]
	class PhysicsBoxCastAll106 : Automation {

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

	[Automation( "Generated/Physics/Box Cast All" )]
	class PhysicsBoxCastAll107 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layermask;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastAll(center,halfExtents,direction,orientation,maxDistance,layermask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast All" )]
	class PhysicsBoxCastAll108 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastAll(center,halfExtents,direction,orientation,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast All" )]
	class PhysicsBoxCastAll109 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastAll(center,halfExtents,direction,orientation);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast All" )]
	class PhysicsBoxCastAll110 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastAll(center,halfExtents,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast Non Alloc" )]
	class PhysicsBoxCastNonAlloc111 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layermask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastNonAlloc(center,halfExtents,direction,results,orientation,maxDistance,layermask,queryTriggerInteraction);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast Non Alloc" )]
	class PhysicsBoxCastNonAlloc112 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastNonAlloc(center,halfExtents,direction,results,orientation,maxDistance,layermask);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast Non Alloc" )]
	class PhysicsBoxCastNonAlloc113 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastNonAlloc(center,halfExtents,direction,results,orientation,maxDistance);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast Non Alloc" )]
	class PhysicsBoxCastNonAlloc114 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastNonAlloc(center,halfExtents,direction,results,orientation);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast Non Alloc" )]
	class PhysicsBoxCastNonAlloc115 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCastNonAlloc(center,halfExtents,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast116 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,orientation,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast117 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,orientation,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast118 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,orientation);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast119 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast120 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		public UnityEngine.QueryTriggerInteraction queryTriggerInteraction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,orientation,maxDistance,layerMask,queryTriggerInteraction);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast121 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo,orientation,maxDistance,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast122 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo,orientation,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast123 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public UnityEngine.Quaternion orientation;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo,orientation);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast124 : ConditionalAutomation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics/Box Cast" )]
	class PhysicsBoxCast125 : ConditionalAutomation {

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

	[Automation( "Generated/Physics/Ignore Collision" )]
	class PhysicsIgnoreCollision126 : Automation {

		public UnityEngine.Collider collider1;
		public UnityEngine.Collider collider2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreCollision(collider1,collider2,ignore);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Ignore Collision" )]
	class PhysicsIgnoreCollision127 : Automation {

		public UnityEngine.Collider collider1;
		public UnityEngine.Collider collider2;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreCollision(collider1,collider2);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Ignore Layer Collision" )]
	class PhysicsIgnoreLayerCollision128 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreLayerCollision(layer1,layer2,ignore);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Ignore Layer Collision" )]
	class PhysicsIgnoreLayerCollision129 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreLayerCollision(layer1,layer2);
			yield break;
		}

	}

	[Automation( "Generated/Physics/Get Ignore Layer Collision" )]
	class PhysicsGetIgnoreLayerCollision130 : ConditionalAutomation {

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
