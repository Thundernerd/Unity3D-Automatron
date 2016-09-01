using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Ray 2D/Get Origin" )]
	class Ray2DoriginGet0 : Automation {

		public UnityEngine.Ray2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.origin;
			yield break;
		}

	}

	[Automation( "Ray 2D/Set Origin" )]
	class Ray2DoriginSet0 : Automation {

		public UnityEngine.Ray2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.origin = Value;
			yield break;
		}

	}

	[Automation( "Ray 2D/Get Direction" )]
	class Ray2DdirectionGet1 : Automation {

		public UnityEngine.Ray2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.direction;
			yield break;
		}

	}

	[Automation( "Ray 2D/Set Direction" )]
	class Ray2DdirectionSet1 : Automation {

		public UnityEngine.Ray2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.direction = Value;
			yield break;
		}

	}

	[Automation( "Ray 2D/Get Point" )]
	class Ray2DGetPoint0 : Automation {

		public UnityEngine.Ray2D Instance;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPoint(distance);
			yield break;
		}

	}


#pragma warning restore 0649
}
