using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "String/Get Empty" )]
	class StringEmptyGet0 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Empty;
			yield break;
		}

	}

	[Automation( "String/Get Length" )]
	class StringLengthGet0 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Length;
			yield break;
		}

	}

	[Automation( "String/Equals" )]
	class StringEquals0 : ConditionalAutomation {

		public System.String a;
		public System.String b;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.String.Equals(a,b);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Substring" )]
	class StringSubstring1 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		public System.Int32 length;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Substring(startIndex,length);
			yield break;
		}

	}

	[Automation( "String/Trim" )]
	class StringTrim2 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Trim();
			yield break;
		}

	}

	[Automation( "String/Index Of" )]
	class StringIndexOf4 : Automation {

		public System.String Instance;
		public System.String value;
		public System.Int32 startIndex;
		public System.StringComparison comparisonType;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.IndexOf(value,startIndex,comparisonType);
			yield break;
		}

	}

	[Automation( "String/Last Index Of" )]
	class StringLastIndexOf5 : Automation {

		public System.String Instance;
		public System.String value;
		public System.Int32 startIndex;
		public System.StringComparison comparisonType;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.LastIndexOf(value,startIndex,comparisonType);
			yield break;
		}

	}

	[Automation( "String/Contains" )]
	class StringContains8 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.Contains(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Is Null Or Empty" )]
	class StringIsNullOrEmpty9 : ConditionalAutomation {

		public System.String value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.String.IsNullOrEmpty(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Normalize" )]
	class StringNormalize10 : Automation {

		public System.String Instance;
		public System.Text.NormalizationForm normalizationForm;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Normalize(normalizationForm);
			yield break;
		}

	}

	[Automation( "String/Is Normalized" )]
	class StringIsNormalized11 : ConditionalAutomation {

		public System.String Instance;
		public System.Text.NormalizationForm normalizationForm;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsNormalized(normalizationForm);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Pad Left" )]
	class StringPadLeft13 : Automation {

		public System.String Instance;
		public System.Int32 totalWidth;
		public System.Char paddingChar;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.PadLeft(totalWidth,paddingChar);
			yield break;
		}

	}

	[Automation( "String/Pad Right" )]
	class StringPadRight14 : Automation {

		public System.String Instance;
		public System.Int32 totalWidth;
		public System.Char paddingChar;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.PadRight(totalWidth,paddingChar);
			yield break;
		}

	}

	[Automation( "String/Starts With" )]
	class StringStartsWith15 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		public System.StringComparison comparisonType;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.StartsWith(value,comparisonType);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Ends With" )]
	class StringEndsWith16 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		public System.StringComparison comparisonType;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.EndsWith(value,comparisonType);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Replace" )]
	class StringReplace17 : Automation {

		public System.String Instance;
		public System.String oldValue;
		public System.String newValue;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Replace(oldValue,newValue);
			yield break;
		}

	}

	[Automation( "String/Remove" )]
	class StringRemove18 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		public System.Int32 count;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Remove(startIndex,count);
			yield break;
		}

	}

	[Automation( "String/To Lower" )]
	class StringToLower19 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLower();
			yield break;
		}

	}

	[Automation( "String/To Lower Invariant" )]
	class StringToLowerInvariant20 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLowerInvariant();
			yield break;
		}

	}

	[Automation( "String/To Upper" )]
	class StringToUpper21 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUpper();
			yield break;
		}

	}

	[Automation( "String/To Upper Invariant" )]
	class StringToUpperInvariant22 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUpperInvariant();
			yield break;
		}

	}

	[Automation( "String/Concat" )]
	class StringConcat23 : Automation {

		public System.String[] values;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Concat(values);
			yield break;
		}

	}

	[Automation( "String/Insert" )]
	class StringInsert24 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		public System.String value;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Insert(startIndex,value);
			yield break;
		}

	}

	[Automation( "String/Intern" )]
	class StringIntern25 : Automation {

		public System.String str;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Intern(str);
			yield break;
		}

	}

	[Automation( "String/Is Interned" )]
	class StringIsInterned26 : Automation {

		public System.String str;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.IsInterned(str);
			yield break;
		}

	}

	[Automation( "String/Join" )]
	class StringJoin27 : Automation {

		public System.String separator;
		public System.String[] value;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Join(separator,value);
			yield break;
		}

	}

    [Automation( "String/Append" )]
    class StringAppend28 : Automation {

        public System.String instance;
        public System.String value;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = instance + value;
            yield break;
        }

    }

    [Automation( "String/Prepend" )]
    class StringPrepend29 : Automation {

        public System.String instance;
        public System.String value;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = value + instance;
            yield break;
        }

    }


#pragma warning restore 0649
}
