using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Generated/Physics 2D/Get Ignore Raycast Layer" )]
	class Physics2DIgnoreRaycastLayerGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.IgnoreRaycastLayer;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Default Raycast Layers" )]
	class Physics2DDefaultRaycastLayersGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.DefaultRaycastLayers;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get All Layers" )]
	class Physics2DAllLayersGet2 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.AllLayers;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Velocity Iterations" )]
	class Physics2DvelocityIterationsGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.velocityIterations;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Velocity Iterations" )]
	class Physics2DvelocityIterationsSet0 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.velocityIterations = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Position Iterations" )]
	class Physics2DpositionIterationsGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.positionIterations;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Position Iterations" )]
	class Physics2DpositionIterationsSet1 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.positionIterations = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Gravity" )]
	class Physics2DgravityGet2 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.gravity;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Gravity" )]
	class Physics2DgravitySet2 : Automation {

		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.gravity = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Queries Hit Triggers" )]
	class Physics2DqueriesHitTriggersGet3 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.queriesHitTriggers;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Queries Hit Triggers" )]
	class Physics2DqueriesHitTriggersSet3 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.queriesHitTriggers = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Queries Start In Colliders" )]
	class Physics2DqueriesStartInCollidersGet4 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.queriesStartInColliders;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Queries Start In Colliders" )]
	class Physics2DqueriesStartInCollidersSet4 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.queriesStartInColliders = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Change Stops Callbacks" )]
	class Physics2DchangeStopsCallbacksGet5 : Automation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.changeStopsCallbacks;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Change Stops Callbacks" )]
	class Physics2DchangeStopsCallbacksSet5 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.changeStopsCallbacks = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Velocity Threshold" )]
	class Physics2DvelocityThresholdGet6 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.velocityThreshold;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Velocity Threshold" )]
	class Physics2DvelocityThresholdSet6 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.velocityThreshold = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Max Linear Correction" )]
	class Physics2DmaxLinearCorrectionGet7 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxLinearCorrection;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Max Linear Correction" )]
	class Physics2DmaxLinearCorrectionSet7 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxLinearCorrection = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Max Angular Correction" )]
	class Physics2DmaxAngularCorrectionGet8 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxAngularCorrection;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Max Angular Correction" )]
	class Physics2DmaxAngularCorrectionSet8 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxAngularCorrection = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Max Translation Speed" )]
	class Physics2DmaxTranslationSpeedGet9 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxTranslationSpeed;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Max Translation Speed" )]
	class Physics2DmaxTranslationSpeedSet9 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxTranslationSpeed = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Max Rotation Speed" )]
	class Physics2DmaxRotationSpeedGet10 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.maxRotationSpeed;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Max Rotation Speed" )]
	class Physics2DmaxRotationSpeedSet10 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.maxRotationSpeed = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Min Penetration For Penalty" )]
	class Physics2DminPenetrationForPenaltyGet11 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.minPenetrationForPenalty;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Min Penetration For Penalty" )]
	class Physics2DminPenetrationForPenaltySet11 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.minPenetrationForPenalty = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Baumgarte Scale" )]
	class Physics2DbaumgarteScaleGet12 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.baumgarteScale;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Baumgarte Scale" )]
	class Physics2DbaumgarteScaleSet12 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.baumgarteScale = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Baumgarte TOI Scale" )]
	class Physics2DbaumgarteTOIScaleGet13 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.baumgarteTOIScale;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Baumgarte TOI Scale" )]
	class Physics2DbaumgarteTOIScaleSet13 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.baumgarteTOIScale = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Time To Sleep" )]
	class Physics2DtimeToSleepGet14 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.timeToSleep;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Time To Sleep" )]
	class Physics2DtimeToSleepSet14 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.timeToSleep = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Linear Sleep Tolerance" )]
	class Physics2DlinearSleepToleranceGet15 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.linearSleepTolerance;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Linear Sleep Tolerance" )]
	class Physics2DlinearSleepToleranceSet15 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.linearSleepTolerance = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Angular Sleep Tolerance" )]
	class Physics2DangularSleepToleranceGet16 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.angularSleepTolerance;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Set Angular Sleep Tolerance" )]
	class Physics2DangularSleepToleranceSet16 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.angularSleepTolerance = Value;
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Ignore Collision" )]
	class Physics2DIgnoreCollision0 : Automation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreCollision(collider1,collider2,ignore);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Ignore Collision" )]
	class Physics2DIgnoreCollision1 : Automation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreCollision(collider1,collider2);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ignore Collision" )]
	class Physics2DGetIgnoreCollision2 : ConditionalAutomation {

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

	[Automation( "Generated/Physics 2D/Ignore Layer Collision" )]
	class Physics2DIgnoreLayerCollision3 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreLayerCollision(layer1,layer2,ignore);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Ignore Layer Collision" )]
	class Physics2DIgnoreLayerCollision4 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreLayerCollision(layer1,layer2);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ignore Layer Collision" )]
	class Physics2DGetIgnoreLayerCollision5 : ConditionalAutomation {

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

	[Automation( "Generated/Physics 2D/Is Touching" )]
	class Physics2DIsTouching6 : ConditionalAutomation {

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

	[Automation( "Generated/Physics 2D/Is Touching Layers" )]
	class Physics2DIsTouchingLayers7 : ConditionalAutomation {

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

	[Automation( "Generated/Physics 2D/Is Touching Layers" )]
	class Physics2DIsTouchingLayers8 : ConditionalAutomation {

		public UnityEngine.Collider2D collider;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Physics2D.IsTouchingLayers(collider);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Physics 2D/Linecast" )]
	class Physics2DLinecast9 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Linecast(start,end,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast" )]
	class Physics2DLinecast10 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Linecast(start,end,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast" )]
	class Physics2DLinecast11 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Linecast(start,end);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast" )]
	class Physics2DLinecast12 : Automation {

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

	[Automation( "Generated/Physics 2D/Linecast All" )]
	class Physics2DLinecastAll13 : Automation {

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

	[Automation( "Generated/Physics 2D/Linecast All" )]
	class Physics2DLinecastAll14 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastAll(start,end,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast All" )]
	class Physics2DLinecastAll15 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastAll(start,end,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast All" )]
	class Physics2DLinecastAll16 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastAll(start,end);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast Non Alloc" )]
	class Physics2DLinecastNonAlloc17 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public UnityEngine.RaycastHit2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastNonAlloc(start,end,results,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast Non Alloc" )]
	class Physics2DLinecastNonAlloc18 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public UnityEngine.RaycastHit2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastNonAlloc(start,end,results,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast Non Alloc" )]
	class Physics2DLinecastNonAlloc19 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public UnityEngine.RaycastHit2D[] results;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastNonAlloc(start,end,results,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Linecast Non Alloc" )]
	class Physics2DLinecastNonAlloc20 : Automation {

		public UnityEngine.Vector2 start;
		public UnityEngine.Vector2 end;
		public UnityEngine.RaycastHit2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.LinecastNonAlloc(start,end,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast" )]
	class Physics2DRaycast21 : Automation {

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

	[Automation( "Generated/Physics 2D/Raycast" )]
	class Physics2DRaycast22 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Raycast(origin,direction,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast" )]
	class Physics2DRaycast23 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Raycast(origin,direction,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast" )]
	class Physics2DRaycast24 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Raycast(origin,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast" )]
	class Physics2DRaycast25 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.Raycast(origin,direction,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast All" )]
	class Physics2DRaycastAll26 : Automation {

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

	[Automation( "Generated/Physics 2D/Raycast All" )]
	class Physics2DRaycastAll27 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastAll(origin,direction,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast All" )]
	class Physics2DRaycastAll28 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastAll(origin,direction,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast All" )]
	class Physics2DRaycastAll29 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastAll(origin,direction,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast All" )]
	class Physics2DRaycastAll30 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastAll(origin,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast Non Alloc" )]
	class Physics2DRaycastNonAlloc31 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastNonAlloc(origin,direction,results,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast Non Alloc" )]
	class Physics2DRaycastNonAlloc32 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastNonAlloc(origin,direction,results,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast Non Alloc" )]
	class Physics2DRaycastNonAlloc33 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastNonAlloc(origin,direction,results,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast Non Alloc" )]
	class Physics2DRaycastNonAlloc34 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastNonAlloc(origin,direction,results,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Raycast Non Alloc" )]
	class Physics2DRaycastNonAlloc35 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.RaycastNonAlloc(origin,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast" )]
	class Physics2DCircleCast36 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCast(origin,radius,direction,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast" )]
	class Physics2DCircleCast37 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCast(origin,radius,direction,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast" )]
	class Physics2DCircleCast38 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCast(origin,radius,direction,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast" )]
	class Physics2DCircleCast39 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCast(origin,radius,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast" )]
	class Physics2DCircleCast40 : Automation {

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

	[Automation( "Generated/Physics 2D/Circle Cast All" )]
	class Physics2DCircleCastAll41 : Automation {

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

	[Automation( "Generated/Physics 2D/Circle Cast All" )]
	class Physics2DCircleCastAll42 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastAll(origin,radius,direction,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast All" )]
	class Physics2DCircleCastAll43 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastAll(origin,radius,direction,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast All" )]
	class Physics2DCircleCastAll44 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastAll(origin,radius,direction,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast All" )]
	class Physics2DCircleCastAll45 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastAll(origin,radius,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast Non Alloc" )]
	class Physics2DCircleCastNonAlloc46 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastNonAlloc(origin,radius,direction,results,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast Non Alloc" )]
	class Physics2DCircleCastNonAlloc47 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastNonAlloc(origin,radius,direction,results,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast Non Alloc" )]
	class Physics2DCircleCastNonAlloc48 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastNonAlloc(origin,radius,direction,results,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast Non Alloc" )]
	class Physics2DCircleCastNonAlloc49 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastNonAlloc(origin,radius,direction,results,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Circle Cast Non Alloc" )]
	class Physics2DCircleCastNonAlloc50 : Automation {

		public UnityEngine.Vector2 origin;
		public System.Single radius;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.CircleCastNonAlloc(origin,radius,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast" )]
	class Physics2DBoxCast51 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCast(origin,size,angle,direction,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast" )]
	class Physics2DBoxCast52 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCast(origin,size,angle,direction,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast" )]
	class Physics2DBoxCast53 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCast(origin,size,angle,direction,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast" )]
	class Physics2DBoxCast54 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCast(origin,size,angle,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast" )]
	class Physics2DBoxCast55 : Automation {

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

	[Automation( "Generated/Physics 2D/Box Cast All" )]
	class Physics2DBoxCastAll56 : Automation {

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

	[Automation( "Generated/Physics 2D/Box Cast All" )]
	class Physics2DBoxCastAll57 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastAll(origin,size,angle,direction,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast All" )]
	class Physics2DBoxCastAll58 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastAll(origin,size,angle,direction,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast All" )]
	class Physics2DBoxCastAll59 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastAll(origin,size,angle,direction,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast All" )]
	class Physics2DBoxCastAll60 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastAll(origin,size,angle,direction);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast Non Alloc" )]
	class Physics2DBoxCastNonAlloc61 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastNonAlloc(origin,size,angle,direction,results,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast Non Alloc" )]
	class Physics2DBoxCastNonAlloc62 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastNonAlloc(origin,size,angle,direction,results,distance,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast Non Alloc" )]
	class Physics2DBoxCastNonAlloc63 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastNonAlloc(origin,size,angle,direction,results,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast Non Alloc" )]
	class Physics2DBoxCastNonAlloc64 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastNonAlloc(origin,size,angle,direction,results,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Box Cast Non Alloc" )]
	class Physics2DBoxCastNonAlloc65 : Automation {

		public UnityEngine.Vector2 origin;
		public UnityEngine.Vector2 size;
		public System.Single angle;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.BoxCastNonAlloc(origin,size,angle,direction,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection" )]
	class Physics2DGetRayIntersection66 : Automation {

		public UnityEngine.Ray ray;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersection(ray,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection" )]
	class Physics2DGetRayIntersection67 : Automation {

		public UnityEngine.Ray ray;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersection(ray);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection" )]
	class Physics2DGetRayIntersection68 : Automation {

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

	[Automation( "Generated/Physics 2D/Get Ray Intersection All" )]
	class Physics2DGetRayIntersectionAll69 : Automation {

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

	[Automation( "Generated/Physics 2D/Get Ray Intersection All" )]
	class Physics2DGetRayIntersectionAll70 : Automation {

		public UnityEngine.Ray ray;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionAll(ray,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection All" )]
	class Physics2DGetRayIntersectionAll71 : Automation {

		public UnityEngine.Ray ray;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionAll(ray);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection Non Alloc" )]
	class Physics2DGetRayIntersectionNonAlloc72 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionNonAlloc(ray,results,distance,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection Non Alloc" )]
	class Physics2DGetRayIntersectionNonAlloc73 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionNonAlloc(ray,results,distance);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Get Ray Intersection Non Alloc" )]
	class Physics2DGetRayIntersectionNonAlloc74 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionNonAlloc(ray,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point" )]
	class Physics2DOverlapPoint75 : Automation {

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

	[Automation( "Generated/Physics 2D/Overlap Point" )]
	class Physics2DOverlapPoint76 : Automation {

		public UnityEngine.Vector2 point;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPoint(point,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point" )]
	class Physics2DOverlapPoint77 : Automation {

		public UnityEngine.Vector2 point;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPoint(point,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point" )]
	class Physics2DOverlapPoint78 : Automation {

		public UnityEngine.Vector2 point;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPoint(point);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point All" )]
	class Physics2DOverlapPointAll79 : Automation {

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

	[Automation( "Generated/Physics 2D/Overlap Point All" )]
	class Physics2DOverlapPointAll80 : Automation {

		public UnityEngine.Vector2 point;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointAll(point,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point All" )]
	class Physics2DOverlapPointAll81 : Automation {

		public UnityEngine.Vector2 point;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointAll(point,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point All" )]
	class Physics2DOverlapPointAll82 : Automation {

		public UnityEngine.Vector2 point;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointAll(point);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point Non Alloc" )]
	class Physics2DOverlapPointNonAlloc83 : Automation {

		public UnityEngine.Vector2 point;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointNonAlloc(point,results,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point Non Alloc" )]
	class Physics2DOverlapPointNonAlloc84 : Automation {

		public UnityEngine.Vector2 point;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointNonAlloc(point,results,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point Non Alloc" )]
	class Physics2DOverlapPointNonAlloc85 : Automation {

		public UnityEngine.Vector2 point;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointNonAlloc(point,results,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Point Non Alloc" )]
	class Physics2DOverlapPointNonAlloc86 : Automation {

		public UnityEngine.Vector2 point;
		public UnityEngine.Collider2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointNonAlloc(point,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle" )]
	class Physics2DOverlapCircle87 : Automation {

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

	[Automation( "Generated/Physics 2D/Overlap Circle" )]
	class Physics2DOverlapCircle88 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircle(point,radius,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle" )]
	class Physics2DOverlapCircle89 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircle(point,radius,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle" )]
	class Physics2DOverlapCircle90 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircle(point,radius);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle All" )]
	class Physics2DOverlapCircleAll91 : Automation {

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

	[Automation( "Generated/Physics 2D/Overlap Circle All" )]
	class Physics2DOverlapCircleAll92 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleAll(point,radius,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle All" )]
	class Physics2DOverlapCircleAll93 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleAll(point,radius,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle All" )]
	class Physics2DOverlapCircleAll94 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleAll(point,radius);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle Non Alloc" )]
	class Physics2DOverlapCircleNonAlloc95 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleNonAlloc(point,radius,results,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle Non Alloc" )]
	class Physics2DOverlapCircleNonAlloc96 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleNonAlloc(point,radius,results,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle Non Alloc" )]
	class Physics2DOverlapCircleNonAlloc97 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleNonAlloc(point,radius,results,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Circle Non Alloc" )]
	class Physics2DOverlapCircleNonAlloc98 : Automation {

		public UnityEngine.Vector2 point;
		public System.Single radius;
		public UnityEngine.Collider2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapCircleNonAlloc(point,radius,results);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area" )]
	class Physics2DOverlapArea99 : Automation {

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

	[Automation( "Generated/Physics 2D/Overlap Area" )]
	class Physics2DOverlapArea100 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapArea(pointA,pointB,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area" )]
	class Physics2DOverlapArea101 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapArea(pointA,pointB,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area" )]
	class Physics2DOverlapArea102 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapArea(pointA,pointB);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area All" )]
	class Physics2DOverlapAreaAll103 : Automation {

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

	[Automation( "Generated/Physics 2D/Overlap Area All" )]
	class Physics2DOverlapAreaAll104 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaAll(pointA,pointB,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area All" )]
	class Physics2DOverlapAreaAll105 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public System.Int32 layerMask;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaAll(pointA,pointB,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area All" )]
	class Physics2DOverlapAreaAll106 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaAll(pointA,pointB);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area Non Alloc" )]
	class Physics2DOverlapAreaNonAlloc107 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaNonAlloc(pointA,pointB,results,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area Non Alloc" )]
	class Physics2DOverlapAreaNonAlloc108 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		public System.Single minDepth;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaNonAlloc(pointA,pointB,results,layerMask,minDepth);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area Non Alloc" )]
	class Physics2DOverlapAreaNonAlloc109 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public UnityEngine.Collider2D[] results;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaNonAlloc(pointA,pointB,results,layerMask);
			yield break;
		}

	}

	[Automation( "Generated/Physics 2D/Overlap Area Non Alloc" )]
	class Physics2DOverlapAreaNonAlloc110 : Automation {

		public UnityEngine.Vector2 pointA;
		public UnityEngine.Vector2 pointB;
		public UnityEngine.Collider2D[] results;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapAreaNonAlloc(pointA,pointB,results);
			yield break;
		}

	}


#pragma warning restore 0649
}
