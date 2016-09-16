using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio Low Pass Filter/Get Cutoff Frequency" )]
	class AudioLowPassFiltercutoffFrequencyGet0 : Automation {

		public UnityEngine.AudioLowPassFilter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.cutoffFrequency;
			yield break;
		}

	}

	[Automation( "Audio Low Pass Filter/Set Cutoff Frequency" )]
	class AudioLowPassFiltercutoffFrequencySet0 : Automation {

		public UnityEngine.AudioLowPassFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.cutoffFrequency = Value;
			yield break;
		}

	}

	[Automation( "Audio Low Pass Filter/Get Custom Cutoff Curve" )]
	class AudioLowPassFiltercustomCutoffCurveGet1 : Automation {

		public UnityEngine.AudioLowPassFilter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnimationCurve Result;

		public override IEnumerator Execute() {
			Result = Instance.customCutoffCurve;
			yield break;
		}

	}

	[Automation( "Audio Low Pass Filter/Set Custom Cutoff Curve" )]
	class AudioLowPassFiltercustomCutoffCurveSet1 : Automation {

		public UnityEngine.AudioLowPassFilter Instance;
		public UnityEngine.AnimationCurve Value;

		public override IEnumerator Execute() {
			Instance.customCutoffCurve = Value;
			yield break;
		}

	}

	[Automation( "Audio Low Pass Filter/Get Lowpass Resonance Q" )]
	class AudioLowPassFilterlowpassResonanceQGet2 : Automation {

		public UnityEngine.AudioLowPassFilter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.lowpassResonanceQ;
			yield break;
		}

	}

	[Automation( "Audio Low Pass Filter/Set Lowpass Resonance Q" )]
	class AudioLowPassFilterlowpassResonanceQSet2 : Automation {

		public UnityEngine.AudioLowPassFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.lowpassResonanceQ = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
