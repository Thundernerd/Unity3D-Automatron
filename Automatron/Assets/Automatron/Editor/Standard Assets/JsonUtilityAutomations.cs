using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Json Utility/To Json" )]
	class JsonUtilityToJson1 : Automation {

		public System.Object obj;
		public System.Boolean prettyPrint;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.JsonUtility.ToJson(obj,prettyPrint);
			yield break;
		}

	}

	[Automation( "Utilities/Json Utility/From Json" )]
	class JsonUtilityFromJson2 : Automation {

		public System.String json;
		public System.Type type;
		[ReadOnly]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.JsonUtility.FromJson(json,type);
			yield break;
		}

	}

	[Automation( "Utilities/Json Utility/From Json Overwrite" )]
	class JsonUtilityFromJsonOverwrite3 : Automation {

		public System.String json;
		public System.Object objectToOverwrite;

		public override IEnumerator Execute() {
			UnityEngine.JsonUtility.FromJsonOverwrite(json,objectToOverwrite);
			yield break;
		}

	}


#pragma warning restore 0649
}
