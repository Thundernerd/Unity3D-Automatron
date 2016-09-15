using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Sketch Up Importer/Get Latitude" )]
	class SketchUpImporterlatitudeGet0 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.latitude;
			yield break;
		}

	}

	[Automation( "Sketch Up Importer/Get Longitude" )]
	class SketchUpImporterlongitudeGet1 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.longitude;
			yield break;
		}

	}

	[Automation( "Sketch Up Importer/Get North Correction" )]
	class SketchUpImporternorthCorrectionGet2 : Automation {

		public UnityEditor.SketchUpImporter Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.northCorrection;
			yield break;
		}

	}

	[Automation( "Sketch Up Importer/Get Default Camera" )]
	class SketchUpImporterGetDefaultCamera0 : Automation {

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
