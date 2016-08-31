using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Math/Utilities/Get Quat Length" )]
	class MathUtilsGetQuatLength0 : Automation {

		public UnityEngine.Quaternion q;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.GetQuatLength(q);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Get Quat Conjugate" )]
	class MathUtilsGetQuatConjugate1 : Automation {

		public UnityEngine.Quaternion q;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.GetQuatConjugate(q);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Orthogonalize Matrix" )]
	class MathUtilsOrthogonalizeMatrix2 : Automation {

		public UnityEngine.Matrix4x4 m;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.OrthogonalizeMatrix(m);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Quaternion Normalize" )]
	class MathUtilsQuaternionNormalize3 : Automation {

		public UnityEngine.Quaternion q;

		public override IEnumerator Execute() {
			UnityEditor.MathUtils.QuaternionNormalize(ref q);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Quaternion From Matrix" )]
	class MathUtilsQuaternionFromMatrix4 : Automation {

		public UnityEngine.Matrix4x4 m;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.QuaternionFromMatrix(m);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Get Quat Log" )]
	class MathUtilsGetQuatLog5 : Automation {

		public UnityEngine.Quaternion q;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.GetQuatLog(q);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Get Quat Exp" )]
	class MathUtilsGetQuatExp6 : Automation {

		public UnityEngine.Quaternion q;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.GetQuatExp(q);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Get Quat Squad" )]
	class MathUtilsGetQuatSquad7 : Automation {

		public System.Single t;
		public UnityEngine.Quaternion q0;
		public UnityEngine.Quaternion q1;
		public UnityEngine.Quaternion a0;
		public UnityEngine.Quaternion a1;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.GetQuatSquad(t,q0,q1,a0,a1);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Get Squad Intermediate" )]
	class MathUtilsGetSquadIntermediate8 : Automation {

		public UnityEngine.Quaternion q0;
		public UnityEngine.Quaternion q1;
		public UnityEngine.Quaternion q2;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.GetSquadIntermediate(q0,q1,q2);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Ease" )]
	class MathUtilsEase9 : Automation {

		public System.Single t;
		public System.Single k1;
		public System.Single k2;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.Ease(t,k1,k2);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Slerp" )]
	class MathUtilsSlerp10 : Automation {

		public UnityEngine.Quaternion p;
		public UnityEngine.Quaternion q;
		public System.Single t;
		[ReadOnly]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.Slerp(p,q,t);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Intersect Ray Triangle" )]
	class MathUtilsIntersectRayTriangle11 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.Vector3 v0;
		public UnityEngine.Vector3 v1;
		public UnityEngine.Vector3 v2;
		public System.Boolean bidirectional;
		[ReadOnly]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.IntersectRayTriangle(ray,v0,v1,v2,bidirectional);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Closest Pt Segment Ray" )]
	class MathUtilsClosestPtSegmentRay12 : Automation {

		public UnityEngine.Vector3 p1;
		public UnityEngine.Vector3 q1;
		public UnityEngine.Ray ray;
		public System.Single squaredDist;
		public System.Single s;
		public UnityEngine.Vector3 closestRay;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.ClosestPtSegmentRay(p1,q1,ray,out squaredDist,out s,out closestRay);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Intersect Ray Sphere" )]
	class MathUtilsIntersectRaySphere13 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.Vector3 sphereOrigin;
		public System.Single sphereRadius;
		public System.Single t;
		public UnityEngine.Vector3 q;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.IntersectRaySphere(ray,sphereOrigin,sphereRadius,ref t,ref q);
			yield break;
		}

	}

	[Automation( "Math/Utilities/Closest Pt Ray Sphere" )]
	class MathUtilsClosestPtRaySphere14 : Automation {

		public UnityEngine.Ray ray;
		public UnityEngine.Vector3 sphereOrigin;
		public System.Single sphereRadius;
		public System.Single t;
		public UnityEngine.Vector3 q;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.MathUtils.ClosestPtRaySphere(ray,sphereOrigin,sphereRadius,ref t,ref q);
			yield break;
		}

	}


#pragma warning restore 0649
}
