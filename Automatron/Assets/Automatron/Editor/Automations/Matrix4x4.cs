using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

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

	[Automation( "Matrix 4x4/Scale" )]
	class Matrix4x4Scale3 : Automation {

		public UnityEngine.Vector3 v;
		[ReadOnly]
		public UnityEngine.Matrix4x4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Matrix4x4.Scale(v);
			yield break;
		}

	}

	[Automation( "Matrix 4x4/TRS" )]
	class Matrix4x4TRS4 : Automation {

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
	class Matrix4x4Ortho5 : Automation {

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
	class Matrix4x4Perspective6 : Automation {

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
