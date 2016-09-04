using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Color Utility/Try Parse Html String" )]
	class ColorUtilityTryParseHtmlString0 : ConditionalAutomation {

		public System.String htmlString;
		public UnityEngine.Color color;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.ColorUtility.TryParseHtmlString(htmlString,out color);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Color Utility/To Html String RGB" )]
	class ColorUtilityToHtmlStringRGB1 : Automation {

		public UnityEngine.Color color;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ColorUtility.ToHtmlStringRGB(color);
			yield break;
		}

	}

	[Automation( "Utilities/Color Utility/To Html String RGBA" )]
	class ColorUtilityToHtmlStringRGBA2 : Automation {

		public UnityEngine.Color color;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.ColorUtility.ToHtmlStringRGBA(color);
			yield break;
		}

	}


#pragma warning restore 0649
}