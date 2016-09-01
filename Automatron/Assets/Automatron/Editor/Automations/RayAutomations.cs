using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Ray/Get Origin" )]
	class RayoriginGet0 : Automation {

		public UnityEngine.Ray Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.origin;
			yield break;
		}

	}

	[Automation( "Ray/Set Origin" )]
	class RayoriginSet0 : Automation {

		public UnityEngine.Ray Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.origin = Value;
			yield break;
		}

	}

	[Automation( "Ray/Get Direction" )]
	class RaydirectionGet1 : Automation {

		public UnityEngine.Ray Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.direction;
			yield break;
		}

	}

	[Automation( "Ray/Set Direction" )]
	class RaydirectionSet1 : Automation {

		public UnityEngine.Ray Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.direction = Value;
			yield break;
		}

	}

	[Automation( "Ray/Get Point" )]
	class RayGetPoint0 : Automation {

		public UnityEngine.Ray Instance;
		public System.Single distance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPoint(distance);
			yield break;
		}

	}


#pragma warning restore 0649
}
