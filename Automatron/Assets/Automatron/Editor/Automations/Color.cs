using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Color/Lerp" )]
	class ColorLerp0 : Automation {

		public UnityEngine.Color a;
		public UnityEngine.Color b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Color/Lerp Unclamped" )]
	class ColorLerpUnclamped1 : Automation {

		public UnityEngine.Color a;
		public UnityEngine.Color b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Color/RGB To HSV" )]
	class ColorRGBToHSV2 : Automation {

		public UnityEngine.Color rgbColor;
		public System.Single H;
		public System.Single S;
		public System.Single V;

		public override IEnumerator Execute() {
			UnityEngine.Color.RGBToHSV(rgbColor,out H,out S,out V);
			yield break;
		}

	}

	[Automation( "Color/HSV To RGB" )]
	class ColorHSVToRGB4 : Automation {

		public System.Single H;
		public System.Single S;
		public System.Single V;
		public System.Boolean hdr;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.HSVToRGB(H,S,V,hdr);
			yield break;
		}

	}


#pragma warning restore 0649
}
