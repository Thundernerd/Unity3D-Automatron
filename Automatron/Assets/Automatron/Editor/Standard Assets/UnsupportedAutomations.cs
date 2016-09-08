using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsupported/Capture Screenshot Immediate" )]
	class UnsupportedCaptureScreenshotImmediate0 : Automation {

		public System.String filePath;
		public System.Int32 x;
		public System.Int32 y;
		public System.Int32 width;
		public System.Int32 height;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.CaptureScreenshotImmediate(filePath,x,y,width,height);
			yield break;
		}

	}


#pragma warning restore 0649
}
