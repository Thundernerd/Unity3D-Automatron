using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Mathf/Get PI" )]
	class MathfPIGet0 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.PI;
			yield break;
		}

	}

	[Automation( "Mathf/Get Infinity" )]
	class MathfInfinityGet1 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Infinity;
			yield break;
		}

	}

	[Automation( "Mathf/Get Negative Infinity" )]
	class MathfNegativeInfinityGet2 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.NegativeInfinity;
			yield break;
		}

	}

	[Automation( "Mathf/Get Deg 2 Rad" )]
	class MathfDeg2RadGet3 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Deg2Rad;
			yield break;
		}

	}

	[Automation( "Mathf/Get Rad 2 Deg" )]
	class MathfRad2DegGet4 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Rad2Deg;
			yield break;
		}

	}

	[Automation( "Mathf/Get Epsilon" )]
	class MathfEpsilonGet5 : Automation {

		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Epsilon;
			yield break;
		}

	}

	[Automation( "Mathf/Sin" )]
	class MathfSin0 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Sin(f);
			yield break;
		}

	}

	[Automation( "Mathf/Cos" )]
	class MathfCos1 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Cos(f);
			yield break;
		}

	}

	[Automation( "Mathf/Tan" )]
	class MathfTan2 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Tan(f);
			yield break;
		}

	}

	[Automation( "Mathf/Asin" )]
	class MathfAsin3 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Asin(f);
			yield break;
		}

	}

	[Automation( "Mathf/Acos" )]
	class MathfAcos4 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Acos(f);
			yield break;
		}

	}

	[Automation( "Mathf/Atan" )]
	class MathfAtan5 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Atan(f);
			yield break;
		}

	}

	[Automation( "Mathf/Atan 2" )]
	class MathfAtan26 : Automation {

		public System.Single y;
		public System.Single x;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Atan2(y,x);
			yield break;
		}

	}

	[Automation( "Mathf/Sqrt" )]
	class MathfSqrt7 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Sqrt(f);
			yield break;
		}

	}

	[Automation( "Mathf/Abs Float" )]
	class MathfAbs8 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Abs(f);
			yield break;
		}

	}

	[Automation( "Mathf/Abs Int" )]
	class MathfAbs9 : Automation {

		public System.Int32 value;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Abs(value);
			yield break;
		}

	}

	[Automation( "Mathf/Min Float" )]
	class MathfMin10 : Automation {

		public System.Single a;
		public System.Single b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Min(a,b);
			yield break;
		}

	}

	[Automation( "Mathf/Min Int" )]
	class MathfMin11 : Automation {

		public System.Int32 a;
		public System.Int32 b;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Min(a,b);
			yield break;
		}

	}

	[Automation( "Mathf/Max Float" )]
	class MathfMax12 : Automation {

		public System.Single a;
		public System.Single b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Max(a,b);
			yield break;
		}

	}

	[Automation( "Mathf/Max Int" )]
	class MathfMax13 : Automation {

		public System.Int32 a;
		public System.Int32 b;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Max(a,b);
			yield break;
		}

	}

	[Automation( "Mathf/Pow" )]
	class MathfPow14 : Automation {

		public System.Single f;
		public System.Single p;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Pow(f,p);
			yield break;
		}

	}

	[Automation( "Mathf/Exp" )]
	class MathfExp15 : Automation {

		public System.Single power;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Exp(power);
			yield break;
		}

	}

	[Automation( "Mathf/Log P" )]
	class MathfLog16 : Automation {

		public System.Single f;
		public System.Single p;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Log(f,p);
			yield break;
		}

	}

	[Automation( "Mathf/Log" )]
	class MathfLog17 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Log(f);
			yield break;
		}

	}

	[Automation( "Mathf/Log 10" )]
	class MathfLog1018 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Log10(f);
			yield break;
		}

	}

	[Automation( "Mathf/Ceil" )]
	class MathfCeil19 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Ceil(f);
			yield break;
		}

	}

	[Automation( "Mathf/Floor" )]
	class MathfFloor20 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Floor(f);
			yield break;
		}

	}

	[Automation( "Mathf/Round" )]
	class MathfRound21 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Round(f);
			yield break;
		}

	}

	[Automation( "Mathf/Ceil To Int" )]
	class MathfCeilToInt22 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.CeilToInt(f);
			yield break;
		}

	}

	[Automation( "Mathf/Floor To Int" )]
	class MathfFloorToInt23 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.FloorToInt(f);
			yield break;
		}

	}

	[Automation( "Mathf/Round To Int" )]
	class MathfRoundToInt24 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.RoundToInt(f);
			yield break;
		}

	}

	[Automation( "Mathf/Sign" )]
	class MathfSign25 : Automation {

		public System.Single f;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Sign(f);
			yield break;
		}

	}

	[Automation( "Mathf/Clamp Float" )]
	class MathfClamp26 : Automation {

		public System.Single value;
		public System.Single min;
		public System.Single max;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Clamp(value,min,max);
			yield break;
		}

	}

	[Automation( "Mathf/Clamp Int" )]
	class MathfClamp27 : Automation {

		public System.Int32 value;
		public System.Int32 min;
		public System.Int32 max;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Clamp(value,min,max);
			yield break;
		}

	}

	[Automation( "Mathf/Clamp 01" )]
	class MathfClamp0128 : Automation {

		public System.Single value;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Clamp01(value);
			yield break;
		}

	}

	[Automation( "Mathf/Lerp" )]
	class MathfLerp29 : Automation {

		public System.Single a;
		public System.Single b;
		public System.Single t;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Mathf/Lerp Unclamped" )]
	class MathfLerpUnclamped30 : Automation {

		public System.Single a;
		public System.Single b;
		public System.Single t;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Mathf/Lerp Angle" )]
	class MathfLerpAngle31 : Automation {

		public System.Single a;
		public System.Single b;
		public System.Single t;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.LerpAngle(a,b,t);
			yield break;
		}

	}

	[Automation( "Mathf/Move Towards" )]
	class MathfMoveTowards32 : Automation {

		public System.Single current;
		public System.Single target;
		public System.Single maxDelta;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.MoveTowards(current,target,maxDelta);
			yield break;
		}

	}

	[Automation( "Mathf/Move Towards Angle" )]
	class MathfMoveTowardsAngle33 : Automation {

		public System.Single current;
		public System.Single target;
		public System.Single maxDelta;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.MoveTowardsAngle(current,target,maxDelta);
			yield break;
		}

	}

	[Automation( "Mathf/Smooth Step" )]
	class MathfSmoothStep34 : Automation {

		public System.Single from;
		public System.Single to;
		public System.Single t;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.SmoothStep(from,to,t);
			yield break;
		}

	}

	[Automation( "Mathf/Gamma" )]
	class MathfGamma35 : Automation {

		public System.Single value;
		public System.Single absmax;
		public System.Single gamma;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Gamma(value,absmax,gamma);
			yield break;
		}

	}

	[Automation( "Mathf/Approximately" )]
	class MathfApproximately36 : ConditionalAutomation {

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

	[Automation( "Mathf/Smooth Damp" )]
	class MathfSmoothDamp37 : Automation {

		public System.Single current;
		public System.Single target;
		public System.Single currentVelocity;
		public System.Single smoothTime;
		public System.Single maxSpeed;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.SmoothDamp(current,target,ref currentVelocity,smoothTime,maxSpeed);
			yield break;
		}

	}

	[Automation( "Mathf/Smooth Damp Angle" )]
	class MathfSmoothDampAngle38 : Automation {

		public System.Single current;
		public System.Single target;
		public System.Single currentVelocity;
		public System.Single smoothTime;
		public System.Single maxSpeed;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.SmoothDampAngle(current,target,ref currentVelocity,smoothTime,maxSpeed);
			yield break;
		}

	}

	[Automation( "Mathf/Repeat" )]
	class MathfRepeat39 : Automation {

		public System.Single t;
		public System.Single length;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.Repeat(t,length);
			yield break;
		}

	}

	[Automation( "Mathf/Ping Pong" )]
	class MathfPingPong40 : Automation {

		public System.Single t;
		public System.Single length;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.PingPong(t,length);
			yield break;
		}

	}

	[Automation( "Mathf/Inverse Lerp" )]
	class MathfInverseLerp41 : Automation {

		public System.Single a;
		public System.Single b;
		public System.Single value;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.InverseLerp(a,b,value);
			yield break;
		}

	}

	[Automation( "Mathf/Closest Power Of Two" )]
	class MathfClosestPowerOfTwo42 : Automation {

		public System.Int32 value;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.ClosestPowerOfTwo(value);
			yield break;
		}

	}

	[Automation( "Mathf/Gamma To Linear Space" )]
	class MathfGammaToLinearSpace43 : Automation {

		public System.Single value;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.GammaToLinearSpace(value);
			yield break;
		}

	}

	[Automation( "Mathf/Linear To Gamma Space" )]
	class MathfLinearToGammaSpace44 : Automation {

		public System.Single value;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.LinearToGammaSpace(value);
			yield break;
		}

	}

	[Automation( "Mathf/Is Power Of Two" )]
	class MathfIsPowerOfTwo45 : ConditionalAutomation {

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

	[Automation( "Mathf/Next Power Of Two" )]
	class MathfNextPowerOfTwo46 : Automation {

		public System.Int32 value;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.NextPowerOfTwo(value);
			yield break;
		}

	}

	[Automation( "Mathf/Delta Angle" )]
	class MathfDeltaAngle47 : Automation {

		public System.Single current;
		public System.Single target;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.DeltaAngle(current,target);
			yield break;
		}

	}

	[Automation( "Mathf/Perlin Noise" )]
	class MathfPerlinNoise48 : Automation {

		public System.Single x;
		public System.Single y;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.PerlinNoise(x,y);
			yield break;
		}

	}

	[Automation( "Mathf/Float To Half" )]
	class MathfFloatToHalf49 : Automation {

		public System.Single val;
		[ReadOnly]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.FloatToHalf(val);
			yield break;
		}

	}

	[Automation( "Mathf/Half To Float" )]
	class MathfHalfToFloat50 : Automation {

		public System.UInt16 val;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Mathf.HalfToFloat(val);
			yield break;
		}

	}


#pragma warning restore 0649
}
