#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Polygon Collider 2D/Get Points" )]
	class PolygonCollider2DpointsGet0 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2[] Result;

		public override IEnumerator Execute() {
			Result = Instance.points;
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Set Points" )]
	class PolygonCollider2DpointsSet0 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		public UnityEngine.Vector2[] Value;

		public override IEnumerator Execute() {
			Instance.points = Value;
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Get Path Count" )]
	class PolygonCollider2DpathCountGet1 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.pathCount;
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Set Path Count" )]
	class PolygonCollider2DpathCountSet1 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.pathCount = Value;
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Get Path" )]
	class PolygonCollider2DGetPath0 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		public System.Int32 index;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPath(index);
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Set Path" )]
	class PolygonCollider2DSetPath1 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		public System.Int32 index;
		public UnityEngine.Vector2[] points;

		public override IEnumerator Execute() {
			Instance.SetPath(index,points);
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Get Total Point Count" )]
	class PolygonCollider2DGetTotalPointCount2 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetTotalPointCount();
			yield break;
		}

	}

	[Automation( "Polygon Collider 2D/Create Primitive" )]
	class PolygonCollider2DCreatePrimitive3 : Automation {

		public UnityEngine.PolygonCollider2D Instance;
		public System.Int32 sides;
		public UnityEngine.Vector2 scale;
		public UnityEngine.Vector2 offset;

		public override IEnumerator Execute() {
			Instance.CreatePrimitive(sides,scale,offset);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif