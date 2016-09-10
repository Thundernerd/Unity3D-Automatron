using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Importers/Movie Importer/Get Quality" )]
	class MovieImporterqualityGet0 : Automation {

		public UnityEditor.MovieImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.quality;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Set Quality" )]
	class MovieImporterqualitySet0 : Automation {

		public UnityEditor.MovieImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.quality = Value;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Get Linear Texture" )]
	class MovieImporterlinearTextureGet1 : ConditionalAutomation {

		public UnityEditor.MovieImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.linearTexture;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Importers/Movie Importer/Set Linear Texture" )]
	class MovieImporterlinearTextureSet1 : Automation {

		public UnityEditor.MovieImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.linearTexture = Value;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Get Duration" )]
	class MovieImporterdurationGet2 : Automation {

		public UnityEditor.MovieImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.duration;
			yield break;
		}

	}


#pragma warning restore 0649
}
