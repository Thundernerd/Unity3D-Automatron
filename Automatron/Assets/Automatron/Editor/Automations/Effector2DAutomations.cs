#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Effector 2D/Get Use Collider Mask" )]
	class Effector2DuseColliderMaskGet0 : ConditionalAutomation {

		public UnityEngine.Effector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useColliderMask;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Effector 2D/Set Use Collider Mask" )]
	class Effector2DuseColliderMaskSet0 : Automation {

		public UnityEngine.Effector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useColliderMask = Value;
			yield break;
		}

	}

	[Automation( "Effector 2D/Get Collider Mask" )]
	class Effector2DcolliderMaskGet1 : Automation {

		public UnityEngine.Effector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.colliderMask;
			yield break;
		}

	}

	[Automation( "Effector 2D/Set Collider Mask" )]
	class Effector2DcolliderMaskSet1 : Automation {

		public UnityEngine.Effector2D Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.colliderMask = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif