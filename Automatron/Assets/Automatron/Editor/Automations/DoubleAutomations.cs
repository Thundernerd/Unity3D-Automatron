using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Double/Get Epsilon" )]
	class DoubleEpsilonGet0 : Automation {

		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.Epsilon;
			yield break;
		}

	}

	[Automation( "Double/Get Max Value" )]
	class DoubleMaxValueGet1 : Automation {

		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.MaxValue;
			yield break;
		}

	}

	[Automation( "Double/Get Min Value" )]
	class DoubleMinValueGet2 : Automation {

		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.MinValue;
			yield break;
		}

	}

	[Automation( "Double/Get Na N" )]
	class DoubleNaNGet3 : Automation {

		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.NaN;
			yield break;
		}

	}

	[Automation( "Double/Get Negative Infinity" )]
	class DoubleNegativeInfinityGet4 : Automation {

		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.NegativeInfinity;
			yield break;
		}

	}

	[Automation( "Double/Get Positive Infinity" )]
	class DoublePositiveInfinityGet5 : Automation {

		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.PositiveInfinity;
			yield break;
		}

	}

	[Automation( "Double/Is Infinity" )]
	class DoubleIsInfinity0 : ConditionalAutomation {

		public System.Double d;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Double.IsInfinity(d);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Double/Is Na N" )]
	class DoubleIsNaN1 : ConditionalAutomation {

		public System.Double d;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Double.IsNaN(d);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Double/Is Negative Infinity" )]
	class DoubleIsNegativeInfinity2 : ConditionalAutomation {

		public System.Double d;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Double.IsNegativeInfinity(d);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Double/Is Positive Infinity" )]
	class DoubleIsPositiveInfinity3 : ConditionalAutomation {

		public System.Double d;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Double.IsPositiveInfinity(d);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Double/Parse" )]
	class DoubleParse4 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Double.Parse(s);
			yield break;
		}

	}

	[Automation( "Double/Try Parse" )]
	class DoubleTryParse5 : ConditionalAutomation {

		public System.String s;
		public System.Double result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Double.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Double/To String" )]
	class DoubleToString6 : Automation {

		public System.Double Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
