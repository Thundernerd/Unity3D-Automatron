using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Physics/Raycast Advanced" )]
	class PhysicsRaycast0 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Raycast(origin,direction,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Raycast Simple" )]
	class PhysicsRaycast2 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Raycast(origin,direction);
			yield break;
		}

	}

	[Automation( "Physics/Raycast Advanced (out)" )]
	class PhysicsRaycast4 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Raycast(origin,direction,out hitInfo,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Raycast Simple (out)" )]
	class PhysicsRaycast6 : Automation {

		public UnityEngine.Vector3 origin;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Raycast(origin,direction,out hitInfo);
			yield break;
		}

	}

	[Automation( "Physics/Raycast All Advanced" )]
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

	[Automation( "Physics/Raycast All Simple" )]
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

	[Automation( "Physics/Linecast Advanced" )]
	class PhysicsLinecast32 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Linecast(start,end,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Linecast Simple" )]
	class PhysicsLinecast33 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Linecast(start,end);
			yield break;
		}

	}

	[Automation( "Physics/Linecast Advanced (out)" )]
	class PhysicsLinecast35 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public UnityEngine.RaycastHit hitInfo;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Linecast(start,end,out hitInfo,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Linecast Simple (out)" )]
	class PhysicsLinecast36 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.Linecast(start,end,out hitInfo);
			yield break;
		}

	}

	[Automation( "Physics/Overlap Sphere Advanced" )]
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

	[Automation( "Physics/Overlap Sphere Simple" )]
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

	[Automation( "Physics/Capsule Cast Advanced" )]
	class PhysicsCapsuleCast44 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Capsule Cast Simple" )]
	class PhysicsCapsuleCast46 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction);
			yield break;
		}

	}

	[Automation( "Physics/Capsule Cast Advanced (out)" )]
	class PhysicsCapsuleCast48 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,out hitInfo,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Capsule Cast Simple (out)" )]
	class PhysicsCapsuleCast50 : Automation {

		public UnityEngine.Vector3 point1;
		public UnityEngine.Vector3 point2;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CapsuleCast(point1,point2,radius,direction,out hitInfo);
			yield break;
		}

	}

	[Automation( "Physics/Sphere Cast Advanced (out)" )]
	class PhysicsSphereCast52 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCast(origin,radius,direction,out hitInfo,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Sphere Cast Simple (out)" )]
	class PhysicsSphereCast54 : Automation {

		public UnityEngine.Vector3 origin;
		public System.Single radius;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.SphereCast(origin,radius,direction,out hitInfo);
			yield break;
		}

	}

	[Automation( "Physics/Capsule Cast All Advanced" )]
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

	[Automation( "Physics/Capsule Cast All Simple" )]
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

	[Automation( "Physics/Sphere Cast All Advanced" )]
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

	[Automation( "Physics/Sphere Cast All Simple" )]
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

	[Automation( "Physics/Check Sphere Advanced" )]
	class PhysicsCheckSphere89 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CheckSphere(position,radius,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Check Sphere Simple" )]
	class PhysicsCheckSphere90 : Automation {

		public UnityEngine.Vector3 position;
		public System.Single radius;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CheckSphere(position,radius);
			yield break;
		}

	}

	[Automation( "Physics/Check Capsule Advanced" )]
	class PhysicsCheckCapsule92 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Single radius;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CheckCapsule(start,end,radius,layermask);
			yield break;
		}

	}

	[Automation( "Physics/Check Capsule Simple" )]
	class PhysicsCheckCapsule93 : Automation {

		public UnityEngine.Vector3 start;
		public UnityEngine.Vector3 end;
		public System.Single radius;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CheckCapsule(start,end,radius);
			yield break;
		}

	}

	[Automation( "Physics/Check Box Advanced" )]
	class PhysicsCheckBox95 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Quaternion orientation;
		public System.Int32 layermask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CheckBox(center,halfExtents,orientation,layermask);
			yield break;
		}

	}

	[Automation( "Physics/Check Box Simple" )]
	class PhysicsCheckBox97 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.CheckBox(center,halfExtents);
			yield break;
		}

	}

	[Automation( "Physics/Overlap Box Advanced" )]
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

	[Automation( "Physics/Overlap Box Simple" )]
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

	[Automation( "Physics/Box Cast All Advanced" )]
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

	[Automation( "Physics/Box Cast All Simple" )]
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
    
	[Automation( "Physics/Box Cast Advanced" )]
	class PhysicsBoxCast116 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,orientation,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Box Cast Simple" )]
	class PhysicsBoxCast119 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction);
			yield break;
		}

	}

	[Automation( "Physics/Box Cast Advanced (out)" )]
	class PhysicsBoxCast121 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		public UnityEngine.Quaternion orientation;
		public System.Single maxDistance;
		public System.Int32 layerMask;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo,orientation,maxDistance,layerMask);
			yield break;
		}

	}

	[Automation( "Physics/Box Cast Simple (out)" )]
	class PhysicsBoxCast124 : Automation {

		public UnityEngine.Vector3 center;
		public UnityEngine.Vector3 halfExtents;
		public UnityEngine.Vector3 direction;
		public UnityEngine.RaycastHit hitInfo;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.BoxCast(center,halfExtents,direction,out hitInfo);
			yield break;
		}

	}

	[Automation( "Physics/Ignore Collision" )]
	class PhysicsIgnoreCollision126 : Automation {

		public UnityEngine.Collider collider1;
		public UnityEngine.Collider collider2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreCollision(collider1,collider2,ignore);
			yield break;
		}

	}

	[Automation( "Physics/Ignore Layer Collision" )]
	class PhysicsIgnoreLayerCollision128 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		public System.Boolean ignore;

		public override IEnumerator Execute() {
			UnityEngine.Physics.IgnoreLayerCollision(layer1,layer2,ignore);
			yield break;
		}

	}

	[Automation( "Physics/Get Ignore Layer Collision" )]
	class PhysicsGetIgnoreLayerCollision130 : Automation {

		public System.Int32 layer1;
		public System.Int32 layer2;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Physics.GetIgnoreLayerCollision(layer1,layer2);
			yield break;
		}

	}


#pragma warning restore 0649
}
