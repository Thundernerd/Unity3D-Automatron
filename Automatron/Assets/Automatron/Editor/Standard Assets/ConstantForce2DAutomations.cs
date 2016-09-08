using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Constant Force 2D/Get Force" )]
	class ConstantForce2DforceGet0 : Automation {

		public UnityEngine.ConstantForce2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.force;
			yield break;
		}

	}

	[Automation( "Constant Force 2D/Set Force" )]
	class ConstantForce2DforceSet0 : Automation {

		public UnityEngine.ConstantForce2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.force = Value;
			yield break;
		}

	}

	[Automation( "Constant Force 2D/Get Relative Force" )]
	class ConstantForce2DrelativeForceGet1 : Automation {

		public UnityEngine.ConstantForce2D Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.relativeForce;
			yield break;
		}

	}

	[Automation( "Constant Force 2D/Set Relative Force" )]
	class ConstantForce2DrelativeForceSet1 : Automation {

		public UnityEngine.ConstantForce2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.relativeForce = Value;
			yield break;
		}

	}

	[Automation( "Constant Force 2D/Get Torque" )]
	class ConstantForce2DtorqueGet2 : Automation {

		public UnityEngine.ConstantForce2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.torque;
			yield break;
		}

	}

	[Automation( "Constant Force 2D/Set Torque" )]
	class ConstantForce2DtorqueSet2 : Automation {

		public UnityEngine.ConstantForce2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.torque = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
