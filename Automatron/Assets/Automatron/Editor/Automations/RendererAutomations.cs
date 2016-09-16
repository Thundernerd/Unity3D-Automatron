using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Renderer/Get Is Part Of Static Batch" )]
	class RendererisPartOfStaticBatchGet0 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPartOfStaticBatch;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Renderer/Get World To Local Matrix" )]
	class RendererworldToLocalMatrixGet1 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldToLocalMatrix;
			yield break;
		}

	}

	[Automation( "Renderer/Get Local To World Matrix" )]
	class RendererlocalToWorldMatrixGet2 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.localToWorldMatrix;
			yield break;
		}

	}

	[Automation( "Renderer/Get Enabled" )]
	class RendererenabledGet3 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Renderer/Set Enabled" )]
	class RendererenabledSet3 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Shadow Casting Mode" )]
	class RenderershadowCastingModeGet4 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rendering.ShadowCastingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowCastingMode;
			yield break;
		}

	}

	[Automation( "Renderer/Set Shadow Casting Mode" )]
	class RenderershadowCastingModeSet4 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Rendering.ShadowCastingMode Value;

		public override IEnumerator Execute() {
			Instance.shadowCastingMode = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Receive Shadows" )]
	class RendererreceiveShadowsGet5 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.receiveShadows;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Renderer/Set Receive Shadows" )]
	class RendererreceiveShadowsSet5 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.receiveShadows = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Material" )]
	class RenderermaterialGet6 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "Renderer/Set Material" )]
	class RenderermaterialSet6 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Shared Material" )]
	class RenderersharedMaterialGet7 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMaterial;
			yield break;
		}

	}

	[Automation( "Renderer/Set Shared Material" )]
	class RenderersharedMaterialSet7 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.sharedMaterial = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Materials" )]
	class RenderermaterialsGet8 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material[] Result;

		public override IEnumerator Execute() {
			Result = Instance.materials;
			yield break;
		}

	}

	[Automation( "Renderer/Set Materials" )]
	class RenderermaterialsSet8 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material[] Value;

		public override IEnumerator Execute() {
			Instance.materials = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Shared Materials" )]
	class RenderersharedMaterialsGet9 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material[] Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMaterials;
			yield break;
		}

	}

	[Automation( "Renderer/Set Shared Materials" )]
	class RenderersharedMaterialsSet9 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material[] Value;

		public override IEnumerator Execute() {
			Instance.sharedMaterials = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Bounds" )]
	class RendererboundsGet10 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.bounds;
			yield break;
		}

	}

	[Automation( "Renderer/Get Lightmap Index" )]
	class RendererlightmapIndexGet11 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapIndex;
			yield break;
		}

	}

	[Automation( "Renderer/Set Lightmap Index" )]
	class RendererlightmapIndexSet11 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.lightmapIndex = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Realtime Lightmap Index" )]
	class RendererrealtimeLightmapIndexGet12 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.realtimeLightmapIndex;
			yield break;
		}

	}

	[Automation( "Renderer/Set Realtime Lightmap Index" )]
	class RendererrealtimeLightmapIndexSet12 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.realtimeLightmapIndex = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Lightmap Scale Offset" )]
	class RendererlightmapScaleOffsetGet13 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapScaleOffset;
			yield break;
		}

	}

	[Automation( "Renderer/Set Lightmap Scale Offset" )]
	class RendererlightmapScaleOffsetSet13 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.lightmapScaleOffset = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Motion Vectors" )]
	class RenderermotionVectorsGet14 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.motionVectors;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Renderer/Set Motion Vectors" )]
	class RenderermotionVectorsSet14 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.motionVectors = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Realtime Lightmap Scale Offset" )]
	class RendererrealtimeLightmapScaleOffsetGet15 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.realtimeLightmapScaleOffset;
			yield break;
		}

	}

	[Automation( "Renderer/Set Realtime Lightmap Scale Offset" )]
	class RendererrealtimeLightmapScaleOffsetSet15 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.realtimeLightmapScaleOffset = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Is Visible" )]
	class RendererisVisibleGet16 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isVisible;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Renderer/Get Light Probe Usage" )]
	class RendererlightProbeUsageGet17 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rendering.LightProbeUsage Result;

		public override IEnumerator Execute() {
			Result = Instance.lightProbeUsage;
			yield break;
		}

	}

	[Automation( "Renderer/Set Light Probe Usage" )]
	class RendererlightProbeUsageSet17 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Rendering.LightProbeUsage Value;

		public override IEnumerator Execute() {
			Instance.lightProbeUsage = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Light Probe Proxy Volume Override" )]
	class RendererlightProbeProxyVolumeOverrideGet18 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = Instance.lightProbeProxyVolumeOverride;
			yield break;
		}

	}

	[Automation( "Renderer/Set Light Probe Proxy Volume Override" )]
	class RendererlightProbeProxyVolumeOverrideSet18 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.GameObject Value;

		public override IEnumerator Execute() {
			Instance.lightProbeProxyVolumeOverride = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Probe Anchor" )]
	class RendererprobeAnchorGet19 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.probeAnchor;
			yield break;
		}

	}

	[Automation( "Renderer/Set Probe Anchor" )]
	class RendererprobeAnchorSet19 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Transform Value;

		public override IEnumerator Execute() {
			Instance.probeAnchor = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Reflection Probe Usage" )]
	class RendererreflectionProbeUsageGet20 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rendering.ReflectionProbeUsage Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionProbeUsage;
			yield break;
		}

	}

	[Automation( "Renderer/Set Reflection Probe Usage" )]
	class RendererreflectionProbeUsageSet20 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Rendering.ReflectionProbeUsage Value;

		public override IEnumerator Execute() {
			Instance.reflectionProbeUsage = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Sorting Layer Name" )]
	class RenderersortingLayerNameGet21 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingLayerName;
			yield break;
		}

	}

	[Automation( "Renderer/Set Sorting Layer Name" )]
	class RenderersortingLayerNameSet21 : Automation {

		public UnityEngine.Renderer Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.sortingLayerName = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Sorting Layer ID" )]
	class RenderersortingLayerIDGet22 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingLayerID;
			yield break;
		}

	}

	[Automation( "Renderer/Set Sorting Layer ID" )]
	class RenderersortingLayerIDSet22 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingLayerID = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Get Sorting Order" )]
	class RenderersortingOrderGet23 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingOrder;
			yield break;
		}

	}

	[Automation( "Renderer/Set Sorting Order" )]
	class RenderersortingOrderSet23 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingOrder = Value;
			yield break;
		}

	}

	[Automation( "Renderer/Set Property Block" )]
	class RendererSetPropertyBlock0 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.MaterialPropertyBlock properties;

		public override IEnumerator Execute() {
			Instance.SetPropertyBlock(properties);
			yield break;
		}

	}

	[Automation( "Renderer/Get Property Block" )]
	class RendererGetPropertyBlock1 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.MaterialPropertyBlock dest;

		public override IEnumerator Execute() {
			Instance.GetPropertyBlock(dest);
			yield break;
		}

	}


#pragma warning restore 0649
}
