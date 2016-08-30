using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Movie Importer/Quality/Get" )]
	class MovieImporterqualityGet0 : Automation {

		public UnityEditor.MovieImporter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.quality;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Quality/Set" )]
	class MovieImporterqualitySet0 : Automation {

		public UnityEditor.MovieImporter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.quality = Value;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Linear Texture/Get" )]
	class MovieImporterlinearTextureGet1 : Automation {

		public UnityEditor.MovieImporter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.linearTexture;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Linear Texture/Set" )]
	class MovieImporterlinearTextureSet1 : Automation {

		public UnityEditor.MovieImporter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.linearTexture = Value;
			yield break;
		}

	}

	[Automation( "Importers/Movie Importer/Duration/Get" )]
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
