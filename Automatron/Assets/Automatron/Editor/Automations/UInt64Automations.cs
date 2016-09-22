#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Long/Get Max Value" )]
	class UInt64MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Long/Get Min Value" )]
	class UInt64MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Unsigned Long/Create" )]
    class UnsignedLongCreate : Automation {

        public ulong Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Unsigned Long/Add" )]
    class UInt64Add : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a + b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Subtract" )]
    class UInt64Subtract : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a - b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Divide" )]
    class UInt64Divide : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a / b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Multiply" )]
    class UInt64Multiply : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a * b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Modulo" )]
    class UInt64Modulo : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a % b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Logical AND" )]
    class UInt64LogicalAND : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a & b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Logical OR" )]
    class UInt64LogicalOR : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a | b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Logical XOR" )]
    class UInt64LogicalXOR : Automation {

        public ulong a;
        public ulong b;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = a ^ b;
            yield break;
        }
    }

    [Automation( "Unsigned Long/Bitwise Negate" )]
    class UInt64BitNegate : Automation {

        public ulong a;
        [ReadOnly]
        public ulong result;

        public override IEnumerator Execute() {
            result = ~a;
            yield break;
        }
    }

#pragma warning restore 0649
}

#endif