using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/String/Get Empty" )]
    class StringEmptyGet0 : Automation {

        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.Empty;
            yield break;
        }

    }

    [Automation( "Primitives/String/Is Null Or Empty" )]
    class StringIsNullOrEmpty14 : Automation {

        public System.String value;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = System.String.IsNullOrEmpty( value );
            yield break;
        }

    }

    [Automation( "Primitives/String/Format" )]
    class StringFormat18 : Automation {

        public System.String format;
        public System.Object[] args;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.Format( format, args );
            yield break;
        }

    }

    [Automation( "Primitives/String/Copy" )]
    class StringCopy20 : Automation {

        public System.String str;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.Copy( str );
            yield break;
        }

    }

    [Automation( "Primitives/String/Concat" )]
    class StringConcat29 : Automation {

        public System.String[] values;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.Concat( values );
            yield break;
        }

    }

    [Automation( "Primitives/String/Intern" )]
    class StringIntern30 : Automation {

        public System.String str;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.Intern( str );
            yield break;
        }

    }

    [Automation( "Primitives/String/Is Interned" )]
    class StringIsInterned31 : Automation {

        public System.String str;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.IsInterned( str );
            yield break;
        }

    }

    [Automation( "Primitives/String/Join" )]
    class StringJoin33 : Automation {

        public System.String separator;
        public System.String[] value;
        public System.Int32 startIndex;
        public System.Int32 count;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.String.Join( separator, value, startIndex, count );
            yield break;
        }

    }

    [Automation( "Primitives/String/To Char Array" )]
    class StringToCharArray6 : Automation {

        public System.String Instance;
        public System.Int32 startIndex;
        public System.Int32 length;
        [ReadOnly]
        public System.Char[] Result;

        public override IEnumerator Execute() {
            Result = Instance.ToCharArray( startIndex, length );
            yield break;
        }

    }

    [Automation( "Primitives/String/Split" )]
    class StringSplit12 : Automation {

        public System.String Instance;
        public System.String[] separator;
        public System.StringSplitOptions options;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = Instance.Split( separator, options );
            yield break;
        }

    }

    [Automation( "Primitives/String/Substring" )]
    class StringSubstring13 : Automation {

        public System.String Instance;
        public System.Int32 startIndex;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Substring( startIndex );
            yield break;
        }

    }

    [Automation( "Primitives/String/Substring" )]
    class StringSubstring14 : Automation {

        public System.String Instance;
        public System.Int32 startIndex;
        public System.Int32 length;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Substring( startIndex, length );
            yield break;
        }

    }

    [Automation( "Primitives/String/Trim" )]
    class StringTrim15 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Trim();
            yield break;
        }

    }

    [Automation( "Primitives/String/Trim" )]
    class StringTrim16 : Automation {

        public System.String Instance;
        public System.Char[] trimChars;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Trim( trimChars );
            yield break;
        }

    }

    [Automation( "Primitives/String/Trim Start" )]
    class StringTrimStart17 : Automation {

        public System.String Instance;
        public System.Char[] trimChars;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.TrimStart( trimChars );
            yield break;
        }

    }

    [Automation( "Primitives/String/Trim End" )]
    class StringTrimEnd18 : Automation {

        public System.String Instance;
        public System.Char[] trimChars;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.TrimEnd( trimChars );
            yield break;
        }

    }

    [Automation( "Primitives/String/Ends With" )]
    class StringEndsWith22 : Automation {

        public System.String Instance;
        public System.String value;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = Instance.EndsWith( value );
            yield break;
        }

    }

    [Automation( "Primitives/String/Index Of Any" )]
    class StringIndexOfAny25 : Automation {

        public System.String Instance;
        public System.Char[] anyOf;
        public System.Int32 startIndex;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = Instance.IndexOfAny( anyOf, startIndex );
            yield break;
        }

    }

    [Automation( "Primitives/String/Index Of" )]
    class StringIndexOf37 : Automation {

        public System.String Instance;
        public System.String value;
        public System.Int32 startIndex;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = Instance.IndexOf( value, startIndex );
            yield break;
        }

    }

    [Automation( "Primitives/String/Last Index Of" )]
    class StringLastIndexOf42 : Automation {

        public System.String Instance;
        public System.Char value;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = Instance.LastIndexOf( value );
            yield break;
        }

    }

    [Automation( "Primitives/String/Last Index Of" )]
    class StringLastIndexOf45 : Automation {

        public System.String Instance;
        public System.String value;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = Instance.LastIndexOf( value );
            yield break;
        }

    }

    [Automation( "Primitives/String/Contains" )]
    class StringContains48 : Automation {

        public System.String Instance;
        public System.String value;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = Instance.Contains( value );
            yield break;
        }

    }

    [Automation( "Primitives/String/Normalize" )]
    class StringNormalize49 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Normalize();
            yield break;
        }

    }

    [Automation( "Primitives/String/Is Normalized" )]
    class StringIsNormalized51 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = Instance.IsNormalized();
            yield break;
        }

    }

    [Automation( "Primitives/String/Remove" )]
    class StringRemove53 : Automation {

        public System.String Instance;
        public System.Int32 startIndex;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Remove( startIndex );
            yield break;
        }

    }

    [Automation( "Primitives/String/Pad Left" )]
    class StringPadLeft55 : Automation {

        public System.String Instance;
        public System.Int32 totalWidth;
        public System.Char paddingChar;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.PadLeft( totalWidth, paddingChar );
            yield break;
        }

    }

    [Automation( "Primitives/String/Pad Right" )]
    class StringPadRight57 : Automation {

        public System.String Instance;
        public System.Int32 totalWidth;
        public System.Char paddingChar;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.PadRight( totalWidth, paddingChar );
            yield break;
        }

    }

    [Automation( "Primitives/String/Starts With" )]
    class StringStartsWith58 : Automation {

        public System.String Instance;
        public System.String value;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = Instance.StartsWith( value );
            yield break;
        }

    }

    [Automation( "Primitives/String/Replace" )]
    class StringReplace63 : Automation {

        public System.String Instance;
        public System.String oldValue;
        public System.String newValue;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Replace( oldValue, newValue );
            yield break;
        }

    }

    [Automation( "Primitives/String/Remove" )]
    class StringRemove64 : Automation {

        public System.String Instance;
        public System.Int32 startIndex;
        public System.Int32 count;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Remove( startIndex, count );
            yield break;
        }

    }

    [Automation( "Primitives/String/To Lower" )]
    class StringToLower65 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.ToLower();
            yield break;
        }

    }

    [Automation( "Primitives/String/To Lower Invariant" )]
    class StringToLowerInvariant67 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.ToLowerInvariant();
            yield break;
        }

    }

    [Automation( "Primitives/String/To Upper" )]
    class StringToUpper68 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.ToUpper();
            yield break;
        }

    }

    [Automation( "Primitives/String/To Upper Invariant" )]
    class StringToUpperInvariant70 : Automation {

        public System.String Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.ToUpperInvariant();
            yield break;
        }

    }

    [Automation( "Primitives/String/Insert" )]
    class StringInsert73 : Automation {

        public System.String Instance;
        public System.Int32 startIndex;
        public System.String value;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.Insert( startIndex, value );
            yield break;
        }

    }
    /// <summary>
    /// //////////////////////////////
    /// </summary>

    [Automation( "Primitives/String/Create" )]
    class StringCreate : Automation {

        public string Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}