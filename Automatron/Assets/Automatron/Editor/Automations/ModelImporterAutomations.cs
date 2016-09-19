#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Model Importer/Get Import Materials" )]
	class ModelImporterimportMaterialsGet0 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.importMaterials;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Import Materials" )]
	class ModelImporterimportMaterialsSet0 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importMaterials = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Material Name" )]
	class ModelImportermaterialNameGet1 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterMaterialName Result;

		public override IEnumerator Execute() {
			Result = Instance.materialName;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Material Name" )]
	class ModelImportermaterialNameSet1 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMaterialName Value;

		public override IEnumerator Execute() {
			Instance.materialName = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Material Search" )]
	class ModelImportermaterialSearchGet2 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterMaterialSearch Result;

		public override IEnumerator Execute() {
			Result = Instance.materialSearch;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Material Search" )]
	class ModelImportermaterialSearchSet2 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMaterialSearch Value;

		public override IEnumerator Execute() {
			Instance.materialSearch = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Global Scale" )]
	class ModelImporterglobalScaleGet3 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.globalScale;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Global Scale" )]
	class ModelImporterglobalScaleSet3 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.globalScale = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Is Use File Units Supported" )]
	class ModelImporterisUseFileUnitsSupportedGet4 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isUseFileUnitsSupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Get Use File Units" )]
	class ModelImporteruseFileUnitsGet5 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useFileUnits;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Use File Units" )]
	class ModelImporteruseFileUnitsSet5 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useFileUnits = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get File Scale" )]
	class ModelImporterfileScaleGet6 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fileScale;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Is File Scale Used" )]
	class ModelImporterisFileScaleUsedGet7 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isFileScaleUsed;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Get Import Blend Shapes" )]
	class ModelImporterimportBlendShapesGet8 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.importBlendShapes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Import Blend Shapes" )]
	class ModelImporterimportBlendShapesSet8 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importBlendShapes = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Add Collider" )]
	class ModelImporteraddColliderGet9 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.addCollider;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Add Collider" )]
	class ModelImporteraddColliderSet9 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.addCollider = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Normal Smoothing Angle" )]
	class ModelImporternormalSmoothingAngleGet10 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.normalSmoothingAngle;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Normal Smoothing Angle" )]
	class ModelImporternormalSmoothingAngleSet10 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.normalSmoothingAngle = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Swap UV Channels" )]
	class ModelImporterswapUVChannelsGet11 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.swapUVChannels;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Swap UV Channels" )]
	class ModelImporterswapUVChannelsSet11 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.swapUVChannels = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Generate Secondary UV" )]
	class ModelImportergenerateSecondaryUVGet12 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.generateSecondaryUV;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Generate Secondary UV" )]
	class ModelImportergenerateSecondaryUVSet12 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.generateSecondaryUV = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Secondary UV Angle Distortion" )]
	class ModelImportersecondaryUVAngleDistortionGet13 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVAngleDistortion;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Secondary UV Angle Distortion" )]
	class ModelImportersecondaryUVAngleDistortionSet13 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVAngleDistortion = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Secondary UV Area Distortion" )]
	class ModelImportersecondaryUVAreaDistortionGet14 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVAreaDistortion;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Secondary UV Area Distortion" )]
	class ModelImportersecondaryUVAreaDistortionSet14 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVAreaDistortion = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Secondary UV Hard Angle" )]
	class ModelImportersecondaryUVHardAngleGet15 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVHardAngle;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Secondary UV Hard Angle" )]
	class ModelImportersecondaryUVHardAngleSet15 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVHardAngle = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Secondary UV Pack Margin" )]
	class ModelImportersecondaryUVPackMarginGet16 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVPackMargin;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Secondary UV Pack Margin" )]
	class ModelImportersecondaryUVPackMarginSet16 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVPackMargin = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Generate Animations" )]
	class ModelImportergenerateAnimationsGet17 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterGenerateAnimations Result;

		public override IEnumerator Execute() {
			Result = Instance.generateAnimations;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Generate Animations" )]
	class ModelImportergenerateAnimationsSet17 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterGenerateAnimations Value;

		public override IEnumerator Execute() {
			Instance.generateAnimations = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Imported Take Infos" )]
	class ModelImporterimportedTakeInfosGet18 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.TakeInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.importedTakeInfos;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Transform Paths" )]
	class ModelImportertransformPathsGet19 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.transformPaths;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Referenced Clips" )]
	class ModelImporterreferencedClipsGet20 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.referencedClips;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Is Readable" )]
	class ModelImporterisReadableGet21 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isReadable;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Is Readable" )]
	class ModelImporterisReadableSet21 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isReadable = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Optimize Mesh" )]
	class ModelImporteroptimizeMeshGet22 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.optimizeMesh;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Optimize Mesh" )]
	class ModelImporteroptimizeMeshSet22 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.optimizeMesh = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Import Normals" )]
	class ModelImporterimportNormalsGet23 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterNormals Result;

		public override IEnumerator Execute() {
			Result = Instance.importNormals;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Import Normals" )]
	class ModelImporterimportNormalsSet23 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterNormals Value;

		public override IEnumerator Execute() {
			Instance.importNormals = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Import Tangents" )]
	class ModelImporterimportTangentsGet24 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterTangents Result;

		public override IEnumerator Execute() {
			Result = Instance.importTangents;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Import Tangents" )]
	class ModelImporterimportTangentsSet24 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterTangents Value;

		public override IEnumerator Execute() {
			Instance.importTangents = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Bake IK" )]
	class ModelImporterbakeIKGet25 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.bakeIK;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Bake IK" )]
	class ModelImporterbakeIKSet25 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.bakeIK = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Is Bake IK Supported" )]
	class ModelImporterisBakeIKSupportedGet26 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isBakeIKSupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Get Resample Curves" )]
	class ModelImporterresampleCurvesGet27 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.resampleCurves;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Resample Curves" )]
	class ModelImporterresampleCurvesSet27 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.resampleCurves = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Is Tangent Import Supported" )]
	class ModelImporterisTangentImportSupportedGet28 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isTangentImportSupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Get Mesh Compression" )]
	class ModelImportermeshCompressionGet29 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterMeshCompression Result;

		public override IEnumerator Execute() {
			Result = Instance.meshCompression;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Mesh Compression" )]
	class ModelImportermeshCompressionSet29 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMeshCompression Value;

		public override IEnumerator Execute() {
			Instance.meshCompression = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Import Animation" )]
	class ModelImporterimportAnimationGet30 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.importAnimation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Import Animation" )]
	class ModelImporterimportAnimationSet30 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importAnimation = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Optimize Game Objects" )]
	class ModelImporteroptimizeGameObjectsGet31 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.optimizeGameObjects;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Model Importer/Set Optimize Game Objects" )]
	class ModelImporteroptimizeGameObjectsSet31 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.optimizeGameObjects = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Extra Exposed Transform Paths" )]
	class ModelImporterextraExposedTransformPathsGet32 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.extraExposedTransformPaths;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Extra Exposed Transform Paths" )]
	class ModelImporterextraExposedTransformPathsSet32 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.String[] Value;

		public override IEnumerator Execute() {
			Instance.extraExposedTransformPaths = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Animation Compression" )]
	class ModelImporteranimationCompressionGet33 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterAnimationCompression Result;

		public override IEnumerator Execute() {
			Result = Instance.animationCompression;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Animation Compression" )]
	class ModelImporteranimationCompressionSet33 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterAnimationCompression Value;

		public override IEnumerator Execute() {
			Instance.animationCompression = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Animation Rotation Error" )]
	class ModelImporteranimationRotationErrorGet34 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.animationRotationError;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Animation Rotation Error" )]
	class ModelImporteranimationRotationErrorSet34 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.animationRotationError = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Animation Position Error" )]
	class ModelImporteranimationPositionErrorGet35 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.animationPositionError;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Animation Position Error" )]
	class ModelImporteranimationPositionErrorSet35 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.animationPositionError = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Animation Scale Error" )]
	class ModelImporteranimationScaleErrorGet36 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.animationScaleError;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Animation Scale Error" )]
	class ModelImporteranimationScaleErrorSet36 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.animationScaleError = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Animation Wrap Mode" )]
	class ModelImporteranimationWrapModeGet37 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.WrapMode Result;

		public override IEnumerator Execute() {
			Result = Instance.animationWrapMode;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Animation Wrap Mode" )]
	class ModelImporteranimationWrapModeSet37 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEngine.WrapMode Value;

		public override IEnumerator Execute() {
			Instance.animationWrapMode = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Animation Type" )]
	class ModelImporteranimationTypeGet38 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterAnimationType Result;

		public override IEnumerator Execute() {
			Result = Instance.animationType;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Animation Type" )]
	class ModelImporteranimationTypeSet38 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterAnimationType Value;

		public override IEnumerator Execute() {
			Instance.animationType = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Humanoid Oversampling" )]
	class ModelImporterhumanoidOversamplingGet39 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterHumanoidOversampling Result;

		public override IEnumerator Execute() {
			Result = Instance.humanoidOversampling;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Humanoid Oversampling" )]
	class ModelImporterhumanoidOversamplingSet39 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterHumanoidOversampling Value;

		public override IEnumerator Execute() {
			Instance.humanoidOversampling = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Motion Node Name" )]
	class ModelImportermotionNodeNameGet40 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.motionNodeName;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Motion Node Name" )]
	class ModelImportermotionNodeNameSet40 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.motionNodeName = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Source Avatar" )]
	class ModelImportersourceAvatarGet41 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Avatar Result;

		public override IEnumerator Execute() {
			Result = Instance.sourceAvatar;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Source Avatar" )]
	class ModelImportersourceAvatarSet41 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEngine.Avatar Value;

		public override IEnumerator Execute() {
			Instance.sourceAvatar = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Human Description" )]
	class ModelImporterhumanDescriptionGet42 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.HumanDescription Result;

		public override IEnumerator Execute() {
			Result = Instance.humanDescription;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Human Description" )]
	class ModelImporterhumanDescriptionSet42 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEngine.HumanDescription Value;

		public override IEnumerator Execute() {
			Instance.humanDescription = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Clip Animations" )]
	class ModelImporterclipAnimationsGet43 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterClipAnimation[] Result;

		public override IEnumerator Execute() {
			Result = Instance.clipAnimations;
			yield break;
		}

	}

	[Automation( "Model Importer/Set Clip Animations" )]
	class ModelImporterclipAnimationsSet43 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterClipAnimation[] Value;

		public override IEnumerator Execute() {
			Instance.clipAnimations = Value;
			yield break;
		}

	}

	[Automation( "Model Importer/Get Default Clip Animations" )]
	class ModelImporterdefaultClipAnimationsGet44 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.ModelImporterClipAnimation[] Result;

		public override IEnumerator Execute() {
			Result = Instance.defaultClipAnimations;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif