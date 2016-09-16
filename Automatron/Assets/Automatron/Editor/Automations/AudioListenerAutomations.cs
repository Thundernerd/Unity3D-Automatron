using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio Listener/Get Volume" )]
	class AudioListenervolumeGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.AudioListener.volume;
			yield break;
		}

	}

	[Automation( "Audio Listener/Set Volume" )]
	class AudioListenervolumeSet0 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.AudioListener.volume = Value;
			yield break;
		}

	}

	[Automation( "Audio Listener/Get Pause" )]
	class AudioListenerpauseGet1 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.AudioListener.pause;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Listener/Set Pause" )]
	class AudioListenerpauseSet1 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.AudioListener.pause = Value;
			yield break;
		}

	}

	[Automation( "Audio Listener/Get Velocity Update Mode" )]
	class AudioListenervelocityUpdateModeGet2 : Automation {

		public UnityEngine.AudioListener Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AudioVelocityUpdateMode Result;

		public override IEnumerator Execute() {
			Result = Instance.velocityUpdateMode;
			yield break;
		}

	}

	[Automation( "Audio Listener/Set Velocity Update Mode" )]
	class AudioListenervelocityUpdateModeSet2 : Automation {

		public UnityEngine.AudioListener Instance;
		public UnityEngine.AudioVelocityUpdateMode Value;

		public override IEnumerator Execute() {
			Instance.velocityUpdateMode = Value;
			yield break;
		}

	}

	[Automation( "Audio Listener/Get Output Data" )]
	class AudioListenerGetOutputData0 : Automation {

		public System.Single[] samples;
		public System.Int32 channel;

		public override IEnumerator Execute() {
			UnityEngine.AudioListener.GetOutputData(samples,channel);
			yield break;
		}

	}

	[Automation( "Audio Listener/Get Spectrum Data" )]
	class AudioListenerGetSpectrumData1 : Automation {

		public System.Single[] samples;
		public System.Int32 channel;
		public UnityEngine.FFTWindow window;

		public override IEnumerator Execute() {
			UnityEngine.AudioListener.GetSpectrumData(samples,channel,window);
			yield break;
		}

	}


#pragma warning restore 0649
}
