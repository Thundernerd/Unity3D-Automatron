using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Model Importer/Import Materials/Get" )]
	class ModelImporterimportMaterialsGet0 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.importMaterials;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Materials/Set" )]
	class ModelImporterimportMaterialsSet0 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importMaterials = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Material Name/Get" )]
	class ModelImportermaterialNameGet1 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterMaterialName Result;

		public override IEnumerator Execute() {
			Result = Instance.materialName;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Material Name/Set" )]
	class ModelImportermaterialNameSet1 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMaterialName Value;

		public override IEnumerator Execute() {
			Instance.materialName = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Material Search/Get" )]
	class ModelImportermaterialSearchGet2 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterMaterialSearch Result;

		public override IEnumerator Execute() {
			Result = Instance.materialSearch;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Material Search/Set" )]
	class ModelImportermaterialSearchSet2 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMaterialSearch Value;

		public override IEnumerator Execute() {
			Instance.materialSearch = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Global Scale/Get" )]
	class ModelImporterglobalScaleGet3 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.globalScale;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Global Scale/Set" )]
	class ModelImporterglobalScaleSet3 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.globalScale = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Is Use File Units Supported/Get" )]
	class ModelImporterisUseFileUnitsSupportedGet4 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isUseFileUnitsSupported;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Use File Units/Get" )]
	class ModelImporteruseFileUnitsGet5 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useFileUnits;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Use File Units/Set" )]
	class ModelImporteruseFileUnitsSet5 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useFileUnits = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/File Scale/Get" )]
	class ModelImporterfileScaleGet6 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fileScale;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Is File Scale Used/Get" )]
	class ModelImporterisFileScaleUsedGet7 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isFileScaleUsed;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Blend Shapes/Get" )]
	class ModelImporterimportBlendShapesGet8 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.importBlendShapes;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Blend Shapes/Set" )]
	class ModelImporterimportBlendShapesSet8 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importBlendShapes = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Add Collider/Get" )]
	class ModelImporteraddColliderGet9 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.addCollider;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Add Collider/Set" )]
	class ModelImporteraddColliderSet9 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.addCollider = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Normal Smoothing Angle/Get" )]
	class ModelImporternormalSmoothingAngleGet10 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.normalSmoothingAngle;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Normal Smoothing Angle/Set" )]
	class ModelImporternormalSmoothingAngleSet10 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.normalSmoothingAngle = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Swap UV Channels/Get" )]
	class ModelImporterswapUVChannelsGet11 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.swapUVChannels;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Swap UV Channels/Set" )]
	class ModelImporterswapUVChannelsSet11 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.swapUVChannels = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Generate Secondary UV/Get" )]
	class ModelImportergenerateSecondaryUVGet12 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.generateSecondaryUV;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Generate Secondary UV/Set" )]
	class ModelImportergenerateSecondaryUVSet12 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.generateSecondaryUV = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Angle Distortion/Get" )]
	class ModelImportersecondaryUVAngleDistortionGet13 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVAngleDistortion;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Angle Distortion/Set" )]
	class ModelImportersecondaryUVAngleDistortionSet13 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVAngleDistortion = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Area Distortion/Get" )]
	class ModelImportersecondaryUVAreaDistortionGet14 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVAreaDistortion;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Area Distortion/Set" )]
	class ModelImportersecondaryUVAreaDistortionSet14 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVAreaDistortion = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Hard Angle/Get" )]
	class ModelImportersecondaryUVHardAngleGet15 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVHardAngle;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Hard Angle/Set" )]
	class ModelImportersecondaryUVHardAngleSet15 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVHardAngle = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Pack Margin/Get" )]
	class ModelImportersecondaryUVPackMarginGet16 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.secondaryUVPackMargin;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Secondary UV Pack Margin/Set" )]
	class ModelImportersecondaryUVPackMarginSet16 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.secondaryUVPackMargin = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Generate Animations/Get" )]
	class ModelImportergenerateAnimationsGet17 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterGenerateAnimations Result;

		public override IEnumerator Execute() {
			Result = Instance.generateAnimations;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Generate Animations/Set" )]
	class ModelImportergenerateAnimationsSet17 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterGenerateAnimations Value;

		public override IEnumerator Execute() {
			Instance.generateAnimations = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Imported Take Infos/Get" )]
	class ModelImporterimportedTakeInfosGet18 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.TakeInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.importedTakeInfos;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Transform Paths/Get" )]
	class ModelImportertransformPathsGet19 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.transformPaths;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Referenced Clips/Get" )]
	class ModelImporterreferencedClipsGet20 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.referencedClips;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Is Readable/Get" )]
	class ModelImporterisReadableGet21 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isReadable;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Is Readable/Set" )]
	class ModelImporterisReadableSet21 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isReadable = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Optimize Mesh/Get" )]
	class ModelImporteroptimizeMeshGet22 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.optimizeMesh;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Optimize Mesh/Set" )]
	class ModelImporteroptimizeMeshSet22 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.optimizeMesh = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Normals/Get" )]
	class ModelImporterimportNormalsGet23 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterNormals Result;

		public override IEnumerator Execute() {
			Result = Instance.importNormals;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Normals/Set" )]
	class ModelImporterimportNormalsSet23 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterNormals Value;

		public override IEnumerator Execute() {
			Instance.importNormals = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Tangents/Get" )]
	class ModelImporterimportTangentsGet24 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterTangents Result;

		public override IEnumerator Execute() {
			Result = Instance.importTangents;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Tangents/Set" )]
	class ModelImporterimportTangentsSet24 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterTangents Value;

		public override IEnumerator Execute() {
			Instance.importTangents = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Bake IK/Get" )]
	class ModelImporterbakeIKGet25 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.bakeIK;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Bake IK/Set" )]
	class ModelImporterbakeIKSet25 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.bakeIK = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Is Bake IK Supported/Get" )]
	class ModelImporterisBakeIKSupportedGet26 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isBakeIKSupported;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Resample Curves/Get" )]
	class ModelImporterresampleCurvesGet27 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.resampleCurves;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Resample Curves/Set" )]
	class ModelImporterresampleCurvesSet27 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.resampleCurves = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Is Tangent Import Supported/Get" )]
	class ModelImporterisTangentImportSupportedGet28 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isTangentImportSupported;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Mesh Compression/Get" )]
	class ModelImportermeshCompressionGet29 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterMeshCompression Result;

		public override IEnumerator Execute() {
			Result = Instance.meshCompression;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Mesh Compression/Set" )]
	class ModelImportermeshCompressionSet29 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMeshCompression Value;

		public override IEnumerator Execute() {
			Instance.meshCompression = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Animation/Get" )]
	class ModelImporterimportAnimationGet30 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.importAnimation;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Import Animation/Set" )]
	class ModelImporterimportAnimationSet30 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importAnimation = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Optimize Game Objects/Get" )]
	class ModelImporteroptimizeGameObjectsGet31 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.optimizeGameObjects;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Optimize Game Objects/Set" )]
	class ModelImporteroptimizeGameObjectsSet31 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.optimizeGameObjects = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Extra Exposed Transform Paths/Get" )]
	class ModelImporterextraExposedTransformPathsGet32 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.extraExposedTransformPaths;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Extra Exposed Transform Paths/Set" )]
	class ModelImporterextraExposedTransformPathsSet32 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.String[] Value;

		public override IEnumerator Execute() {
			Instance.extraExposedTransformPaths = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Compression/Get" )]
	class ModelImporteranimationCompressionGet33 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterAnimationCompression Result;

		public override IEnumerator Execute() {
			Result = Instance.animationCompression;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Compression/Set" )]
	class ModelImporteranimationCompressionSet33 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterAnimationCompression Value;

		public override IEnumerator Execute() {
			Instance.animationCompression = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Rotation Error/Get" )]
	class ModelImporteranimationRotationErrorGet34 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.animationRotationError;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Rotation Error/Set" )]
	class ModelImporteranimationRotationErrorSet34 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.animationRotationError = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Position Error/Get" )]
	class ModelImporteranimationPositionErrorGet35 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.animationPositionError;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Position Error/Set" )]
	class ModelImporteranimationPositionErrorSet35 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.animationPositionError = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Scale Error/Get" )]
	class ModelImporteranimationScaleErrorGet36 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.animationScaleError;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Scale Error/Set" )]
	class ModelImporteranimationScaleErrorSet36 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.animationScaleError = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Wrap Mode/Get" )]
	class ModelImporteranimationWrapModeGet37 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEngine.WrapMode Result;

		public override IEnumerator Execute() {
			Result = Instance.animationWrapMode;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Wrap Mode/Set" )]
	class ModelImporteranimationWrapModeSet37 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEngine.WrapMode Value;

		public override IEnumerator Execute() {
			Instance.animationWrapMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Type/Get" )]
	class ModelImporteranimationTypeGet38 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterAnimationType Result;

		public override IEnumerator Execute() {
			Result = Instance.animationType;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Animation Type/Set" )]
	class ModelImporteranimationTypeSet38 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterAnimationType Value;

		public override IEnumerator Execute() {
			Instance.animationType = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Humanoid Oversampling/Get" )]
	class ModelImporterhumanoidOversamplingGet39 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterHumanoidOversampling Result;

		public override IEnumerator Execute() {
			Result = Instance.humanoidOversampling;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Humanoid Oversampling/Set" )]
	class ModelImporterhumanoidOversamplingSet39 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterHumanoidOversampling Value;

		public override IEnumerator Execute() {
			Instance.humanoidOversampling = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Motion Node Name/Get" )]
	class ModelImportermotionNodeNameGet40 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.motionNodeName;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Motion Node Name/Set" )]
	class ModelImportermotionNodeNameSet40 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.motionNodeName = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Source Avatar/Get" )]
	class ModelImportersourceAvatarGet41 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEngine.Avatar Result;

		public override IEnumerator Execute() {
			Result = Instance.sourceAvatar;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Source Avatar/Set" )]
	class ModelImportersourceAvatarSet41 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEngine.Avatar Value;

		public override IEnumerator Execute() {
			Instance.sourceAvatar = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Human Description/Get" )]
	class ModelImporterhumanDescriptionGet42 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEngine.HumanDescription Result;

		public override IEnumerator Execute() {
			Result = Instance.humanDescription;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Human Description/Set" )]
	class ModelImporterhumanDescriptionSet42 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEngine.HumanDescription Value;

		public override IEnumerator Execute() {
			Instance.humanDescription = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Clip Animations/Get" )]
	class ModelImporterclipAnimationsGet43 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterClipAnimation[] Result;

		public override IEnumerator Execute() {
			Result = Instance.clipAnimations;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Clip Animations/Set" )]
	class ModelImporterclipAnimationsSet43 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterClipAnimation[] Value;

		public override IEnumerator Execute() {
			Instance.clipAnimations = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Default Clip Animations/Get" )]
	class ModelImporterdefaultClipAnimationsGet44 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterClipAnimation[] Result;

		public override IEnumerator Execute() {
			Result = Instance.defaultClipAnimations;
			yield break;
		}

	}


#pragma warning restore 0649
}
