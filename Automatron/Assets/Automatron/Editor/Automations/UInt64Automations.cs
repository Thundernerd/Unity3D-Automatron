using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Long/Get Max Value" )]
	class UInt64MaxValueGet0 : Automation {

		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Long/Get Min Value" )]
	class UInt64MinValueGet1 : Automation {

		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.MinValue;
			yield break;
		}

	}

	[Automation( "Unsigned Long/Parse" )]
	class UInt64Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Long/Try Parse" )]
	class UInt64TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.UInt64 result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
