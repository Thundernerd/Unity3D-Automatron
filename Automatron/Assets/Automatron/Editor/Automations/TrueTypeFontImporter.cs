using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/True Type Font Importer/Font Size/Get" )]
	class TrueTypeFontImporterfontSizeGet0 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.fontSize;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Size/Set" )]
	class TrueTypeFontImporterfontSizeSet0 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.fontSize = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Texture Case/Get" )]
	class TrueTypeFontImporterfontTextureCaseGet1 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEditor.FontTextureCase Result;

		public override IEnumerator Execute() {
			Result = Instance.fontTextureCase;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Texture Case/Set" )]
	class TrueTypeFontImporterfontTextureCaseSet1 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEditor.FontTextureCase Value;

		public override IEnumerator Execute() {
			Instance.fontTextureCase = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Include Font Data/Get" )]
	class TrueTypeFontImporterincludeFontDataGet2 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.includeFontData;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Include Font Data/Set" )]
	class TrueTypeFontImporterincludeFontDataSet2 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.includeFontData = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Ascent Calculation Mode/Get" )]
	class TrueTypeFontImporterascentCalculationModeGet3 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEditor.AscentCalculationMode Result;

		public override IEnumerator Execute() {
			Result = Instance.ascentCalculationMode;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Ascent Calculation Mode/Set" )]
	class TrueTypeFontImporterascentCalculationModeSet3 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEditor.AscentCalculationMode Value;

		public override IEnumerator Execute() {
			Instance.ascentCalculationMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Names/Get" )]
	class TrueTypeFontImporterfontNamesGet4 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.fontNames;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Names/Set" )]
	class TrueTypeFontImporterfontNamesSet4 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.String[] Value;

		public override IEnumerator Execute() {
			Instance.fontNames = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font References/Get" )]
	class TrueTypeFontImporterfontReferencesGet5 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEngine.Font[] Result;

		public override IEnumerator Execute() {
			Result = Instance.fontReferences;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font References/Set" )]
	class TrueTypeFontImporterfontReferencesSet5 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEngine.Font[] Value;

		public override IEnumerator Execute() {
			Instance.fontReferences = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Custom Characters/Get" )]
	class TrueTypeFontImportercustomCharactersGet6 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.customCharacters;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Custom Characters/Set" )]
	class TrueTypeFontImportercustomCharactersSet6 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.customCharacters = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font TTF Name/Get" )]
	class TrueTypeFontImporterfontTTFNameGet7 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.fontTTFName;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Character Spacing/Get" )]
	class TrueTypeFontImportercharacterSpacingGet8 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.characterSpacing;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Character Spacing/Set" )]
	class TrueTypeFontImportercharacterSpacingSet8 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.characterSpacing = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Character Padding/Get" )]
	class TrueTypeFontImportercharacterPaddingGet9 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.characterPadding;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Character Padding/Set" )]
	class TrueTypeFontImportercharacterPaddingSet9 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.characterPadding = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Rendering Mode/Get" )]
	class TrueTypeFontImporterfontRenderingModeGet10 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEditor.FontRenderingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.fontRenderingMode;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Font Rendering Mode/Set" )]
	class TrueTypeFontImporterfontRenderingModeSet10 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEditor.FontRenderingMode Value;

		public override IEnumerator Execute() {
			Instance.fontRenderingMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Generate Editable Font" )]
	class TrueTypeFontImporterGenerateEditableFont0 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.String path;
		[ReadOnly]
		public UnityEngine.Font Result;

		public override IEnumerator Execute() {
			Result = Instance.GenerateEditableFont(path);
			yield break;
		}

	}


#pragma warning restore 0649
}
