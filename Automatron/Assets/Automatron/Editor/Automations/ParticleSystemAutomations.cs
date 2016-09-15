using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Particle System/Get Start Delay" )]
	class ParticleSystemstartDelayGet0 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startDelay;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Delay" )]
	class ParticleSystemstartDelaySet0 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startDelay = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Is Playing" )]
	class ParticleSystemisPlayingGet1 : ConditionalAutomation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPlaying;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle System/Get Is Stopped" )]
	class ParticleSystemisStoppedGet2 : ConditionalAutomation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isStopped;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle System/Get Is Paused" )]
	class ParticleSystemisPausedGet3 : ConditionalAutomation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPaused;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle System/Get Loop" )]
	class ParticleSystemloopGet4 : ConditionalAutomation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.loop;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle System/Set Loop" )]
	class ParticleSystemloopSet4 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.loop = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Play On Awake" )]
	class ParticleSystemplayOnAwakeGet5 : ConditionalAutomation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.playOnAwake;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle System/Set Play On Awake" )]
	class ParticleSystemplayOnAwakeSet5 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.playOnAwake = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Time" )]
	class ParticleSystemtimeGet6 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.time;
			yield break;
		}

	}

	[Automation( "Particle System/Set Time" )]
	class ParticleSystemtimeSet6 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.time = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Duration" )]
	class ParticleSystemdurationGet7 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.duration;
			yield break;
		}

	}

	[Automation( "Particle System/Get Playback Speed" )]
	class ParticleSystemplaybackSpeedGet8 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.playbackSpeed;
			yield break;
		}

	}

	[Automation( "Particle System/Set Playback Speed" )]
	class ParticleSystemplaybackSpeedSet8 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.playbackSpeed = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Particle Count" )]
	class ParticleSystemparticleCountGet9 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.particleCount;
			yield break;
		}

	}

	[Automation( "Particle System/Get Start Speed" )]
	class ParticleSystemstartSpeedGet10 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startSpeed;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Speed" )]
	class ParticleSystemstartSpeedSet10 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startSpeed = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Start Size" )]
	class ParticleSystemstartSizeGet11 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startSize;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Size" )]
	class ParticleSystemstartSizeSet11 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startSize = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Start Color" )]
	class ParticleSystemstartColorGet12 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.startColor;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Color" )]
	class ParticleSystemstartColorSet12 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.startColor = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Start Rotation" )]
	class ParticleSystemstartRotationGet13 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startRotation;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Rotation" )]
	class ParticleSystemstartRotationSet13 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startRotation = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Start Rotation 3D" )]
	class ParticleSystemstartRotation3DGet14 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.startRotation3D;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Rotation 3D" )]
	class ParticleSystemstartRotation3DSet14 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.startRotation3D = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Start Lifetime" )]
	class ParticleSystemstartLifetimeGet15 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.startLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Set Start Lifetime" )]
	class ParticleSystemstartLifetimeSet15 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.startLifetime = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Gravity Modifier" )]
	class ParticleSystemgravityModifierGet16 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.gravityModifier;
			yield break;
		}

	}

	[Automation( "Particle System/Set Gravity Modifier" )]
	class ParticleSystemgravityModifierSet16 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.gravityModifier = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Max Particles" )]
	class ParticleSystemmaxParticlesGet17 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.maxParticles;
			yield break;
		}

	}

	[Automation( "Particle System/Set Max Particles" )]
	class ParticleSystemmaxParticlesSet17 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.maxParticles = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Simulation Space" )]
	class ParticleSystemsimulationSpaceGet18 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystemSimulationSpace Result;

		public override IEnumerator Execute() {
			Result = Instance.simulationSpace;
			yield break;
		}

	}

	[Automation( "Particle System/Set Simulation Space" )]
	class ParticleSystemsimulationSpaceSet18 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public UnityEngine.ParticleSystemSimulationSpace Value;

		public override IEnumerator Execute() {
			Instance.simulationSpace = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Scaling Mode" )]
	class ParticleSystemscalingModeGet19 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystemScalingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.scalingMode;
			yield break;
		}

	}

	[Automation( "Particle System/Set Scaling Mode" )]
	class ParticleSystemscalingModeSet19 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public UnityEngine.ParticleSystemScalingMode Value;

		public override IEnumerator Execute() {
			Instance.scalingMode = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Random Seed" )]
	class ParticleSystemrandomSeedGet20 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = Instance.randomSeed;
			yield break;
		}

	}

	[Automation( "Particle System/Set Random Seed" )]
	class ParticleSystemrandomSeedSet20 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.UInt32 Value;

		public override IEnumerator Execute() {
			Instance.randomSeed = Value;
			yield break;
		}

	}

	[Automation( "Particle System/Get Emission" )]
	class ParticleSystememissionGet21 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.EmissionModule Result;

		public override IEnumerator Execute() {
			Result = Instance.emission;
			yield break;
		}

	}

	[Automation( "Particle System/Get Shape" )]
	class ParticleSystemshapeGet22 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.ShapeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.shape;
			yield break;
		}

	}

	[Automation( "Particle System/Get Velocity Over Lifetime" )]
	class ParticleSystemvelocityOverLifetimeGet23 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.VelocityOverLifetimeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.velocityOverLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Get Limit Velocity Over Lifetime" )]
	class ParticleSystemlimitVelocityOverLifetimeGet24 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.limitVelocityOverLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Get Inherit Velocity" )]
	class ParticleSysteminheritVelocityGet25 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.InheritVelocityModule Result;

		public override IEnumerator Execute() {
			Result = Instance.inheritVelocity;
			yield break;
		}

	}

	[Automation( "Particle System/Get Force Over Lifetime" )]
	class ParticleSystemforceOverLifetimeGet26 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.ForceOverLifetimeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.forceOverLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Get Color Over Lifetime" )]
	class ParticleSystemcolorOverLifetimeGet27 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.ColorOverLifetimeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.colorOverLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Get Color By Speed" )]
	class ParticleSystemcolorBySpeedGet28 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.ColorBySpeedModule Result;

		public override IEnumerator Execute() {
			Result = Instance.colorBySpeed;
			yield break;
		}

	}

	[Automation( "Particle System/Get Size Over Lifetime" )]
	class ParticleSystemsizeOverLifetimeGet29 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.SizeOverLifetimeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.sizeOverLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Get Size By Speed" )]
	class ParticleSystemsizeBySpeedGet30 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.SizeBySpeedModule Result;

		public override IEnumerator Execute() {
			Result = Instance.sizeBySpeed;
			yield break;
		}

	}

	[Automation( "Particle System/Get Rotation Over Lifetime" )]
	class ParticleSystemrotationOverLifetimeGet31 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.RotationOverLifetimeModule Result;

		public override IEnumerator Execute() {
			Result = Instance.rotationOverLifetime;
			yield break;
		}

	}

	[Automation( "Particle System/Get Rotation By Speed" )]
	class ParticleSystemrotationBySpeedGet32 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.RotationBySpeedModule Result;

		public override IEnumerator Execute() {
			Result = Instance.rotationBySpeed;
			yield break;
		}

	}

	[Automation( "Particle System/Get External Forces" )]
	class ParticleSystemexternalForcesGet33 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.ExternalForcesModule Result;

		public override IEnumerator Execute() {
			Result = Instance.externalForces;
			yield break;
		}

	}

	[Automation( "Particle System/Get Collision" )]
	class ParticleSystemcollisionGet34 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.CollisionModule Result;

		public override IEnumerator Execute() {
			Result = Instance.collision;
			yield break;
		}

	}

	[Automation( "Particle System/Get Trigger" )]
	class ParticleSystemtriggerGet35 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.TriggerModule Result;

		public override IEnumerator Execute() {
			Result = Instance.trigger;
			yield break;
		}

	}

	[Automation( "Particle System/Get Sub Emitters" )]
	class ParticleSystemsubEmittersGet36 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.SubEmittersModule Result;

		public override IEnumerator Execute() {
			Result = Instance.subEmitters;
			yield break;
		}

	}

	[Automation( "Particle System/Get Texture Sheet Animation" )]
	class ParticleSystemtextureSheetAnimationGet37 : Automation {

		public UnityEngine.ParticleSystem Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystem.TextureSheetAnimationModule Result;

		public override IEnumerator Execute() {
			Result = Instance.textureSheetAnimation;
			yield break;
		}

	}

	[Automation( "Particle System/Set Particles" )]
	class ParticleSystemSetParticles0 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public UnityEngine.ParticleSystem.Particle[] particles;
		public System.Int32 size;

		public override IEnumerator Execute() {
			Instance.SetParticles(particles,size);
			yield break;
		}

	}

	[Automation( "Particle System/Get Particles" )]
	class ParticleSystemGetParticles1 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public UnityEngine.ParticleSystem.Particle[] particles;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetParticles(particles);
			yield break;
		}

	}

	[Automation( "Particle System/Simulate" )]
	class ParticleSystemSimulate2 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Single t;
		public System.Boolean withChildren;
		public System.Boolean restart;
		public System.Boolean fixedTimeStep;

		public override IEnumerator Execute() {
			Instance.Simulate(t,withChildren,restart,fixedTimeStep);
			yield break;
		}

	}

	[Automation( "Particle System/Play" )]
	class ParticleSystemPlay3 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean withChildren;

		public override IEnumerator Execute() {
			Instance.Play(withChildren);
			yield break;
		}

	}

	[Automation( "Particle System/Stop" )]
	class ParticleSystemStop4 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean withChildren;

		public override IEnumerator Execute() {
			Instance.Stop(withChildren);
			yield break;
		}

	}

	[Automation( "Particle System/Pause" )]
	class ParticleSystemPause5 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean withChildren;

		public override IEnumerator Execute() {
			Instance.Pause(withChildren);
			yield break;
		}

	}

	[Automation( "Particle System/Clear" )]
	class ParticleSystemClear6 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean withChildren;

		public override IEnumerator Execute() {
			Instance.Clear(withChildren);
			yield break;
		}

	}

	[Automation( "Particle System/Is Alive" )]
	class ParticleSystemIsAlive7 : ConditionalAutomation {

		public UnityEngine.ParticleSystem Instance;
		public System.Boolean withChildren;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsAlive(withChildren);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Particle System/Emit" )]
	class ParticleSystemEmit8 : Automation {

		public UnityEngine.ParticleSystem Instance;
		public System.Int32 count;

		public override IEnumerator Execute() {
			Instance.Emit(count);
			yield break;
		}

	}


#pragma warning restore 0649
}
