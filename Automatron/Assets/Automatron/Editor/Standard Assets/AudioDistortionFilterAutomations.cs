using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Audio/Audio Distortion Filter/Get Distortion Level" )]
	class AudioDistortionFilterdistortionLevelGet0 : Automation {

		public UnityEngine.AudioDistortionFilter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.distortionLevel;
			yield break;
		}

	}

	[Automation( "Audio/Audio Distortion Filter/Set Distortion Level" )]
	class AudioDistortionFilterdistortionLevelSet0 : Automation {

		public UnityEngine.AudioDistortionFilter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.distortionLevel = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
