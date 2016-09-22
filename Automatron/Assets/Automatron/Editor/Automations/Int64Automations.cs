#if UNITY_EDITOR
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

    [Automation( "Long/Create" )]
    class LongCreate2 : Automation {

        public long Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Long/Add" )]
    class Int64Add : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a + b;
            yield break;
        }
    }

    [Automation( "Long/Subtract" )]
    class Int64Subtract : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a - b;
            yield break;
        }
    }

    [Automation( "Long/Divide" )]
    class Int64Divide : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a / b;
            yield break;
        }
    }

    [Automation( "Long/Multiply" )]
    class Int64Multiply : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a * b;
            yield break;
        }
    }

    [Automation( "Long/Modulo" )]
    class Int64Modulo : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a % b;
            yield break;
        }
    }

    [Automation( "Long/Logical AND" )]
    class Int64LogicalAND : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a & b;
            yield break;
        }
    }

    [Automation( "Long/Logical OR" )]
    class Int64LogicalOR : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a | b;
            yield break;
        }
    }

    [Automation( "Long/Logical XOR" )]
    class Int64LogicalXOR : Automation {

        public long a;
        public long b;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = a ^ b;
            yield break;
        }
    }

    [Automation( "Long/Negate" )]
    class Int64Negate : Automation {

        public long a;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = -a;
            yield break;
        }
    }

    [Automation( "Long/Bitwise Negate" )]
    class Int64BitNegate : Automation {

        public long a;
        [ReadOnly]
        public long result;

        public override IEnumerator Execute() {
            result = ~a;
            yield break;
        }
    }


#pragma warning restore 0649
}

#endif