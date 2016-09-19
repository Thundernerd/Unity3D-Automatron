#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Point Effector 2D/Get Force Magnitude" )]
	class PointEffector2DforceMagnitudeGet0 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceMagnitude;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Force Magnitude" )]
	class PointEffector2DforceMagnitudeSet0 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceMagnitude = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Force Variation" )]
	class PointEffector2DforceVariationGet1 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceVariation;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Force Variation" )]
	class PointEffector2DforceVariationSet1 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceVariation = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Distance Scale" )]
	class PointEffector2DdistanceScaleGet2 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.distanceScale;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Distance Scale" )]
	class PointEffector2DdistanceScaleSet2 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.distanceScale = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Drag" )]
	class PointEffector2DdragGet3 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.drag;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Drag" )]
	class PointEffector2DdragSet3 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.drag = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Angular Drag" )]
	class PointEffector2DangularDragGet4 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularDrag;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Angular Drag" )]
	class PointEffector2DangularDragSet4 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularDrag = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Force Source" )]
	class PointEffector2DforceSourceGet5 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.EffectorSelection2D Result;

		public override IEnumerator Execute() {
			Result = Instance.forceSource;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Force Source" )]
	class PointEffector2DforceSourceSet5 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public UnityEngine.EffectorSelection2D Value;

		public override IEnumerator Execute() {
			Instance.forceSource = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Force Target" )]
	class PointEffector2DforceTargetGet6 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.EffectorSelection2D Result;

		public override IEnumerator Execute() {
			Result = Instance.forceTarget;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Force Target" )]
	class PointEffector2DforceTargetSet6 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public UnityEngine.EffectorSelection2D Value;

		public override IEnumerator Execute() {
			Instance.forceTarget = Value;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Get Force Mode" )]
	class PointEffector2DforceModeGet7 : Automation {

		public UnityEngine.PointEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.EffectorForceMode2D Result;

		public override IEnumerator Execute() {
			Result = Instance.forceMode;
			yield break;
		}

	}

	[Automation( "Point Effector 2D/Set Force Mode" )]
	class PointEffector2DforceModeSet7 : Automation {

		public UnityEngine.PointEffector2D Instance;
		public UnityEngine.EffectorForceMode2D Value;

		public override IEnumerator Execute() {
			Instance.forceMode = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif