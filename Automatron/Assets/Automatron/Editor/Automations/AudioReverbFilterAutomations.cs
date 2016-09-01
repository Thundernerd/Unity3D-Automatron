using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio Reverb Filter/Get Reverb Preset" )]
	class AudioReverbFilterreverbPresetGet0 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public UnityEngine.AudioReverbPreset Result;

		public override IEnumerator Execute() {
			Result = Instance.reverbPreset;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Reverb Preset" )]
	class AudioReverbFilterreverbPresetSet0 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public UnityEngine.AudioReverbPreset Value;

		public override IEnumerator Execute() {
			Instance.reverbPreset = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Dry Level" )]
	class AudioReverbFilterdryLevelGet1 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dryLevel;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Dry Level" )]
	class AudioReverbFilterdryLevelSet1 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dryLevel = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Room" )]
	class AudioReverbFilterroomGet2 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.room;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Room" )]
	class AudioReverbFilterroomSet2 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.room = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Room HF" )]
	class AudioReverbFilterroomHFGet3 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.roomHF;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Room HF" )]
	class AudioReverbFilterroomHFSet3 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.roomHF = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Room Rolloff" )]
	class AudioReverbFilterroomRolloffGet4 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.roomRolloff;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Room Rolloff" )]
	class AudioReverbFilterroomRolloffSet4 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.roomRolloff = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Decay Time" )]
	class AudioReverbFilterdecayTimeGet5 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.decayTime;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Decay Time" )]
	class AudioReverbFilterdecayTimeSet5 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.decayTime = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Decay HF Ratio" )]
	class AudioReverbFilterdecayHFRatioGet6 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.decayHFRatio;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Decay HF Ratio" )]
	class AudioReverbFilterdecayHFRatioSet6 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.decayHFRatio = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Reflections Level" )]
	class AudioReverbFilterreflectionsLevelGet7 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionsLevel;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Reflections Level" )]
	class AudioReverbFilterreflectionsLevelSet7 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reflectionsLevel = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Reflections Delay" )]
	class AudioReverbFilterreflectionsDelayGet8 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionsDelay;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Reflections Delay" )]
	class AudioReverbFilterreflectionsDelaySet8 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reflectionsDelay = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Reverb Level" )]
	class AudioReverbFilterreverbLevelGet9 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reverbLevel;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Reverb Level" )]
	class AudioReverbFilterreverbLevelSet9 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reverbLevel = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Reverb Delay" )]
	class AudioReverbFilterreverbDelayGet10 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reverbDelay;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Reverb Delay" )]
	class AudioReverbFilterreverbDelaySet10 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reverbDelay = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Diffusion" )]
	class AudioReverbFilterdiffusionGet11 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.diffusion;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Diffusion" )]
	class AudioReverbFilterdiffusionSet11 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.diffusion = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Density" )]
	class AudioReverbFilterdensityGet12 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.density;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Density" )]
	class AudioReverbFilterdensitySet12 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.density = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Hf Reference" )]
	class AudioReverbFilterhfReferenceGet13 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.hfReference;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Hf Reference" )]
	class AudioReverbFilterhfReferenceSet13 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.hfReference = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Room LF" )]
	class AudioReverbFilterroomLFGet14 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.roomLF;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Room LF" )]
	class AudioReverbFilterroomLFSet14 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.roomLF = Value;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Get Lf Reference" )]
	class AudioReverbFilterlfReferenceGet15 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.lfReference;
			yield break;
		}

	}

	[Automation( "Audio Reverb Filter/Set Lf Reference" )]
	class AudioReverbFilterlfReferenceSet15 : Automation {

		public UnityEngine.AudioReverbFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.lfReference = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
