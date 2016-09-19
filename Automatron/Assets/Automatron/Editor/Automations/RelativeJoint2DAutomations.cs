#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Relative Joint 2D/Get Max Force" )]
	class RelativeJoint2DmaxForceGet0 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxForce;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Set Max Force" )]
	class RelativeJoint2DmaxForceSet0 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxForce = Value;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Get Max Torque" )]
	class RelativeJoint2DmaxTorqueGet1 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxTorque;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Set Max Torque" )]
	class RelativeJoint2DmaxTorqueSet1 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxTorque = Value;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Get Correction Scale" )]
	class RelativeJoint2DcorrectionScaleGet2 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.correctionScale;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Set Correction Scale" )]
	class RelativeJoint2DcorrectionScaleSet2 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.correctionScale = Value;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Get Auto Configure Offset" )]
	class RelativeJoint2DautoConfigureOffsetGet3 : ConditionalAutomation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.autoConfigureOffset;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Relative Joint 2D/Set Auto Configure Offset" )]
	class RelativeJoint2DautoConfigureOffsetSet3 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autoConfigureOffset = Value;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Get Linear Offset" )]
	class RelativeJoint2DlinearOffsetGet4 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.linearOffset;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Set Linear Offset" )]
	class RelativeJoint2DlinearOffsetSet4 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.linearOffset = Value;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Get Angular Offset" )]
	class RelativeJoint2DangularOffsetGet5 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularOffset;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Set Angular Offset" )]
	class RelativeJoint2DangularOffsetSet5 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularOffset = Value;
			yield break;
		}

	}

	[Automation( "Relative Joint 2D/Get Target" )]
	class RelativeJoint2DtargetGet6 : Automation {

		public UnityEngine.RelativeJoint2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.target;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif