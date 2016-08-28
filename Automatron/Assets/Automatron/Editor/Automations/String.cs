using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/String/Create" )]
    class StringCreate : Automation {

        public string Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

    [Automation( "Primitives/String/Ends With" )]
    class StringEndsWith : Automation {

        public string Original;
        public string Value;
        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = Original.EndsWith( Value );
            yield break;
        }
    }

    [Automation( "Primitives/String/Index Of (Char)" )]
    class StringIndexOfC : Automation {

        public string Original;
        public char Value;
        public int StartIndex;
        public int Count;
        [ReadOnly]
        public int Index;

        public override IEnumerator Execute() {
            if ( Count == 0 ) {
                Index = Original.IndexOf( Value, StartIndex );
            } else {
                Index = Original.IndexOf( Value, StartIndex, Count );
            }

            yield break;
        }
    }

    [Automation( "Primitives/String/Index Of (String)" )]
    class StringIndexOfS : Automation {

        public string Original;
        public string Value;
        public int StartIndex;
        public int Count;
        [ReadOnly]
        public int Index;

        public override IEnumerator Execute() {
            if ( Count == 0 ) {
                Index = Original.IndexOf( Value, StartIndex );
            } else {
                Index = Original.IndexOf( Value, StartIndex, Count );
            }

            yield break;
        }
    }

    [Automation( "Primitives/String/Remove" )]
    class StringRemove : Automation {

        public string InOut;
        public int StartIndex;
        public int Count;

        public override IEnumerator Execute() {
            if ( Count == 0 ) {
                InOut = InOut.Remove( StartIndex );
            } else {
                InOut = InOut.Remove( StartIndex, Count );
            }

            yield break;
        }
    }

    [Automation( "Primitives/String/Replace (Char)" )]
    class StringReplaceC : Automation {

        public string InOut;
        public char OldValue;
        public char NewValue;

        public override IEnumerator Execute() {
            InOut = InOut.Replace( OldValue, NewValue );
            yield break;
        }
    }

    [Automation( "Primitives/String/Replace (String)" )]
    class StringReplaceS : Automation {

        public string InOut;
        public string OldValue;
        public string NewValue;

        public override IEnumerator Execute() {
            InOut = InOut.Replace( OldValue, NewValue );
            yield break;
        }
    }

#pragma warning restore 0649
}