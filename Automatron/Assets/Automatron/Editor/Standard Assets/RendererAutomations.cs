using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rendeders/Renderer/Get Is Part Of Static Batch" )]
	class RendererisPartOfStaticBatchGet0 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isPartOfStaticBatch;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Renderer/Get World To Local Matrix" )]
	class RendererworldToLocalMatrixGet1 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldToLocalMatrix;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Local To World Matrix" )]
	class RendererlocalToWorldMatrixGet2 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.localToWorldMatrix;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Enabled" )]
	class RendererenabledGet3 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Renderer/Set Enabled" )]
	class RendererenabledSet3 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Shadow Casting Mode" )]
	class RenderershadowCastingModeGet4 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ShadowCastingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.shadowCastingMode;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Shadow Casting Mode" )]
	class RenderershadowCastingModeSet4 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Rendering.ShadowCastingMode Value;

		public override IEnumerator Execute() {
			Instance.shadowCastingMode = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Receive Shadows" )]
	class RendererreceiveShadowsGet5 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.receiveShadows;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Renderer/Set Receive Shadows" )]
	class RendererreceiveShadowsSet5 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.receiveShadows = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Material" )]
	class RenderermaterialGet6 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Material" )]
	class RenderermaterialSet6 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Shared Material" )]
	class RenderersharedMaterialGet7 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMaterial;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Shared Material" )]
	class RenderersharedMaterialSet7 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.sharedMaterial = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Materials" )]
	class RenderermaterialsGet8 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Material[] Result;

		public override IEnumerator Execute() {
			Result = Instance.materials;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Materials" )]
	class RenderermaterialsSet8 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material[] Value;

		public override IEnumerator Execute() {
			Instance.materials = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Shared Materials" )]
	class RenderersharedMaterialsGet9 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Material[] Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMaterials;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Shared Materials" )]
	class RenderersharedMaterialsSet9 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Material[] Value;

		public override IEnumerator Execute() {
			Instance.sharedMaterials = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Bounds" )]
	class RendererboundsGet10 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.bounds;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Lightmap Index" )]
	class RendererlightmapIndexGet11 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapIndex;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Lightmap Index" )]
	class RendererlightmapIndexSet11 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.lightmapIndex = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Realtime Lightmap Index" )]
	class RendererrealtimeLightmapIndexGet12 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.realtimeLightmapIndex;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Realtime Lightmap Index" )]
	class RendererrealtimeLightmapIndexSet12 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.realtimeLightmapIndex = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Lightmap Scale Offset" )]
	class RendererlightmapScaleOffsetGet13 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapScaleOffset;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Lightmap Scale Offset" )]
	class RendererlightmapScaleOffsetSet13 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.lightmapScaleOffset = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Realtime Lightmap Scale Offset" )]
	class RendererrealtimeLightmapScaleOffsetGet14 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.realtimeLightmapScaleOffset;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Realtime Lightmap Scale Offset" )]
	class RendererrealtimeLightmapScaleOffsetSet14 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.realtimeLightmapScaleOffset = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Is Visible" )]
	class RendererisVisibleGet15 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isVisible;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Renderer/Get Use Light Probes" )]
	class RendereruseLightProbesGet16 : ConditionalAutomation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.useLightProbes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Renderer/Set Use Light Probes" )]
	class RendereruseLightProbesSet16 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useLightProbes = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Probe Anchor" )]
	class RendererprobeAnchorGet17 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.probeAnchor;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Probe Anchor" )]
	class RendererprobeAnchorSet17 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Transform Value;

		public override IEnumerator Execute() {
			Instance.probeAnchor = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Reflection Probe Usage" )]
	class RendererreflectionProbeUsageGet18 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeUsage Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionProbeUsage;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Reflection Probe Usage" )]
	class RendererreflectionProbeUsageSet18 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.Rendering.ReflectionProbeUsage Value;

		public override IEnumerator Execute() {
			Instance.reflectionProbeUsage = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Sorting Layer Name" )]
	class RenderersortingLayerNameGet19 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingLayerName;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Sorting Layer Name" )]
	class RenderersortingLayerNameSet19 : Automation {

		public UnityEngine.Renderer Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.sortingLayerName = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Sorting Layer ID" )]
	class RenderersortingLayerIDGet20 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingLayerID;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Sorting Layer ID" )]
	class RenderersortingLayerIDSet20 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingLayerID = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Sorting Order" )]
	class RenderersortingOrderGet21 : Automation {

		public UnityEngine.Renderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingOrder;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Sorting Order" )]
	class RenderersortingOrderSet21 : Automation {

		public UnityEngine.Renderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingOrder = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Set Property Block" )]
	class RendererSetPropertyBlock0 : Automation {

		public UnityEngine.Renderer Instance;
		public UnityEngine.MaterialPropertyBlock properties;

		public override IEnumerator Execute() {
			Instance.SetPropertyBlock(properties);
			yield break;
		}

	}

	[Automation( "Rendeders/Renderer/Get Property Block" )]
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
