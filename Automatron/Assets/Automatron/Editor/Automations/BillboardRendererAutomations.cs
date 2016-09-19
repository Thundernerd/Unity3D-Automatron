#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Billboard Renderer/Get Billboard" )]
	class BillboardRendererbillboardGet0 : Automation {

		public UnityEngine.BillboardRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.BillboardAsset Result;

		public override IEnumerator Execute() {
			Result = Instance.billboard;
			yield break;
		}

	}

	[Automation( "Billboard Renderer/Set Billboard" )]
	class BillboardRendererbillboardSet0 : Automation {

		public UnityEngine.BillboardRenderer Instance;
		public UnityEngine.BillboardAsset Value;

		public override IEnumerator Execute() {
			Instance.billboard = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif