using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Matrix 4x4/Get Inverse" )]
	class Matrix4x4inverseGet0 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.inverse;
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Get Transpose" )]
	class Matrix4x4transposeGet1 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = Instance.transpose;
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Get Is Identity" )]
	class Matrix4x4isIdentityGet2 : ConditionalAutomation {

		public UnityEngine.Matrix4x4 Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isIdentity;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Matrix 4x4/Get Determinant" )]
	class Matrix4x4determinantGet3 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.determinant;
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Get Zero" )]
	class Matrix4x4zeroGet4 : Automation {

		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.zero;
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Get Identity" )]
	class Matrix4x4identityGet5 : Automation {

		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.identity;
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Inverse" )]
	class Matrix4x4Inverse0 : Automation {

		public UnityEngine.Matrix4x4 m;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Inverse(m);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Transpose" )]
	class Matrix4x4Transpose1 : Automation {

		public UnityEngine.Matrix4x4 m;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Transpose(m);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Determinant" )]
	class Matrix4x4Determinant2 : Automation {

		public UnityEngine.Matrix4x4 m;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Determinant(m);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Get Column" )]
	class Matrix4x4GetColumn3 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public System.Int32 i;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetColumn(i);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Get Row" )]
	class Matrix4x4GetRow4 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public System.Int32 i;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRow(i);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Set Column" )]
	class Matrix4x4SetColumn5 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public System.Int32 i;
		public UnityEngine.Vector4 v;

		public override IEnumerator Execute() {
			Instance.SetColumn(i,v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Set Row" )]
	class Matrix4x4SetRow6 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public System.Int32 i;
		public UnityEngine.Vector4 v;

		public override IEnumerator Execute() {
			Instance.SetRow(i,v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Multiply Point" )]
	class Matrix4x4MultiplyPoint7 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public UnityEngine.Vector3 v;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.MultiplyPoint(v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Multiply Point 3x4" )]
	class Matrix4x4MultiplyPoint3x48 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public UnityEngine.Vector3 v;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.MultiplyPoint3x4(v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Multiply Vector" )]
	class Matrix4x4MultiplyVector9 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public UnityEngine.Vector3 v;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.MultiplyVector(v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Scale" )]
	class Matrix4x4Scale10 : Automation {

		public UnityEngine.Vector3 v;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Scale(v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Set TRS" )]
	class Matrix4x4SetTRS11 : Automation {

		public UnityEngine.Matrix4x4 Instance;
		public UnityEngine.Vector3 pos;
		public UnityEngine.Quaternion q;
		public UnityEngine.Vector3 s;

		public override IEnumerator Execute() {
			Instance.SetTRS(pos,q,s);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/TRS" )]
	class Matrix4x4TRS12 : Automation {

		public UnityEngine.Vector3 pos;
		public UnityEngine.Quaternion q;
		public UnityEngine.Vector3 s;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.TRS(pos,q,s);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Ortho" )]
	class Matrix4x4Ortho13 : Automation {

		public System.Single left;
		public System.Single right;
		public System.Single bottom;
		public System.Single top;
		public System.Single zNear;
		public System.Single zFar;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Ortho(left,right,bottom,top,zNear,zFar);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/Perspective" )]
	class Matrix4x4Perspective14 : Automation {

		public System.Single fov;
		public System.Single aspect;
		public System.Single zNear;
		public System.Single zFar;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Perspective(fov,aspect,zNear,zFar);
			yield break;
		}

	}


#pragma warning restore 0649
}
