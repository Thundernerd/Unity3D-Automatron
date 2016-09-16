using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Long/Get Max Value" )]
	class Int64MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = System.Int64.MaxValue;
			yield break;
		}

	}

	[Automation( "Long/Get Min Value" )]
	class Int64MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = System.Int64.MinValue;
			yield break;
		}

	}

	[Automation( "Long/Parse" )]
	class Int64Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = System.Int64.Parse(s);
			yield break;
		}

	}

	[Automation( "Long/Try Parse" )]
	class Int64TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.Int64 result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Int64.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
