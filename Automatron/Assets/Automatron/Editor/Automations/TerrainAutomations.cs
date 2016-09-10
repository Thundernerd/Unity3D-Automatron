using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Terrain/Get Editor Render Flags" )]
	class TerraineditorRenderFlagsGet0 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.TerrainRenderFlags Result;

		public override IEnumerator Execute() {
			Result = Instance.editorRenderFlags;
			yield break;
		}

	}

	[Automation( "Terrain/Set Editor Render Flags" )]
	class TerraineditorRenderFlagsSet0 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.TerrainRenderFlags Value;

		public override IEnumerator Execute() {
			Instance.editorRenderFlags = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Terrain Data" )]
	class TerrainterrainDataGet1 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.TerrainData Result;

		public override IEnumerator Execute() {
			Result = Instance.terrainData;
			yield break;
		}

	}

	[Automation( "Terrain/Set Terrain Data" )]
	class TerrainterrainDataSet1 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.TerrainData Value;

		public override IEnumerator Execute() {
			Instance.terrainData = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Tree Distance" )]
	class TerraintreeDistanceGet2 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.treeDistance;
			yield break;
		}

	}

	[Automation( "Terrain/Set Tree Distance" )]
	class TerraintreeDistanceSet2 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.treeDistance = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Tree Billboard Distance" )]
	class TerraintreeBillboardDistanceGet3 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.treeBillboardDistance;
			yield break;
		}

	}

	[Automation( "Terrain/Set Tree Billboard Distance" )]
	class TerraintreeBillboardDistanceSet3 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.treeBillboardDistance = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Tree Cross Fade Length" )]
	class TerraintreeCrossFadeLengthGet4 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.treeCrossFadeLength;
			yield break;
		}

	}

	[Automation( "Terrain/Set Tree Cross Fade Length" )]
	class TerraintreeCrossFadeLengthSet4 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.treeCrossFadeLength = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Tree Maximum Full LOD Count" )]
	class TerraintreeMaximumFullLODCountGet5 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.treeMaximumFullLODCount;
			yield break;
		}

	}

	[Automation( "Terrain/Set Tree Maximum Full LOD Count" )]
	class TerraintreeMaximumFullLODCountSet5 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.treeMaximumFullLODCount = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Detail Object Distance" )]
	class TerraindetailObjectDistanceGet6 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.detailObjectDistance;
			yield break;
		}

	}

	[Automation( "Terrain/Set Detail Object Distance" )]
	class TerraindetailObjectDistanceSet6 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.detailObjectDistance = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Detail Object Density" )]
	class TerraindetailObjectDensityGet7 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.detailObjectDensity;
			yield break;
		}

	}

	[Automation( "Terrain/Set Detail Object Density" )]
	class TerraindetailObjectDensitySet7 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.detailObjectDensity = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Collect Detail Patches" )]
	class TerraincollectDetailPatchesGet8 : ConditionalAutomation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.collectDetailPatches;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Terrain/Set Collect Detail Patches" )]
	class TerraincollectDetailPatchesSet8 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.collectDetailPatches = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Heightmap Pixel Error" )]
	class TerrainheightmapPixelErrorGet9 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.heightmapPixelError;
			yield break;
		}

	}

	[Automation( "Terrain/Set Heightmap Pixel Error" )]
	class TerrainheightmapPixelErrorSet9 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.heightmapPixelError = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Heightmap Maximum LOD" )]
	class TerrainheightmapMaximumLODGet10 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.heightmapMaximumLOD;
			yield break;
		}

	}

	[Automation( "Terrain/Set Heightmap Maximum LOD" )]
	class TerrainheightmapMaximumLODSet10 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.heightmapMaximumLOD = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Basemap Distance" )]
	class TerrainbasemapDistanceGet11 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.basemapDistance;
			yield break;
		}

	}

	[Automation( "Terrain/Set Basemap Distance" )]
	class TerrainbasemapDistanceSet11 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.basemapDistance = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Lightmap Index" )]
	class TerrainlightmapIndexGet12 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapIndex;
			yield break;
		}

	}

	[Automation( "Terrain/Set Lightmap Index" )]
	class TerrainlightmapIndexSet12 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.lightmapIndex = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Realtime Lightmap Index" )]
	class TerrainrealtimeLightmapIndexGet13 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.realtimeLightmapIndex;
			yield break;
		}

	}

	[Automation( "Terrain/Set Realtime Lightmap Index" )]
	class TerrainrealtimeLightmapIndexSet13 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.realtimeLightmapIndex = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Lightmap Scale Offset" )]
	class TerrainlightmapScaleOffsetGet14 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapScaleOffset;
			yield break;
		}

	}

	[Automation( "Terrain/Set Lightmap Scale Offset" )]
	class TerrainlightmapScaleOffsetSet14 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.lightmapScaleOffset = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Realtime Lightmap Scale Offset" )]
	class TerrainrealtimeLightmapScaleOffsetGet15 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.realtimeLightmapScaleOffset;
			yield break;
		}

	}

	[Automation( "Terrain/Set Realtime Lightmap Scale Offset" )]
	class TerrainrealtimeLightmapScaleOffsetSet15 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.realtimeLightmapScaleOffset = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Cast Shadows" )]
	class TerraincastShadowsGet16 : ConditionalAutomation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.castShadows;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Terrain/Set Cast Shadows" )]
	class TerraincastShadowsSet16 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.castShadows = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Reflection Probe Usage" )]
	class TerrainreflectionProbeUsageGet17 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeUsage Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionProbeUsage;
			yield break;
		}

	}

	[Automation( "Terrain/Set Reflection Probe Usage" )]
	class TerrainreflectionProbeUsageSet17 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Rendering.ReflectionProbeUsage Value;

		public override IEnumerator Execute() {
			Instance.reflectionProbeUsage = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Material Type" )]
	class TerrainmaterialTypeGet18 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Terrain.MaterialType Result;

		public override IEnumerator Execute() {
			Result = Instance.materialType;
			yield break;
		}

	}

	[Automation( "Terrain/Set Material Type" )]
	class TerrainmaterialTypeSet18 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Terrain.MaterialType Value;

		public override IEnumerator Execute() {
			Instance.materialType = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Material Template" )]
	class TerrainmaterialTemplateGet19 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.materialTemplate;
			yield break;
		}

	}

	[Automation( "Terrain/Set Material Template" )]
	class TerrainmaterialTemplateSet19 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.materialTemplate = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Legacy Specular" )]
	class TerrainlegacySpecularGet20 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.legacySpecular;
			yield break;
		}

	}

	[Automation( "Terrain/Set Legacy Specular" )]
	class TerrainlegacySpecularSet20 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.legacySpecular = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Legacy Shininess" )]
	class TerrainlegacyShininessGet21 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.legacyShininess;
			yield break;
		}

	}

	[Automation( "Terrain/Set Legacy Shininess" )]
	class TerrainlegacyShininessSet21 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.legacyShininess = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Draw Heightmap" )]
	class TerraindrawHeightmapGet22 : ConditionalAutomation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.drawHeightmap;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Terrain/Set Draw Heightmap" )]
	class TerraindrawHeightmapSet22 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.drawHeightmap = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Draw Trees And Foliage" )]
	class TerraindrawTreesAndFoliageGet23 : ConditionalAutomation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.drawTreesAndFoliage;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Terrain/Set Draw Trees And Foliage" )]
	class TerraindrawTreesAndFoliageSet23 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.drawTreesAndFoliage = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Bake Light Probes For Trees" )]
	class TerrainbakeLightProbesForTreesGet24 : ConditionalAutomation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.bakeLightProbesForTrees;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Terrain/Set Bake Light Probes For Trees" )]
	class TerrainbakeLightProbesForTreesSet24 : Automation {

		public UnityEngine.Terrain Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.bakeLightProbesForTrees = Value;
			yield break;
		}

	}

	[Automation( "Terrain/Get Active Terrain" )]
	class TerrainactiveTerrainGet25 : Automation {

		[ReadOnly]
		public UnityEngine.Terrain Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Terrain.activeTerrain;
			yield break;
		}

	}

	[Automation( "Terrain/Get Active Terrains" )]
	class TerrainactiveTerrainsGet26 : Automation {

		[ReadOnly]
		public UnityEngine.Terrain[] Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Terrain.activeTerrains;
			yield break;
		}

	}

	[Automation( "Terrain/Sample Height" )]
	class TerrainSampleHeight0 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Vector3 worldPosition;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.SampleHeight(worldPosition);
			yield break;
		}

	}

	[Automation( "Terrain/Apply Delayed Heightmap Modification" )]
	class TerrainApplyDelayedHeightmapModification1 : Automation {

		public UnityEngine.Terrain Instance;

		public override IEnumerator Execute() {
			Instance.ApplyDelayedHeightmapModification();
			yield break;
		}

	}

	[Automation( "Terrain/Add Tree Instance" )]
	class TerrainAddTreeInstance2 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.TreeInstance instance;

		public override IEnumerator Execute() {
			Instance.AddTreeInstance(instance);
			yield break;
		}

	}

	[Automation( "Terrain/Set Neighbors" )]
	class TerrainSetNeighbors3 : Automation {

		public UnityEngine.Terrain Instance;
		public UnityEngine.Terrain left;
		public UnityEngine.Terrain top;
		public UnityEngine.Terrain right;
		public UnityEngine.Terrain bottom;

		public override IEnumerator Execute() {
			Instance.SetNeighbors(left,top,right,bottom);
			yield break;
		}

	}

	[Automation( "Terrain/Get Position" )]
	class TerrainGetPosition4 : Automation {

		public UnityEngine.Terrain Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPosition();
			yield break;
		}

	}

	[Automation( "Terrain/Flush" )]
	class TerrainFlush5 : Automation {

		public UnityEngine.Terrain Instance;

		public override IEnumerator Execute() {
			Instance.Flush();
			yield break;
		}

	}

	[Automation( "Terrain/Create Terrain Game Object" )]
	class TerrainCreateTerrainGameObject6 : Automation {

		public UnityEngine.TerrainData assignTerrain;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Terrain.CreateTerrainGameObject(assignTerrain);
			yield break;
		}

	}


#pragma warning restore 0649
}
