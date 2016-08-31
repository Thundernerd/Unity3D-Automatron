using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Texture Importer/Get Texture Format" )]
	class TextureImportertextureFormatGet0 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.TextureImporterFormat Result;

		public override IEnumerator Execute() {
			Result = Instance.textureFormat;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Texture Format" )]
	class TextureImportertextureFormatSet0 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterFormat Value;

		public override IEnumerator Execute() {
			Instance.textureFormat = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Max Texture Size" )]
	class TextureImportermaxTextureSizeGet1 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.maxTextureSize;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Max Texture Size" )]
	class TextureImportermaxTextureSizeSet1 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.maxTextureSize = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Compression Quality" )]
	class TextureImportercompressionQualityGet2 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.compressionQuality;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Compression Quality" )]
	class TextureImportercompressionQualitySet2 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.compressionQuality = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Grayscale To Alpha" )]
	class TextureImportergrayscaleToAlphaGet3 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.grayscaleToAlpha;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Grayscale To Alpha" )]
	class TextureImportergrayscaleToAlphaSet3 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.grayscaleToAlpha = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Generate Cubemap" )]
	class TextureImportergenerateCubemapGet4 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.TextureImporterGenerateCubemap Result;

		public override IEnumerator Execute() {
			Result = Instance.generateCubemap;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Generate Cubemap" )]
	class TextureImportergenerateCubemapSet4 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterGenerateCubemap Value;

		public override IEnumerator Execute() {
			Instance.generateCubemap = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Npot Scale" )]
	class TextureImporternpotScaleGet5 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.TextureImporterNPOTScale Result;

		public override IEnumerator Execute() {
			Result = Instance.npotScale;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Npot Scale" )]
	class TextureImporternpotScaleSet5 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterNPOTScale Value;

		public override IEnumerator Execute() {
			Instance.npotScale = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Is Readable" )]
	class TextureImporterisReadableGet6 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isReadable;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Is Readable" )]
	class TextureImporterisReadableSet6 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isReadable = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Mipmap Enabled" )]
	class TextureImportermipmapEnabledGet7 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.mipmapEnabled;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Mipmap Enabled" )]
	class TextureImportermipmapEnabledSet7 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.mipmapEnabled = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Border Mipmap" )]
	class TextureImporterborderMipmapGet8 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.borderMipmap;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Border Mipmap" )]
	class TextureImporterborderMipmapSet8 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.borderMipmap = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Linear Texture" )]
	class TextureImporterlinearTextureGet9 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.linearTexture;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Linear Texture" )]
	class TextureImporterlinearTextureSet9 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.linearTexture = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Mipmap Filter" )]
	class TextureImportermipmapFilterGet10 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.TextureImporterMipFilter Result;

		public override IEnumerator Execute() {
			Result = Instance.mipmapFilter;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Mipmap Filter" )]
	class TextureImportermipmapFilterSet10 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterMipFilter Value;

		public override IEnumerator Execute() {
			Instance.mipmapFilter = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Fadeout" )]
	class TextureImporterfadeoutGet11 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.fadeout;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Fadeout" )]
	class TextureImporterfadeoutSet11 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.fadeout = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Mipmap Fade Distance Start" )]
	class TextureImportermipmapFadeDistanceStartGet12 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.mipmapFadeDistanceStart;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Mipmap Fade Distance Start" )]
	class TextureImportermipmapFadeDistanceStartSet12 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.mipmapFadeDistanceStart = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Mipmap Fade Distance End" )]
	class TextureImportermipmapFadeDistanceEndGet13 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.mipmapFadeDistanceEnd;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Mipmap Fade Distance End" )]
	class TextureImportermipmapFadeDistanceEndSet13 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.mipmapFadeDistanceEnd = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Generate Mips In Linear Space" )]
	class TextureImportergenerateMipsInLinearSpaceGet14 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.generateMipsInLinearSpace;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Generate Mips In Linear Space" )]
	class TextureImportergenerateMipsInLinearSpaceSet14 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.generateMipsInLinearSpace = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Convert To Normalmap" )]
	class TextureImporterconvertToNormalmapGet15 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.convertToNormalmap;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Convert To Normalmap" )]
	class TextureImporterconvertToNormalmapSet15 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.convertToNormalmap = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Normalmap" )]
	class TextureImporternormalmapGet16 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.normalmap;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Normalmap" )]
	class TextureImporternormalmapSet16 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.normalmap = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Normalmap Filter" )]
	class TextureImporternormalmapFilterGet17 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.TextureImporterNormalFilter Result;

		public override IEnumerator Execute() {
			Result = Instance.normalmapFilter;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Normalmap Filter" )]
	class TextureImporternormalmapFilterSet17 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterNormalFilter Value;

		public override IEnumerator Execute() {
			Instance.normalmapFilter = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Heightmap Scale" )]
	class TextureImporterheightmapScaleGet18 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.heightmapScale;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Heightmap Scale" )]
	class TextureImporterheightmapScaleSet18 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.heightmapScale = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Lightmap" )]
	class TextureImporterlightmapGet19 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmap;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Lightmap" )]
	class TextureImporterlightmapSet19 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.lightmap = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Aniso Level" )]
	class TextureImporteranisoLevelGet20 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.anisoLevel;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Aniso Level" )]
	class TextureImporteranisoLevelSet20 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.anisoLevel = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Filter Mode" )]
	class TextureImporterfilterModeGet21 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEngine.FilterMode Result;

		public override IEnumerator Execute() {
			Result = Instance.filterMode;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Filter Mode" )]
	class TextureImporterfilterModeSet21 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEngine.FilterMode Value;

		public override IEnumerator Execute() {
			Instance.filterMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Wrap Mode" )]
	class TextureImporterwrapModeGet22 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEngine.TextureWrapMode Result;

		public override IEnumerator Execute() {
			Result = Instance.wrapMode;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Wrap Mode" )]
	class TextureImporterwrapModeSet22 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEngine.TextureWrapMode Value;

		public override IEnumerator Execute() {
			Instance.wrapMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Mip Map Bias" )]
	class TextureImportermipMapBiasGet23 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.mipMapBias;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Mip Map Bias" )]
	class TextureImportermipMapBiasSet23 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.mipMapBias = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Alpha Is Transparency" )]
	class TextureImporteralphaIsTransparencyGet24 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.alphaIsTransparency;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Alpha Is Transparency" )]
	class TextureImporteralphaIsTransparencySet24 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.alphaIsTransparency = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Qualifies For Sprite Packing" )]
	class TextureImporterqualifiesForSpritePackingGet25 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.qualifiesForSpritePacking;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Sprite Import Mode" )]
	class TextureImporterspriteImportModeGet26 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.SpriteImportMode Result;

		public override IEnumerator Execute() {
			Result = Instance.spriteImportMode;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Sprite Import Mode" )]
	class TextureImporterspriteImportModeSet26 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.SpriteImportMode Value;

		public override IEnumerator Execute() {
			Instance.spriteImportMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Spritesheet" )]
	class TextureImporterspritesheetGet27 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.SpriteMetaData[] Result;

		public override IEnumerator Execute() {
			Result = Instance.spritesheet;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Spritesheet" )]
	class TextureImporterspritesheetSet27 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.SpriteMetaData[] Value;

		public override IEnumerator Execute() {
			Instance.spritesheet = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Sprite Packing Tag" )]
	class TextureImporterspritePackingTagGet28 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.spritePackingTag;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Sprite Packing Tag" )]
	class TextureImporterspritePackingTagSet28 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.spritePackingTag = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Sprite Pixels Per Unit" )]
	class TextureImporterspritePixelsPerUnitGet29 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.spritePixelsPerUnit;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Sprite Pixels Per Unit" )]
	class TextureImporterspritePixelsPerUnitSet29 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.spritePixelsPerUnit = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Sprite Pivot" )]
	class TextureImporterspritePivotGet30 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.spritePivot;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Sprite Pivot" )]
	class TextureImporterspritePivotSet30 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.spritePivot = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Sprite Border" )]
	class TextureImporterspriteBorderGet31 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.spriteBorder;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Sprite Border" )]
	class TextureImporterspriteBorderSet31 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEngine.Vector4 Value;

		public override IEnumerator Execute() {
			Instance.spriteBorder = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Texture Type" )]
	class TextureImportertextureTypeGet32 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public UnityEditor.TextureImporterType Result;

		public override IEnumerator Execute() {
			Result = Instance.textureType;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Texture Type" )]
	class TextureImportertextureTypeSet32 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterType Value;

		public override IEnumerator Execute() {
			Instance.textureType = Value;
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Allows Alpha Splitting" )]
	class TextureImporterGetAllowsAlphaSplitting0 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAllowsAlphaSplitting();
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Allows Alpha Splitting" )]
	class TextureImporterSetAllowsAlphaSplitting1 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.Boolean flag;

		public override IEnumerator Execute() {
			Instance.SetAllowsAlphaSplitting(flag);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Platform Texture Settings" )]
	class TextureImporterGetPlatformTextureSettings2 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String platform;
		public System.Int32 maxTextureSize;
		public UnityEditor.TextureImporterFormat textureFormat;
		public System.Int32 compressionQuality;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPlatformTextureSettings(platform,out maxTextureSize,out textureFormat,out compressionQuality);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Get Platform Texture Settings" )]
	class TextureImporterGetPlatformTextureSettings3 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String platform;
		public System.Int32 maxTextureSize;
		public UnityEditor.TextureImporterFormat textureFormat;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPlatformTextureSettings(platform,out maxTextureSize,out textureFormat);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Platform Texture Settings" )]
	class TextureImporterSetPlatformTextureSettings4 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String platform;
		public System.Int32 maxTextureSize;
		public UnityEditor.TextureImporterFormat textureFormat;
		public System.Int32 compressionQuality;
		public System.Boolean allowsAlphaSplit;

		public override IEnumerator Execute() {
			Instance.SetPlatformTextureSettings(platform,maxTextureSize,textureFormat,compressionQuality,allowsAlphaSplit);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Platform Texture Settings" )]
	class TextureImporterSetPlatformTextureSettings5 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String platform;
		public System.Int32 maxTextureSize;
		public UnityEditor.TextureImporterFormat textureFormat;

		public override IEnumerator Execute() {
			Instance.SetPlatformTextureSettings(platform,maxTextureSize,textureFormat);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Platform Texture Settings" )]
	class TextureImporterSetPlatformTextureSettings6 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String platform;
		public System.Int32 maxTextureSize;
		public UnityEditor.TextureImporterFormat textureFormat;
		public System.Boolean allowsAlphaSplit;

		public override IEnumerator Execute() {
			Instance.SetPlatformTextureSettings(platform,maxTextureSize,textureFormat,allowsAlphaSplit);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Clear Platform Texture Settings" )]
	class TextureImporterClearPlatformTextureSettings7 : Automation {

		public UnityEditor.TextureImporter Instance;
		public System.String platform;

		public override IEnumerator Execute() {
			Instance.ClearPlatformTextureSettings(platform);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Does Source Texture Have Alpha" )]
	class TextureImporterDoesSourceTextureHaveAlpha8 : Automation {

		public UnityEditor.TextureImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.DoesSourceTextureHaveAlpha();
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Read Texture Settings" )]
	class TextureImporterReadTextureSettings9 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterSettings dest;

		public override IEnumerator Execute() {
			Instance.ReadTextureSettings(dest);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Set Texture Settings" )]
	class TextureImporterSetTextureSettings10 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.TextureImporterSettings src;

		public override IEnumerator Execute() {
			Instance.SetTextureSettings(src);
			yield break;
		}

	}

	[Automation( "Importers/Texture Importer/Read Texture Import Instructions" )]
	class TextureImporterReadTextureImportInstructions11 : Automation {

		public UnityEditor.TextureImporter Instance;
		public UnityEditor.BuildTarget target;
		public UnityEngine.TextureFormat desiredFormat;
		public UnityEngine.ColorSpace colorSpace;
		public System.Int32 compressionQuality;

		public override IEnumerator Execute() {
			Instance.ReadTextureImportInstructions(target,out desiredFormat,out colorSpace,out compressionQuality);
			yield break;
		}

	}


#pragma warning restore 0649
}
