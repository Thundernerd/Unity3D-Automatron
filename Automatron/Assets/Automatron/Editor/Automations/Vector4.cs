using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Vector4/Add" )]
    class Vector4Add : Automation {

        public Vector4 InOut;
        public Vector4 Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Vector4/Subtract" )]
    class Vector4Subtract : Automation {

        public Vector4 InOut;
        public Vector4 Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Vector4/Multiply" )]
    class Vector4Multiply : Automation {

        public Vector4 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Vector4/Divide" )]
    class Vector4Divide : Automation {

        public Vector4 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Vector4/Random" )]
    class RandomVector4 : Automation {

        public Vector4 Value;
        public float XMin;
        public float XMax;
        public float YMin;
        public float YMax;
        public float ZMin;
        public float ZMax;
        public float WMin;
        public float WMax;

        public override IEnumerator Execute() {
            Value = new Vector4(
                XMin == XMax ? 0 : Random.Range( XMin, XMax ),
                YMin == YMax ? 0 : Random.Range( YMin, YMax ),
                ZMin == ZMax ? 0 : Random.Range( ZMin, ZMax ),
                WMin == WMax ? 0 : Random.Range( WMin, WMax ) );
            yield break;
        }
    }

    [Automation( "Vector4/Create" )]
    class Vector4C : Automation {

        public Vector4 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}