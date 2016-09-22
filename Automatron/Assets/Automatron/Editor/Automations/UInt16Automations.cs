#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Short/Get Max Value" )]
	class UInt16MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Short/Get Min Value" )]
	class UInt16MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.MinValue;
			yield break;
		}

	}

	[Automation( "Unsigned Short/Parse" )]
	class UInt16Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Short/Try Parse" )]
	class UInt16TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.UInt16 result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Unsigned Short/Create" )]
    class UnsignedShortCreate2 : Automation {

        public ushort Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Unsigned Short/Add" )]
    class UInt16Add : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a + b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Subtract" )]
    class UInt16Subtract : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a - b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Divide" )]
    class UInt16Divide : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a / b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Multiply" )]
    class UInt16Multiply : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a * b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Modulo" )]
    class UInt16Modulo : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a % b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Logical AND" )]
    class UInt16LogicalAND : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a & b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Logical OR" )]
    class UInt16LogicalOR : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a | b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Logical XOR" )]
    class UInt16LogicalXOR : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a ^ b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Negate" )]
    class UInt16Negate : Automation {

        public ushort a;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = -a;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Bitwise Negate" )]
    class UInt16BitNegate : Automation {

        public ushort a;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = ~a;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Shift Left" )]
    class UInt16ShiftLeft : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a << b;
            yield break;
        }
    }

    [Automation( "Unsigned Short/Shift Right" )]
    class UInt16ShiftRight : Automation {

        public ushort a;
        public ushort b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a >> b;
            yield break;
        }
    }

#pragma warning restore 0649
}

#endif