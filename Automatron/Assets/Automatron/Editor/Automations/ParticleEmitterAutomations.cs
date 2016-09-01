using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Particle Emitter/Get Emit" )]
	class ParticleEmitteremitGet0 : ConditionalAutomation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.emit;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle Emitter/Set Emit" )]
	class ParticleEmitteremitSet0 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.emit = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Min Size" )]
	class ParticleEmitterminSizeGet1 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minSize;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Min Size" )]
	class ParticleEmitterminSizeSet1 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minSize = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Max Size" )]
	class ParticleEmittermaxSizeGet2 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxSize;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Max Size" )]
	class ParticleEmittermaxSizeSet2 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxSize = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Min Energy" )]
	class ParticleEmitterminEnergyGet3 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minEnergy;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Min Energy" )]
	class ParticleEmitterminEnergySet3 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minEnergy = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Max Energy" )]
	class ParticleEmittermaxEnergyGet4 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxEnergy;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Max Energy" )]
	class ParticleEmittermaxEnergySet4 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxEnergy = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Min Emission" )]
	class ParticleEmitterminEmissionGet5 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minEmission;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Min Emission" )]
	class ParticleEmitterminEmissionSet5 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minEmission = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Max Emission" )]
	class ParticleEmittermaxEmissionGet6 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxEmission;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Max Emission" )]
	class ParticleEmittermaxEmissionSet6 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxEmission = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Emitter Velocity Scale" )]
	class ParticleEmitteremitterVelocityScaleGet7 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.emitterVelocityScale;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Emitter Velocity Scale" )]
	class ParticleEmitteremitterVelocityScaleSet7 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.emitterVelocityScale = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get World Velocity" )]
	class ParticleEmitterworldVelocityGet8 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.worldVelocity;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set World Velocity" )]
	class ParticleEmitterworldVelocitySet8 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.worldVelocity = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Local Velocity" )]
	class ParticleEmitterlocalVelocityGet9 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.localVelocity;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Local Velocity" )]
	class ParticleEmitterlocalVelocitySet9 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.localVelocity = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Rnd Velocity" )]
	class ParticleEmitterrndVelocityGet10 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.rndVelocity;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Rnd Velocity" )]
	class ParticleEmitterrndVelocitySet10 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.rndVelocity = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Use World Space" )]
	class ParticleEmitteruseWorldSpaceGet11 : ConditionalAutomation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.useWorldSpace;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle Emitter/Set Use World Space" )]
	class ParticleEmitteruseWorldSpaceSet11 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useWorldSpace = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Rnd Rotation" )]
	class ParticleEmitterrndRotationGet12 : ConditionalAutomation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.rndRotation;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle Emitter/Set Rnd Rotation" )]
	class ParticleEmitterrndRotationSet12 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.rndRotation = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Angular Velocity" )]
	class ParticleEmitterangularVelocityGet13 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.angularVelocity;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Angular Velocity" )]
	class ParticleEmitterangularVelocitySet13 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.angularVelocity = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Rnd Angular Velocity" )]
	class ParticleEmitterrndAngularVelocityGet14 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.rndAngularVelocity;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Rnd Angular Velocity" )]
	class ParticleEmitterrndAngularVelocitySet14 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.rndAngularVelocity = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Particles" )]
	class ParticleEmitterparticlesGet15 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public UnityEngine.Particle[] Result;

		public override IEnumerator Execute() {
			Result = Instance.particles;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Set Particles" )]
	class ParticleEmitterparticlesSet15 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public UnityEngine.Particle[] Value;

		public override IEnumerator Execute() {
			Instance.particles = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Particle Count" )]
	class ParticleEmitterparticleCountGet16 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.particleCount;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Get Enabled" )]
	class ParticleEmitterenabledGet17 : ConditionalAutomation {

		public UnityEngine.ParticleEmitter Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle Emitter/Set Enabled" )]
	class ParticleEmitterenabledSet17 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Particle Emitter/Clear Particles" )]
	class ParticleEmitterClearParticles0 : Automation {

		public UnityEngine.ParticleEmitter Instance;

		public override IEnumerator Execute() {
			Instance.ClearParticles();
			yield break;
		}

	}

	[Automation( "Particle Emitter/Emit" )]
	class ParticleEmitterEmit1 : Automation {

		public UnityEngine.ParticleEmitter Instance;

		public override IEnumerator Execute() {
			Instance.Emit();
			yield break;
		}

	}

	[Automation( "Particle Emitter/Simulate" )]
	class ParticleEmitterSimulate2 : Automation {

		public UnityEngine.ParticleEmitter Instance;
		public System.Single deltaTime;

		public override IEnumerator Execute() {
			Instance.Simulate(deltaTime);
			yield break;
		}

	}


#pragma warning restore 0649
}
