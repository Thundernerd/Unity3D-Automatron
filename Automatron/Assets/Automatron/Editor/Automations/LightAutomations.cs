using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Light/Get Type" )]
	class LighttypeGet0 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.LightType Result;

		public override IEnumerator Execute() {
			Result = Instance.type;
			yield break;
		}

	}

	[Automation( "Light/Set Type" )]
	class LighttypeSet0 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.LightType Value;

		public override IEnumerator Execute() {
			Instance.type = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Color" )]
	class LightcolorGet1 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "Light/Set Color" )]
	class LightcolorSet1 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Intensity" )]
	class LightintensityGet2 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.intensity;
			yield break;
		}

	}

	[Automation( "Light/Set Intensity" )]
	class LightintensitySet2 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.intensity = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Bounce Intensity" )]
	class LightbounceIntensityGet3 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.bounceIntensity;
			yield break;
		}

	}

	[Automation( "Light/Set Bounce Intensity" )]
	class LightbounceIntensitySet3 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.bounceIntensity = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadows" )]
	class LightshadowsGet4 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.LightShadows Result;

		public override IEnumerator Execute() {
			Result = Instance.shadows;
			yield break;
		}

	}

	[Automation( "Light/Set Shadows" )]
	class LightshadowsSet4 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.LightShadows Value;

		public override IEnumerator Execute() {
			Instance.shadows = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Strength" )]
	class LightshadowStrengthGet5 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowStrength;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Strength" )]
	class LightshadowStrengthSet5 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowStrength = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Bias" )]
	class LightshadowBiasGet6 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowBias;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Bias" )]
	class LightshadowBiasSet6 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowBias = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Normal Bias" )]
	class LightshadowNormalBiasGet7 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowNormalBias;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Normal Bias" )]
	class LightshadowNormalBiasSet7 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowNormalBias = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Near Plane" )]
	class LightshadowNearPlaneGet8 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowNearPlane;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Near Plane" )]
	class LightshadowNearPlaneSet8 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowNearPlane = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Range" )]
	class LightrangeGet9 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.range;
			yield break;
		}

	}

	[Automation( "Light/Set Range" )]
	class LightrangeSet9 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.range = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Spot Angle" )]
	class LightspotAngleGet10 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.spotAngle;
			yield break;
		}

	}

	[Automation( "Light/Set Spot Angle" )]
	class LightspotAngleSet10 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.spotAngle = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Cookie Size" )]
	class LightcookieSizeGet11 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.cookieSize;
			yield break;
		}

	}

	[Automation( "Light/Set Cookie Size" )]
	class LightcookieSizeSet11 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.cookieSize = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Cookie" )]
	class LightcookieGet12 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.cookie;
			yield break;
		}

	}

	[Automation( "Light/Set Cookie" )]
	class LightcookieSet12 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Texture Value;

		public override IEnumerator Execute() {
			Instance.cookie = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Flare" )]
	class LightflareGet13 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.Flare Result;

		public override IEnumerator Execute() {
			Result = Instance.flare;
			yield break;
		}

	}

	[Automation( "Light/Set Flare" )]
	class LightflareSet13 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Flare Value;

		public override IEnumerator Execute() {
			Instance.flare = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Render Mode" )]
	class LightrenderModeGet14 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.LightRenderMode Result;

		public override IEnumerator Execute() {
			Result = Instance.renderMode;
			yield break;
		}

	}

	[Automation( "Light/Set Render Mode" )]
	class LightrenderModeSet14 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.LightRenderMode Value;

		public override IEnumerator Execute() {
			Instance.renderMode = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Culling Mask" )]
	class LightcullingMaskGet16 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMask;
			yield break;
		}

	}

	[Automation( "Light/Set Culling Mask" )]
	class LightcullingMaskSet16 : Automation {

		public UnityEngine.Light Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.cullingMask = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Area Size" )]
	class LightareaSizeGet17 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.areaSize;
			yield break;
		}

	}

	[Automation( "Light/Set Area Size" )]
	class LightareaSizeSet17 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.areaSize = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Command Buffer Count" )]
	class LightcommandBufferCountGet18 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.commandBufferCount;
			yield break;
		}

	}

	[Automation( "Light/Add Command Buffer" )]
	class LightAddCommandBuffer0 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Rendering.LightEvent evt;
		public UnityEngine.Rendering.CommandBuffer buffer;

		public override IEnumerator Execute() {
			Instance.AddCommandBuffer(evt,buffer);
			yield break;
		}

	}

	[Automation( "Light/Remove Command Buffers" )]
	class LightRemoveCommandBuffers1 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Rendering.LightEvent evt;

		public override IEnumerator Execute() {
			Instance.RemoveCommandBuffers(evt);
			yield break;
		}

	}

	[Automation( "Light/Remove All Command Buffers" )]
	class LightRemoveAllCommandBuffers2 : Automation {

		public UnityEngine.Light Instance;

		public override IEnumerator Execute() {
			Instance.RemoveAllCommandBuffers();
			yield break;
		}

	}

	[Automation( "Light/Get Command Buffers" )]
	class LightGetCommandBuffers3 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Rendering.LightEvent evt;
		[ReadOnly]
		public UnityEngine.Rendering.CommandBuffer[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetCommandBuffers(evt);
			yield break;
		}

	}

	[Automation( "Light/Get Lights" )]
	class LightGetLights4 : Automation {

		public UnityEngine.LightType type;
		public System.Int32 layer;
		[ReadOnly]
		public UnityEngine.Light[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Light.GetLights(type,layer);
			yield break;
		}

	}


#pragma warning restore 0649
}
