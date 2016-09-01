using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Raycast Hit 2D/Get Centroid" )]
	class RaycastHit2DcentroidGet0 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.centroid;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Set Centroid" )]
	class RaycastHit2DcentroidSet0 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.centroid = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Point" )]
	class RaycastHit2DpointGet1 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.point;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Set Point" )]
	class RaycastHit2DpointSet1 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.point = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Normal" )]
	class RaycastHit2DnormalGet2 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.normal;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Set Normal" )]
	class RaycastHit2DnormalSet2 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.normal = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Distance" )]
	class RaycastHit2DdistanceGet3 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.distance;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Set Distance" )]
	class RaycastHit2DdistanceSet3 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.distance = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Fraction" )]
	class RaycastHit2DfractionGet4 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.fraction;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Set Fraction" )]
	class RaycastHit2DfractionSet4 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.fraction = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Collider" )]
	class RaycastHit2DcolliderGet5 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public UnityEngine.Collider2D Result;

		public override IEnumerator Execute() {
			Result = Instance.collider;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Rigidbody" )]
	class RaycastHit2DrigidbodyGet6 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public UnityEngine.Rigidbody2D Result;

		public override IEnumerator Execute() {
			Result = Instance.rigidbody;
			yield break;
		}

	}

	[Automation( "Raycast Hit 2D/Get Transform" )]
	class RaycastHit2DtransformGet7 : Automation {

		public UnityEngine.RaycastHit2D Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.transform;
			yield break;
		}

	}


#pragma warning restore 0649
}
