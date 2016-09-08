using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio/Audio Echo Filter/Get Delay" )]
	class AudioEchoFilterdelayGet0 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.delay;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Set Delay" )]
	class AudioEchoFilterdelaySet0 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.delay = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Get Decay Ratio" )]
	class AudioEchoFilterdecayRatioGet1 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.decayRatio;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Set Decay Ratio" )]
	class AudioEchoFilterdecayRatioSet1 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.decayRatio = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Get Dry Mix" )]
	class AudioEchoFilterdryMixGet2 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dryMix;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Set Dry Mix" )]
	class AudioEchoFilterdryMixSet2 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dryMix = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Get Wet Mix" )]
	class AudioEchoFilterwetMixGet3 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.wetMix;
			yield break;
		}

	}

	[Automation( "Audio/Audio Echo Filter/Set Wet Mix" )]
	class AudioEchoFilterwetMixSet3 : Automation {

		public UnityEngine.AudioEchoFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.wetMix = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
