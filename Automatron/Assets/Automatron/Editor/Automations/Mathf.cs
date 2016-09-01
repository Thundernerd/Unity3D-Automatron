using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Generated/Mathf/Get PI" )]
	class MathfPIGet0 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.PI;
			yield break;
		}

	}

	[Automation( "Generated/Mathf/Get Infinity" )]
	class MathfInfinityGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Infinity;
			yield break;
		}

	}

	[Automation( "Generated/Mathf/Get Negative Infinity" )]
	class MathfNegativeInfinityGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.NegativeInfinity;
			yield break;
		}

	}

	[Automation( "Generated/Mathf/Get Deg 2 Rad" )]
	class MathfDeg2RadGet3 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Deg2Rad;
			yield break;
		}

	}

	[Automation( "Generated/Mathf/Get Rad 2 Deg" )]
	class MathfRad2DegGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Rad2Deg;
			yield break;
		}

	}

	[Automation( "Generated/Mathf/Get Epsilon" )]
	class MathfEpsilonGet5 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Epsilon;
			yield break;
		}

	}

    [Automation( "Math/Sin" )]
    class MathfSin0 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Sin( f );
            yield break;
        }

    }

    [Automation( "Math/Cos" )]
    class MathfCos1 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Cos( f );
            yield break;
        }

    }

    [Automation( "Math/Tan" )]
    class MathfTan2 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Tan( f );
            yield break;
        }

    }

    [Automation( "Math/Asin" )]
    class MathfAsin3 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Asin( f );
            yield break;
        }

    }

    [Automation( "Math/Acos" )]
    class MathfAcos4 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Acos( f );
            yield break;
        }

    }

    [Automation( "Math/Atan" )]
    class MathfAtan5 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Atan( f );
            yield break;
        }

    }

    [Automation( "Math/Atan 2" )]
    class MathfAtan26 : Automation {

        public System.Single y;
        public System.Single x;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Atan2( y, x );
            yield break;
        }

    }

    [Automation( "Math/Sqrt" )]
    class MathfSqrt7 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Sqrt( f );
            yield break;
        }

    }

    [Automation( "Math/Abs/Float" )]
    class MathfAbs8 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Abs( f );
            yield break;
        }

    }

    [Automation( "Math/Abs/Int" )]
    class MathfAbs9 : Automation {

        public System.Int32 value;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Abs( value );
            yield break;
        }

    }

    [Automation( "Math/Min/Float" )]
    class MathfMin10 : Automation {

        public System.Single a;
        public System.Single b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Min( a, b );
            yield break;
        }

    }

    [Automation( "Math/Min/Int" )]
    class MathfMin12 : Automation {

        public System.Int32 a;
        public System.Int32 b;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Min( a, b );
            yield break;
        }

    }

    [Automation( "Math/Max/Float" )]
    class MathfMax14 : Automation {

        public System.Single a;
        public System.Single b;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Max( a, b );
            yield break;
        }

    }

    [Automation( "Math/Max/Int" )]
    class MathfMax16 : Automation {

        public System.Int32 a;
        public System.Int32 b;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Max( a, b );
            yield break;
        }

    }

    [Automation( "Math/Pow" )]
    class MathfPow18 : Automation {

        public System.Single f;
        public System.Single p;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Pow( f, p );
            yield break;
        }

    }

    [Automation( "Math/Exp" )]
    class MathfExp19 : Automation {

        public System.Single power;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Exp( power );
            yield break;
        }

    }

    [Automation( "Math/Log Power" )]
    class MathfLog20 : Automation {

        public System.Single f;
        public System.Single p;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Log( f, p );
            yield break;
        }

    }

    [Automation( "Math/Log" )]
    class MathfLog21 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Log( f );
            yield break;
        }

    }

    [Automation( "Math/Log 10" )]
    class MathfLog1022 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Log10( f );
            yield break;
        }

    }

    [Automation( "Math/Ceil" )]
    class MathfCeil23 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Ceil( f );
            yield break;
        }

    }

    [Automation( "Math/Floor" )]
    class MathfFloor24 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Floor( f );
            yield break;
        }

    }

    [Automation( "Math/Round" )]
    class MathfRound25 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Round( f );
            yield break;
        }

    }

    [Automation( "Math/Ceil To Int" )]
    class MathfCeilToInt26 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.CeilToInt( f );
            yield break;
        }

    }

    [Automation( "Math/Floor To Int" )]
    class MathfFloorToInt27 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.FloorToInt( f );
            yield break;
        }

    }

    [Automation( "Math/Round To Int" )]
    class MathfRoundToInt28 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.RoundToInt( f );
            yield break;
        }

    }

    [Automation( "Math/Sign" )]
    class MathfSign29 : Automation {

        public System.Single f;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Sign( f );
            yield break;
        }

    }

    [Automation( "Math/Clamp/Float" )]
    class MathfClamp30 : Automation {

        public System.Single value;
        public System.Single min;
        public System.Single max;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Clamp( value, min, max );
            yield break;
        }

    }

    [Automation( "Math/Clamp/Int" )]
    class MathfClamp31 : Automation {

        public System.Int32 value;
        public System.Int32 min;
        public System.Int32 max;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Clamp( value, min, max );
            yield break;
        }

    }

    [Automation( "Math/Clamp 01" )]
    class MathfClamp0132 : Automation {

        public System.Single value;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Clamp01( value );
            yield break;
        }

    }

    [Automation( "Math/Lerp" )]
    class MathfLerp33 : Automation {

        public System.Single a;
        public System.Single b;
        public System.Single t;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Lerp( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Lerp Unclamped" )]
    class MathfLerpUnclamped34 : Automation {

        public System.Single a;
        public System.Single b;
        public System.Single t;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.LerpUnclamped( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Lerp Angle" )]
    class MathfLerpAngle35 : Automation {

        public System.Single a;
        public System.Single b;
        public System.Single t;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.LerpAngle( a, b, t );
            yield break;
        }

    }

    [Automation( "Math/Move Towards" )]
    class MathfMoveTowards36 : Automation {

        public System.Single current;
        public System.Single target;
        public System.Single maxDelta;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.MoveTowards( current, target, maxDelta );
            yield break;
        }

    }

    [Automation( "Math/Move Towards Angle" )]
    class MathfMoveTowardsAngle37 : Automation {

        public System.Single current;
        public System.Single target;
        public System.Single maxDelta;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.MoveTowardsAngle( current, target, maxDelta );
            yield break;
        }

    }

    [Automation( "Math/Smooth Step" )]
    class MathfSmoothStep38 : Automation {

        public System.Single from;
        public System.Single to;
        public System.Single t;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.SmoothStep( from, to, t );
            yield break;
        }

    }

    [Automation( "Math/Gamma" )]
    class MathfGamma39 : Automation {

        public System.Single value;
        public System.Single absmax;
        public System.Single gamma;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Gamma( value, absmax, gamma );
            yield break;
        }

    }

    [Automation( "Math/Approximately" )]
	class MathfApproximately40 : ConditionalAutomation {

		public System.Single a;
		public System.Single b;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Mathf.Approximately(a,b);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Math/Smooth Damp" )]
    class MathfSmoothDamp41 : Automation {

        public System.Single current;
        public System.Single target;
        public System.Single currentVelocity;
        public System.Single smoothTime;
        public System.Single maxSpeed;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.SmoothDamp( current, target, ref currentVelocity, smoothTime, maxSpeed );
            yield break;
        }

    }

    [Automation( "Math/Smooth Damp Angle" )]
    class MathfSmoothDampAngle44 : Automation {

        public System.Single current;
        public System.Single target;
        public System.Single currentVelocity;
        public System.Single smoothTime;
        public System.Single maxSpeed;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.SmoothDampAngle( current, target, ref currentVelocity, smoothTime, maxSpeed );
            yield break;
        }

    }

    [Automation( "Math/Repeat" )]
    class MathfRepeat47 : Automation {

        public System.Single t;
        public System.Single length;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.Repeat( t, length );
            yield break;
        }

    }

    [Automation( "Math/Ping Pong" )]
    class MathfPingPong48 : Automation {

        public System.Single t;
        public System.Single length;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.PingPong( t, length );
            yield break;
        }

    }

    [Automation( "Math/Inverse Lerp" )]
    class MathfInverseLerp49 : Automation {

        public System.Single a;
        public System.Single b;
        public System.Single value;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.InverseLerp( a, b, value );
            yield break;
        }

    }

    [Automation( "Math/Closest Power Of Two" )]
    class MathfClosestPowerOfTwo50 : Automation {

        public System.Int32 value;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.ClosestPowerOfTwo( value );
            yield break;
        }

    }

    [Automation( "Math/Gamma To Linear Space" )]
    class MathfGammaToLinearSpace51 : Automation {

        public System.Single value;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.GammaToLinearSpace( value );
            yield break;
        }

    }

    [Automation( "Math/Linear To Gamma Space" )]
    class MathfLinearToGammaSpace52 : Automation {

        public System.Single value;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.LinearToGammaSpace( value );
            yield break;
        }

    }

    [Automation( "Math/Is Power Of Two" )]
	class MathfIsPowerOfTwo53 : ConditionalAutomation {

		public System.Int32 value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEngine.Mathf.IsPowerOfTwo(value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

    [Automation( "Math/Next Power Of Two" )]
    class MathfNextPowerOfTwo54 : Automation {

        public System.Int32 value;
        [ReadOnly]
        public System.Int32 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.NextPowerOfTwo( value );
            yield break;
        }

    }

    [Automation( "Math/Delta Angle" )]
    class MathfDeltaAngle55 : Automation {

        public System.Single current;
        public System.Single target;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.DeltaAngle( current, target );
            yield break;
        }

    }

    [Automation( "Math/Perlin Noise" )]
    class MathfPerlinNoise56 : Automation {

        public System.Single x;
        public System.Single y;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.PerlinNoise( x, y );
            yield break;
        }

    }

    [Automation( "Math/Float To Half" )]
    class MathfFloatToHalf57 : Automation {

        public System.Single val;
        [ReadOnly]
        public System.UInt16 Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.FloatToHalf( val );
            yield break;
        }

    }

    [Automation( "Math/Half To Float" )]
    class MathfHalfToFloat58 : Automation {

        public System.UInt16 val;
        [ReadOnly]
        public System.Single Result;

        public override IEnumerator Execute() {
            Result = UnityEngine.Mathf.HalfToFloat( val );
            yield break;
        }

    }

#pragma warning restore 0649
}