using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "String/Get Empty" )]
	class StringEmptyGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Empty;
			yield break;
		}

	}

	[Automation( "String/Get Length" )]
	class StringLengthGet1 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Length;
			yield break;
		}

	}

	[Automation( "String/To Char Array" )]
	class StringToCharArray0 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Char[] Result;

		public override IEnumerator Execute() {
			Result = Instance.ToCharArray();
			yield break;
		}

	}

	[Automation( "String/Substring" )]
	class StringSubstring2 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		public System.Int32 length = -1;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
            if ( length == -1 )
                Result = Instance.Substring( startIndex, length );
            else
                Result = Instance.Substring( startIndex );
            yield break;
		}

	}

	[Automation( "String/Trim" )]
	class StringTrim3 : Automation {

		public System.String Instance;
		public System.Char[] trimChars;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Trim(trimChars);
			yield break;
		}

	}

	[Automation( "String/Trim Start" )]
	class StringTrimStart4 : Automation {

		public System.String Instance;
		public System.Char[] trimChars;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.TrimStart(trimChars);
			yield break;
		}

	}

	[Automation( "String/Trim End" )]
	class StringTrimEnd5 : Automation {

		public System.String Instance;
		public System.Char[] trimChars;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.TrimEnd(trimChars);
			yield break;
		}

	}

	[Automation( "String/Compare" )]
	class StringCompare6 : Automation {

		public System.String strA;
		public System.String strB;
		public System.Boolean ignoreCase;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.String.Compare(strA,strB,ignoreCase);
			yield break;
		}

	}

	[Automation( "String/Ends With" )]
	class StringEndsWith7 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.EndsWith(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Index Of Any" )]
	class StringIndexOfAny8 : Automation {

		public System.String Instance;
		public System.Char[] anyOf;
		public System.Int32 startIndex;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.IndexOfAny(anyOf,startIndex);
			yield break;
		}

	}

	[Automation( "String/Index Of" )]
	class StringIndexOf9 : Automation {

		public System.String Instance;
		public System.String value;
		public System.Int32 startIndex;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.IndexOf(value,startIndex);
			yield break;
		}

	}

	[Automation( "String/Last Index Of Any" )]
	class StringLastIndexOfAny10 : Automation {

		public System.String Instance;
		public System.Char[] anyOf;
		public System.Int32 startIndex;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.LastIndexOfAny(anyOf,startIndex);
			yield break;
		}

	}

	[Automation( "String/Last Index Of" )]
	class StringLastIndexOf11 : Automation {

		public System.String Instance;
		public System.String value;
		public System.Int32 startIndex;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.LastIndexOf(value,startIndex);
			yield break;
		}

	}

	[Automation( "String/Contains" )]
	class StringContains12 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Contains(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Is Null Or Empty" )]
	class StringIsNullOrEmpty13 : ConditionalAutomation {

		public System.String value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.String.IsNullOrEmpty(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Normalize" )]
	class StringNormalize14 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Normalize();
			yield break;
		}

	}

	[Automation( "String/Is Normalized" )]
	class StringIsNormalized15 : ConditionalAutomation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsNormalized();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Pad Left" )]
	class StringPadLeft17 : Automation {

		public System.String Instance;
		public System.Int32 totalWidth;
		public System.Char paddingChar;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.PadLeft(totalWidth,paddingChar);
			yield break;
		}

	}

	[Automation( "String/Pad Right" )]
	class StringPadRight18 : Automation {

		public System.String Instance;
		public System.Int32 totalWidth;
		public System.Char paddingChar;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.PadRight(totalWidth,paddingChar);
			yield break;
		}

	}

	[Automation( "String/Starts With" )]
	class StringStartsWith19 : ConditionalAutomation {

		public System.String Instance;
		public System.String value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.StartsWith(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "String/Replace" )]
	class StringReplace20 : Automation {

		public System.String Instance;
		public System.String oldValue;
		public System.String newValue;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Replace(oldValue,newValue);
			yield break;
		}

	}

	[Automation( "String/Remove" )]
	class StringRemove21 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		public System.Int32 count = -1;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
            if ( count == -1 )
                Result = Instance.Remove( startIndex );
            else
                Result = Instance.Remove( startIndex, count );
            yield break;
		}

	}

	[Automation( "String/To Lower" )]
	class StringToLower22 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLower();
			yield break;
		}

	}

	[Automation( "String/To Lower Invariant" )]
	class StringToLowerInvariant23 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLowerInvariant();
			yield break;
		}

	}

	[Automation( "String/To Upper" )]
	class StringToUpper24 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUpper();
			yield break;
		}

	}

	[Automation( "String/To Upper Invariant" )]
	class StringToUpperInvariant25 : Automation {

		public System.String Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUpperInvariant();
			yield break;
		}

	}

	[Automation( "String/Copy" )]
	class StringCopy26 : Automation {

		public System.String str;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Copy(str);
			yield break;
		}

	}

	[Automation( "String/Concat" )]
	class StringConcat27 : Automation {

		public System.Object[] args;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Concat(args);
			yield break;
		}

	}

	[Automation( "String/Insert" )]
	class StringInsert28 : Automation {

		public System.String Instance;
		public System.Int32 startIndex;
		public System.String value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Insert(startIndex,value);
			yield break;
		}

	}

	[Automation( "String/Intern" )]
	class StringIntern29 : Automation {

		public System.String str;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Intern(str);
			yield break;
		}

	}

	[Automation( "String/Is Interned" )]
	class StringIsInterned30 : Automation {

		public System.String str;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.IsInterned(str);
			yield break;
		}

	}

	[Automation( "String/Join" )]
	class StringJoin31 : Automation {

		public System.String separator;
		public System.String[] value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.String.Join(separator,value);
			yield break;
		}

	}


#pragma warning restore 0649
}
