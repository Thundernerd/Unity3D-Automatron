using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Boolean/Get False String" )]
	class BooleanFalseStringGet0 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.FalseString;
			yield break;
		}

	}

	[Automation( "Boolean/Get True String" )]
	class BooleanTrueStringGet1 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.TrueString;
			yield break;
		}

	}

	[Automation( "Boolean/Parse" )]
	class BooleanParse0 : ConditionalAutomation {

		public System.String value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Boolean.Parse(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Boolean/Try Parse" )]
	class BooleanTryParse1 : ConditionalAutomation {

		public System.String value;
		public System.Boolean result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Boolean.TryParse(value,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Boolean/To String" )]
	class BooleanToString2 : Automation {

		public System.Boolean Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
