using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mesh Filter/Get Mesh" )]
	class MeshFiltermeshGet0 : Automation {

		public UnityEngine.MeshFilter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Mesh Result;

		public override IEnumerator Execute() {
			Result = Instance.mesh;
			yield break;
		}

	}

	[Automation( "Mesh Filter/Set Mesh" )]
	class MeshFiltermeshSet0 : Automation {

		public UnityEngine.MeshFilter Instance;
		public UnityEngine.Mesh Value;

		public override IEnumerator Execute() {
			Instance.mesh = Value;
			yield break;
		}

	}

	[Automation( "Mesh Filter/Get Shared Mesh" )]
	class MeshFiltersharedMeshGet1 : Automation {

		public UnityEngine.MeshFilter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Mesh Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMesh;
			yield break;
		}

	}

	[Automation( "Mesh Filter/Set Shared Mesh" )]
	class MeshFiltersharedMeshSet1 : Automation {

		public UnityEngine.MeshFilter Instance;
		public UnityEngine.Mesh Value;

		public override IEnumerator Execute() {
			Instance.sharedMesh = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
