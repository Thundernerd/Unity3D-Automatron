using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Math/Vector4/Lerp" )]
    class Vector4Lerp0 : Automation {

        public UnityEngine.Vector4 a;
        public UnityEngine.Vector4 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Lerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Lerp Unclamped" )]
    class Vector4LerpUnclamped1 : Automation {

        public UnityEngine.Vector4 a;
        public UnityEngine.Vector4 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.LerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Move Towards" )]
    class Vector4MoveTowards2 : Automation {

        public UnityEngine.Vector4 current;
        public UnityEngine.Vector4 target;
        public System.Single maxDistanceDelta;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.MoveTowards( current, target, maxDistanceDelta );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Scale" )]
    class Vector4Scale3 : Automation {

        public UnityEngine.Vector4 a;
        public UnityEngine.Vector4 b;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Scale( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Normalize" )]
    class Vector4Normalize4 : Automation {

        public UnityEngine.Vector4 a;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Normalize( a );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Dot" )]
    class Vector4Dot5 : Automation {

        public UnityEngine.Vector4 a;
        public UnityEngine.Vector4 b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Dot( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Project" )]
    class Vector4Project6 : Automation {

        public UnityEngine.Vector4 a;
        public UnityEngine.Vector4 b;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Project( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Distance" )]
    class Vector4Distance7 : Automation {

        public UnityEngine.Vector4 a;
        public UnityEngine.Vector4 b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Distance( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Magnitude" )]
    class Vector4Magnitude8 : Automation {

        public UnityEngine.Vector4 a;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Magnitude( a );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Sqr Magnitude" )]
    class Vector4SqrMagnitude9 : Automation {

        public UnityEngine.Vector4 a;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.SqrMagnitude( a );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Min" )]
    class Vector4Min10 : Automation {

        public UnityEngine.Vector4 lhs;
        public UnityEngine.Vector4 rhs;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Min( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Max" )]
    class Vector4Max11 : Automation {

        public UnityEngine.Vector4 lhs;
        public UnityEngine.Vector4 rhs;
        [ReadOnly]
        public UnityEngine.Vector4 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector4.Max( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector4/Add" )]
    class Vector4Add : Automation {

        public Vector4 InOut;
        public Vector4 Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Math/Vector4/Subtract" )]
    class Vector4Subtract : Automation {

        public Vector4 InOut;
        public Vector4 Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector4/Multiply" )]
    class Vector4Multiply : Automation {

        public Vector4 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector4/Divide" )]
    class Vector4Divide : Automation {

        public Vector4 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector4/Create" )]
    class Vector4C : Automation {

        public Vector4 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}