using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/Float/Add" )]
    class FloatAdd : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Subtract" )]
    class FloatSubtract : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Multiply" )]
    class FloatMultiply : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Divide" )]
    class FloatDivide : Automation {

        public float InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Float/Random" )]
    class RandomRangeF : Automation {

        public float Value;
        public float Min;
        public float Max;

        public override IEnumerator Execute() {
            Value = Random.Range( Min, Max );
            yield break;
        }
    }

    [Automation( "Primitives/Float/Create" )]
    class FloatCreate : Automation {

        public float Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}