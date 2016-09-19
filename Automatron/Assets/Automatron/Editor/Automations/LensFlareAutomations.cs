#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Lens Flare/Get Flare" )]
	class LensFlareflareGet0 : Automation {

		public UnityEngine.LensFlare Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Flare Result;

		public override IEnumerator Execute() {
			Result = Instance.flare;
			yield break;
		}

	}

	[Automation( "Lens Flare/Set Flare" )]
	class LensFlareflareSet0 : Automation {

		public UnityEngine.LensFlare Instance;
		public UnityEngine.Flare Value;

		public override IEnumerator Execute() {
			Instance.flare = Value;
			yield break;
		}

	}

	[Automation( "Lens Flare/Get Brightness" )]
	class LensFlarebrightnessGet1 : Automation {

		public UnityEngine.LensFlare Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.brightness;
			yield break;
		}

	}

	[Automation( "Lens Flare/Set Brightness" )]
	class LensFlarebrightnessSet1 : Automation {

		public UnityEngine.LensFlare Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.brightness = Value;
			yield break;
		}

	}

	[Automation( "Lens Flare/Get Fade Speed" )]
	class LensFlarefadeSpeedGet2 : Automation {

		public UnityEngine.LensFlare Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fadeSpeed;
			yield break;
		}

	}

	[Automation( "Lens Flare/Set Fade Speed" )]
	class LensFlarefadeSpeedSet2 : Automation {

		public UnityEngine.LensFlare Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.fadeSpeed = Value;
			yield break;
		}

	}

	[Automation( "Lens Flare/Get Color" )]
	class LensFlarecolorGet3 : Automation {

		public UnityEngine.LensFlare Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "Lens Flare/Set Color" )]
	class LensFlarecolorSet3 : Automation {

		public UnityEngine.LensFlare Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif