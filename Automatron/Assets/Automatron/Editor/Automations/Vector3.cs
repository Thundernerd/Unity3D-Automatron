using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Vector3/Add" )]
    class Vector3Add : Automation {

        public Vector3 InOut;
        public Vector3 Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Vector3/Subtract" )]
    class Vector3Subtract : Automation {

        public Vector3 InOut;
        public Vector3 Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Vector3/Multiply" )]
    class Vector3Multiply : Automation {

        public Vector3 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Vector3/Divide" )]
    class Vector3Divide : Automation {

        public Vector3 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Vector3/Random" )]
    class RandomVector3 : Automation {

        public Vector3 Value;
        public float XMin;
        public float XMax;
        public float YMin;
        public float YMax;
        public float ZMin;
        public float ZMax;

        public override IEnumerator Execute() {
            Value = new Vector3(
                XMin == XMax ? 0 : Random.Range( XMin, XMax ),
                YMin == YMax ? 0 : Random.Range( YMin, YMax ),
                ZMin == ZMax ? 0 : Random.Range( ZMin, ZMax ) );
            yield break;
        }
    }

    [Automation( "Vector3/Create" )]
    class Vector3C : Automation {

        public Vector3 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}