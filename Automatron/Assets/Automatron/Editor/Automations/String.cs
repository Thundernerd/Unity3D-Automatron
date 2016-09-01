using System;
using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Generated/String/Get Empty" )]
	class StringEmptyGet0 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Empty;
			yield break;
		}

	}

	[Automation( "Generated/String/Get Length" )]
	class StringLengthGet1 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Length;
			yield break;
		}

	}
	[Automation( "Generated/String/Split" )]
	class StringSplit13 : Automation {

		public System.String Instance;
		public System.String[] separator;
		public System.StringSplitOptions options;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.Split(separator,options);
			yield break;
		}

	}
	[Automation( "Generated/String/Substring" )]
	class StringSubstring15 : Automation {

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
	[Automation( "Generated/String/Trim" )]
	class StringTrim16 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Trim();
			yield break;
		}

	}
    class StringCreate : Automation {

        public string Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

	[Automation( "Generated/String/Ends With" )]
	class StringEndsWith36 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.EndsWith(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}
	[Automation( "Generated/String/Index Of" )]
	class StringIndexOf42 : Automation {

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
	[Automation( "Generated/String/Last Index Of" )]
	class StringLastIndexOf45 : Automation {

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
	[Automation( "Generated/String/Index Of" )]
	class StringIndexOf51 : Automation {

		public System.String Instance;
		public System.String value;
		public System.Int32 startIndex;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.IndexOf(value,startIndex);
			yield break;
		}

	}
	[Automation( "Generated/String/Last Index Of" )]
	class StringLastIndexOf60 : Automation {

		public System.String Instance;
		public System.String value;
		public System.Int32 startIndex;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.LastIndexOf(value,startIndex);
			yield break;
		}

	}
	[Automation( "Generated/String/Contains" )]
	class StringContains62 : ConditionalAutomation {

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

	[Automation( "Generated/String/Is Null Or Empty" )]
	class StringIsNullOrEmpty63 : ConditionalAutomation {

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
	[Automation( "Generated/String/Normalize" )]
	class StringNormalize65 : Automation {

		public System.String Instance;
		public System.Text.NormalizationForm normalizationForm;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Normalize(normalizationForm);
			yield break;
		}

	}
	[Automation( "Generated/String/Is Normalized" )]
	class StringIsNormalized67 : ConditionalAutomation {

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
	[Automation( "Generated/String/Remove" )]
	class StringRemove68 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Remove(startIndex);
			yield break;
		}

	}
	[Automation( "Generated/String/Pad Left" )]
	class StringPadLeft70 : Automation {

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
	[Automation( "Generated/String/Pad Right" )]
	class StringPadRight72 : Automation {

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
	[Automation( "Generated/String/Starts With" )]
	class StringStartsWith74 : ConditionalAutomation {

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
	[Automation( "Generated/String/Ends With" )]
	class StringEndsWith75 : ConditionalAutomation {

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
	[Automation( "Generated/String/Replace" )]
	class StringReplace78 : Automation {

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
	[Automation( "Generated/String/Remove" )]
	class StringRemove79 : Automation {

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
	[Automation( "Generated/String/To Lower" )]
	class StringToLower80 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLower();
			yield break;
		}

	}
	[Automation( "Generated/String/To Lower Invariant" )]
	class StringToLowerInvariant82 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLowerInvariant();
			yield break;
		}

	}
	[Automation( "Generated/String/To Upper" )]
	class StringToUpper83 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUpper();
			yield break;
		}

	}
	[Automation( "Generated/String/To Upper Invariant" )]
	class StringToUpperInvariant85 : Automation {

		public System.String Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUpperInvariant();
			yield break;
		}

	}
	[Automation( "Generated/String/Format" )]
	class StringFormat91 : Automation {

		public System.String format;
		public System.Object[] args;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Format(format,args);
			yield break;
		}

	}
	[Automation( "Generated/String/Concat" )]
	class StringConcat102 : Automation {

		public System.String[] values;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Concat(values);
			yield break;
		}

	}
	[Automation( "Generated/String/Insert" )]
	class StringInsert103 : Automation {

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

	[Automation( "Generated/String/Intern" )]
	class StringIntern104 : Automation {

		public System.String str;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Intern(str);
			yield break;
		}

	}

	[Automation( "Generated/String/Is Interned" )]
	class StringIsInterned105 : Automation {

		public System.String str;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.IsInterned(str);
			yield break;
		}

	}
	[Automation( "Generated/String/Join" )]
	class StringJoin106 : Automation {

		public System.String separator;
		public System.String[] value;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Join(separator,value);
			yield break;
		}

	}
#pragma warning restore 0649
}