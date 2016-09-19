#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Constant Force/Get Force" )]
	class ConstantForceforceGet0 : Automation {

		public UnityEngine.ConstantForce Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.force;
			yield break;
		}

	}

	[Automation( "Constant Force/Set Force" )]
	class ConstantForceforceSet0 : Automation {

		public UnityEngine.ConstantForce Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.force = Value;
			yield break;
		}

	}

	[Automation( "Constant Force/Get Relative Force" )]
	class ConstantForcerelativeForceGet1 : Automation {

		public UnityEngine.ConstantForce Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.relativeForce;
			yield break;
		}

	}

	[Automation( "Constant Force/Set Relative Force" )]
	class ConstantForcerelativeForceSet1 : Automation {

		public UnityEngine.ConstantForce Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.relativeForce = Value;
			yield break;
		}

	}

	[Automation( "Constant Force/Get Torque" )]
	class ConstantForcetorqueGet2 : Automation {

		public UnityEngine.ConstantForce Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.torque;
			yield break;
		}

	}

	[Automation( "Constant Force/Set Torque" )]
	class ConstantForcetorqueSet2 : Automation {

		public UnityEngine.ConstantForce Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.torque = Value;
			yield break;
		}

	}

	[Automation( "Constant Force/Get Relative Torque" )]
	class ConstantForcerelativeTorqueGet3 : Automation {

		public UnityEngine.ConstantForce Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.relativeTorque;
			yield break;
		}

	}

	[Automation( "Constant Force/Set Relative Torque" )]
	class ConstantForcerelativeTorqueSet3 : Automation {

		public UnityEngine.ConstantForce Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.relativeTorque = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif