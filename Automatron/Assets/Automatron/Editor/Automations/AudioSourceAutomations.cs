using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio Source/Get Volume" )]
	class AudioSourcevolumeGet0 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.volume;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Volume" )]
	class AudioSourcevolumeSet0 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.volume = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Pitch" )]
	class AudioSourcepitchGet1 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.pitch;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Pitch" )]
	class AudioSourcepitchSet1 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.pitch = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Time" )]
	class AudioSourcetimeGet2 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.time;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Time" )]
	class AudioSourcetimeSet2 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.time = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Time Samples" )]
	class AudioSourcetimeSamplesGet3 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.timeSamples;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Time Samples" )]
	class AudioSourcetimeSamplesSet3 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.timeSamples = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Clip" )]
	class AudioSourceclipGet4 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public UnityEngine.AudioClip Result;

		public override IEnumerator Execute() {
			Result = Instance.clip;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Clip" )]
	class AudioSourceclipSet4 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.AudioClip Value;

		public override IEnumerator Execute() {
			Instance.clip = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Output Audio Mixer Group" )]
	class AudioSourceoutputAudioMixerGroupGet5 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public UnityEngine.Audio.AudioMixerGroup Result;

		public override IEnumerator Execute() {
			Result = Instance.outputAudioMixerGroup;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Output Audio Mixer Group" )]
	class AudioSourceoutputAudioMixerGroupSet5 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.Audio.AudioMixerGroup Value;

		public override IEnumerator Execute() {
			Instance.outputAudioMixerGroup = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Is Playing" )]
	class AudioSourceisPlayingGet6 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPlaying;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Get Is Virtual" )]
	class AudioSourceisVirtualGet7 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isVirtual;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Get Loop" )]
	class AudioSourceloopGet8 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.loop;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Loop" )]
	class AudioSourceloopSet8 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.loop = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Ignore Listener Volume" )]
	class AudioSourceignoreListenerVolumeGet9 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.ignoreListenerVolume;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Ignore Listener Volume" )]
	class AudioSourceignoreListenerVolumeSet9 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.ignoreListenerVolume = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Play On Awake" )]
	class AudioSourceplayOnAwakeGet10 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.playOnAwake;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Play On Awake" )]
	class AudioSourceplayOnAwakeSet10 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.playOnAwake = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Ignore Listener Pause" )]
	class AudioSourceignoreListenerPauseGet11 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.ignoreListenerPause;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Ignore Listener Pause" )]
	class AudioSourceignoreListenerPauseSet11 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.ignoreListenerPause = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Velocity Update Mode" )]
	class AudioSourcevelocityUpdateModeGet12 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public UnityEngine.AudioVelocityUpdateMode Result;

		public override IEnumerator Execute() {
			Result = Instance.velocityUpdateMode;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Velocity Update Mode" )]
	class AudioSourcevelocityUpdateModeSet12 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.AudioVelocityUpdateMode Value;

		public override IEnumerator Execute() {
			Instance.velocityUpdateMode = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Pan Stereo" )]
	class AudioSourcepanStereoGet13 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.panStereo;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Pan Stereo" )]
	class AudioSourcepanStereoSet13 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.panStereo = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Spatial Blend" )]
	class AudioSourcespatialBlendGet14 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.spatialBlend;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Spatial Blend" )]
	class AudioSourcespatialBlendSet14 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.spatialBlend = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Spatialize" )]
	class AudioSourcespatializeGet15 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.spatialize;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Spatialize" )]
	class AudioSourcespatializeSet15 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.spatialize = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Reverb Zone Mix" )]
	class AudioSourcereverbZoneMixGet16 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reverbZoneMix;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Reverb Zone Mix" )]
	class AudioSourcereverbZoneMixSet16 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.reverbZoneMix = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Bypass Effects" )]
	class AudioSourcebypassEffectsGet17 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.bypassEffects;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Bypass Effects" )]
	class AudioSourcebypassEffectsSet17 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.bypassEffects = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Bypass Listener Effects" )]
	class AudioSourcebypassListenerEffectsGet18 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.bypassListenerEffects;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Bypass Listener Effects" )]
	class AudioSourcebypassListenerEffectsSet18 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.bypassListenerEffects = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Bypass Reverb Zones" )]
	class AudioSourcebypassReverbZonesGet19 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.bypassReverbZones;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Bypass Reverb Zones" )]
	class AudioSourcebypassReverbZonesSet19 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.bypassReverbZones = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Doppler Level" )]
	class AudioSourcedopplerLevelGet20 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.dopplerLevel;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Doppler Level" )]
	class AudioSourcedopplerLevelSet20 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.dopplerLevel = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Spread" )]
	class AudioSourcespreadGet21 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.spread;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Spread" )]
	class AudioSourcespreadSet21 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.spread = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Priority" )]
	class AudioSourcepriorityGet22 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.priority;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Priority" )]
	class AudioSourceprioritySet22 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.priority = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Mute" )]
	class AudioSourcemuteGet23 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.mute;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Set Mute" )]
	class AudioSourcemuteSet23 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.mute = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Min Distance" )]
	class AudioSourceminDistanceGet24 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minDistance;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Min Distance" )]
	class AudioSourceminDistanceSet24 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minDistance = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Max Distance" )]
	class AudioSourcemaxDistanceGet25 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxDistance;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Max Distance" )]
	class AudioSourcemaxDistanceSet25 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxDistance = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Get Rolloff Mode" )]
	class AudioSourcerolloffModeGet26 : Automation {

		public UnityEngine.AudioSource Instance;
		[ReadOnly]
		public UnityEngine.AudioRolloffMode Result;

		public override IEnumerator Execute() {
			Result = Instance.rolloffMode;
			yield break;
		}

	}

	[Automation( "Audio Source/Set Rolloff Mode" )]
	class AudioSourcerolloffModeSet26 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.AudioRolloffMode Value;

		public override IEnumerator Execute() {
			Instance.rolloffMode = Value;
			yield break;
		}

	}

	[Automation( "Audio Source/Play" )]
	class AudioSourcePlay0 : Automation {

		public UnityEngine.AudioSource Instance;

		public override IEnumerator Execute() {
			Instance.Play();
			yield break;
		}

	}

	[Automation( "Audio Source/Play Delayed" )]
	class AudioSourcePlayDelayed1 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single delay;

		public override IEnumerator Execute() {
			Instance.PlayDelayed(delay);
			yield break;
		}

	}

	[Automation( "Audio Source/Play Scheduled" )]
	class AudioSourcePlayScheduled2 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Double time;

		public override IEnumerator Execute() {
			Instance.PlayScheduled(time);
			yield break;
		}

	}

	[Automation( "Audio Source/Set Scheduled Start Time" )]
	class AudioSourceSetScheduledStartTime3 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Double time;

		public override IEnumerator Execute() {
			Instance.SetScheduledStartTime(time);
			yield break;
		}

	}

	[Automation( "Audio Source/Set Scheduled End Time" )]
	class AudioSourceSetScheduledEndTime4 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Double time;

		public override IEnumerator Execute() {
			Instance.SetScheduledEndTime(time);
			yield break;
		}

	}

	[Automation( "Audio Source/Stop" )]
	class AudioSourceStop5 : Automation {

		public UnityEngine.AudioSource Instance;

		public override IEnumerator Execute() {
			Instance.Stop();
			yield break;
		}

	}

	[Automation( "Audio Source/Pause" )]
	class AudioSourcePause6 : Automation {

		public UnityEngine.AudioSource Instance;

		public override IEnumerator Execute() {
			Instance.Pause();
			yield break;
		}

	}

	[Automation( "Audio Source/Un Pause" )]
	class AudioSourceUnPause7 : Automation {

		public UnityEngine.AudioSource Instance;

		public override IEnumerator Execute() {
			Instance.UnPause();
			yield break;
		}

	}

	[Automation( "Audio Source/Play One Shot" )]
	class AudioSourcePlayOneShot8 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.AudioClip clip;
		public System.Single volumeScale;

		public override IEnumerator Execute() {
			Instance.PlayOneShot(clip,volumeScale);
			yield break;
		}

	}

	[Automation( "Audio Source/Play Clip At Point" )]
	class AudioSourcePlayClipAtPoint9 : Automation {

		public UnityEngine.AudioClip clip;
		public UnityEngine.Vector3 position;
		public System.Single volume;

		public override IEnumerator Execute() {
			UnityEngine.AudioSource.PlayClipAtPoint(clip,position,volume);
			yield break;
		}

	}

	[Automation( "Audio Source/Set Custom Curve" )]
	class AudioSourceSetCustomCurve10 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.AudioSourceCurveType type;
		public UnityEngine.AnimationCurve curve;

		public override IEnumerator Execute() {
			Instance.SetCustomCurve(type,curve);
			yield break;
		}

	}

	[Automation( "Audio Source/Get Custom Curve" )]
	class AudioSourceGetCustomCurve11 : Automation {

		public UnityEngine.AudioSource Instance;
		public UnityEngine.AudioSourceCurveType type;
		[ReadOnly]
		public UnityEngine.AnimationCurve Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCustomCurve(type);
			yield break;
		}

	}

	[Automation( "Audio Source/Get Output Data" )]
	class AudioSourceGetOutputData12 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single[] samples;
		public System.Int32 channel;

		public override IEnumerator Execute() {
			Instance.GetOutputData(samples,channel);
			yield break;
		}

	}

	[Automation( "Audio Source/Get Spectrum Data" )]
	class AudioSourceGetSpectrumData13 : Automation {

		public UnityEngine.AudioSource Instance;
		public System.Single[] samples;
		public System.Int32 channel;
		public UnityEngine.FFTWindow window;

		public override IEnumerator Execute() {
			Instance.GetSpectrumData(samples,channel,window);
			yield break;
		}

	}

	[Automation( "Audio Source/Set Spatializer Float" )]
	class AudioSourceSetSpatializerFloat14 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		public System.Int32 index;
		public System.Single value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.SetSpatializerFloat(index,value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Audio Source/Get Spatializer Float" )]
	class AudioSourceGetSpatializerFloat15 : ConditionalAutomation {

		public UnityEngine.AudioSource Instance;
		public System.Int32 index;
		public System.Single value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetSpatializerFloat(index,out value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
