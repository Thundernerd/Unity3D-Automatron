#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Int/Get Max Value" )]
	class UInt32MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Int/Get Min Value" )]
	class UInt32MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.MinValue;
			yield break;
		}

	}

	[Automation( "Unsigned Int/Parse" )]
	class UInt32Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Int/Try Parse" )]
	class UInt32TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.UInt32 result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Unsigned Int/Create" )]
    class UnsignedIntCreate2 : Automation {

        public uint Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Unsigned Int/Add" )]
    class UInt32Add : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a + b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Subtract" )]
    class UInt32Subtract : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a - b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Divide" )]
    class UInt32Divide : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a / b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Multiply" )]
    class UInt32Multiply : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a * b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Modulo" )]
    class UInt32Modulo : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a % b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Logical AND" )]
    class UInt32LogicalAND : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a & b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Logical OR" )]
    class UInt32LogicalOR : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a | b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Logical XOR" )]
    class UInt32LogicalXOR : Automation {

        public uint a;
        public uint b;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = a ^ b;
            yield break;
        }
    }

    [Automation( "Unsigned Int/Bitwise Negate" )]
    class UInt32BitNegate : Automation {

        public uint a;
        [ReadOnly]
        public uint result;

        public override IEnumerator Execute() {
            result = ~a;
            yield break;
        }
    }


#pragma warning restore 0649
}

#endif