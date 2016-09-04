using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Int/Get Max Value" )]
	class Int32MaxValueGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Int32.MaxValue;
			yield break;
		}

	}

	[Automation( "Int/Get Min Value" )]
	class Int32MinValueGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Int32.MinValue;
			yield break;
		}

	}

	[Automation( "Int/Parse" )]
	class Int32Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Int32.Parse(s);
			yield break;
		}

	}

	[Automation( "Int/Try Parse" )]
	class Int32TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.Int32 result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Int32.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Int/To String" )]
	class Int32ToString2 : Automation {

		public System.Int32 Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
