using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Colliders/Edge Collider 2D/Get Edge Count" )]
	class EdgeCollider2DedgeCountGet0 : Automation {

		public UnityEngine.EdgeCollider2D Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.edgeCount;
			yield break;
		}

	}

	[Automation( "Colliders/Edge Collider 2D/Get Point Count" )]
	class EdgeCollider2DpointCountGet1 : Automation {

		public UnityEngine.EdgeCollider2D Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.pointCount;
			yield break;
		}

	}

	[Automation( "Colliders/Edge Collider 2D/Get Points" )]
	class EdgeCollider2DpointsGet2 : Automation {

		public UnityEngine.EdgeCollider2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2[] Result;

		public override IEnumerator Execute() {
			Result = Instance.points;
			yield break;
		}

	}

	[Automation( "Colliders/Edge Collider 2D/Set Points" )]
	class EdgeCollider2DpointsSet2 : Automation {

		public UnityEngine.EdgeCollider2D Instance;
		public UnityEngine.Vector2[] Value;

		public override IEnumerator Execute() {
			Instance.points = Value;
			yield break;
		}

	}

	[Automation( "Colliders/Edge Collider 2D/Reset" )]
	class EdgeCollider2DReset0 : Automation {

		public UnityEngine.EdgeCollider2D Instance;

		public override IEnumerator Execute() {
			Instance.Reset();
			yield break;
		}

	}


#pragma warning restore 0649
}
