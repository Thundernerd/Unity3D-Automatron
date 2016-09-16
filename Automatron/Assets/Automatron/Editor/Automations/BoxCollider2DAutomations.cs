using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Box Collider 2D/Get Size" )]
	class BoxCollider2DsizeGet0 : Automation {

		public UnityEngine.BoxCollider2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Box Collider 2D/Set Size" )]
	class BoxCollider2DsizeSet0 : Automation {

		public UnityEngine.BoxCollider2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
