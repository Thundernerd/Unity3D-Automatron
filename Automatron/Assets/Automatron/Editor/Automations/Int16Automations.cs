#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Short/Get Max Value" )]
	class Int16MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.MaxValue;
			yield break;
		}

	}

	[Automation( "Short/Get Min Value" )]
	class Int16MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.MinValue;
			yield break;
		}

	}

	[Automation( "Short/Parse" )]
	class Int16Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.Parse(s);
			yield break;
		}

	}

	[Automation( "Short/Try Parse" )]
	class Int16TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.Int16 result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Int16.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Short/Create" )]
    class ShortCreate2 : Automation {

        public short Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Short/Add" )]
    class Int16Add : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a + b;
            yield break;
        }
    }

    [Automation( "Short/Subtract" )]
    class Int16Subtract : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a - b;
            yield break;
        }
    }

    [Automation( "Short/Divide" )]
    class Int16Divide : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a / b;
            yield break;
        }
    }

    [Automation( "Short/Multiply" )]
    class Int16Multiply : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a * b;
            yield break;
        }
    }

    [Automation( "Short/Modulo" )]
    class Int16Modulo : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a % b;
            yield break;
        }
    }

    [Automation( "Short/Logical AND" )]
    class Int16LogicalAND : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a & b;
            yield break;
        }
    }

    [Automation( "Short/Logical OR" )]
    class Int16LogicalOR : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a | b;
            yield break;
        }
    }

    [Automation( "Short/Logical XOR" )]
    class Int16LogicalXOR : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a ^ b;
            yield break;
        }
    }

    [Automation( "Short/Negate" )]
    class Int16Negate : Automation {

        public short a;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = -a;
            yield break;
        }
    }

    [Automation( "Short/Bitwise Negate" )]
    class Int16BitNegate : Automation {

        public short a;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = ~a;
            yield break;
        }
    }

    [Automation( "Short/Shift Left" )]
    class Int16ShiftLeft : Automation {

        public short a;
        public short b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a << b;
            yield break;
        }
    }

    [Automation( "Short/Shift Right" )]
    class Int16ShiftRight : Automation {

        public short a;
        public short b;
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