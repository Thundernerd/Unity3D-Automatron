using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Tree/Get Data" )]
	class TreedataGet0 : Automation {

		public UnityEngine.Tree Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.ScriptableObject Result;

		public override IEnumerator Execute() {
			Result = Instance.data;
			yield break;
		}

	}

	[Automation( "Tree/Set Data" )]
	class TreedataSet0 : Automation {

		public UnityEngine.Tree Instance;
		public UnityEngine.ScriptableObject Value;

		public override IEnumerator Execute() {
			Instance.data = Value;
			yield break;
		}

	}

	[Automation( "Tree/Get Has Speed Tree Wind" )]
	class TreehasSpeedTreeWindGet1 : ConditionalAutomation {

		public UnityEngine.Tree Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.hasSpeedTreeWind;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
