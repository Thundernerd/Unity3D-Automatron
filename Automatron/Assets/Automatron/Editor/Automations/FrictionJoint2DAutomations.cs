using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Friction Joint 2D/Get Max Force" )]
	class FrictionJoint2DmaxForceGet0 : Automation {

		public UnityEngine.FrictionJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxForce;
			yield break;
		}

	}

	[Automation( "Friction Joint 2D/Set Max Force" )]
	class FrictionJoint2DmaxForceSet0 : Automation {

		public UnityEngine.FrictionJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxForce = Value;
			yield break;
		}

	}

	[Automation( "Friction Joint 2D/Get Max Torque" )]
	class FrictionJoint2DmaxTorqueGet1 : Automation {

		public UnityEngine.FrictionJoint2D Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxTorque;
			yield break;
		}

	}

	[Automation( "Friction Joint 2D/Set Max Torque" )]
	class FrictionJoint2DmaxTorqueSet1 : Automation {

		public UnityEngine.FrictionJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxTorque = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
