#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Substance Importer/Get Prototype Names" )]
	class SubstanceImporterGetPrototypeNames0 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPrototypeNames();
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Material Count" )]
	class SubstanceImporterGetMaterialCount1 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMaterialCount();
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Materials" )]
	class SubstanceImporterGetMaterials2 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ProceduralMaterial[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMaterials();
			yield break;
		}

	}

	[Automation( "Substance Importer/Clone Material" )]
	class SubstanceImporterCloneMaterial3 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.CloneMaterial(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Instantiate Material" )]
	class SubstanceImporterInstantiateMaterial4 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public System.String prototypeName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.InstantiateMaterial(prototypeName);
			yield break;
		}

	}

	[Automation( "Substance Importer/Destroy Material" )]
	class SubstanceImporterDestroyMaterial5 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;

		public override IEnumerator Execute() {
			Instance.DestroyMaterial(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Reset Material" )]
	class SubstanceImporterResetMaterial6 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;

		public override IEnumerator Execute() {
			Instance.ResetMaterial(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Rename Material" )]
	class SubstanceImporterRenameMaterial7 : ConditionalAutomation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.RenameMaterial(material,name);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Substance Importer/On Shader Modified" )]
	class SubstanceImporterOnShaderModified8 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;

		public override IEnumerator Execute() {
			Instance.OnShaderModified(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Texture Alpha Source" )]
	class SubstanceImporterGetTextureAlphaSource9 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.String textureName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ProceduralOutputType Result;

		public override IEnumerator Execute() {
			Result = Instance.GetTextureAlphaSource(material,textureName);
			yield break;
		}

	}

	[Automation( "Substance Importer/Set Texture Alpha Source" )]
	class SubstanceImporterSetTextureAlphaSource10 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.String textureName;
		public UnityEngine.ProceduralOutputType alphaSource;

		public override IEnumerator Execute() {
			Instance.SetTextureAlphaSource(material,textureName,alphaSource);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Platform Texture Settings" )]
	class SubstanceImporterGetPlatformTextureSettings11 : ConditionalAutomation {

		public UnityEditor.SubstanceImporter Instance;
		public System.String materialName;
		public System.String platform;
		public System.Int32 maxTextureWidth;
		public System.Int32 maxTextureHeight;
		public System.Int32 textureFormat;
		public System.Int32 loadBehavior;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPlatformTextureSettings(materialName,platform,out maxTextureWidth,out maxTextureHeight,out textureFormat,out loadBehavior);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Substance Importer/Set Platform Texture Settings" )]
	class SubstanceImporterSetPlatformTextureSettings12 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.String platform;
		public System.Int32 maxTextureWidth;
		public System.Int32 maxTextureHeight;
		public System.Int32 textureFormat;
		public System.Int32 loadBehavior;

		public override IEnumerator Execute() {
			Instance.SetPlatformTextureSettings(material,platform,maxTextureWidth,maxTextureHeight,textureFormat,loadBehavior);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Material Offset" )]
	class SubstanceImporterGetMaterialOffset13 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMaterialOffset(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Set Material Offset" )]
	class SubstanceImporterSetMaterialOffset14 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public UnityEngine.Vector2 offset;

		public override IEnumerator Execute() {
			Instance.SetMaterialOffset(material,offset);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Material Scale" )]
	class SubstanceImporterGetMaterialScale15 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMaterialScale(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Set Material Scale" )]
	class SubstanceImporterSetMaterialScale16 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public UnityEngine.Vector2 scale;

		public override IEnumerator Execute() {
			Instance.SetMaterialScale(material,scale);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Generate All Outputs" )]
	class SubstanceImporterGetGenerateAllOutputs17 : ConditionalAutomation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetGenerateAllOutputs(material);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Substance Importer/Set Generate All Outputs" )]
	class SubstanceImporterSetGenerateAllOutputs18 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.Boolean generated;

		public override IEnumerator Execute() {
			Instance.SetGenerateAllOutputs(material,generated);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Animation Update Rate" )]
	class SubstanceImporterGetAnimationUpdateRate19 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAnimationUpdateRate(material);
			yield break;
		}

	}

	[Automation( "Substance Importer/Set Animation Update Rate" )]
	class SubstanceImporterSetAnimationUpdateRate20 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.Int32 animation_update_rate;

		public override IEnumerator Execute() {
			Instance.SetAnimationUpdateRate(material,animation_update_rate);
			yield break;
		}

	}

	[Automation( "Substance Importer/Get Generate Mip Maps" )]
	class SubstanceImporterGetGenerateMipMaps21 : ConditionalAutomation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetGenerateMipMaps(material);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Substance Importer/Set Generate Mip Maps" )]
	class SubstanceImporterSetGenerateMipMaps22 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.Boolean mode;

		public override IEnumerator Execute() {
			Instance.SetGenerateMipMaps(material,mode);
			yield break;
		}

	}

	[Automation( "Substance Importer/Export Bitmaps" )]
	class SubstanceImporterExportBitmaps23 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.String exportPath;
		public System.Boolean alphaRemap;

		public override IEnumerator Execute() {
			Instance.ExportBitmaps(material,exportPath,alphaRemap);
			yield break;
		}

	}

	[Automation( "Substance Importer/Export Preset" )]
	class SubstanceImporterExportPreset24 : Automation {

		public UnityEditor.SubstanceImporter Instance;
		public UnityEngine.ProceduralMaterial material;
		public System.String exportPath;

		public override IEnumerator Execute() {
			Instance.ExportPreset(material,exportPath);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif