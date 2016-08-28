using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Vector2/Add" )]
    class Vector2Add : Automation {

        public Vector2 InOut;
        public Vector2 Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Vector2/Subtract" )]
    class Vector2Subtract : Automation {

        public Vector2 InOut;
        public Vector2 Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Vector2/Multiply" )]
    class Vector2Multiply : Automation {

        public Vector2 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Vector2/Divide" )]
    class Vector2Divide : Automation {

        public Vector2 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Vector2/Random" )]
    class RandomVector2 : Automation {

        public Vector2 Value;
        public float XMin;
        public float XMax;
        public float YMin;
        public float YMax;

        public override IEnumerator Execute() {
            Value = new Vector2(
                XMin == XMax ? 0 : Random.Range( XMin, XMax ),
                YMin == YMax ? 0 : Random.Range( YMin, YMax ) );
            yield break;
        }
    }

    [Automation( "Vector2/Create" )]
    class Vector2C : Automation {

        public Vector2 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}