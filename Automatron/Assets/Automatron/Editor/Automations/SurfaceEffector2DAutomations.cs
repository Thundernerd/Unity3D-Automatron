using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Surface Effector 2D/Get Speed" )]
	class SurfaceEffector2DspeedGet0 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.speed;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Set Speed" )]
	class SurfaceEffector2DspeedSet0 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.speed = Value;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Get Speed Variation" )]
	class SurfaceEffector2DspeedVariationGet1 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.speedVariation;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Set Speed Variation" )]
	class SurfaceEffector2DspeedVariationSet1 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.speedVariation = Value;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Get Force Scale" )]
	class SurfaceEffector2DforceScaleGet2 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.forceScale;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Set Force Scale" )]
	class SurfaceEffector2DforceScaleSet2 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.forceScale = Value;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Get Use Contact Force" )]
	class SurfaceEffector2DuseContactForceGet3 : ConditionalAutomation {

		public UnityEngine.SurfaceEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useContactForce;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Surface Effector 2D/Set Use Contact Force" )]
	class SurfaceEffector2DuseContactForceSet3 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useContactForce = Value;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Get Use Friction" )]
	class SurfaceEffector2DuseFrictionGet4 : ConditionalAutomation {

		public UnityEngine.SurfaceEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useFriction;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Surface Effector 2D/Set Use Friction" )]
	class SurfaceEffector2DuseFrictionSet4 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useFriction = Value;
			yield break;
		}

	}

	[Automation( "Surface Effector 2D/Get Use Bounce" )]
	class SurfaceEffector2DuseBounceGet5 : ConditionalAutomation {

		public UnityEngine.SurfaceEffector2D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useBounce;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Surface Effector 2D/Set Use Bounce" )]
	class SurfaceEffector2DuseBounceSet5 : Automation {

		public UnityEngine.SurfaceEffector2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useBounce = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
