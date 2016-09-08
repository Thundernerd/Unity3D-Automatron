using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Particle Animator/Get Does Animate Color" )]
	class ParticleAnimatordoesAnimateColorGet0 : ConditionalAutomation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.doesAnimateColor;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle Animator/Set Does Animate Color" )]
	class ParticleAnimatordoesAnimateColorSet0 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.doesAnimateColor = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get World Rotation Axis" )]
	class ParticleAnimatorworldRotationAxisGet1 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldRotationAxis;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set World Rotation Axis" )]
	class ParticleAnimatorworldRotationAxisSet1 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.worldRotationAxis = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Local Rotation Axis" )]
	class ParticleAnimatorlocalRotationAxisGet2 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.localRotationAxis;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set Local Rotation Axis" )]
	class ParticleAnimatorlocalRotationAxisSet2 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.localRotationAxis = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Size Grow" )]
	class ParticleAnimatorsizeGrowGet3 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sizeGrow;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set Size Grow" )]
	class ParticleAnimatorsizeGrowSet3 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.sizeGrow = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Rnd Force" )]
	class ParticleAnimatorrndForceGet4 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.rndForce;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set Rnd Force" )]
	class ParticleAnimatorrndForceSet4 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.rndForce = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Force" )]
	class ParticleAnimatorforceGet5 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.force;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set Force" )]
	class ParticleAnimatorforceSet5 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.force = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Damping" )]
	class ParticleAnimatordampingGet6 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.damping;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set Damping" )]
	class ParticleAnimatordampingSet6 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.damping = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Autodestruct" )]
	class ParticleAnimatorautodestructGet7 : ConditionalAutomation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.autodestruct;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle Animator/Set Autodestruct" )]
	class ParticleAnimatorautodestructSet7 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.autodestruct = Value;
			yield break;
		}

	}

	[Automation( "Particle Animator/Get Color Animation" )]
	class ParticleAnimatorcolorAnimationGet8 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		[ReadOnly]
		public UnityEngine.Color[] Result;

		public override IEnumerator Execute() {
			Result = Instance.colorAnimation;
			yield break;
		}

	}

	[Automation( "Particle Animator/Set Color Animation" )]
	class ParticleAnimatorcolorAnimationSet8 : Automation {

		public UnityEngine.ParticleAnimator Instance;
		public UnityEngine.Color[] Value;

		public override IEnumerator Execute() {
			Instance.colorAnimation = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
