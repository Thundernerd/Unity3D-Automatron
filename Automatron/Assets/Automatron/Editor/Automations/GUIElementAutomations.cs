using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "GUI Element/Hit Test" )]
	class GUIElementHitTest0 : ConditionalAutomation {

		public UnityEngine.GUIElement Instance;
		public UnityEngine.Vector3 screenPosition;
		public UnityEngine.Camera camera;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.HitTest(screenPosition,camera);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "GUI Element/Get Screen Rect" )]
	class GUIElementGetScreenRect1 : Automation {

		public UnityEngine.GUIElement Instance;
		public UnityEngine.Camera camera;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.GetScreenRect(camera);
			yield break;
		}

	}


#pragma warning restore 0649
}
