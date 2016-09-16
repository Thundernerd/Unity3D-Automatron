using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Bool/Get False String" )]
	class BooleanFalseStringGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.FalseString;
			yield break;
		}

	}

	[Automation( "Bool/Get True String" )]
	class BooleanTrueStringGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.TrueString;
			yield break;
		}

	}

	[Automation( "Bool/Equals" )]
	class BooleanEquals0 : ConditionalAutomation {

		public System.Boolean Instance;
		public System.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Bool/Parse" )]
	class BooleanParse1 : ConditionalAutomation {

		public System.String value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.Parse(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Bool/Try Parse" )]
	class BooleanTryParse2 : ConditionalAutomation {

		public System.String value;
		public System.Boolean result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Boolean.TryParse(value,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
