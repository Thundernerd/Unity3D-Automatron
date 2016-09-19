#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Platform Effector 2D/Get Use One Way" )]
	class PlatformEffector2DuseOneWayGet0 : ConditionalAutomation {

		public UnityEngine.PlatformEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useOneWay;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Platform Effector 2D/Set Use One Way" )]
	class PlatformEffector2DuseOneWaySet0 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useOneWay = Value;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Get Use One Way Grouping" )]
	class PlatformEffector2DuseOneWayGroupingGet1 : ConditionalAutomation {

		public UnityEngine.PlatformEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useOneWayGrouping;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Platform Effector 2D/Set Use One Way Grouping" )]
	class PlatformEffector2DuseOneWayGroupingSet1 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useOneWayGrouping = Value;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Get Use Side Friction" )]
	class PlatformEffector2DuseSideFrictionGet2 : ConditionalAutomation {

		public UnityEngine.PlatformEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useSideFriction;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Platform Effector 2D/Set Use Side Friction" )]
	class PlatformEffector2DuseSideFrictionSet2 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useSideFriction = Value;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Get Use Side Bounce" )]
	class PlatformEffector2DuseSideBounceGet3 : ConditionalAutomation {

		public UnityEngine.PlatformEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useSideBounce;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Platform Effector 2D/Set Use Side Bounce" )]
	class PlatformEffector2DuseSideBounceSet3 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useSideBounce = Value;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Get Surface Arc" )]
	class PlatformEffector2DsurfaceArcGet4 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.surfaceArc;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Set Surface Arc" )]
	class PlatformEffector2DsurfaceArcSet4 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.surfaceArc = Value;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Get Side Arc" )]
	class PlatformEffector2DsideArcGet5 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sideArc;
			yield break;
		}

	}

	[Automation( "Platform Effector 2D/Set Side Arc" )]
	class PlatformEffector2DsideArcSet5 : Automation {

		public UnityEngine.PlatformEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.sideArc = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif