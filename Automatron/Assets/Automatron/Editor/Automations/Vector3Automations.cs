#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Vector 3/Get Epsilon" )]
	class Vector3kEpsilonGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.kEpsilon;
			yield break;
		}

	}

	[Automation( "Vector 3/Get X" )]
	class Vector3xGet1 : Automation {

		public UnityEngine.Vector3 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.x;
			yield break;
		}

	}

	[Automation( "Vector 3/Set X" )]
	class Vector3xSet1 : Automation {

		public UnityEngine.Vector3 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.x = Value;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Y" )]
	class Vector3yGet2 : Automation {

		public UnityEngine.Vector3 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.y;
			yield break;
		}

	}

	[Automation( "Vector 3/Set Y" )]
	class Vector3ySet2 : Automation {

		public UnityEngine.Vector3 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.y = Value;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Z" )]
	class Vector3zGet3 : Automation {

		public UnityEngine.Vector3 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.z;
			yield break;
		}

	}

	[Automation( "Vector 3/Set Z" )]
	class Vector3zSet3 : Automation {

		public UnityEngine.Vector3 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.z = Value;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Normalized" )]
	class Vector3normalizedGet1 : Automation {

		public UnityEngine.Vector3 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.normalized;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Magnitude" )]
	class Vector3magnitudeGet2 : Automation {

		public UnityEngine.Vector3 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.magnitude;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Sqr Magnitude" )]
	class Vector3sqrMagnitudeGet3 : Automation {

		public UnityEngine.Vector3 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sqrMagnitude;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Zero" )]
	class Vector3zeroGet4 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.zero;
			yield break;
		}

	}

	[Automation( "Vector 3/Get One" )]
	class Vector3oneGet5 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.one;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Forward" )]
	class Vector3forwardGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.forward;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Back" )]
	class Vector3backGet7 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.back;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Up" )]
	class Vector3upGet8 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.up;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Down" )]
	class Vector3downGet9 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.down;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Left" )]
	class Vector3leftGet10 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.left;
			yield break;
		}

	}

	[Automation( "Vector 3/Get Right" )]
	class Vector3rightGet11 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.right;
			yield break;
		}

	}

	[Automation( "Vector 3/Lerp" )]
	class Vector3Lerp0 : Automation {

		public UnityEngine.Vector3 a;
		public UnityEngine.Vector3 b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 3/Lerp Unclamped" )]
	class Vector3LerpUnclamped1 : Automation {

		public UnityEngine.Vector3 a;
		public UnityEngine.Vector3 b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 3/Slerp" )]
	class Vector3Slerp2 : Automation {

		public UnityEngine.Vector3 a;
		public UnityEngine.Vector3 b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Slerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 3/Slerp Unclamped" )]
	class Vector3SlerpUnclamped3 : Automation {

		public UnityEngine.Vector3 a;
		public UnityEngine.Vector3 b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.SlerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 3/Ortho Normalize" )]
	class Vector3OrthoNormalize4 : Automation {

		public UnityEngine.Vector3 normal;
		public UnityEngine.Vector3 tangent;
		public UnityEngine.Vector3 binormal;

		public override IEnumerator Execute() {
			UnityEngine.Vector3.OrthoNormalize(ref normal,ref tangent,ref binormal);
			yield break;
		}

	}

	[Automation( "Vector 3/Move Towards" )]
	class Vector3MoveTowards5 : Automation {

		public UnityEngine.Vector3 current;
		public UnityEngine.Vector3 target;
		public System.Single maxDistanceDelta;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.MoveTowards(current,target,maxDistanceDelta);
			yield break;
		}

	}

	[Automation( "Vector 3/Rotate Towards" )]
	class Vector3RotateTowards6 : Automation {

		public UnityEngine.Vector3 current;
		public UnityEngine.Vector3 target;
		public System.Single maxRadiansDelta;
		public System.Single maxMagnitudeDelta;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.RotateTowards(current,target,maxRadiansDelta,maxMagnitudeDelta);
			yield break;
		}

	}

	[Automation( "Vector 3/Smooth Damp" )]
	class Vector3SmoothDamp7 : Automation {

		public UnityEngine.Vector3 current;
		public UnityEngine.Vector3 target;
		public UnityEngine.Vector3 currentVelocity;
		public System.Single smoothTime;
		public System.Single maxSpeed;
		public System.Single deltaTime;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.SmoothDamp(current,target,ref currentVelocity,smoothTime,maxSpeed,deltaTime);
			yield break;
		}

	}

	[Automation( "Vector 3/Scale" )]
	class Vector3Scale8 : Automation {

		public UnityEngine.Vector3 Instance;
		public UnityEngine.Vector3 scale;

		public override IEnumerator Execute() {
			Instance.Scale(scale);
			yield break;
		}

	}

	[Automation( "Vector 3/Cross" )]
	class Vector3Cross9 : Automation {

		public UnityEngine.Vector3 lhs;
		public UnityEngine.Vector3 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Cross(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 3/Equals" )]
	class Vector3Equals10 : ConditionalAutomation {

		public UnityEngine.Vector3 Instance;
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

	[Automation( "Vector 3/Reflect" )]
	class Vector3Reflect11 : Automation {

		public UnityEngine.Vector3 inDirection;
		public UnityEngine.Vector3 inNormal;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Reflect(inDirection,inNormal);
			yield break;
		}

	}

	[Automation( "Vector 3/Normalize" )]
	class Vector3Normalize12 : Automation {

		public UnityEngine.Vector3 instance;

		public override IEnumerator Execute() {
            instance.Normalize();
			yield break;
		}

	}

	[Automation( "Vector 3/Dot" )]
	class Vector3Dot14 : Automation {

		public UnityEngine.Vector3 lhs;
		public UnityEngine.Vector3 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Dot(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 3/Project" )]
	class Vector3Project15 : Automation {

		public UnityEngine.Vector3 vector;
		public UnityEngine.Vector3 onNormal;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Project(vector,onNormal);
			yield break;
		}

	}

	[Automation( "Vector 3/Project On Plane" )]
	class Vector3ProjectOnPlane16 : Automation {

		public UnityEngine.Vector3 vector;
		public UnityEngine.Vector3 planeNormal;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.ProjectOnPlane(vector,planeNormal);
			yield break;
		}

	}

	[Automation( "Vector 3/Angle" )]
	class Vector3Angle17 : Automation {

		public UnityEngine.Vector3 from;
		public UnityEngine.Vector3 to;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Angle(from,to);
			yield break;
		}

	}

	[Automation( "Vector 3/Distance" )]
	class Vector3Distance18 : Automation {

		public UnityEngine.Vector3 a;
		public UnityEngine.Vector3 b;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Distance(a,b);
			yield break;
		}

	}

	[Automation( "Vector 3/Clamp Magnitude" )]
	class Vector3ClampMagnitude19 : Automation {

		public UnityEngine.Vector3 vector;
		public System.Single maxLength;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.ClampMagnitude(vector,maxLength);
			yield break;
		}

	}

	[Automation( "Vector 3/Magnitude" )]
	class Vector3Magnitude20 : Automation {

		public UnityEngine.Vector3 a;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Magnitude(a);
			yield break;
		}

	}

	[Automation( "Vector 3/Sqr Magnitude" )]
	class Vector3SqrMagnitude21 : Automation {

		public UnityEngine.Vector3 a;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.SqrMagnitude(a);
			yield break;
		}

	}

	[Automation( "Vector 3/Min" )]
	class Vector3Min22 : Automation {

		public UnityEngine.Vector3 lhs;
		public UnityEngine.Vector3 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Min(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 3/Max" )]
	class Vector3Max23 : Automation {

		public UnityEngine.Vector3 lhs;
		public UnityEngine.Vector3 rhs;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector3.Max(lhs,rhs);
			yield break;
		}

	}

    [Automation( "Vector 3/Create" )]
    class Vector3Create24 : Automation {

        public UnityEngine.Vector3 Value;

        public override IEnumerator Execute() {
            yield break;
        }
    }


#pragma warning restore 0649
}

#endif