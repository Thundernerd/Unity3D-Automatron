using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Math/Vector3/Lerp" )]
    class Vector3Lerp0 : Automation {

        public UnityEngine.Vector3 a;
        public UnityEngine.Vector3 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Lerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Lerp Unclamped" )]
    class Vector3LerpUnclamped1 : Automation {

        public UnityEngine.Vector3 a;
        public UnityEngine.Vector3 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.LerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Slerp" )]
    class Vector3Slerp2 : Automation {

        public UnityEngine.Vector3 a;
        public UnityEngine.Vector3 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Slerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Slerp Unclamped" )]
    class Vector3SlerpUnclamped3 : Automation {

        public UnityEngine.Vector3 a;
        public UnityEngine.Vector3 b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.SlerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Ortho Normalize" )]
    class Vector3OrthoNormalize4 : Automation {

        public UnityEngine.Vector3 normal;
        public UnityEngine.Vector3 tangent;

        public override IEnumerator Execute() {
            UnityEngine.Vector3.OrthoNormalize( ref normal, ref tangent );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Move Towards" )]
    class Vector3MoveTowards6 : Automation {

        public UnityEngine.Vector3 current;
        public UnityEngine.Vector3 target;
        public System.Single maxDistanceDelta;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.MoveTowards( current, target, maxDistanceDelta );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Rotate Towards" )]
    class Vector3RotateTowards7 : Automation {

        public UnityEngine.Vector3 current;
        public UnityEngine.Vector3 target;
        public System.Single maxRadiansDelta;
        public System.Single maxMagnitudeDelta;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.RotateTowards( current, target, maxRadiansDelta, maxMagnitudeDelta );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Smooth Damp" )]
    class Vector3SmoothDamp8 : Automation {

        public UnityEngine.Vector3 current;
        public UnityEngine.Vector3 target;
        public UnityEngine.Vector3 currentVelocity;
        public System.Single smoothTime;
        public System.Single maxSpeed;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.SmoothDamp( current, target, ref currentVelocity, smoothTime, maxSpeed );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Scale" )]
    class Vector3Scale11 : Automation {

        public UnityEngine.Vector3 a;
        public UnityEngine.Vector3 b;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Scale( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Cross" )]
    class Vector3Cross12 : Automation {

        public UnityEngine.Vector3 lhs;
        public UnityEngine.Vector3 rhs;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Cross( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Reflect" )]
    class Vector3Reflect13 : Automation {

        public UnityEngine.Vector3 inDirection;
        public UnityEngine.Vector3 inNormal;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Reflect( inDirection, inNormal );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Normalize" )]
    class Vector3Normalize14 : Automation {

        public UnityEngine.Vector3 value;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Normalize( value );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Dot" )]
    class Vector3Dot15 : Automation {

        public UnityEngine.Vector3 lhs;
        public UnityEngine.Vector3 rhs;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Dot( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Project" )]
    class Vector3Project16 : Automation {

        public UnityEngine.Vector3 vector;
        public UnityEngine.Vector3 onNormal;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Project( vector, onNormal );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Project On Plane" )]
    class Vector3ProjectOnPlane17 : Automation {

        public UnityEngine.Vector3 vector;
        public UnityEngine.Vector3 planeNormal;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.ProjectOnPlane( vector, planeNormal );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Angle" )]
    class Vector3Angle18 : Automation {

        public UnityEngine.Vector3 from;
        public UnityEngine.Vector3 to;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Angle( from, to );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Distance" )]
    class Vector3Distance19 : Automation {

        public UnityEngine.Vector3 a;
        public UnityEngine.Vector3 b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Distance( a, b );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Clamp Magnitude" )]
    class Vector3ClampMagnitude20 : Automation {

        public UnityEngine.Vector3 vector;
        public System.Single maxLength;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.ClampMagnitude( vector, maxLength );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Magnitude" )]
    class Vector3Magnitude21 : Automation {

        public UnityEngine.Vector3 a;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Magnitude( a );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Sqr Magnitude" )]
    class Vector3SqrMagnitude22 : Automation {

        public UnityEngine.Vector3 a;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.SqrMagnitude( a );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Min" )]
    class Vector3Min23 : Automation {

        public UnityEngine.Vector3 lhs;
        public UnityEngine.Vector3 rhs;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Min( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Max" )]
    class Vector3Max24 : Automation {

        public UnityEngine.Vector3 lhs;
        public UnityEngine.Vector3 rhs;
        [ReadOnly]
        public UnityEngine.Vector3 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Vector3.Max( lhs, rhs );
            yield break;
        }

    }

    [Automation( "Math/Vector3/Add" )]
    class Vector3Add : Automation {

        public Vector3 InOut;
        public Vector3 Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Math/Vector3/Subtract" )]
    class Vector3Subtract : Automation {

        public Vector3 InOut;
        public Vector3 Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector3/Multiply" )]
    class Vector3Multiply : Automation {

        public Vector3 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector3/Divide" )]
    class Vector3Divide : Automation {

        public Vector3 InOut;
        public float Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Math/Vector3/Create" )]
    class Vector3C : Automation {

        public Vector3 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}