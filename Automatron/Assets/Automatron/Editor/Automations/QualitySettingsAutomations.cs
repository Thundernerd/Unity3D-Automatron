using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Quality Settings/Get Names" )]
	class QualitySettingsnamesGet0 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.names;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Pixel Light Count" )]
	class QualitySettingspixelLightCountGet1 : Automation {

		[ReadOnly]
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

	[Automation( "Quality Settings/Get Shadow Near Plane Offset" )]
	class QualitySettingsshadowNearPlaneOffsetGet5 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowNearPlaneOffset;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Near Plane Offset" )]
	class QualitySettingsshadowNearPlaneOffsetSet5 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowNearPlaneOffset = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Cascade 2 Split" )]
	class QualitySettingsshadowCascade2SplitGet6 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowCascade2Split;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Cascade 2 Split" )]
	class QualitySettingsshadowCascade2SplitSet6 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowCascade2Split = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Shadow Cascade 4 Split" )]
	class QualitySettingsshadowCascade4SplitGet7 : Automation {

		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.shadowCascade4Split;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Shadow Cascade 4 Split" )]
	class QualitySettingsshadowCascade4SplitSet7 : Automation {

		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.shadowCascade4Split = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Master Texture Limit" )]
	class QualitySettingsmasterTextureLimitGet8 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.masterTextureLimit;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Master Texture Limit" )]
	class QualitySettingsmasterTextureLimitSet8 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.masterTextureLimit = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Anisotropic Filtering" )]
	class QualitySettingsanisotropicFilteringGet9 : Automation {

		[ReadOnly]
		public UnityEngine.AnisotropicFiltering Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.anisotropicFiltering;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Anisotropic Filtering" )]
	class QualitySettingsanisotropicFilteringSet9 : Automation {

		public UnityEngine.AnisotropicFiltering Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.anisotropicFiltering = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Lod Bias" )]
	class QualitySettingslodBiasGet10 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.lodBias;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Lod Bias" )]
	class QualitySettingslodBiasSet10 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.lodBias = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Maximum LOD Level" )]
	class QualitySettingsmaximumLODLevelGet11 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.maximumLODLevel;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Maximum LOD Level" )]
	class QualitySettingsmaximumLODLevelSet11 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.maximumLODLevel = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Particle Raycast Budget" )]
	class QualitySettingsparticleRaycastBudgetGet12 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.particleRaycastBudget;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Particle Raycast Budget" )]
	class QualitySettingsparticleRaycastBudgetSet12 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.particleRaycastBudget = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Soft Vegetation" )]
	class QualitySettingssoftVegetationGet13 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.QualitySettings.softVegetation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Quality Settings/Set Soft Vegetation" )]
	class QualitySettingssoftVegetationSet13 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.softVegetation = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Realtime Reflection Probes" )]
	class QualitySettingsrealtimeReflectionProbesGet14 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.QualitySettings.realtimeReflectionProbes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Quality Settings/Set Realtime Reflection Probes" )]
	class QualitySettingsrealtimeReflectionProbesSet14 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.realtimeReflectionProbes = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Billboards Face Camera Position" )]
	class QualitySettingsbillboardsFaceCameraPositionGet15 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.QualitySettings.billboardsFaceCameraPosition;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Quality Settings/Set Billboards Face Camera Position" )]
	class QualitySettingsbillboardsFaceCameraPositionSet15 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.billboardsFaceCameraPosition = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Max Queued Frames" )]
	class QualitySettingsmaxQueuedFramesGet16 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.maxQueuedFrames;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Max Queued Frames" )]
	class QualitySettingsmaxQueuedFramesSet16 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.maxQueuedFrames = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get V Sync Count" )]
	class QualitySettingsvSyncCountGet17 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.vSyncCount;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set V Sync Count" )]
	class QualitySettingsvSyncCountSet17 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.vSyncCount = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Anti Aliasing" )]
	class QualitySettingsantiAliasingGet18 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.antiAliasing;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Anti Aliasing" )]
	class QualitySettingsantiAliasingSet18 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.antiAliasing = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Desired Color Space" )]
	class QualitySettingsdesiredColorSpaceGet19 : Automation {

		[ReadOnly]
		public UnityEngine.ColorSpace Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.desiredColorSpace;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Active Color Space" )]
	class QualitySettingsactiveColorSpaceGet20 : Automation {

		[ReadOnly]
		public UnityEngine.ColorSpace Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.activeColorSpace;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Blend Weights" )]
	class QualitySettingsblendWeightsGet21 : Automation {

		[ReadOnly]
		public UnityEngine.BlendWeights Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.blendWeights;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Blend Weights" )]
	class QualitySettingsblendWeightsSet21 : Automation {

		public UnityEngine.BlendWeights Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.blendWeights = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Async Upload Time Slice" )]
	class QualitySettingsasyncUploadTimeSliceGet22 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.asyncUploadTimeSlice;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Async Upload Time Slice" )]
	class QualitySettingsasyncUploadTimeSliceSet22 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.asyncUploadTimeSlice = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Async Upload Buffer Size" )]
	class QualitySettingsasyncUploadBufferSizeGet23 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.QualitySettings.asyncUploadBufferSize;
			yield break;
		}

	}

	[Automation( "Quality Settings/Set Async Upload Buffer Size" )]
	class QualitySettingsasyncUploadBufferSizeSet23 : Automation {

		public System.Int32 Value;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.asyncUploadBufferSize = Value;
			yield break;
		}

	}

	[Automation( "Quality Settings/Get Quality Level" )]
	class QualitySettingsGetQualityLevel0 : Automation {

		[ReadOnly]
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
	class QualitySettingsIncreaseLevel3 : Automation {

		public System.Boolean applyExpensiveChanges;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.IncreaseLevel(applyExpensiveChanges);
			yield break;
		}

	}
	[Automation( "Quality Settings/Decrease Level" )]
	class QualitySettingsDecreaseLevel5 : Automation {

		public System.Boolean applyExpensiveChanges;

		public override IEnumerator Execute() {
			UnityEngine.QualitySettings.DecreaseLevel(applyExpensiveChanges);
			yield break;
		}

	}


#pragma warning restore 0649
}
