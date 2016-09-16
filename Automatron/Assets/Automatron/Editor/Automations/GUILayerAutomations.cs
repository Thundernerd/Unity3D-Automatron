using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "GUI Layer/Hit Test" )]
	class GUILayerHitTest0 : Automation {

		public UnityEngine.GUILayer Instance;
		public UnityEngine.Vector3 screenPosition;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GUIElement Result;

		public override IEnumerator Execute() {
			Result = Instance.HitTest(screenPosition);
			yield break;
		}

	}


#pragma warning restore 0649
}
