using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Text Asset/Get Text" )]
	class TextAssettextGet0 : Automation {

		public UnityEngine.TextAsset Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.text;
			yield break;
		}

	}


#pragma warning restore 0649
}
