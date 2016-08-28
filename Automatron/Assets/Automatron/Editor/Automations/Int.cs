using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/Int/Add" )]
    class IntAdd : Automation {

        public int InOut;
        public int Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Primitives/Int/Subtract" )]
    class IntSubtract : Automation {

        public int InOut;
        public int Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Int/Multiply" )]
    class IntMultiply : Automation {

        public int InOut;
        public int Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Int/Divide" )]
    class IntDivide : Automation {

        public int InOut;
        public int Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Int/Random" )]
    class RandomRangeI : Automation {

        public int Value;
        public int Min;
        public int Max;

        public override IEnumerator Execute() {
            Value = Random.Range( Min, Max );
            yield break;
        }
    }

    [Automation( "Primitives/Int/Create" )]
    class IntCreate : Automation {
        
        public int Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}
