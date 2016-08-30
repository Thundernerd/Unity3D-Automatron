using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Asset Importer/Asset Path/Get" )]
	class AssetImporterassetPathGet0 : Automation {

		public UnityEditor.AssetImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.assetPath;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Asset Time Stamp/Get" )]
	class AssetImporterassetTimeStampGet1 : Automation {

		public UnityEditor.AssetImporter Instance;
		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = Instance.assetTimeStamp;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/User Data/Get" )]
	class AssetImporteruserDataGet2 : Automation {

		public UnityEditor.AssetImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.userData;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/User Data/Set" )]
	class AssetImporteruserDataSet2 : Automation {

		public UnityEditor.AssetImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.userData = Value;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Asset Bundle Name/Get" )]
	class AssetImporterassetBundleNameGet3 : Automation {

		public UnityEditor.AssetImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.assetBundleName;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Asset Bundle Name/Set" )]
	class AssetImporterassetBundleNameSet3 : Automation {

		public UnityEditor.AssetImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.assetBundleName = Value;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Asset Bundle Variant/Get" )]
	class AssetImporterassetBundleVariantGet4 : Automation {

		public UnityEditor.AssetImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.assetBundleVariant;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Asset Bundle Variant/Set" )]
	class AssetImporterassetBundleVariantSet4 : Automation {

		public UnityEditor.AssetImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.assetBundleVariant = Value;
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Set Asset Bundle Name And Variant" )]
	class AssetImporterSetAssetBundleNameAndVariant0 : Automation {

		public UnityEditor.AssetImporter Instance;
		public System.String assetBundleName;
		public System.String assetBundleVariant;

		public override IEnumerator Execute() {
			Instance.SetAssetBundleNameAndVariant(assetBundleName,assetBundleVariant);
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Get At Path" )]
	class AssetImporterGetAtPath1 : Automation {

		public System.String path;
		[ReadOnly]
		public UnityEditor.AssetImporter Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetImporter.GetAtPath(path);
			yield break;
		}

	}

	[Automation( "Importers/Asset Importer/Save And Reimport" )]
	class AssetImporterSaveAndReimport2 : Automation {

		public UnityEditor.AssetImporter Instance;

		public override IEnumerator Execute() {
			Instance.SaveAndReimport();
			yield break;
		}

	}


#pragma warning restore 0649
}
