using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/Float/Add" )]
    class FloatAdd : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Subtract" )]
    class FloatSubtract : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Multiply" )]
    class FloatMultiply : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Divide" )]
    class FloatDivide : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Random" )]
    class RandomRangeF : Automation {

        public float Min;
        public float Max;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Random.Range( Min, Max );
            yield break;
        }
    }

    [Automation( "Primitives/Float/Create" )]
    class FloatCreate : Automation {

        public float Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    ////////////////////////////////////

    [Automation( "Primitives/Float/Get Epsilon" )]
    class SingleEpsilonGet0 : Automation {

        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.Epsilon;
            yield break;
        }

    }

    [Automation( "Primitives/Float/Get Max Value" )]
    class SingleMaxValueGet1 : Automation {

        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.MaxValue;
            yield break;
        }

    }

    [Automation( "Primitives/Float/Get Min Value" )]
    class SingleMinValueGet2 : Automation {

        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.MinValue;
            yield break;
        }

    }

    [Automation( "Primitives/Float/Get NaN" )]
    class SingleNaNGet3 : Automation {

        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.NaN;
            yield break;
        }

    }

    [Automation( "Primitives/Float/Get Positive Infinity" )]
    class SinglePositiveInfinityGet4 : Automation {

        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.PositiveInfinity;
            yield break;
        }

    }

    [Automation( "Primitives/Float/Get Negative Infinity" )]
    class SingleNegativeInfinityGet5 : Automation {

        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.NegativeInfinity;
            yield break;
        }

    }

	[Automation( "Generated/Single/Is Infinity" )]
	class SingleIsInfinity5 : ConditionalAutomation {

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

	[Automation( "Generated/Single/Is Na N" )]
	class SingleIsNaN6 : ConditionalAutomation {

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

	[Automation( "Generated/Single/Is Negative Infinity" )]
	class SingleIsNegativeInfinity7 : ConditionalAutomation {

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

	[Automation( "Generated/Single/Is Positive Infinity" )]
	class SingleIsPositiveInfinity8 : ConditionalAutomation {

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

    [Automation( "Primitives/Float/Parse" )]
    class SingleParse4 : Automation {

        public System.String s;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = System.Single.Parse( s );
            yield break;
        }

    }

    [Automation( "Primitives/Float/Try Parse" )]
    class SingleTryParse9 : Automation {

        public System.String s;
        public System.Single result;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = System.Single.TryParse( s, out result );
            yield break;
        }

    }

#pragma warning restore 0649
}