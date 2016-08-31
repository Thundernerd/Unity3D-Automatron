using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Primitives/Bool/Get False String" )]
	class BooleanFalseStringGet0 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.FalseString;
			yield break;
		}

	}

	[Automation( "Primitives/Bool/Get True String" )]
	class BooleanTrueStringGet1 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.TrueString;
			yield break;
		}

	}

	[Automation( "Primitives/Bool/Parse" )]
	class BooleanParse0 : Automation {

		public System.String value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.Parse(value);
			yield break;
		}

	}

	[Automation( "Primitives/Bool/Try Parse" )]
	class BooleanTryParse1 : Automation {

		public System.String value;
		public System.Boolean result;
		[ReadOnly]
		public System.Boolean ParseResult;

		public override IEnumerator Execute() {
			ParseResult = System.Boolean.TryParse(value,out result);
			yield break;
		}

	}


#pragma warning restore 0649
}
