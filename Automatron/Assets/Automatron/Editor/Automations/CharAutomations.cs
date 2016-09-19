#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Char/Get Max Value" )]
	class CharMaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.MaxValue;
			yield break;
		}

	}

	[Automation( "Char/Get Min Value" )]
	class CharMinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.MinValue;
			yield break;
		}

	}

	[Automation( "Char/Equals" )]
	class CharEquals0 : ConditionalAutomation {

		public System.Char Instance;
		public System.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Surrogate Pair" )]
	class CharIsSurrogatePair1 : ConditionalAutomation {

		public System.String s;
		public System.Int32 index;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsSurrogatePair(s,index);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Get Numeric Value" )]
	class CharGetNumericValue2 : Automation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Char.GetNumericValue(c);
			yield break;
		}

	}

	[Automation( "Char/Is Control" )]
	class CharIsControl3 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsControl(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Digit" )]
	class CharIsDigit4 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsDigit(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is High Surrogate" )]
	class CharIsHighSurrogate5 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsHighSurrogate(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Letter" )]
	class CharIsLetter6 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsLetter(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Letter Or Digit" )]
	class CharIsLetterOrDigit7 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsLetterOrDigit(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Lower" )]
	class CharIsLower8 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsLower(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Low Surrogate" )]
	class CharIsLowSurrogate9 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsLowSurrogate(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Number" )]
	class CharIsNumber10 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsNumber(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Punctuation" )]
	class CharIsPunctuation11 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsPunctuation(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Separator" )]
	class CharIsSeparator12 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsSeparator(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Surrogate" )]
	class CharIsSurrogate13 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsSurrogate(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Symbol" )]
	class CharIsSymbol14 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsSymbol(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Upper" )]
	class CharIsUpper15 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsUpper(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is White Space" )]
	class CharIsWhiteSpace16 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.IsWhiteSpace(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Try Parse" )]
	class CharTryParse17 : ConditionalAutomation {

		public System.String s;
		public System.Char result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Char.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Parse" )]
	class CharParse18 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.Parse(s);
			yield break;
		}

	}

	[Automation( "Char/To Lower" )]
	class CharToLower19 : Automation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.ToLower(c);
			yield break;
		}

	}

	[Automation( "Char/To Lower Invariant" )]
	class CharToLowerInvariant20 : Automation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.ToLowerInvariant(c);
			yield break;
		}

	}

	[Automation( "Char/To Upper" )]
	class CharToUpper21 : Automation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.ToUpper(c);
			yield break;
		}

	}

	[Automation( "Char/To Upper Invariant" )]
	class CharToUpperInvariant22 : Automation {

		public System.Char c;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.ToUpperInvariant(c);
			yield break;
		}

	}

	[Automation( "Char/To String" )]
	class CharToString23 : Automation {

		public System.Char Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}

    [Automation( "Char/Create" )]
    class CharCreate24 : Automation {

        public char Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}

#endif