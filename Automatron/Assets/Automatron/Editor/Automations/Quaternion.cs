using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Math/Quaternion/Dot" )]
    class QuaternionDot0 : Automation {

        public UnityEngine.Quaternion a;
        public UnityEngine.Quaternion b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Dot( a, b );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Angle Axis" )]
    class QuaternionAngleAxis1 : Automation {

        public System.Single angle;
        public UnityEngine.Vector3 axis;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.AngleAxis( angle, axis );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/From To Rotation" )]
    class QuaternionFromToRotation2 : Automation {

        public UnityEngine.Vector3 fromDirection;
        public UnityEngine.Vector3 toDirection;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.FromToRotation( fromDirection, toDirection );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Look Rotation" )]
    class QuaternionLookRotation3 : Automation {

        public UnityEngine.Vector3 forward;
        public UnityEngine.Vector3 upwards;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.LookRotation( forward, upwards );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Slerp" )]
    class QuaternionSlerp5 : Automation {

        public UnityEngine.Quaternion a;
        public UnityEngine.Quaternion b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Slerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Slerp Unclamped" )]
    class QuaternionSlerpUnclamped6 : Automation {

        public UnityEngine.Quaternion a;
        public UnityEngine.Quaternion b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.SlerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Lerp" )]
    class QuaternionLerp7 : Automation {

        public UnityEngine.Quaternion a;
        public UnityEngine.Quaternion b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Lerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Lerp Unclamped" )]
    class QuaternionLerpUnclamped8 : Automation {

        public UnityEngine.Quaternion a;
        public UnityEngine.Quaternion b;
        public System.Single t;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.LerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Rotate Towards" )]
    class QuaternionRotateTowards9 : Automation {

        public UnityEngine.Quaternion from;
        public UnityEngine.Quaternion to;
        public System.Single maxDegreesDelta;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.RotateTowards( from, to, maxDegreesDelta );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Inverse" )]
    class QuaternionInverse10 : Automation {

        public UnityEngine.Quaternion rotation;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Inverse( rotation );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Angle" )]
    class QuaternionAngle11 : Automation {

        public UnityEngine.Quaternion a;
        public UnityEngine.Quaternion b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Angle( a, b );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Euler" )]
    class QuaternionEuler12 : Automation {

        public System.Single x;
        public System.Single y;
        public System.Single z;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Euler( x, y, z );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Euler (V3)" )]
    class QuaternionEuler13 : Automation {

        public UnityEngine.Vector3 euler;
        [ReadOnly]
        public UnityEngine.Quaternion Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Quaternion.Euler( euler );
            yield break;
        }

    }

    [Automation( "Math/Quaternion/Multiply" )]
    class QuaternionMultiplyQ : Automation {

        public Quaternion InOut;
        public Quaternion Rhs;

        public override IEnumerator Execute() {
            InOut *= Rhs;
            yield break;
        }
    }

    [Automation( "Math/Quaternion/Multiply (V3)" )]
    class QuaternionMultiplyV : Automation {

        public Quaternion Rotation;
        public Vector3 Point;
        [ReadOnly]
        public Vector3 Value;

        public override void Reset() {
            base.Reset();
            Value = new Vector3();
        }

        public override IEnumerator Execute() {
            Value = Rotation * Point;
            yield break;
        }
    }



#pragma warning restore 0649
}