using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

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
	class Physics2DGetIgnoreCollision2 : Automation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetIgnoreCollision(collider1,collider2);
			yield break;
		}

	}

	[Automation( "Physics 2D/Ignore Layer Collision" )]
	class Physics2DIgnoreLayerCollision3 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics2D.IgnoreLayerCollision(layer1,layer2,ignore);
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Ignore Layer Collision" )]
	class Physics2DGetIgnoreLayerCollision5 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetIgnoreLayerCollision(layer1,layer2);
			yield break;
		}

	}

	[Automation( "Physics 2D/Is Touching" )]
	class Physics2DIsTouching6 : Automation {

		public UnityEngine.Collider2D collider1;
		public UnityEngine.Collider2D collider2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.IsTouching(collider1,collider2);
			yield break;
		}

	}

	[Automation( "Physics 2D/Is Touching Layers Advanced" )]
	class Physics2DIsTouchingLayers7 : Automation {

		public UnityEngine.Collider2D collider;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.IsTouchingLayers(collider,layerMask);
			yield break;
		}

	}

	[Automation( "Physics 2D/Is Touching Layers Simple" )]
	class Physics2DIsTouchingLayers8 : Automation {

		public UnityEngine.Collider2D collider;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.IsTouchingLayers(collider);
			yield break;
		}

	}

	[Automation( "Physics 2D/Linecast Simple" )]
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

	[Automation( "Physics 2D/Linecast Advanced" )]
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

	[Automation( "Physics 2D/Linecast All Advanced" )]
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

	[Automation( "Physics 2D/Linecast All Simple" )]
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

	[Automation( "Physics 2D/Raycast Simple" )]
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

	[Automation( "Physics 2D/Raycast Advanced" )]
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

	[Automation( "Physics 2D/Raycast All Advanced" )]
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

	[Automation( "Physics 2D/Raycast All Simple" )]
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

	[Automation( "Physics 2D/Circle Cast Simple" )]
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

	[Automation( "Physics 2D/Circle Cast Advanced" )]
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

	[Automation( "Physics 2D/Circle Cast All Advanced" )]
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

	[Automation( "Physics 2D/Circle Cast All Simple" )]
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

	[Automation( "Physics 2D/Box Cast Simple" )]
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

	[Automation( "Physics 2D/Box Cast Advanced" )]
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

	[Automation( "Physics 2D/Box Cast All" )]
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

	[Automation( "Physics 2D/Get Ray Intersection Simple" )]
	class Physics2DGetRayIntersection67 : Automation {

		public UnityEngine.Ray ray;
		[ReadOnly]
		public UnityEngine.RaycastHit2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersection(ray);
			yield break;
		}

	}

	[Automation( "Physics 2D/Get Ray Intersection Advanced" )]
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

	[Automation( "Physics 2D/Get Ray Intersection All Advanced" )]
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

	[Automation( "Physics 2D/Get Ray Intersection All Simple" )]
	class Physics2DGetRayIntersectionAll71 : Automation {

		public UnityEngine.Ray ray;
		[ReadOnly]
		public UnityEngine.RaycastHit2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.GetRayIntersectionAll(ray);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Point Advanced" )]
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

	[Automation( "Physics 2D/Overlap Point Simple" )]
	class Physics2DOverlapPoint78 : Automation {

		public UnityEngine.Vector2 point;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPoint(point);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Point All Advanced" )]
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

	[Automation( "Physics 2D/Overlap Point All Simple" )]
	class Physics2DOverlapPointAll82 : Automation {

		public UnityEngine.Vector2 point;
		[ReadOnly]
		public UnityEngine.Collider2D[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics2D.OverlapPointAll(point);
			yield break;
		}

	}

	[Automation( "Physics 2D/Overlap Circle Advanced" )]
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

	[Automation( "Physics 2D/Overlap Circle Simple" )]
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

	[Automation( "Physics 2D/Overlap Circle All Advanced" )]
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

	[Automation( "Physics 2D/Overlap Circle All Simple" )]
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

	[Automation( "Physics 2D/Overlap Area Advanced" )]
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

	[Automation( "Physics 2D/Overlap Area Simple" )]
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

	[Automation( "Physics 2D/Overlap Area All Advanced" )]
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

	[Automation( "Physics 2D/Overlap Area All Simple" )]
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


#pragma warning restore 0649
}
