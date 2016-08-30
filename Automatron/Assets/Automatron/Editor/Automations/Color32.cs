using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Color 32/Lerp" )]
	class Color32Lerp0 : Automation {

		public UnityEngine.Color32 a;
		public UnityEngine.Color32 b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Color32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color32.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Color 32/Lerp Unclamped" )]
	class Color32LerpUnclamped1 : Automation {

		public UnityEngine.Color32 a;
		public UnityEngine.Color32 b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Color32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color32.LerpUnclamped(a,b,t);
			yield break;
		}

	}


#pragma warning restore 0649
}
