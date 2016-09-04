using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Char/Get Max Value" )]
	class CharMaxValueGet0 : Automation {

		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.MaxValue;
			yield break;
		}

	}

	[Automation( "Char/Get Min Value" )]
	class CharMinValueGet1 : Automation {

		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.MinValue;
			yield break;
		}

	}

	[Automation( "Char/Get Numeric Value" )]
	class CharGetNumericValue0 : Automation {

		public System.Char c;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = System.Char.GetNumericValue(c);
			yield break;
		}

	}

	[Automation( "Char/Get Unicode Category" )]
	class CharGetUnicodeCategory1 : Automation {

		public System.Char c;
		[ReadOnly]
		public System.Globalization.UnicodeCategory Result;

		public override IEnumerator Execute() {
			Result = System.Char.GetUnicodeCategory(c);
			yield break;
		}

	}

	[Automation( "Char/Is Control" )]
	class CharIsControl2 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsControl(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Digit" )]
	class CharIsDigit3 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsDigit(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is High Surrogate" )]
	class CharIsHighSurrogate4 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsHighSurrogate(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Letter" )]
	class CharIsLetter5 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsLetter(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Letter Or Digit" )]
	class CharIsLetterOrDigit6 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsLetterOrDigit(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Lower" )]
	class CharIsLower7 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsLower(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Low Surrogate" )]
	class CharIsLowSurrogate8 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsLowSurrogate(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Number" )]
	class CharIsNumber9 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsNumber(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Punctuation" )]
	class CharIsPunctuation10 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsPunctuation(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Separator" )]
	class CharIsSeparator11 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsSeparator(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Surrogate" )]
	class CharIsSurrogate12 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsSurrogate(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Symbol" )]
	class CharIsSymbol13 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsSymbol(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is Upper" )]
	class CharIsUpper14 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsUpper(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Is White Space" )]
	class CharIsWhiteSpace15 : ConditionalAutomation {

		public System.Char c;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Char.IsWhiteSpace(c);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Char/Parse" )]
	class CharParse16 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.Parse(s);
			yield break;
		}

	}

	[Automation( "Char/To Lower" )]
	class CharToLower17 : Automation {

		public System.Char c;
		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.ToLower(c);
			yield break;
		}

	}

	[Automation( "Char/To Upper" )]
	class CharToUpper18 : Automation {

		public System.Char c;
		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.Char.ToUpper(c);
			yield break;
		}

	}

	[Automation( "Char/To String" )]
	class CharToString19 : Automation {

		public System.Char Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
