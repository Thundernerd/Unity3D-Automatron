using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Raycast Hit/Get Point" )]
	class RaycastHitpointGet0 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.point;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Set Point" )]
	class RaycastHitpointSet0 : Automation {

		public UnityEngine.RaycastHit Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.point = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Normal" )]
	class RaycastHitnormalGet1 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.normal;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Set Normal" )]
	class RaycastHitnormalSet1 : Automation {

		public UnityEngine.RaycastHit Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.normal = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Barycentric Coordinate" )]
	class RaycastHitbarycentricCoordinateGet2 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.barycentricCoordinate;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Set Barycentric Coordinate" )]
	class RaycastHitbarycentricCoordinateSet2 : Automation {

		public UnityEngine.RaycastHit Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.barycentricCoordinate = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Distance" )]
	class RaycastHitdistanceGet3 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.distance;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Set Distance" )]
	class RaycastHitdistanceSet3 : Automation {

		public UnityEngine.RaycastHit Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.distance = Value;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Triangle Index" )]
	class RaycastHittriangleIndexGet4 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.triangleIndex;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Texture Coord" )]
	class RaycastHittextureCoordGet5 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.textureCoord;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Texture Coord 2" )]
	class RaycastHittextureCoord2Get6 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.textureCoord2;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Lightmap Coord" )]
	class RaycastHitlightmapCoordGet7 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.lightmapCoord;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Collider" )]
	class RaycastHitcolliderGet8 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Collider Result;

		public override IEnumerator Execute() {
			Result = Instance.collider;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Rigidbody" )]
	class RaycastHitrigidbodyGet9 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Rigidbody Result;

		public override IEnumerator Execute() {
			Result = Instance.rigidbody;
			yield break;
		}

	}

	[Automation( "Raycast Hit/Get Transform" )]
	class RaycastHittransformGet10 : Automation {

		public UnityEngine.RaycastHit Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.transform;
			yield break;
		}

	}


#pragma warning restore 0649
}
