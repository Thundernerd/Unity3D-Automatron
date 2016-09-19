#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Json Utility/To Json" )]
	class JsonUtilityToJson0 : Automation {

		public System.Object obj;
		public System.Boolean prettyPrint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.JsonUtility.ToJson(obj,prettyPrint);
			yield break;
		}

	}

	[Automation( "Json Utility/From Json" )]
	class JsonUtilityFromJson1 : Automation {

		public System.String json;
        [TypeLimit( typeof( System.Object ) )]
        public System.Type type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.JsonUtility.FromJson(json,type);
			yield break;
		}

	}

	[Automation( "Json Utility/From Json Overwrite" )]
	class JsonUtilityFromJsonOverwrite2 : Automation {

		public System.String json;
		public System.Object objectToOverwrite;

		public override IEnumerator Execute() {
			UnityEngine.JsonUtility.FromJsonOverwrite(json,objectToOverwrite);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif