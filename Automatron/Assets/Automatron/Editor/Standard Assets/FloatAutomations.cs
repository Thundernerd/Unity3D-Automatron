using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Float/Get Epsilon" )]
	class SingleEpsilonGet0 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.Epsilon;
			yield break;
		}

	}

	[Automation( "Float/Get Max Value" )]
	class SingleMaxValueGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.MaxValue;
			yield break;
		}

	}

	[Automation( "Float/Get Min Value" )]
	class SingleMinValueGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.MinValue;
			yield break;
		}

	}

	[Automation( "Float/Get Na N" )]
	class SingleNaNGet3 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.NaN;
			yield break;
		}

	}

	[Automation( "Float/Get Positive Infinity" )]
	class SinglePositiveInfinityGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.PositiveInfinity;
			yield break;
		}

	}

	[Automation( "Float/Get Negative Infinity" )]
	class SingleNegativeInfinityGet5 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.NegativeInfinity;
			yield break;
		}

	}

	[Automation( "Float/Is Infinity" )]
	class SingleIsInfinity0 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsInfinity(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Float/Is Na N" )]
	class SingleIsNaN1 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsNaN(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Float/Is Negative Infinity" )]
	class SingleIsNegativeInfinity2 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsNegativeInfinity(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Float/Is Positive Infinity" )]
	class SingleIsPositiveInfinity3 : ConditionalAutomation {

		public System.Single f;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.IsPositiveInfinity(f);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Float/Parse" )]
	class SingleParse4 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = System.Single.Parse(s);
			yield break;
		}

	}

	[Automation( "Float/Try Parse" )]
	class SingleTryParse5 : ConditionalAutomation {

		public System.String s;
		public System.Single result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Single.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Float/To String" )]
	class SingleToString6 : Automation {

		public System.Single Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
