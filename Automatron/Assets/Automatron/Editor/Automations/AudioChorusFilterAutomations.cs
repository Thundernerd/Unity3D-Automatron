using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio Chorus Filter/Get Dry Mix" )]
	class AudioChorusFilterdryMixGet0 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dryMix;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Dry Mix" )]
	class AudioChorusFilterdryMixSet0 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dryMix = Value;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Get Wet Mix 1" )]
	class AudioChorusFilterwetMix1Get1 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.wetMix1;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Wet Mix 1" )]
	class AudioChorusFilterwetMix1Set1 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.wetMix1 = Value;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Get Wet Mix 2" )]
	class AudioChorusFilterwetMix2Get2 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.wetMix2;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Wet Mix 2" )]
	class AudioChorusFilterwetMix2Set2 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.wetMix2 = Value;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Get Wet Mix 3" )]
	class AudioChorusFilterwetMix3Get3 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.wetMix3;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Wet Mix 3" )]
	class AudioChorusFilterwetMix3Set3 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.wetMix3 = Value;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Get Delay" )]
	class AudioChorusFilterdelayGet4 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.delay;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Delay" )]
	class AudioChorusFilterdelaySet4 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.delay = Value;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Get Rate" )]
	class AudioChorusFilterrateGet5 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.rate;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Rate" )]
	class AudioChorusFilterrateSet5 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.rate = Value;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Get Depth" )]
	class AudioChorusFilterdepthGet6 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.depth;
			yield break;
		}

	}

	[Automation( "Audio Chorus Filter/Set Depth" )]
	class AudioChorusFilterdepthSet6 : Automation {

		public UnityEngine.AudioChorusFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.depth = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
