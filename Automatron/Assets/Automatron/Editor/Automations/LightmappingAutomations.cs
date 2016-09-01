using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Lightmapping/Get Gi Workflow Mode" )]
	class LightmappinggiWorkflowModeGet0 : Automation {

		[ReadOnly]
		public UnityEditor.Lightmapping.GIWorkflowMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.giWorkflowMode;
			yield break;
		}

	}

	[Automation( "Lightmapping/Set Gi Workflow Mode" )]
	class LightmappinggiWorkflowModeSet0 : Automation {

		public UnityEditor.Lightmapping.GIWorkflowMode Value;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.giWorkflowMode = Value;
			yield break;
		}

	}

	[Automation( "Lightmapping/Get Indirect Output Scale" )]
	class LightmappingindirectOutputScaleGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.indirectOutputScale;
			yield break;
		}

	}

	[Automation( "Lightmapping/Set Indirect Output Scale" )]
	class LightmappingindirectOutputScaleSet1 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.indirectOutputScale = Value;
			yield break;
		}

	}

	[Automation( "Lightmapping/Get Bounce Boost" )]
	class LightmappingbounceBoostGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.bounceBoost;
			yield break;
		}

	}

	[Automation( "Lightmapping/Set Bounce Boost" )]
	class LightmappingbounceBoostSet2 : Automation {

		public System.Single Value;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.bounceBoost = Value;
			yield break;
		}

	}

	[Automation( "Lightmapping/Get Is Running" )]
	class LightmappingisRunningGet3 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.isRunning;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Get Build Progress" )]
	class LightmappingbuildProgressGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.buildProgress;
			yield break;
		}

	}

	[Automation( "Lightmapping/Get Lighting Data Asset" )]
	class LightmappinglightingDataAssetGet5 : Automation {

		[ReadOnly]
		public UnityEditor.LightingDataAsset Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Lightmapping.lightingDataAsset;
			yield break;
		}

	}

	[Automation( "Lightmapping/Set Lighting Data Asset" )]
	class LightmappinglightingDataAssetSet5 : Automation {

		public UnityEditor.LightingDataAsset Value;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.lightingDataAsset = Value;
			yield break;
		}

	}

	[Automation( "Lightmapping/Clear Disk Cache" )]
	class LightmappingClearDiskCache0 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.ClearDiskCache();
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Async" )]
	class LightmappingBakeAsync1 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.BakeAsync();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Bake" )]
	class LightmappingBake2 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.Bake();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Bake Selected" )]
	class LightmappingBakeSelected3 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.BakeSelected();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Bake Light Probes Only Async" )]
	class LightmappingBakeLightProbesOnlyAsync4 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.BakeLightProbesOnlyAsync();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Bake Light Probes Only" )]
	class LightmappingBakeLightProbesOnly5 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.BakeLightProbesOnly();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Cancel" )]
	class LightmappingCancel6 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.Cancel();
			yield break;
		}

	}

	[Automation( "Lightmapping/Clear" )]
	class LightmappingClear7 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.Clear();
			yield break;
		}

	}

	[Automation( "Lightmapping/Clear Lighting Data Asset" )]
	class LightmappingClearLightingDataAsset8 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.ClearLightingDataAsset();
			yield break;
		}

	}

	[Automation( "Lightmapping/Tetrahedralize" )]
	class LightmappingTetrahedralize9 : Automation {

		public UnityEngine.Vector3[] positions;
		public System.Int32[] outIndices;
		public UnityEngine.Vector3[] outPositions;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.Tetrahedralize(positions,out outIndices,out outPositions);
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Reflection Probe" )]
	class LightmappingBakeReflectionProbe10 : ConditionalAutomation {

		public UnityEngine.ReflectionProbe probe;
		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.Lightmapping.BakeReflectionProbe(probe,path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Lightmapping/Get Terrain GI Chunks" )]
	class LightmappingGetTerrainGIChunks11 : Automation {

		public UnityEngine.Terrain terrain;
		public System.Int32 numChunksX;
		public System.Int32 numChunksY;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.GetTerrainGIChunks(terrain,ref numChunksX,ref numChunksY);
			yield break;
		}

	}

	[Automation( "Lightmapping/Bake Multiple Scenes" )]
	class LightmappingBakeMultipleScenes12 : Automation {

		public System.String[] paths;

		public override IEnumerator Execute() {
			UnityEditor.Lightmapping.BakeMultipleScenes(paths);
			yield break;
		}

	}


#pragma warning restore 0649
}
