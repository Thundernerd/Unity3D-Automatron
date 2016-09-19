#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Quality Settings/Get Names" )]
	class QualitySettingsnamesGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.names;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Pixel Light Count" )]
	class QualitySettingspixelLightCountGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.pixelLightCount;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Pixel Light Count" )]
	class QualitySettingspixelLightCountSet1 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.pixelLightCount = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Projection" )]
	class QualitySettingsshadowProjectionGet2 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ShadowProjection Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowProjection;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Projection" )]
	class QualitySettingsshadowProjectionSet2 : Automation {

		public UnityEngine.ShadowProjection Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowProjection = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Cascades" )]
	class QualitySettingsshadowCascadesGet3 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowCascades;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Cascades" )]
	class QualitySettingsshadowCascadesSet3 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowCascades = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Distance" )]
	class QualitySettingsshadowDistanceGet4 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowDistance;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Distance" )]
	class QualitySettingsshadowDistanceSet4 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowDistance = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Resolution" )]
	class QualitySettingsshadowResolutionGet5 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ShadowResolution Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowResolution;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Resolution" )]
	class QualitySettingsshadowResolutionSet5 : Automation {

		public UnityEngine.ShadowResolution Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowResolution = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Near Plane Offset" )]
	class QualitySettingsshadowNearPlaneOffsetGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowNearPlaneOffset;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Near Plane Offset" )]
	class QualitySettingsshadowNearPlaneOffsetSet6 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowNearPlaneOffset = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Cascade 2 Split" )]
	class QualitySettingsshadowCascade2SplitGet7 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowCascade2Split;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Cascade 2 Split" )]
	class QualitySettingsshadowCascade2SplitSet7 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowCascade2Split = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Cascade 4 Split" )]
	class QualitySettingsshadowCascade4SplitGet8 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowCascade4Split;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Cascade 4 Split" )]
	class QualitySettingsshadowCascade4SplitSet8 : Automation {

		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowCascade4Split = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Master Texture Limit" )]
	class QualitySettingsmasterTextureLimitGet9 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.masterTextureLimit;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Master Texture Limit" )]
	class QualitySettingsmasterTextureLimitSet9 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.masterTextureLimit = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Anisotropic Filtering" )]
	class QualitySettingsanisotropicFilteringGet10 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.AnisotropicFiltering Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.anisotropicFiltering;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Anisotropic Filtering" )]
	class QualitySettingsanisotropicFilteringSet10 : Automation {

		public UnityEngine.AnisotropicFiltering Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.anisotropicFiltering = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Lod Bias" )]
	class QualitySettingslodBiasGet11 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.lodBias;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Lod Bias" )]
	class QualitySettingslodBiasSet11 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.lodBias = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Maximum LOD Level" )]
	class QualitySettingsmaximumLODLevelGet12 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.maximumLODLevel;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Maximum LOD Level" )]
	class QualitySettingsmaximumLODLevelSet12 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.maximumLODLevel = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Particle Raycast Budget" )]
	class QualitySettingsparticleRaycastBudgetGet13 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.particleRaycastBudget;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Particle Raycast Budget" )]
	class QualitySettingsparticleRaycastBudgetSet13 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.particleRaycastBudget = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Soft Vegetation" )]
	class QualitySettingssoftVegetationGet14 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.softVegetation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Quality Settings/Set Soft Vegetation" )]
	class QualitySettingssoftVegetationSet14 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.softVegetation = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Realtime Reflection Probes" )]
	class QualitySettingsrealtimeReflectionProbesGet15 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.realtimeReflectionProbes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Quality Settings/Set Realtime Reflection Probes" )]
	class QualitySettingsrealtimeReflectionProbesSet15 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.realtimeReflectionProbes = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Billboards Face Camera Position" )]
	class QualitySettingsbillboardsFaceCameraPositionGet16 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.billboardsFaceCameraPosition;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Quality Settings/Set Billboards Face Camera Position" )]
	class QualitySettingsbillboardsFaceCameraPositionSet16 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Max Queued Frames" )]
	class QualitySettingsmaxQueuedFramesGet17 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.maxQueuedFrames;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Max Queued Frames" )]
	class QualitySettingsmaxQueuedFramesSet17 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.maxQueuedFrames = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get V Sync Count" )]
	class QualitySettingsvSyncCountGet18 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.vSyncCount;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set V Sync Count" )]
	class QualitySettingsvSyncCountSet18 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.vSyncCount = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Anti Aliasing" )]
	class QualitySettingsantiAliasingGet19 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.antiAliasing;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Anti Aliasing" )]
	class QualitySettingsantiAliasingSet19 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.antiAliasing = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Desired Color Space" )]
	class QualitySettingsdesiredColorSpaceGet20 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ColorSpace Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.desiredColorSpace;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Active Color Space" )]
	class QualitySettingsactiveColorSpaceGet21 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ColorSpace Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.activeColorSpace;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Blend Weights" )]
	class QualitySettingsblendWeightsGet22 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.BlendWeights Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.blendWeights;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Blend Weights" )]
	class QualitySettingsblendWeightsSet22 : Automation {

		public UnityEngine.BlendWeights Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.blendWeights = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Async Upload Time Slice" )]
	class QualitySettingsasyncUploadTimeSliceGet23 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.asyncUploadTimeSlice;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Async Upload Time Slice" )]
	class QualitySettingsasyncUploadTimeSliceSet23 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.asyncUploadTimeSlice = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Async Upload Buffer Size" )]
	class QualitySettingsasyncUploadBufferSizeGet24 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.asyncUploadBufferSize;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Async Upload Buffer Size" )]
	class QualitySettingsasyncUploadBufferSizeSet24 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.asyncUploadBufferSize = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Quality Level" )]
	class QualitySettingsGetQualityLevel0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.GetQualityLevel();
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Quality Level" )]
	class QualitySettingsSetQualityLevel1 : Automation {

		public System.Int32 index;
		public System.Boolean applyExpensiveChanges;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.SetQualityLevel(index,applyExpensiveChanges);
			yield break;
		}

	}

	[Automation( "Quality Settings/Increase Level" )]
	class QualitySettingsIncreaseLevel2 : Automation {

		public System.Boolean applyExpensiveChanges;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.IncreaseLevel(applyExpensiveChanges);
			yield break;
		}

	}

	[Automation( "Quality Settings/Decrease Level" )]
	class QualitySettingsDecreaseLevel3 : Automation {

		public System.Boolean applyExpensiveChanges;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.DecreaseLevel(applyExpensiveChanges);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif