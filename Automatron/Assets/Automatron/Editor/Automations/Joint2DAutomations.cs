using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Joint 2D/Get Connected Body" )]
	class Joint2DconnectedBodyGet0 : Automation {

		public UnityEngine.Joint2D Instance;
		[ReadOnly]
		public UnityEngine.Rigidbody2D Result;

		public override IEnumerator Execute() {
			Result = Instance.connectedBody;
			yield break;
		}

	}

	[Automation( "Joint 2D/Set Connected Body" )]
	class Joint2DconnectedBodySet0 : Automation {

		public UnityEngine.Joint2D Instance;
		public UnityEngine.Rigidbody2D Value;

		public override IEnumerator Execute() {
			Instance.connectedBody = Value;
			yield break;
		}

	}

	[Automation( "Joint 2D/Get Enable Collision" )]
	class Joint2DenableCollisionGet1 : ConditionalAutomation {

		public UnityEngine.Joint2D Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableCollision;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Joint 2D/Set Enable Collision" )]
	class Joint2DenableCollisionSet1 : Automation {

		public UnityEngine.Joint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableCollision = Value;
			yield break;
		}

	}

	[Automation( "Joint 2D/Get Break Force" )]
	class Joint2DbreakForceGet2 : Automation {

		public UnityEngine.Joint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.breakForce;
			yield break;
		}

	}

	[Automation( "Joint 2D/Set Break Force" )]
	class Joint2DbreakForceSet2 : Automation {

		public UnityEngine.Joint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.breakForce = Value;
			yield break;
		}

	}

	[Automation( "Joint 2D/Get Break Torque" )]
	class Joint2DbreakTorqueGet3 : Automation {

		public UnityEngine.Joint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.breakTorque;
			yield break;
		}

	}

	[Automation( "Joint 2D/Set Break Torque" )]
	class Joint2DbreakTorqueSet3 : Automation {

		public UnityEngine.Joint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.breakTorque = Value;
			yield break;
		}

	}

	[Automation( "Joint 2D/Get Reaction Force" )]
	class Joint2DreactionForceGet4 : Automation {

		public UnityEngine.Joint2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.reactionForce;
			yield break;
		}

	}

	[Automation( "Joint 2D/Get Reaction Torque" )]
	class Joint2DreactionTorqueGet5 : Automation {

		public UnityEngine.Joint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.reactionTorque;
			yield break;
		}

	}


#pragma warning restore 0649
}
