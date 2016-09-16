using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Sphere Collider/Get Center" )]
	class SphereCollidercenterGet0 : Automation {

		public UnityEngine.SphereCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Sphere Collider/Set Center" )]
	class SphereCollidercenterSet0 : Automation {

		public UnityEngine.SphereCollider Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Sphere Collider/Get Radius" )]
	class SphereColliderradiusGet1 : Automation {

		public UnityEngine.SphereCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Sphere Collider/Set Radius" )]
	class SphereColliderradiusSet1 : Automation {

		public UnityEngine.SphereCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
