#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mesh Utility/Set Per Triangle UV2" )]
	class MeshUtilitySetPerTriangleUV20 : Automation {

		public UnityEngine.Mesh src;
		public UnityEngine.Vector2[] triUV;

		public override IEnumerator Execute() {
			UnityEditor.MeshUtility.SetPerTriangleUV2(src,triUV);
			yield break;
		}

	}

	[Automation( "Mesh Utility/Set Mesh Compression" )]
	class MeshUtilitySetMeshCompression1 : Automation {

		public UnityEngine.Mesh mesh;
		public UnityEditor.ModelImporterMeshCompression compression;

		public override IEnumerator Execute() {
			UnityEditor.MeshUtility.SetMeshCompression(mesh,compression);
			yield break;
		}

	}

	[Automation( "Mesh Utility/Get Mesh Compression" )]
	class MeshUtilityGetMeshCompression2 : Automation {

		public UnityEngine.Mesh mesh;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterMeshCompression Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MeshUtility.GetMeshCompression(mesh);
			yield break;
		}

	}

	[Automation( "Mesh Utility/Optimize" )]
	class MeshUtilityOptimize3 : Automation {

		public UnityEngine.Mesh mesh;

		public override IEnumerator Execute() {
			UnityEditor.MeshUtility.Optimize(mesh);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif