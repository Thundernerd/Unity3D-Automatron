using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Vector 2/Get Epsilon" )]
	class Vector2kEpsilonGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.kEpsilon;
			yield break;
		}

	}

	[Automation( "Vector 2/Get X" )]
	class Vector2xGet1 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.x;
			yield break;
		}

	}

	[Automation( "Vector 2/Set X" )]
	class Vector2xSet1 : Automation {

		public UnityEngine.Vector2 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.x = Value;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Y" )]
	class Vector2yGet2 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.y;
			yield break;
		}

	}

	[Automation( "Vector 2/Set Y" )]
	class Vector2ySet2 : Automation {

		public UnityEngine.Vector2 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.y = Value;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Normalized" )]
	class Vector2normalizedGet1 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.normalized;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Magnitude" )]
	class Vector2magnitudeGet2 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.magnitude;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Sqr Magnitude" )]
	class Vector2sqrMagnitudeGet3 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sqrMagnitude;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Zero" )]
	class Vector2zeroGet4 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.zero;
			yield break;
		}

	}

	[Automation( "Vector 2/Get One" )]
	class Vector2oneGet5 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.one;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Up" )]
	class Vector2upGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.up;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Down" )]
	class Vector2downGet7 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.down;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Left" )]
	class Vector2leftGet8 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.left;
			yield break;
		}

	}

	[Automation( "Vector 2/Get Right" )]
	class Vector2rightGet9 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.MoveTowards(current,target,maxDistanceDelta);
			yield break;
		}

	}

	[Automation( "Vector 2/Scale" )]
	class Vector2Scale4 : Automation {

		public UnityEngine.Vector2 Instance;
		public UnityEngine.Vector2 scale;

		public override IEnumerator Execute() {
			Instance.Scale(scale);
			yield break;
		}

	}

	[Automation( "Vector 2/Normalize" )]
	class Vector2Normalize5 : Automation {

		public UnityEngine.Vector2 Instance;

		public override IEnumerator Execute() {
			Instance.Normalize();
			yield break;
		}

	}

	[Automation( "Vector 2/Equals" )]
	class Vector2Equals6 : ConditionalAutomation {

		public UnityEngine.Vector2 Instance;
		public System.Object other;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(other);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Vector 2/Reflect" )]
	class Vector2Reflect7 : Automation {

		public UnityEngine.Vector2 inDirection;
		public UnityEngine.Vector2 inNormal;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Reflect(inDirection,inNormal);
			yield break;
		}

	}

	[Automation( "Vector 2/Dot" )]
	class Vector2Dot8 : Automation {

		public UnityEngine.Vector2 lhs;
		public UnityEngine.Vector2 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Dot(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 2/Angle" )]
	class Vector2Angle9 : Automation {

		public UnityEngine.Vector2 from;
		public UnityEngine.Vector2 to;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Angle(from,to);
			yield break;
		}

	}

	[Automation( "Vector 2/Distance" )]
	class Vector2Distance10 : Automation {

		public UnityEngine.Vector2 a;
		public UnityEngine.Vector2 b;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Distance(a,b);
			yield break;
		}

	}

	[Automation( "Vector 2/Clamp Magnitude" )]
	class Vector2ClampMagnitude11 : Automation {

		public UnityEngine.Vector2 vector;
		public System.Single maxLength;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.ClampMagnitude(vector,maxLength);
			yield break;
		}

	}

	[Automation( "Vector 2/Sqr Magnitude" )]
	class Vector2SqrMagnitude13 : Automation {

		public UnityEngine.Vector2 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.SqrMagnitude();
			yield break;
		}

	}

	[Automation( "Vector 2/Min" )]
	class Vector2Min14 : Automation {

		public UnityEngine.Vector2 lhs;
		public UnityEngine.Vector2 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Min(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 2/Max" )]
	class Vector2Max15 : Automation {

		public UnityEngine.Vector2 lhs;
		public UnityEngine.Vector2 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.Max(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 2/Smooth Damp" )]
	class Vector2SmoothDamp18 : Automation {

		public UnityEngine.Vector2 current;
		public UnityEngine.Vector2 target;
		public UnityEngine.Vector2 currentVelocity;
		public System.Single smoothTime;
		public System.Single maxSpeed;
		public System.Single deltaTime;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector2.SmoothDamp(current,target,ref currentVelocity,smoothTime,maxSpeed,deltaTime);
			yield break;
		}

	}


#pragma warning restore 0649
}
