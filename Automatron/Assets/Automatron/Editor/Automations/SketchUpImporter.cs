using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Importers/Sketch Up Importer/Latitude/Get" )]
	class SketchUpImporterlatitudeGet0 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.latitude;
			yield break;
		}

	}

	[Automation( "Importers/Sketch Up Importer/Longitude/Get" )]
	class SketchUpImporterlongitudeGet1 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.longitude;
			yield break;
		}

	}

	[Automation( "Importers/Sketch Up Importer/North Correction/Get" )]
	class SketchUpImporternorthCorrectionGet2 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.northCorrection;
			yield break;
		}

	}

	[Automation( "Importers/Sketch Up Importer/Get Scenes" )]
	class SketchUpImporterGetScenes0 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public UnityEditor.SketchUpImportScene[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetScenes();
			yield break;
		}

	}

	[Automation( "Importers/Sketch Up Importer/Get Default Camera" )]
	class SketchUpImporterGetDefaultCamera1 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public UnityEditor.SketchUpImportCamera Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDefaultCamera();
			yield break;
		}

	}


#pragma warning restore 0649
}
