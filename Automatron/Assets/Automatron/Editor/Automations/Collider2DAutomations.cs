#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Collider 2D/Get Density" )]
	class Collider2DdensityGet0 : Automation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.density;
			yield break;
		}

	}

	[Automation( "Collider 2D/Set Density" )]
	class Collider2DdensitySet0 : Automation {

		public UnityEngine.Collider2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.density = Value;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Is Trigger" )]
	class Collider2DisTriggerGet1 : ConditionalAutomation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isTrigger;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Collider 2D/Set Is Trigger" )]
	class Collider2DisTriggerSet1 : Automation {

		public UnityEngine.Collider2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isTrigger = Value;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Used By Effector" )]
	class Collider2DusedByEffectorGet2 : ConditionalAutomation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.usedByEffector;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Collider 2D/Set Used By Effector" )]
	class Collider2DusedByEffectorSet2 : Automation {

		public UnityEngine.Collider2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.usedByEffector = Value;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Offset" )]
	class Collider2DoffsetGet3 : Automation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.offset;
			yield break;
		}

	}

	[Automation( "Collider 2D/Set Offset" )]
	class Collider2DoffsetSet3 : Automation {

		public UnityEngine.Collider2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.offset = Value;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Attached Rigidbody" )]
	class Collider2DattachedRigidbodyGet4 : Automation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rigidbody2D Result;

		public override IEnumerator Execute() {
			Result = Instance.attachedRigidbody;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Shape Count" )]
	class Collider2DshapeCountGet5 : Automation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.shapeCount;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Bounds" )]
	class Collider2DboundsGet6 : Automation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.bounds;
			yield break;
		}

	}

	[Automation( "Collider 2D/Get Shared Material" )]
	class Collider2DsharedMaterialGet7 : Automation {

		public UnityEngine.Collider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.PhysicsMaterial2D Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMaterial;
			yield break;
		}

	}

	[Automation( "Collider 2D/Set Shared Material" )]
	class Collider2DsharedMaterialSet7 : Automation {

		public UnityEngine.Collider2D Instance;
		public UnityEngine.PhysicsMaterial2D Value;

		public override IEnumerator Execute() {
			Instance.sharedMaterial = Value;
			yield break;
		}

	}

	[Automation( "Collider 2D/Is Touching" )]
	class Collider2DIsTouching0 : ConditionalAutomation {

		public UnityEngine.Collider2D Instance;
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

	[Automation( "Collider 2D/Is Touching Layers" )]
	class Collider2DIsTouchingLayers1 : ConditionalAutomation {

		public UnityEngine.Collider2D Instance;
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

	[Automation( "Collider 2D/Overlap Point" )]
	class Collider2DOverlapPoint2 : ConditionalAutomation {

		public UnityEngine.Collider2D Instance;
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

	[Automation( "Collider 2D/Raycast" )]
	class Collider2DRaycast3 : Automation {

		public UnityEngine.Collider2D Instance;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Int32 layerMask;
		public System.Single minDepth;
		public System.Single maxDepth;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Raycast(direction,results,distance,layerMask,minDepth,maxDepth);
			yield break;
		}

	}

	[Automation( "Collider 2D/Cast" )]
	class Collider2DCast4 : Automation {

		public UnityEngine.Collider2D Instance;
		public UnityEngine.Vector2 direction;
		public UnityEngine.RaycastHit2D[] results;
		public System.Single distance;
		public System.Boolean ignoreSiblingColliders;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Cast(direction,results,distance,ignoreSiblingColliders);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif