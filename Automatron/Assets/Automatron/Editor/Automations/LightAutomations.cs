using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Light/Get Type" )]
	class LighttypeGet0 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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

	[Automation( "Light/Get Shadow Resolution" )]
	class LightshadowResolutionGet6 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.LightShadowResolution Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowResolution;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Resolution" )]
	class LightshadowResolutionSet6 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.LightShadowResolution Value;

		public override IEnumerator Execute() {
			Instance.shadowResolution = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Custom Resolution" )]
	class LightshadowCustomResolutionGet7 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowCustomResolution;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Custom Resolution" )]
	class LightshadowCustomResolutionSet7 : Automation {

		public UnityEngine.Light Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.shadowCustomResolution = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Bias" )]
	class LightshadowBiasGet8 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowBias;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Bias" )]
	class LightshadowBiasSet8 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowBias = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Normal Bias" )]
	class LightshadowNormalBiasGet9 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowNormalBias;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Normal Bias" )]
	class LightshadowNormalBiasSet9 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowNormalBias = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Shadow Near Plane" )]
	class LightshadowNearPlaneGet10 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowNearPlane;
			yield break;
		}

	}

	[Automation( "Light/Set Shadow Near Plane" )]
	class LightshadowNearPlaneSet10 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shadowNearPlane = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Range" )]
	class LightrangeGet11 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.range;
			yield break;
		}

	}

	[Automation( "Light/Set Range" )]
	class LightrangeSet11 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.range = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Spot Angle" )]
	class LightspotAngleGet12 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.spotAngle;
			yield break;
		}

	}

	[Automation( "Light/Set Spot Angle" )]
	class LightspotAngleSet12 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.spotAngle = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Cookie Size" )]
	class LightcookieSizeGet13 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.cookieSize;
			yield break;
		}

	}

	[Automation( "Light/Set Cookie Size" )]
	class LightcookieSizeSet13 : Automation {

		public UnityEngine.Light Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.cookieSize = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Cookie" )]
	class LightcookieGet14 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.cookie;
			yield break;
		}

	}

	[Automation( "Light/Set Cookie" )]
	class LightcookieSet14 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Texture Value;

		public override IEnumerator Execute() {
			Instance.cookie = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Flare" )]
	class LightflareGet15 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Flare Result;

		public override IEnumerator Execute() {
			Result = Instance.flare;
			yield break;
		}

	}

	[Automation( "Light/Set Flare" )]
	class LightflareSet15 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Flare Value;

		public override IEnumerator Execute() {
			Instance.flare = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Render Mode" )]
	class LightrenderModeGet16 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.LightRenderMode Result;

		public override IEnumerator Execute() {
			Result = Instance.renderMode;
			yield break;
		}

	}

	[Automation( "Light/Set Render Mode" )]
	class LightrenderModeSet16 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.LightRenderMode Value;

		public override IEnumerator Execute() {
			Instance.renderMode = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Baked Index" )]
	class LightbakedIndexGet17 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.bakedIndex;
			yield break;
		}

	}

	[Automation( "Light/Set Baked Index" )]
	class LightbakedIndexSet17 : Automation {

		public UnityEngine.Light Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.bakedIndex = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Is Baked" )]
	class LightisBakedGet18 : ConditionalAutomation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isBaked;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Light/Get Culling Mask" )]
	class LightcullingMaskGet19 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.cullingMask;
			yield break;
		}

	}

	[Automation( "Light/Set Culling Mask" )]
	class LightcullingMaskSet19 : Automation {

		public UnityEngine.Light Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.cullingMask = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Area Size" )]
	class LightareaSizeGet20 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.areaSize;
			yield break;
		}

	}

	[Automation( "Light/Set Area Size" )]
	class LightareaSizeSet20 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.areaSize = Value;
			yield break;
		}

	}

	[Automation( "Light/Get Command Buffer Count" )]
	class LightcommandBufferCountGet21 : Automation {

		public UnityEngine.Light Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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

	[Automation( "Light/Remove Command Buffer" )]
	class LightRemoveCommandBuffer1 : Automation {

		public UnityEngine.Light Instance;
		public UnityEngine.Rendering.LightEvent evt;
		public UnityEngine.Rendering.CommandBuffer buffer;

		public override IEnumerator Execute() {
			Instance.RemoveCommandBuffer(evt,buffer);
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Light[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Light.GetLights(type,layer);
			yield break;
		}

	}


#pragma warning restore 0649
}
