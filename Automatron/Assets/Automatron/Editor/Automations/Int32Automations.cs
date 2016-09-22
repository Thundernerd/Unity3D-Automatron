#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Int/Get Max Value" )]
	class Int32MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.Int32.MaxValue;
			yield break;
		}

	}

	[Automation( "Int/Get Min Value" )]
	class Int32MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Int32.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Int/Create" )]
    class IntCreate2 : Automation {

        public int Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Int/Add" )]
    class IntAdd : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a + b;
            yield break;
        }
    }

    [Automation( "Int/Subtract" )]
    class IntSubtract : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a - b;
            yield break;
        }
    }

    [Automation( "Int/Divide" )]
    class IntDivide : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a / b;
            yield break;
        }
    }

    [Automation( "Int/Multiply" )]
    class IntMultiply : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a * b;
            yield break;
        }
    }

    [Automation( "Int/Modulo" )]
    class IntModulo : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a % b;
            yield break;
        }
    }

    [Automation( "Int/Logical AND" )]
    class IntLogicalAND : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a & b;
            yield break;
        }
    }

    [Automation( "Int/Logical OR" )]
    class IntLogicalOR : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a | b;
            yield break;
        }
    }

    [Automation( "Int/Logical XOR" )]
    class IntLogicalXOR : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a ^ b;
            yield break;
        }
    }

    [Automation( "Int/Negate" )]
    class IntNegate : Automation {

        public int a;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = -a;
            yield break;
        }
    }

    [Automation( "Int/Bitwise Negate" )]
    class IntBitNegate : Automation {

        public int a;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = ~a;
            yield break;
        }
    }

    [Automation( "Int/Shift Left" )]
    class IntShiftLeft : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int result;

        public override IEnumerator Execute() {
            result = a << b;
            yield break;
        }
    }

    [Automation( "Int/Shift Right" )]
    class IntShiftRight : Automation {

        public int a;
        public int b;
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