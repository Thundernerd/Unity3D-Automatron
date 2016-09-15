using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Geometry Utility/Calculate Frustum Planes" )]
	class GeometryUtilityCalculateFrustumPlanes0 : Automation {

		public UnityEngine.Camera camera;
		[ReadOnly]
		public UnityEngine.Plane[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GeometryUtility.CalculateFrustumPlanes(camera);
			yield break;
		}

	}

	[Automation( "Geometry Utility/Test Planes AABB" )]
	class GeometryUtilityTestPlanesAABB2 : ConditionalAutomation {

		public UnityEngine.Plane[] planes;
		public UnityEngine.Bounds bounds;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.GeometryUtility.TestPlanesAABB(planes,bounds);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
