#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mesh Collider/Get Shared Mesh" )]
	class MeshCollidersharedMeshGet0 : Automation {

		public UnityEngine.MeshCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Mesh Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMesh;
			yield break;
		}

	}

	[Automation( "Mesh Collider/Set Shared Mesh" )]
	class MeshCollidersharedMeshSet0 : Automation {

		public UnityEngine.MeshCollider Instance;
		public UnityEngine.Mesh Value;

		public override IEnumerator Execute() {
			Instance.sharedMesh = Value;
			yield break;
		}

	}

	[Automation( "Mesh Collider/Get Convex" )]
	class MeshColliderconvexGet1 : ConditionalAutomation {

		public UnityEngine.MeshCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.convex;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Mesh Collider/Set Convex" )]
	class MeshColliderconvexSet1 : Automation {

		public UnityEngine.MeshCollider Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.convex = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif