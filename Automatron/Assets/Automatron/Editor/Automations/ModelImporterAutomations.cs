using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Importers/Model Importer/Get Import Materials" )]
	class ModelImporterimportMaterialsGet0 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.importMaterials;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Model Importer/Set Import Materials" )]
	class ModelImporterimportMaterialsSet0 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importMaterials = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Material Name" )]
	class ModelImportermaterialNameGet1 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterMaterialName Result;

		public override IEnumerator Execute() {
			Result = Instance.materialName;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Set Material Name" )]
	class ModelImportermaterialNameSet1 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMaterialName Value;

		public override IEnumerator Execute() {
			Instance.materialName = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Material Search" )]
	class ModelImportermaterialSearchGet2 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public UnityEditor.ModelImporterMaterialSearch Result;

		public override IEnumerator Execute() {
			Result = Instance.materialSearch;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Set Material Search" )]
	class ModelImportermaterialSearchSet2 : Automation {

		public UnityEditor.ModelImporter Instance;
		public UnityEditor.ModelImporterMaterialSearch Value;

		public override IEnumerator Execute() {
			Instance.materialSearch = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Global Scale" )]
	class ModelImporterglobalScaleGet3 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.globalScale;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Set Global Scale" )]
	class ModelImporterglobalScaleSet3 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.globalScale = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Is Use File Units Supported" )]
	class ModelImporterisUseFileUnitsSupportedGet4 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isUseFileUnitsSupported;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Model Importer/Get Use File Units" )]
	class ModelImporteruseFileUnitsGet5 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.useFileUnits;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Model Importer/Set Use File Units" )]
	class ModelImporteruseFileUnitsSet5 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useFileUnits = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get File Scale" )]
	class ModelImporterfileScaleGet6 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fileScale;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Is File Scale Used" )]
	class ModelImporterisFileScaleUsedGet7 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isFileScaleUsed;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Model Importer/Get Import Blend Shapes" )]
	class ModelImporterimportBlendShapesGet8 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.importBlendShapes;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Model Importer/Set Import Blend Shapes" )]
	class ModelImporterimportBlendShapesSet8 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.importBlendShapes = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Add Collider" )]
	class ModelImporteraddColliderGet9 : ConditionalAutomation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.addCollider;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Model Importer/Set Add Collider" )]
	class ModelImporteraddColliderSet9 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.addCollider = Value;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Get Normal Smoothing Angle" )]
	class ModelImporternormalSmoothingAngleGet10 : Automation {

		public UnityEditor.ModelImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.normalSmoothingAngle;
			yield break;
		}

	}

	[Automation( "Importers/Model Importer/Set Normal Smoothing Angle" )]
	class ModelImporternormalSmoothingAngleSet10 : Automation {

		public UnityEditor.ModelImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.normalSmoothingAngle = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
