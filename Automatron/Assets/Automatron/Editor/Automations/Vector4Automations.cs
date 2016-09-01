using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Vector 4/Get X" )]
	class Vector4xGet0 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.x;
			yield break;
		}

	}

	[Automation( "Vector 4/Set X" )]
	class Vector4xSet0 : Automation {

		public UnityEngine.Vector4 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.x = Value;
			yield break;
		}

	}

	[Automation( "Vector 4/Get Y" )]
	class Vector4yGet1 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.y;
			yield break;
		}

	}

	[Automation( "Vector 4/Set Y" )]
	class Vector4ySet1 : Automation {

		public UnityEngine.Vector4 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.y = Value;
			yield break;
		}

	}

	[Automation( "Vector 4/Get Z" )]
	class Vector4zGet2 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.z;
			yield break;
		}

	}

	[Automation( "Vector 4/Set Z" )]
	class Vector4zSet2 : Automation {

		public UnityEngine.Vector4 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.z = Value;
			yield break;
		}

	}

	[Automation( "Vector 4/Get W" )]
	class Vector4wGet3 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.w;
			yield break;
		}

	}

	[Automation( "Vector 4/Set W" )]
	class Vector4wSet3 : Automation {

		public UnityEngine.Vector4 Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.w = Value;
			yield break;
		}

	}

	[Automation( "Vector 4/Get Normalized" )]
	class Vector4normalizedGet0 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.normalized;
			yield break;
		}

	}

	[Automation( "Vector 4/Get Magnitude" )]
	class Vector4magnitudeGet1 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.magnitude;
			yield break;
		}

	}

	[Automation( "Vector 4/Get Sqr Magnitude" )]
	class Vector4sqrMagnitudeGet2 : Automation {

		public UnityEngine.Vector4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sqrMagnitude;
			yield break;
		}

	}

	[Automation( "Vector 4/Get Zero" )]
	class Vector4zeroGet3 : Automation {

		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.zero;
			yield break;
		}

	}

	[Automation( "Vector 4/Get One" )]
	class Vector4oneGet4 : Automation {

		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.one;
			yield break;
		}

	}

	[Automation( "Vector 4/Lerp" )]
	class Vector4Lerp0 : Automation {

		public UnityEngine.Vector4 a;
		public UnityEngine.Vector4 b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 4/Lerp Unclamped" )]
	class Vector4LerpUnclamped1 : Automation {

		public UnityEngine.Vector4 a;
		public UnityEngine.Vector4 b;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.LerpUnclamped(a,b,t);
			yield break;
		}

	}

	[Automation( "Vector 4/Move Towards" )]
	class Vector4MoveTowards2 : Automation {

		public UnityEngine.Vector4 current;
		public UnityEngine.Vector4 target;
		public System.Single maxDistanceDelta;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.MoveTowards(current,target,maxDistanceDelta);
			yield break;
		}

	}

	[Automation( "Vector 4/Scale" )]
	class Vector4Scale3 : Automation {

		public UnityEngine.Vector4 a;
		public UnityEngine.Vector4 b;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Scale(a,b);
			yield break;
		}

	}

	[Automation( "Vector 4/Normalize" )]
	class Vector4Normalize4 : Automation {

		public UnityEngine.Vector4 a;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Normalize(a);
			yield break;
		}

	}

	[Automation( "Vector 4/Dot" )]
	class Vector4Dot5 : Automation {

		public UnityEngine.Vector4 a;
		public UnityEngine.Vector4 b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Dot(a,b);
			yield break;
		}

	}

	[Automation( "Vector 4/Project" )]
	class Vector4Project6 : Automation {

		public UnityEngine.Vector4 a;
		public UnityEngine.Vector4 b;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Project(a,b);
			yield break;
		}

	}

	[Automation( "Vector 4/Distance" )]
	class Vector4Distance7 : Automation {

		public UnityEngine.Vector4 a;
		public UnityEngine.Vector4 b;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Distance(a,b);
			yield break;
		}

	}

	[Automation( "Vector 4/Magnitude" )]
	class Vector4Magnitude8 : Automation {

		public UnityEngine.Vector4 a;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Magnitude(a);
			yield break;
		}

	}

	[Automation( "Vector 4/Sqr Magnitude" )]
	class Vector4SqrMagnitude9 : Automation {

		public UnityEngine.Vector4 a;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.SqrMagnitude(a);
			yield break;
		}

	}

	[Automation( "Vector 4/Min" )]
	class Vector4Min11 : Automation {

		public UnityEngine.Vector4 lhs;
		public UnityEngine.Vector4 rhs;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Min(lhs,rhs);
			yield break;
		}

	}

	[Automation( "Vector 4/Max" )]
	class Vector4Max12 : Automation {

		public UnityEngine.Vector4 lhs;
		public UnityEngine.Vector4 rhs;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Vector4.Max(lhs,rhs);
			yield break;
		}

	}


#pragma warning restore 0649
}
