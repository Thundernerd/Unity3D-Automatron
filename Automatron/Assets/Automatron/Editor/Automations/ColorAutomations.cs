#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Color/Get R" )]
	class ColorrGet0 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.r;
			yield break;
		}

	}

	[Automation( "Color/Set R" )]
	class ColorrSet0 : Automation {

		public UnityEngine.Color Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.r = Value;
			yield break;
		}

	}

	[Automation( "Color/Get G" )]
	class ColorgGet1 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.g;
			yield break;
		}

	}

	[Automation( "Color/Set G" )]
	class ColorgSet1 : Automation {

		public UnityEngine.Color Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.g = Value;
			yield break;
		}

	}

	[Automation( "Color/Get B" )]
	class ColorbGet2 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.b;
			yield break;
		}

	}

	[Automation( "Color/Set B" )]
	class ColorbSet2 : Automation {

		public UnityEngine.Color Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.b = Value;
			yield break;
		}

	}

	[Automation( "Color/Get A" )]
	class ColoraGet3 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.a;
			yield break;
		}

	}

	[Automation( "Color/Set A" )]
	class ColoraSet3 : Automation {

		public UnityEngine.Color Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.a = Value;
			yield break;
		}

	}

	[Automation( "Color/Get Red" )]
	class ColorredGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.red;
			yield break;
		}

	}

	[Automation( "Color/Get Green" )]
	class ColorgreenGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.green;
			yield break;
		}

	}

	[Automation( "Color/Get Blue" )]
	class ColorblueGet2 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.blue;
			yield break;
		}

	}

	[Automation( "Color/Get White" )]
	class ColorwhiteGet3 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.white;
			yield break;
		}

	}

	[Automation( "Color/Get Black" )]
	class ColorblackGet4 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.black;
			yield break;
		}

	}

	[Automation( "Color/Get Yellow" )]
	class ColoryellowGet5 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.yellow;
			yield break;
		}

	}

	[Automation( "Color/Get Cyan" )]
	class ColorcyanGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.cyan;
			yield break;
		}

	}

	[Automation( "Color/Get Magenta" )]
	class ColormagentaGet7 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.magenta;
			yield break;
		}

	}

	[Automation( "Color/Get Gray" )]
	class ColorgrayGet8 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.gray;
			yield break;
		}

	}

	[Automation( "Color/Get Grey" )]
	class ColorgreyGet9 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.grey;
			yield break;
		}

	}

	[Automation( "Color/Get Clear" )]
	class ColorclearGet10 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.clear;
			yield break;
		}

	}

	[Automation( "Color/Get Grayscale" )]
	class ColorgrayscaleGet11 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.grayscale;
			yield break;
		}

	}

	[Automation( "Color/Get Linear" )]
	class ColorlinearGet12 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.linear;
			yield break;
		}

	}

	[Automation( "Color/Get Gamma" )]
	class ColorgammaGet13 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.gamma;
			yield break;
		}

	}

	[Automation( "Color/Get Max Color Component" )]
	class ColormaxColorComponentGet14 : Automation {

		public UnityEngine.Color Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxColorComponent;
			yield break;
		}

	}

	[Automation( "Color/Equals" )]
	class ColorEquals0 : ConditionalAutomation {

		public UnityEngine.Color Instance;
		public System.Object other;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(other);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Color/Lerp" )]
	class ColorLerp1 : Automation {

		public UnityEngine.Color a;
		public UnityEngine.Color b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Color/Lerp Unclamped" )]
	class ColorLerpUnclamped2 : Automation {

		public UnityEngine.Color a;
		public UnityEngine.Color b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Color/RGB To HSV" )]
	class ColorRGBToHSV3 : Automation {

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
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color.HSVToRGB(H,S,V,hdr);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif