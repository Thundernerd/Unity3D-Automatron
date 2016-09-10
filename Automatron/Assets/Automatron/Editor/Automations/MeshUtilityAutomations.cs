using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Mesh Utility/Set Per Triangle UV2" )]
	class MeshUtilitySetPerTriangleUV20 : Automation {

		public UnityEngine.Mesh src;
		public UnityEngine.Vector2[] triUV;

		public override IEnumerator Execute() {
			UnityEditor.MeshUtility.SetPerTriangleUV2(src,triUV);
			yield break;
		}

	}

	[Automation( "Utilities/Mesh Utility/Optimize" )]
	class MeshUtilityOptimize1 : Automation {

		public UnityEngine.Mesh mesh;

		public override IEnumerator Execute() {
			UnityEditor.MeshUtility.Optimize(mesh);
			yield break;
		}

	}


#pragma warning restore 0649
}
