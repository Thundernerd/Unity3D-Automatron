using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/True Type Font Importer/Get Font Size" )]
	class TrueTypeFontImporterfontSizeGet0 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.fontSize;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Font Size" )]
	class TrueTypeFontImporterfontSizeSet0 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.fontSize = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Font Texture Case" )]
	class TrueTypeFontImporterfontTextureCaseGet1 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEditor.FontTextureCase Result;

		public override IEnumerator Execute() {
			Result = Instance.fontTextureCase;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Font Texture Case" )]
	class TrueTypeFontImporterfontTextureCaseSet1 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEditor.FontTextureCase Value;

		public override IEnumerator Execute() {
			Instance.fontTextureCase = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Include Font Data" )]
	class TrueTypeFontImporterincludeFontDataGet2 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.includeFontData;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Include Font Data" )]
	class TrueTypeFontImporterincludeFontDataSet2 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.includeFontData = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Ascent Calculation Mode" )]
	class TrueTypeFontImporterascentCalculationModeGet3 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEditor.AscentCalculationMode Result;

		public override IEnumerator Execute() {
			Result = Instance.ascentCalculationMode;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Ascent Calculation Mode" )]
	class TrueTypeFontImporterascentCalculationModeSet3 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEditor.AscentCalculationMode Value;

		public override IEnumerator Execute() {
			Instance.ascentCalculationMode = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Font Names" )]
	class TrueTypeFontImporterfontNamesGet4 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.fontNames;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Font Names" )]
	class TrueTypeFontImporterfontNamesSet4 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.String[] Value;

		public override IEnumerator Execute() {
			Instance.fontNames = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Font References" )]
	class TrueTypeFontImporterfontReferencesGet5 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEngine.Font[] Result;

		public override IEnumerator Execute() {
			Result = Instance.fontReferences;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Font References" )]
	class TrueTypeFontImporterfontReferencesSet5 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public UnityEngine.Font[] Value;

		public override IEnumerator Execute() {
			Instance.fontReferences = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Custom Characters" )]
	class TrueTypeFontImportercustomCharactersGet6 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.customCharacters;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Custom Characters" )]
	class TrueTypeFontImportercustomCharactersSet6 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.customCharacters = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Font TTF Name" )]
	class TrueTypeFontImporterfontTTFNameGet7 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.fontTTFName;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Character Spacing" )]
	class TrueTypeFontImportercharacterSpacingGet8 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.characterSpacing;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Character Spacing" )]
	class TrueTypeFontImportercharacterSpacingSet8 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.characterSpacing = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Character Padding" )]
	class TrueTypeFontImportercharacterPaddingGet9 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.characterPadding;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Character Padding" )]
	class TrueTypeFontImportercharacterPaddingSet9 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.characterPadding = Value;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Get Font Rendering Mode" )]
	class TrueTypeFontImporterfontRenderingModeGet10 : Automation {

		public UnityEditor.TrueTypeFontImporter Instance;
		[ReadOnly]
		public UnityEditor.FontRenderingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.fontRenderingMode;
			yield break;
		}

	}

	[Automation( "Importers/True Type Font Importer/Set Font Rendering Mode" )]
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
