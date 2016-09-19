#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Bounds/Get Center" )]
	class BoundscenterGet0 : Automation {

		public UnityEngine.Bounds Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Bounds/Set Center" )]
	class BoundscenterSet0 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Bounds/Get Size" )]
	class BoundssizeGet1 : Automation {

		public UnityEngine.Bounds Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Bounds/Set Size" )]
	class BoundssizeSet1 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}

	[Automation( "Bounds/Get Extents" )]
	class BoundsextentsGet2 : Automation {

		public UnityEngine.Bounds Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.extents;
			yield break;
		}

	}

	[Automation( "Bounds/Set Extents" )]
	class BoundsextentsSet2 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.extents = Value;
			yield break;
		}

	}

	[Automation( "Bounds/Get Min" )]
	class BoundsminGet3 : Automation {

		public UnityEngine.Bounds Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.min;
			yield break;
		}

	}

	[Automation( "Bounds/Set Min" )]
	class BoundsminSet3 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.min = Value;
			yield break;
		}

	}

	[Automation( "Bounds/Get Max" )]
	class BoundsmaxGet4 : Automation {

		public UnityEngine.Bounds Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.max;
			yield break;
		}

	}

	[Automation( "Bounds/Set Max" )]
	class BoundsmaxSet4 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.max = Value;
			yield break;
		}

	}

	[Automation( "Bounds/Equals" )]
	class BoundsEquals0 : ConditionalAutomation {

		public UnityEngine.Bounds Instance;
		public System.Object other;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(other);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Bounds/Set Min Max" )]
	class BoundsSetMinMax1 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 min;
		public UnityEngine.Vector3 max;

		public override IEnumerator Execute() {
			Instance.SetMinMax(min,max);
			yield break;
		}

	}

	[Automation( "Bounds/Encapsulate" )]
	class BoundsEncapsulate2 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 point;

		public override IEnumerator Execute() {
			Instance.Encapsulate(point);
			yield break;
		}

	}

	[Automation( "Bounds/Expand" )]
	class BoundsExpand3 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 amount;

		public override IEnumerator Execute() {
			Instance.Expand(amount);
			yield break;
		}

	}

	[Automation( "Bounds/Intersects" )]
	class BoundsIntersects4 : ConditionalAutomation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Bounds bounds;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Intersects(bounds);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Bounds/Contains" )]
	class BoundsContains5 : ConditionalAutomation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Contains(point);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Bounds/Sqr Distance" )]
	class BoundsSqrDistance6 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.SqrDistance(point);
			yield break;
		}

	}

	[Automation( "Bounds/Intersect Ray" )]
	class BoundsIntersectRay7 : ConditionalAutomation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Ray ray;
		public System.Single distance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IntersectRay(ray,out distance);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Bounds/Closest Point" )]
	class BoundsClosestPoint8 : Automation {

		public UnityEngine.Bounds Instance;
		public UnityEngine.Vector3 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.ClosestPoint(point);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif