using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Joint/Get Connected Body" )]
	class JointconnectedBodyGet0 : Automation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rigidbody Result;

		public override IEnumerator Execute() {
			Result = Instance.connectedBody;
			yield break;
		}

	}

	[Automation( "Joint/Set Connected Body" )]
	class JointconnectedBodySet0 : Automation {

		public UnityEngine.Joint Instance;
		public UnityEngine.Rigidbody Value;

		public override IEnumerator Execute() {
			Instance.connectedBody = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Axis" )]
	class JointaxisGet1 : Automation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.axis;
			yield break;
		}

	}

	[Automation( "Joint/Set Axis" )]
	class JointaxisSet1 : Automation {

		public UnityEngine.Joint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.axis = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Anchor" )]
	class JointanchorGet2 : Automation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchor;
			yield break;
		}

	}

	[Automation( "Joint/Set Anchor" )]
	class JointanchorSet2 : Automation {

		public UnityEngine.Joint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.anchor = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Connected Anchor" )]
	class JointconnectedAnchorGet3 : Automation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.connectedAnchor;
			yield break;
		}

	}

	[Automation( "Joint/Set Connected Anchor" )]
	class JointconnectedAnchorSet3 : Automation {

		public UnityEngine.Joint Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.connectedAnchor = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Auto Configure Connected Anchor" )]
	class JointautoConfigureConnectedAnchorGet4 : ConditionalAutomation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoConfigureConnectedAnchor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Joint/Set Auto Configure Connected Anchor" )]
	class JointautoConfigureConnectedAnchorSet4 : Automation {

		public UnityEngine.Joint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureConnectedAnchor = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Break Force" )]
	class JointbreakForceGet5 : Automation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.breakForce;
			yield break;
		}

	}

	[Automation( "Joint/Set Break Force" )]
	class JointbreakForceSet5 : Automation {

		public UnityEngine.Joint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.breakForce = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Break Torque" )]
	class JointbreakTorqueGet6 : Automation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.breakTorque;
			yield break;
		}

	}

	[Automation( "Joint/Set Break Torque" )]
	class JointbreakTorqueSet6 : Automation {

		public UnityEngine.Joint Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.breakTorque = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Enable Collision" )]
	class JointenableCollisionGet7 : ConditionalAutomation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableCollision;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Joint/Set Enable Collision" )]
	class JointenableCollisionSet7 : Automation {

		public UnityEngine.Joint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableCollision = Value;
			yield break;
		}

	}

	[Automation( "Joint/Get Enable Preprocessing" )]
	class JointenablePreprocessingGet8 : ConditionalAutomation {

		public UnityEngine.Joint Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enablePreprocessing;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Joint/Set Enable Preprocessing" )]
	class JointenablePreprocessingSet8 : Automation {

		public UnityEngine.Joint Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enablePreprocessing = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
