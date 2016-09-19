#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Animator Utility/Optimize Transform Hierarchy" )]
	class AnimatorUtilityOptimizeTransformHierarchy0 : Automation {

		public UnityEngine.GameObject go;
		public System.String[] exposedTransforms;

		public override IEnumerator Execute() {
			UnityEngine.AnimatorUtility.OptimizeTransformHierarchy(go,exposedTransforms);
			yield break;
		}

	}

	[Automation( "Animator Utility/Deoptimize Transform Hierarchy" )]
	class AnimatorUtilityDeoptimizeTransformHierarchy1 : Automation {

		public UnityEngine.GameObject go;

		public override IEnumerator Execute() {
			UnityEngine.AnimatorUtility.DeoptimizeTransformHierarchy(go);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif