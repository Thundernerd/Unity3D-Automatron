using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Enum/Get Values" )]
    class EnumGetValues1 : Automation {

        [TypeLimit( typeof( System.Enum ) )]
        public System.Type enumType;
        [ReadOnly]
        public System.Array Result;

        public override IEnumerator Execute() {
            Result = System.Enum.GetValues( enumType ); 
            yield break;
        }

    }

    [Automation( "Enum/Get Names" )]
    class EnumGetNames2 : Automation {

        [TypeLimit( typeof( System.Enum ) )]
        public System.Type enumType;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = System.Enum.GetNames( enumType );
            yield break;
        }

    }

    [Automation( "Enum/Get Name" )]
    class EnumGetName3 : Automation {

        [TypeLimit( typeof( System.Enum ) )]
        public System.Type enumType;
        public System.Object value;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = System.Enum.GetName( enumType, value );
            yield break;
        }

    }

    [Automation( "Enum/Is Defined" )]
    class EnumIsDefined4 : Automation {

        [TypeLimit( typeof( System.Enum ) )]
        public System.Type enumType;
        public System.Object value;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = System.Enum.IsDefined( enumType, value );
            yield break;
        }

    }

    [Automation( "Enum/Parse" )]
    class EnumParse7 : Automation {

        [TypeLimit( typeof( System.Enum ) )]
        public System.Type enumType;
        public System.String value;
        public System.Boolean ignoreCase;
        [ReadOnly]
        public System.Object Result;

        public override IEnumerator Execute() {
            Result = System.Enum.Parse( enumType, value, ignoreCase );
            yield break;
        }

    }

    [Automation( "Enum/To String" )]
    class EnumToString9 : Automation {

        public System.Enum Instance;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = Instance.ToString();
            yield break;
        }

    }


#pragma warning restore 0649
}
