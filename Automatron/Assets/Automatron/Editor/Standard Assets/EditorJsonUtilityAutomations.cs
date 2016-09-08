using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Editor Json Utility/To Json" )]
	class EditorJsonUtilityToJson1 : Automation {

		public UnityEngine.Object obj;
		public System.Boolean prettyPrint;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorJsonUtility.ToJson(obj,prettyPrint);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Json Utility/From Json Overwrite" )]
	class EditorJsonUtilityFromJsonOverwrite2 : Automation {

		public System.String json;
		public UnityEngine.Object objectToOverwrite;

		public override IEnumerator Execute() {
			UnityEditor.EditorJsonUtility.FromJsonOverwrite(json,objectToOverwrite);
			yield break;
		}

	}


#pragma warning restore 0649
}
