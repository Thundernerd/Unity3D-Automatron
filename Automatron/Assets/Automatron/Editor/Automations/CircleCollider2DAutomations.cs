using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Colliders/Circle Collider 2D/Get Radius" )]
	class CircleCollider2DradiusGet0 : Automation {

		public UnityEngine.CircleCollider2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.radius;
			yield break;
		}

	}

	[Automation( "Colliders/Circle Collider 2D/Set Radius" )]
	class CircleCollider2DradiusSet0 : Automation {

		public UnityEngine.CircleCollider2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.radius = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
