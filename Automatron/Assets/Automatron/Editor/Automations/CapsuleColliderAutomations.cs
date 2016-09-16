using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Capsule Collider/Get Center" )]
	class CapsuleCollidercenterGet0 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Set Center" )]
	class CapsuleCollidercenterSet0 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Get Radius" )]
	class CapsuleColliderradiusGet1 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Set Radius" )]
	class CapsuleColliderradiusSet1 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Get Height" )]
	class CapsuleColliderheightGet2 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Set Height" )]
	class CapsuleColliderheightSet2 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Get Direction" )]
	class CapsuleColliderdirectionGet3 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.direction;
			yield break;
		}

	}

	[Automation( "Capsule Collider/Set Direction" )]
	class CapsuleColliderdirectionSet3 : Automation {

		public UnityEngine.CapsuleCollider Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.direction = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
