#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Area Effector 2D/Get Force Angle" )]
	class AreaEffector2DforceAngleGet0 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceAngle;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Set Force Angle" )]
	class AreaEffector2DforceAngleSet0 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceAngle = Value;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Get Use Global Angle" )]
	class AreaEffector2DuseGlobalAngleGet1 : ConditionalAutomation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useGlobalAngle;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Area Effector 2D/Set Use Global Angle" )]
	class AreaEffector2DuseGlobalAngleSet1 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useGlobalAngle = Value;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Get Force Magnitude" )]
	class AreaEffector2DforceMagnitudeGet2 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceMagnitude;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Set Force Magnitude" )]
	class AreaEffector2DforceMagnitudeSet2 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceMagnitude = Value;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Get Force Variation" )]
	class AreaEffector2DforceVariationGet3 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceVariation;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Set Force Variation" )]
	class AreaEffector2DforceVariationSet3 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceVariation = Value;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Get Drag" )]
	class AreaEffector2DdragGet4 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.drag;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Set Drag" )]
	class AreaEffector2DdragSet4 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.drag = Value;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Get Angular Drag" )]
	class AreaEffector2DangularDragGet5 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularDrag;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Set Angular Drag" )]
	class AreaEffector2DangularDragSet5 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularDrag = Value;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Get Force Target" )]
	class AreaEffector2DforceTargetGet6 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.EffectorSelection2D Result;

		public override IEnumerator Execute() {
			Result = Instance.forceTarget;
			yield break;
		}

	}

	[Automation( "Area Effector 2D/Set Force Target" )]
	class AreaEffector2DforceTargetSet6 : Automation {

		public UnityEngine.AreaEffector2D Instance;
		public UnityEngine.EffectorSelection2D Value;

		public override IEnumerator Execute() {
			Instance.forceTarget = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif