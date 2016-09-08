using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Vector 2/Get X" )]
	class Vector2xGet0 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.x;
			yield break;
		}

	}

	[Automation( "Vector 2/Set X" )]
	class Vector2xSet0 : Automation {

		public UnityEngine.Vector2 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.x = Value;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Y" )]
	class Vector2yGet1 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.y;
			yield break;
		}

	}

	[Automation( "Vector 2/Set Y" )]
	class Vector2ySet1 : Automation {

		public UnityEngine.Vector2 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.y = Value;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Normalized" )]
	class Vector2normalizedGet0 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.normalized;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Magnitude" )]
	class Vector2magnitudeGet1 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.magnitude;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Sqr Magnitude" )]
	class Vector2sqrMagnitudeGet2 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sqrMagnitude;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Zero" )]
	class Vector2zeroGet3 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.zero;
			yield break;
		}

	}

	[Automation( "Vector 2/Get One" )]
	class Vector2oneGet4 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.one;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Up" )]
	class Vector2upGet5 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.up;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Down" )]
	class Vector2downGet6 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.down;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Left" )]
	class Vector2leftGet7 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.left;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Right" )]
	class Vector2rightGet8 : Automation {

		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.right;
			yield break;
		}

	}

	[Automation( "Vector 2/Lerp" )]
	class Vector2Lerp0 : Automation {

		public UnityEngine.Vector2 a;
		public UnityEngine.Vector2 b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 2/Lerp Unclamped" )]
	class Vector2LerpUnclamped1 : Automation {

		public UnityEngine.Vector2 a;
		public UnityEngine.Vector2 b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 2/Move Towards" )]
	class Vector2MoveTowards2 : Automation {

		public UnityEngine.Vector2 current;
		public UnityEngine.Vector2 target;
		public System.Single maxDistanceDelta;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.MoveTowards(current,target,maxDistanceDelta);
			yield break;
		}

	}

	[Automation( "Vector 2/Scale" )]
	class Vector2Scale3 : Automation {

		public UnityEngine.Vector2 a;
		public UnityEngine.Vector2 b;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Scale(a,b);
			yield break;
		}

	}

	[Automation( "Vector 2/Normalize" )]
	class Vector2Normalize4 : Automation {

		public UnityEngine.Vector2 Instance;

		public override IEnumerator Execute() {
			Instance.Normalize();
			yield break;
		}

	}

	[Automation( "Vector 2/Reflect" )]
	class Vector2Reflect5 : Automation {

		public UnityEngine.Vector2 inDirection;
		public UnityEngine.Vector2 inNormal;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Reflect(inDirection,inNormal);
			yield break;
		}

	}

	[Automation( "Vector 2/Dot" )]
	class Vector2Dot6 : Automation {

		public UnityEngine.Vector2 lhs;
		public UnityEngine.Vector2 rhs;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Dot(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 2/Angle" )]
	class Vector2Angle7 : Automation {

		public UnityEngine.Vector2 from;
		public UnityEngine.Vector2 to;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Angle(from,to);
			yield break;
		}

	}

	[Automation( "Vector 2/Distance" )]
	class Vector2Distance8 : Automation {

		public UnityEngine.Vector2 a;
		public UnityEngine.Vector2 b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Distance(a,b);
			yield break;
		}

	}

	[Automation( "Vector 2/Clamp Magnitude" )]
	class Vector2ClampMagnitude9 : Automation {

		public UnityEngine.Vector2 vector;
		public System.Single maxLength;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.ClampMagnitude(vector,maxLength);
			yield break;
		}

	}

	[Automation( "Vector 2/Sqr Magnitude" )]
	class Vector2SqrMagnitude10 : Automation {

		public UnityEngine.Vector2 a;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.SqrMagnitude(a);
			yield break;
		}

	}

	[Automation( "Vector 2/Min" )]
	class Vector2Min11 : Automation {

		public UnityEngine.Vector2 lhs;
		public UnityEngine.Vector2 rhs;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Min(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 2/Max" )]
	class Vector2Max12 : Automation {

		public UnityEngine.Vector2 lhs;
		public UnityEngine.Vector2 rhs;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Max(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 2/Smooth Damp" )]
	class Vector2SmoothDamp13 : Automation {

		public UnityEngine.Vector2 current;
		public UnityEngine.Vector2 target;
		public UnityEngine.Vector2 currentVelocity;
		public System.Single smoothTime;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.SmoothDamp(current,target,ref currentVelocity,smoothTime);
			yield break;
		}

	}


#pragma warning restore 0649
}
