using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio/Audio High Pass Filter/Get Cutoff Frequency" )]
	class AudioHighPassFiltercutoffFrequencyGet0 : Automation {

		public UnityEngine.AudioHighPassFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.cutoffFrequency;
			yield break;
		}

	}

	[Automation( "Audio/Audio High Pass Filter/Set Cutoff Frequency" )]
	class AudioHighPassFiltercutoffFrequencySet0 : Automation {

		public UnityEngine.AudioHighPassFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.cutoffFrequency = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio High Pass Filter/Get Highpass Resonance Q" )]
	class AudioHighPassFilterhighpassResonanceQGet1 : Automation {

		public UnityEngine.AudioHighPassFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.highpassResonanceQ;
			yield break;
		}

	}

	[Automation( "Audio/Audio High Pass Filter/Set Highpass Resonance Q" )]
	class AudioHighPassFilterhighpassResonanceQSet1 : Automation {

		public UnityEngine.AudioHighPassFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.highpassResonanceQ = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
