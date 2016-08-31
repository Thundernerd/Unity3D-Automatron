using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Math/Vector2/Lerp" )]
    class Vector2Lerp0 : Automation {

        public UnityEngine.Vector2 a;
        public UnityEngine.Vector2 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Lerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Lerp Unclamped" )]
    class Vector2LerpUnclamped1 : Automation {

        public UnityEngine.Vector2 a;
        public UnityEngine.Vector2 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.LerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Move Towards" )]
    class Vector2MoveTowards2 : Automation {

        public UnityEngine.Vector2 current;
        public UnityEngine.Vector2 target;
        public System.Single maxDistanceDelta;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.MoveTowards( current, target, maxDistanceDelta );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Scale" )]
    class Vector2Scale3 : Automation {

        public UnityEngine.Vector2 a;
        public UnityEngine.Vector2 b;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Scale( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Reflect" )]
    class Vector2Reflect4 : Automation {

        public UnityEngine.Vector2 inDirection;
        public UnityEngine.Vector2 inNormal;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Reflect( inDirection, inNormal );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Dot" )]
    class Vector2Dot5 : Automation {

        public UnityEngine.Vector2 lhs;
        public UnityEngine.Vector2 rhs;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Dot( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Angle" )]
    class Vector2Angle6 : Automation {

        public UnityEngine.Vector2 from;
        public UnityEngine.Vector2 to;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Angle( from, to );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Distance" )]
    class Vector2Distance7 : Automation {

        public UnityEngine.Vector2 a;
        public UnityEngine.Vector2 b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Distance( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Clamp Magnitude" )]
    class Vector2ClampMagnitude8 : Automation {

        public UnityEngine.Vector2 vector;
        public System.Single maxLength;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.ClampMagnitude( vector, maxLength );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Sqr Magnitude" )]
    class Vector2SqrMagnitude9 : Automation {

        public UnityEngine.Vector2 a;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.SqrMagnitude( a );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Min" )]
    class Vector2Min10 : Automation {

        public UnityEngine.Vector2 lhs;
        public UnityEngine.Vector2 rhs;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Min( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Max" )]
    class Vector2Max11 : Automation {

        public UnityEngine.Vector2 lhs;
        public UnityEngine.Vector2 rhs;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.Max( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Smooth Damp" )]
    class Vector2SmoothDamp12 : Automation {

        public UnityEngine.Vector2 current;
        public UnityEngine.Vector2 target;
        public UnityEngine.Vector2 currentVelocity;
        public System.Single smoothTime;
        public System.Single maxSpeed;
        [ReadOnly]
        public UnityEngine.Vector2 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector2.SmoothDamp( current, target, ref currentVelocity, smoothTime, maxSpeed );
            yield break;
        }

    }

    [Automation( "Math/Vector2/Add" )]
    class Vector2Add : Automation {

        public Vector2 InOut;
        public Vector2 Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Math/Vector2/Subtract" )]
    class Vector2Subtract : Automation {

        public Vector2 InOut;
        public Vector2 Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector2/Multiply" )]
    class Vector2Multiply : Automation {

        public Vector2 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector2/Divide" )]
    class Vector2Divide : Automation {

        public Vector2 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector2/Create" )]
    class Vector2C : Automation {

        public Vector2 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}