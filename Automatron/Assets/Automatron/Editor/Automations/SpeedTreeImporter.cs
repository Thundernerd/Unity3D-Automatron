using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Speed Tree Importer/Wind Quality Names/Get" )]
	class SpeedTreeImporterwindQualityNamesGet0 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SpeedTreeImporter.windQualityNames;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Has Imported/Get" )]
	class SpeedTreeImporterhasImportedGet0 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hasImported;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Material Folder Path/Get" )]
	class SpeedTreeImportermaterialFolderPathGet1 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.materialFolderPath;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Scale Factor/Get" )]
	class SpeedTreeImporterscaleFactorGet2 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.scaleFactor;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Scale Factor/Set" )]
	class SpeedTreeImporterscaleFactorSet2 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.scaleFactor = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Main Color/Get" )]
	class SpeedTreeImportermainColorGet3 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.mainColor;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Main Color/Set" )]
	class SpeedTreeImportermainColorSet3 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.mainColor = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Spec Color/Get" )]
	class SpeedTreeImporterspecColorGet4 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.specColor;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Spec Color/Set" )]
	class SpeedTreeImporterspecColorSet4 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.specColor = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Hue Variation/Get" )]
	class SpeedTreeImporterhueVariationGet5 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.hueVariation;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Hue Variation/Set" )]
	class SpeedTreeImporterhueVariationSet5 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.hueVariation = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Shininess/Get" )]
	class SpeedTreeImportershininessGet6 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.shininess;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Shininess/Set" )]
	class SpeedTreeImportershininessSet6 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.shininess = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Alpha Test Ref/Get" )]
	class SpeedTreeImporteralphaTestRefGet7 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.alphaTestRef;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Alpha Test Ref/Set" )]
	class SpeedTreeImporteralphaTestRefSet7 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.alphaTestRef = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Has Billboard/Get" )]
	class SpeedTreeImporterhasBillboardGet8 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hasBillboard;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Enable Smooth LOD Transition/Get" )]
	class SpeedTreeImporterenableSmoothLODTransitionGet9 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableSmoothLODTransition;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Enable Smooth LOD Transition/Set" )]
	class SpeedTreeImporterenableSmoothLODTransitionSet9 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableSmoothLODTransition = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Animate Cross Fading/Get" )]
	class SpeedTreeImporteranimateCrossFadingGet10 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.animateCrossFading;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Animate Cross Fading/Set" )]
	class SpeedTreeImporteranimateCrossFadingSet10 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.animateCrossFading = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Billboard Transition Cross Fade Width/Get" )]
	class SpeedTreeImporterbillboardTransitionCrossFadeWidthGet11 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.billboardTransitionCrossFadeWidth;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Billboard Transition Cross Fade Width/Set" )]
	class SpeedTreeImporterbillboardTransitionCrossFadeWidthSet11 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.billboardTransitionCrossFadeWidth = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Fade Out Width/Get" )]
	class SpeedTreeImporterfadeOutWidthGet12 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fadeOutWidth;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Fade Out Width/Set" )]
	class SpeedTreeImporterfadeOutWidthSet12 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.fadeOutWidth = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/LOD Heights/Get" )]
	class SpeedTreeImporterLODHeightsGet13 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Single[] Result;

		public override IEnumerator Execute() {
			Result = Instance.LODHeights;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/LOD Heights/Set" )]
	class SpeedTreeImporterLODHeightsSet13 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single[] Value;

		public override IEnumerator Execute() {
			Instance.LODHeights = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Cast Shadows/Get" )]
	class SpeedTreeImportercastShadowsGet14 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.castShadows;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Cast Shadows/Set" )]
	class SpeedTreeImportercastShadowsSet14 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.castShadows = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Receive Shadows/Get" )]
	class SpeedTreeImporterreceiveShadowsGet15 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.receiveShadows;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Receive Shadows/Set" )]
	class SpeedTreeImporterreceiveShadowsSet15 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.receiveShadows = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Use Light Probes/Get" )]
	class SpeedTreeImporteruseLightProbesGet16 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.useLightProbes;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Use Light Probes/Set" )]
	class SpeedTreeImporteruseLightProbesSet16 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.useLightProbes = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Reflection Probe Usages/Get" )]
	class SpeedTreeImporterreflectionProbeUsagesGet17 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public UnityEngine.Rendering.ReflectionProbeUsage[] Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionProbeUsages;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Reflection Probe Usages/Set" )]
	class SpeedTreeImporterreflectionProbeUsagesSet17 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Rendering.ReflectionProbeUsage[] Value;

		public override IEnumerator Execute() {
			Instance.reflectionProbeUsages = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Enable Bump/Get" )]
	class SpeedTreeImporterenableBumpGet18 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.enableBump;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Enable Bump/Set" )]
	class SpeedTreeImporterenableBumpSet18 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.enableBump = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Enable Hue/Get" )]
	class SpeedTreeImporterenableHueGet19 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.enableHue;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Enable Hue/Set" )]
	class SpeedTreeImporterenableHueSet19 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.enableHue = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Best Wind Quality/Get" )]
	class SpeedTreeImporterbestWindQualityGet20 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.bestWindQuality;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Wind Qualities/Get" )]
	class SpeedTreeImporterwindQualitiesGet21 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		public System.Int32[] Result;

		public override IEnumerator Execute() {
			Result = Instance.windQualities;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Wind Qualities/Set" )]
	class SpeedTreeImporterwindQualitiesSet21 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Int32[] Value;

		public override IEnumerator Execute() {
			Instance.windQualities = Value;
			yield break;
		}

	}

	[Automation( "Importers/Speed Tree Importer/Generate Materials" )]
	class SpeedTreeImporterGenerateMaterials0 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;

		public override IEnumerator Execute() {
			Instance.GenerateMaterials();
			yield break;
		}

	}


#pragma warning restore 0649
}
