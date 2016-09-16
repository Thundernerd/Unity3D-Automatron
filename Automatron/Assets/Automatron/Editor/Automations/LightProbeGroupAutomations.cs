using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Light Probe Group/Get Probe Positions" )]
	class LightProbeGroupprobePositionsGet0 : Automation {

		public UnityEngine.LightProbeGroup Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3[] Result;

		public override IEnumerator Execute() {
			Result = Instance.probePositions;
			yield break;
		}

	}

	[Automation( "Light Probe Group/Set Probe Positions" )]
	class LightProbeGroupprobePositionsSet0 : Automation {

		public UnityEngine.LightProbeGroup Instance;
		public UnityEngine.Vector3[] Value;

		public override IEnumerator Execute() {
			Instance.probePositions = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
