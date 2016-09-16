using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Speed Tree Importer/Get Wind Quality Names" )]
	class SpeedTreeImporterwindQualityNamesGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SpeedTreeImporter.windQualityNames;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Has Imported" )]
	class SpeedTreeImporterhasImportedGet0 : ConditionalAutomation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hasImported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Speed Tree Importer/Get Material Folder Path" )]
	class SpeedTreeImportermaterialFolderPathGet1 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.materialFolderPath;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Scale Factor" )]
	class SpeedTreeImporterscaleFactorGet2 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.scaleFactor;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Scale Factor" )]
	class SpeedTreeImporterscaleFactorSet2 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.scaleFactor = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Main Color" )]
	class SpeedTreeImportermainColorGet3 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.mainColor;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Main Color" )]
	class SpeedTreeImportermainColorSet3 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.mainColor = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Hue Variation" )]
	class SpeedTreeImporterhueVariationGet4 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.hueVariation;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Hue Variation" )]
	class SpeedTreeImporterhueVariationSet4 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.hueVariation = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Alpha Test Ref" )]
	class SpeedTreeImporteralphaTestRefGet5 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.alphaTestRef;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Alpha Test Ref" )]
	class SpeedTreeImporteralphaTestRefSet5 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.alphaTestRef = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Has Billboard" )]
	class SpeedTreeImporterhasBillboardGet6 : ConditionalAutomation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hasBillboard;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Speed Tree Importer/Get Enable Smooth LOD Transition" )]
	class SpeedTreeImporterenableSmoothLODTransitionGet7 : ConditionalAutomation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableSmoothLODTransition;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Speed Tree Importer/Set Enable Smooth LOD Transition" )]
	class SpeedTreeImporterenableSmoothLODTransitionSet7 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableSmoothLODTransition = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Animate Cross Fading" )]
	class SpeedTreeImporteranimateCrossFadingGet8 : ConditionalAutomation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.animateCrossFading;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Speed Tree Importer/Set Animate Cross Fading" )]
	class SpeedTreeImporteranimateCrossFadingSet8 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.animateCrossFading = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Billboard Transition Cross Fade Width" )]
	class SpeedTreeImporterbillboardTransitionCrossFadeWidthGet9 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.billboardTransitionCrossFadeWidth;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Billboard Transition Cross Fade Width" )]
	class SpeedTreeImporterbillboardTransitionCrossFadeWidthSet9 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.billboardTransitionCrossFadeWidth = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Fade Out Width" )]
	class SpeedTreeImporterfadeOutWidthGet10 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fadeOutWidth;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Fade Out Width" )]
	class SpeedTreeImporterfadeOutWidthSet10 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.fadeOutWidth = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get LOD Heights" )]
	class SpeedTreeImporterLODHeightsGet11 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single[] Result;

		public override IEnumerator Execute() {
			Result = Instance.LODHeights;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set LOD Heights" )]
	class SpeedTreeImporterLODHeightsSet11 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Single[] Value;

		public override IEnumerator Execute() {
			Instance.LODHeights = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Cast Shadows" )]
	class SpeedTreeImportercastShadowsGet12 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.castShadows;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Cast Shadows" )]
	class SpeedTreeImportercastShadowsSet12 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.castShadows = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Receive Shadows" )]
	class SpeedTreeImporterreceiveShadowsGet13 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.receiveShadows;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Receive Shadows" )]
	class SpeedTreeImporterreceiveShadowsSet13 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.receiveShadows = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Use Light Probes" )]
	class SpeedTreeImporteruseLightProbesGet14 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.useLightProbes;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Use Light Probes" )]
	class SpeedTreeImporteruseLightProbesSet14 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.useLightProbes = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Reflection Probe Usages" )]
	class SpeedTreeImporterreflectionProbeUsagesGet15 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rendering.ReflectionProbeUsage[] Result;

		public override IEnumerator Execute() {
			Result = Instance.reflectionProbeUsages;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Reflection Probe Usages" )]
	class SpeedTreeImporterreflectionProbeUsagesSet15 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public UnityEngine.Rendering.ReflectionProbeUsage[] Value;

		public override IEnumerator Execute() {
			Instance.reflectionProbeUsages = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Enable Bump" )]
	class SpeedTreeImporterenableBumpGet16 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.enableBump;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Enable Bump" )]
	class SpeedTreeImporterenableBumpSet16 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.enableBump = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Enable Hue" )]
	class SpeedTreeImporterenableHueGet17 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean[] Result;

		public override IEnumerator Execute() {
			Result = Instance.enableHue;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Enable Hue" )]
	class SpeedTreeImporterenableHueSet17 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Boolean[] Value;

		public override IEnumerator Execute() {
			Instance.enableHue = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Best Wind Quality" )]
	class SpeedTreeImporterbestWindQualityGet18 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.bestWindQuality;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Get Wind Qualities" )]
	class SpeedTreeImporterwindQualitiesGet19 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32[] Result;

		public override IEnumerator Execute() {
			Result = Instance.windQualities;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Set Wind Qualities" )]
	class SpeedTreeImporterwindQualitiesSet19 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;
		public System.Int32[] Value;

		public override IEnumerator Execute() {
			Instance.windQualities = Value;
			yield break;
		}

	}

	[Automation( "Speed Tree Importer/Generate Materials" )]
	class SpeedTreeImporterGenerateMaterials0 : Automation {

		public UnityEditor.SpeedTreeImporter Instance;

		public override IEnumerator Execute() {
			Instance.GenerateMaterials();
			yield break;
		}

	}


#pragma warning restore 0649
}
