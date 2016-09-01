using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Colliders/Collider/Get Enabled" )]
	class ColliderenabledGet0 : ConditionalAutomation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Colliders/Collider/Set Enabled" )]
	class ColliderenabledSet0 : Automation {

		public UnityEngine.Collider Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Get Attached Rigidbody" )]
	class ColliderattachedRigidbodyGet1 : Automation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public UnityEngine.Rigidbody Result;

		public override IEnumerator Execute() {
			Result = Instance.attachedRigidbody;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Get Is Trigger" )]
	class ColliderisTriggerGet2 : ConditionalAutomation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isTrigger;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Colliders/Collider/Set Is Trigger" )]
	class ColliderisTriggerSet2 : Automation {

		public UnityEngine.Collider Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isTrigger = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Get Contact Offset" )]
	class CollidercontactOffsetGet3 : Automation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.contactOffset;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Set Contact Offset" )]
	class CollidercontactOffsetSet3 : Automation {

		public UnityEngine.Collider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.contactOffset = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Get Material" )]
	class CollidermaterialGet4 : Automation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public UnityEngine.PhysicMaterial Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Set Material" )]
	class CollidermaterialSet4 : Automation {

		public UnityEngine.Collider Instance;
		public UnityEngine.PhysicMaterial Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Get Shared Material" )]
	class CollidersharedMaterialGet5 : Automation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public UnityEngine.PhysicMaterial Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMaterial;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Set Shared Material" )]
	class CollidersharedMaterialSet5 : Automation {

		public UnityEngine.Collider Instance;
		public UnityEngine.PhysicMaterial Value;

		public override IEnumerator Execute() {
			Instance.sharedMaterial = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Get Bounds" )]
	class ColliderboundsGet6 : Automation {

		public UnityEngine.Collider Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.bounds;
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Closest Point On Bounds" )]
	class ColliderClosestPointOnBounds0 : Automation {

		public UnityEngine.Collider Instance;
		public UnityEngine.Vector3 position;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ClosestPointOnBounds(position);
			yield break;
		}

	}

	[Automation( "Colliders/Collider/Raycast" )]
	class ColliderRaycast1 : ConditionalAutomation {

		public UnityEngine.Collider Instance;
		public UnityEngine.Ray ray;
		public UnityEngine.RaycastHit hitInfo;
		public System.Single maxDistance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.Raycast(ray,out hitInfo,maxDistance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
