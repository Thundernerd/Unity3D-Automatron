using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Physics 2D/Get Ignore Raycast Layer" )]
	class Physics2DIgnoreRaycastLayerGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.IgnoreRaycastLayer;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Default Raycast Layers" )]
	class Physics2DDefaultRaycastLayersGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.DefaultRaycastLayers;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get All Layers" )]
	class Physics2DAllLayersGet2 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.AllLayers;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Velocity Iterations" )]
	class Physics2DvelocityIterationsGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.velocityIterations;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Velocity Iterations" )]
	class Physics2DvelocityIterationsSet0 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.velocityIterations = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Position Iterations" )]
	class Physics2DpositionIterationsGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.positionIterations;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Position Iterations" )]
	class Physics2DpositionIterationsSet1 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.positionIterations = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Gravity" )]
	class Physics2DgravityGet2 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.gravity;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Gravity" )]
	class Physics2DgravitySet2 : Automation {

		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.gravity = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Queries Hit Triggers" )]
	class Physics2DqueriesHitTriggersGet3 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.queriesHitTriggers;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Set Queries Hit Triggers" )]
	class Physics2DqueriesHitTriggersSet3 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.queriesHitTriggers = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Queries Start In Colliders" )]
	class Physics2DqueriesStartInCollidersGet4 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.queriesStartInColliders;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Set Queries Start In Colliders" )]
	class Physics2DqueriesStartInCollidersSet4 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.queriesStartInColliders = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Change Stops Callbacks" )]
	class Physics2DchangeStopsCallbacksGet5 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.changeStopsCallbacks;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Set Change Stops Callbacks" )]
	class Physics2DchangeStopsCallbacksSet5 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.changeStopsCallbacks = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Velocity Threshold" )]
	class Physics2DvelocityThresholdGet6 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.velocityThreshold;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Velocity Threshold" )]
	class Physics2DvelocityThresholdSet6 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.velocityThreshold = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Max Linear Correction" )]
	class Physics2DmaxLinearCorrectionGet7 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxLinearCorrection;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Max Linear Correction" )]
	class Physics2DmaxLinearCorrectionSet7 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxLinearCorrection = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Max Angular Correction" )]
	class Physics2DmaxAngularCorrectionGet8 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxAngularCorrection;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Max Angular Correction" )]
	class Physics2DmaxAngularCorrectionSet8 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxAngularCorrection = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Max Translation Speed" )]
	class Physics2DmaxTranslationSpeedGet9 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxTranslationSpeed;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Max Translation Speed" )]
	class Physics2DmaxTranslationSpeedSet9 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxTranslationSpeed = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Max Rotation Speed" )]
	class Physics2DmaxRotationSpeedGet10 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxRotationSpeed;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Max Rotation Speed" )]
	class Physics2DmaxRotationSpeedSet10 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxRotationSpeed = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Min Penetration For Penalty" )]
	class Physics2DminPenetrationForPenaltyGet11 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.minPenetrationForPenalty;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Min Penetration For Penalty" )]
	class Physics2DminPenetrationForPenaltySet11 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.minPenetrationForPenalty = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Baumgarte Scale" )]
	class Physics2DbaumgarteScaleGet12 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.baumgarteScale;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Baumgarte Scale" )]
	class Physics2DbaumgarteScaleSet12 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.baumgarteScale = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Baumgarte TOI Scale" )]
	class Physics2DbaumgarteTOIScaleGet13 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.baumgarteTOIScale;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Baumgarte TOI Scale" )]
	class Physics2DbaumgarteTOIScaleSet13 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.baumgarteTOIScale = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Time To Sleep" )]
	class Physics2DtimeToSleepGet14 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.timeToSleep;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Time To Sleep" )]
	class Physics2DtimeToSleepSet14 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.timeToSleep = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Linear Sleep Tolerance" )]
	class Physics2DlinearSleepToleranceGet15 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.linearSleepTolerance;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Linear Sleep Tolerance" )]
	class Physics2DlinearSleepToleranceSet15 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.linearSleepTolerance = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Angular Sleep Tolerance" )]
	class Physics2DangularSleepToleranceGet16 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.angularSleepTolerance;
			yield break;
		}

	}

	[Automation( "Physics 2D/Set Angular Sleep Tolerance" )]
	class Physics2DangularSleepToleranceSet16 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.angularSleepTolerance = Value;
			yield break;
		}

	}

	[Automation( "Physics 2D/Ignore Collision" )]
	class Physics2DIgnoreCollision0 : Automation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreCollision(collider1,collider2,ignore);
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Ignore Collision" )]
	class Physics2DGetIgnoreCollision1 : ConditionalAutomation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.GetIgnoreCollision(collider1,collider2);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Ignore Layer Collision" )]
	class Physics2DIgnoreLayerCollision2 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreLayerCollision(layer1,layer2,ignore);
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Ignore Layer Collision" )]
	class Physics2DGetIgnoreLayerCollision3 : ConditionalAutomation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.GetIgnoreLayerCollision(layer1,layer2);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Is Touching" )]
	class Physics2DIsTouching4 : ConditionalAutomation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.IsTouching(collider1,collider2);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Is Touching Layers" )]
	class Physics2DIsTouchingLayers5 : ConditionalAutomation {

		public UnityEngine.Collider2D collider;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.IsTouchingLayers(collider,layerMask);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Physics 2D/Linecast" )]
	class Physics2DLinecast6 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Linecast(start,end,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Linecast All" )]
	class Physics2DLinecastAll7 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastAll(start,end,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Raycast" )]
	class Physics2DRaycast8 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Raycast(origin,direction,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Raycast All" )]
	class Physics2DRaycastAll9 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastAll(origin,direction,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Circle Cast" )]
	class Physics2DCircleCast10 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCast(origin,radius,direction,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Circle Cast All" )]
	class Physics2DCircleCastAll11 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastAll(origin,radius,direction,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Box Cast" )]
	class Physics2DBoxCast12 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCast(origin,size,angle,direction,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Box Cast All" )]
	class Physics2DBoxCastAll13 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastAll(origin,size,angle,direction,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Ray Intersection" )]
	class Physics2DGetRayIntersection14 : Automation {

		public UnityEngine.Ray ray;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersection(ray,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Ray Intersection All" )]
	class Physics2DGetRayIntersectionAll15 : Automation {

		public UnityEngine.Ray ray;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionAll(ray,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Point" )]
	class Physics2DOverlapPoint16 : Automation {

		public UnityEngine.Vector2 point;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPoint(point,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Point All" )]
	class Physics2DOverlapPointAll17 : Automation {

		public UnityEngine.Vector2 point;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointAll(point,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Circle" )]
	class Physics2DOverlapCircle18 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircle(point,radius,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Circle All" )]
	class Physics2DOverlapCircleAll19 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleAll(point,radius,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Area" )]
	class Physics2DOverlapArea20 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapArea(pointA,pointB,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Area All" )]
	class Physics2DOverlapAreaAll21 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaAll(pointA,pointB,layerMask,minDepth,maxDepth);
			yield break;
		}

	}


#pragma warning restore 0649
}
