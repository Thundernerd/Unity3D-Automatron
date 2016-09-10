using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio/Audio Reverb Zone/Get Min Distance" )]
	class AudioReverbZoneminDistanceGet0 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minDistance;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Min Distance" )]
	class AudioReverbZoneminDistanceSet0 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minDistance = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Max Distance" )]
	class AudioReverbZonemaxDistanceGet1 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxDistance;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Max Distance" )]
	class AudioReverbZonemaxDistanceSet1 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxDistance = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Reverb Preset" )]
	class AudioReverbZonereverbPresetGet2 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public UnityEngine.AudioReverbPreset Result;

		public override IEnumerator Execute() {
			Result = Instance.reverbPreset;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Reverb Preset" )]
	class AudioReverbZonereverbPresetSet2 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public UnityEngine.AudioReverbPreset Value;

		public override IEnumerator Execute() {
			Instance.reverbPreset = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Room" )]
	class AudioReverbZoneroomGet3 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.room;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Room" )]
	class AudioReverbZoneroomSet3 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.room = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Room HF" )]
	class AudioReverbZoneroomHFGet4 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.roomHF;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Room HF" )]
	class AudioReverbZoneroomHFSet4 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.roomHF = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Room LF" )]
	class AudioReverbZoneroomLFGet5 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.roomLF;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Room LF" )]
	class AudioReverbZoneroomLFSet5 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.roomLF = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Decay Time" )]
	class AudioReverbZonedecayTimeGet6 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.decayTime;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Decay Time" )]
	class AudioReverbZonedecayTimeSet6 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.decayTime = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Decay HF Ratio" )]
	class AudioReverbZonedecayHFRatioGet7 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.decayHFRatio;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Decay HF Ratio" )]
	class AudioReverbZonedecayHFRatioSet7 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.decayHFRatio = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Reflections" )]
	class AudioReverbZonereflectionsGet8 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.reflections;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Reflections" )]
	class AudioReverbZonereflectionsSet8 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.reflections = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Reflections Delay" )]
	class AudioReverbZonereflectionsDelayGet9 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionsDelay;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Reflections Delay" )]
	class AudioReverbZonereflectionsDelaySet9 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reflectionsDelay = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Reverb" )]
	class AudioReverbZonereverbGet10 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.reverb;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Reverb" )]
	class AudioReverbZonereverbSet10 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.reverb = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Reverb Delay" )]
	class AudioReverbZonereverbDelayGet11 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reverbDelay;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Reverb Delay" )]
	class AudioReverbZonereverbDelaySet11 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reverbDelay = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get HF Reference" )]
	class AudioReverbZoneHFReferenceGet12 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.HFReference;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set HF Reference" )]
	class AudioReverbZoneHFReferenceSet12 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.HFReference = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get LF Reference" )]
	class AudioReverbZoneLFReferenceGet13 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.LFReference;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set LF Reference" )]
	class AudioReverbZoneLFReferenceSet13 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.LFReference = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Room Rolloff Factor" )]
	class AudioReverbZoneroomRolloffFactorGet14 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.roomRolloffFactor;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Room Rolloff Factor" )]
	class AudioReverbZoneroomRolloffFactorSet14 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.roomRolloffFactor = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Diffusion" )]
	class AudioReverbZonediffusionGet15 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.diffusion;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Diffusion" )]
	class AudioReverbZonediffusionSet15 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.diffusion = Value;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Get Density" )]
	class AudioReverbZonedensityGet16 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.density;
			yield break;
		}

	}

	[Automation( "Audio/Audio Reverb Zone/Set Density" )]
	class AudioReverbZonedensitySet16 : Automation {

		public UnityEngine.AudioReverbZone Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.density = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
