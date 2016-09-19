#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "LOD Utility/Calculate LOD Group Bounding Box" )]
	class LODUtilityCalculateLODGroupBoundingBox0 : Automation {

		public UnityEngine.LODGroup group;

		public override IEnumerator Execute() {
			UnityEditor.LODUtility.CalculateLODGroupBoundingBox(group);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif