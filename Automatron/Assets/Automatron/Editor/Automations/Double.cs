using System;
using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/Double/Add" )]
    class DoubleAdd : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Subtract" )]
    class DoubleSubtract : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Multiply" )]
    class DoubleMultiply : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Divide" )]
    class DoubleDivide : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Create" )]
    class DoubleCreate : Automation {

        public double InOut;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    /////////////////////////////////////

    [Automation( "Primitives/Double/Get Epsilon" )]
    class DoubleEpsilonGet0 : Automation {

        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.Epsilon;
            yield break;
        }

    }

    [Automation( "Primitives/Double/Get Max Value" )]
    class DoubleMaxValueGet1 : Automation {

        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.MaxValue;
            yield break;
        }

    }

    [Automation( "Primitives/Double/Get Min Value" )]
    class DoubleMinValueGet2 : Automation {

        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.MinValue;
            yield break;
        }

    }

    [Automation( "Primitives/Double/Get NaN" )]
    class DoubleNaNGet3 : Automation {

        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.NaN;
            yield break;
        }

    }

    [Automation( "Primitives/Double/Get Negative Infinity" )]
    class DoubleNegativeInfinityGet4 : Automation {

        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.NegativeInfinity;
            yield break;
        }

    }

    [Automation( "Primitives/Double/Get Positive Infinity" )]
    class DoublePositiveInfinityGet5 : Automation {

        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.PositiveInfinity;
            yield break;
        }

    }

    [Automation( "Primitives/Double/Is Infinity" )]
	class DoubleIsInfinity5 : ConditionalAutomation {

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

    [Automation( "Primitives/Double/Is NaN" )]
	class DoubleIsNaN6 : ConditionalAutomation {

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

    [Automation( "Primitives/Double/Is Negative Infinity" )]
	class DoubleIsNegativeInfinity7 : ConditionalAutomation {

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

    [Automation( "Primitives/Double/Is Positive Infinity" )]
	class DoubleIsPositiveInfinity8 : ConditionalAutomation {

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

    [Automation( "Primitives/Double/Parse" )]
    class DoubleParse4 : Automation {

        public System.String s;
        [ReadOnly]
        public System.Double Result;

        public override IEnumerator Execute() {
            Result = System.Double.Parse( s );
            yield break;
        }

    }

    [Automation( "Primitives/Double/Try Parse" )]
    class DoubleTryParse9 : ConditionalAutomation {

        public System.String s;
        public System.Double result;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator ExecuteCondition() {
            Result = System.Double.TryParse( s, out result );
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

	[Automation( "Generated/Double/To String" )]
	class DoubleToString15 : Automation {

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