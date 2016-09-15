using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Light Probe Proxy Volume/Get Bounds Global" )]
	class LightProbeProxyVolumeboundsGlobalGet0 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.boundsGlobal;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Size Custom" )]
	class LightProbeProxyVolumesizeCustomGet1 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.sizeCustom;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Size Custom" )]
	class LightProbeProxyVolumesizeCustomSet1 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.sizeCustom = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Origin Custom" )]
	class LightProbeProxyVolumeoriginCustomGet2 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.originCustom;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Origin Custom" )]
	class LightProbeProxyVolumeoriginCustomSet2 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.originCustom = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Bounding Box Mode" )]
	class LightProbeProxyVolumeboundingBoxModeGet3 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.LightProbeProxyVolume.BoundingBoxMode Result;

		public override IEnumerator Execute() {
			Result = Instance.boundingBoxMode;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Bounding Box Mode" )]
	class LightProbeProxyVolumeboundingBoxModeSet3 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public UnityEngine.LightProbeProxyVolume.BoundingBoxMode Value;

		public override IEnumerator Execute() {
			Instance.boundingBoxMode = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Resolution Mode" )]
	class LightProbeProxyVolumeresolutionModeGet4 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.LightProbeProxyVolume.ResolutionMode Result;

		public override IEnumerator Execute() {
			Result = Instance.resolutionMode;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Resolution Mode" )]
	class LightProbeProxyVolumeresolutionModeSet4 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public UnityEngine.LightProbeProxyVolume.ResolutionMode Value;

		public override IEnumerator Execute() {
			Instance.resolutionMode = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Probe Position Mode" )]
	class LightProbeProxyVolumeprobePositionModeGet5 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.LightProbeProxyVolume.ProbePositionMode Result;

		public override IEnumerator Execute() {
			Result = Instance.probePositionMode;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Probe Position Mode" )]
	class LightProbeProxyVolumeprobePositionModeSet5 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public UnityEngine.LightProbeProxyVolume.ProbePositionMode Value;

		public override IEnumerator Execute() {
			Instance.probePositionMode = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Refresh Mode" )]
	class LightProbeProxyVolumerefreshModeGet6 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public UnityEngine.LightProbeProxyVolume.RefreshMode Result;

		public override IEnumerator Execute() {
			Result = Instance.refreshMode;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Refresh Mode" )]
	class LightProbeProxyVolumerefreshModeSet6 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public UnityEngine.LightProbeProxyVolume.RefreshMode Value;

		public override IEnumerator Execute() {
			Instance.refreshMode = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Probe Density" )]
	class LightProbeProxyVolumeprobeDensityGet7 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.probeDensity;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Probe Density" )]
	class LightProbeProxyVolumeprobeDensitySet7 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.probeDensity = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Grid Resolution X" )]
	class LightProbeProxyVolumegridResolutionXGet8 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.gridResolutionX;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Grid Resolution X" )]
	class LightProbeProxyVolumegridResolutionXSet8 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.gridResolutionX = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Grid Resolution Y" )]
	class LightProbeProxyVolumegridResolutionYGet9 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.gridResolutionY;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Grid Resolution Y" )]
	class LightProbeProxyVolumegridResolutionYSet9 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.gridResolutionY = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Grid Resolution Z" )]
	class LightProbeProxyVolumegridResolutionZGet10 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.gridResolutionZ;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Set Grid Resolution Z" )]
	class LightProbeProxyVolumegridResolutionZSet10 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.gridResolutionZ = Value;
			yield break;
		}

	}

	[Automation( "Light Probe Proxy Volume/Get Is Feature Supported" )]
	class LightProbeProxyVolumeisFeatureSupportedGet11 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.LightProbeProxyVolume.isFeatureSupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Light Probe Proxy Volume/Update" )]
	class LightProbeProxyVolumeUpdate0 : Automation {

		public UnityEngine.LightProbeProxyVolume Instance;

		public override IEnumerator Execute() {
			Instance.Update();
			yield break;
		}

	}


#pragma warning restore 0649
}
