using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Math/Abs/Float" )]
    class AbsF : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Abs( Value );
            yield break;
        }
    }

    [Automation( "Math/Abs/Int" )]
    class AbsI : Automation {

        public int Value;
        [ReadOnly]
        public int Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Abs( Value );
            yield break;
        }
    }

    [Automation( "Math/Acos" )]
    class Acos : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Acos( Value );
            yield break;
        }
    }

    [Automation( "Math/Asin" )]
    class Asin : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Asin( Value );
            yield break;
        }
    }

    [Automation( "Math/Atan" )]
    class Atan : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Atan( Value );
            yield break;
        }
    }

    [Automation( "Math/Atan2" )]
    class Atan2 : Automation {

        public float X;
        public float Y;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Atan2( Y, X );
            yield break;
        }
    }

    [Automation( "Math/Ceil" )]
    class Ceil : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Ceil( Value );
            yield break;
        }
    }

    [Automation( "Math/Clamp/Int" )]
    class ClampI : Automation {

        public int Value;
        public int Min;
        public int Max;
        [ReadOnly]
        public int Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Clamp( Value, Min, Max );
            yield break;
        }
    }

    [Automation( "Math/Clamp/Float" )]
    class ClampF : Automation {

        public float Value;
        public float Min;
        public float Max;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Clamp( Value, Min, Max );
            yield break;
        }
    }

    [Automation( "Math/Clamp01" )]
    class Clamp01 : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Clamp01( Value );
            yield break;
        }
    }

    [Automation( "Math/Cos" )]
    class Cos : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Cos( Value );
            yield break;
        }
    }

    [Automation( "Math/Exp" )]
    class Exp : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Exp( Value );
            yield break;
        }
    }

    [Automation( "Math/Floor" )]
    class Floor : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Floor( Value );
            yield break;
        }
    }

    [Automation( "Math/Lerp" )]
    class Lerp : Automation {

        public float a;
        public float b;
        public float t;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Lerp( a, b, t );
            yield break;
        }
    }

    [Automation( "Math/Lerp Abgke" )]
    class LerpAngle : Automation {

        public float a;
        public float b;
        public float t;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.LerpAngle( a, b, t );
            yield break;
        }
    }

    [Automation( "Math/Lerp Unclamped" )]
    class LerpUnclamped : Automation {

        public float a;
        public float b;
        public float t;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.LerpUnclamped( a, b, t );
            yield break;
        }
    }

    [Automation( "Math/Log" )]
    class Log : Automation {

        public float f;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Log( f );
            yield break;
        }
    }

    [Automation( "Math/Log Power" )]
    class LogP : Automation {

        public float f;
        public float p;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Log( f, p );
            yield break;
        }
    }

    [Automation( "Math/Log10" )]
    class Log10 : Automation {

        public float f;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Log10( f );
            yield break;
        }
    }

    [Automation( "Math/Max/Float" )]
    class MaxF : Automation {

        public float a;
        public float b;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Max( a, b );
            yield break;
        }
    }

    [Automation( "Math/Max/Int" )]
    class MaxI : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Max( a, b );
            yield break;
        }
    }

    [Automation( "Math/Min/Float" )]
    class MinF : Automation {

        public float a;
        public float b;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Min( a, b );
            yield break;
        }
    }

    [Automation( "Math/Min/Int" )]
    class MinI : Automation {

        public int a;
        public int b;
        [ReadOnly]
        public int Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Min( a, b );
            yield break;
        }
    }

    [Automation( "Math/Round" )]
    class Round : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Round( Value );
            yield break;
        }
    }

    [Automation( "Math/Sin" )]
    class Sin : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Sin( Value );
            yield break;
        }
    }

    [Automation( "Math/Sqrt" )]
    class Sqrt : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Sqrt( Value );
            yield break;
        }
    }

    [Automation( "Math/Tan" )]
    class Tan : Automation {

        public float Value;
        [ReadOnly]
        public float Result;

        public override void Reset() {
            base.Reset();
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = Mathf.Tan( Value );
            yield break;
        }
    }

#pragma warning restore 0649
}