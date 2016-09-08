using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rendeders/Particle Renderer/Get Particle Render Mode" )]
	class ParticleRendererparticleRenderModeGet0 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public UnityEngine.ParticleRenderMode Result;

		public override IEnumerator Execute() {
			Result = Instance.particleRenderMode;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Particle Render Mode" )]
	class ParticleRendererparticleRenderModeSet0 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public UnityEngine.ParticleRenderMode Value;

		public override IEnumerator Execute() {
			Instance.particleRenderMode = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Length Scale" )]
	class ParticleRendererlengthScaleGet1 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.lengthScale;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Length Scale" )]
	class ParticleRendererlengthScaleSet1 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.lengthScale = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Velocity Scale" )]
	class ParticleRenderervelocityScaleGet2 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.velocityScale;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Velocity Scale" )]
	class ParticleRenderervelocityScaleSet2 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.velocityScale = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Camera Velocity Scale" )]
	class ParticleRenderercameraVelocityScaleGet3 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.cameraVelocityScale;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Camera Velocity Scale" )]
	class ParticleRenderercameraVelocityScaleSet3 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.cameraVelocityScale = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Max Particle Size" )]
	class ParticleRenderermaxParticleSizeGet4 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxParticleSize;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Max Particle Size" )]
	class ParticleRenderermaxParticleSizeSet4 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxParticleSize = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Uv Animation X Tile" )]
	class ParticleRendereruvAnimationXTileGet5 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.uvAnimationXTile;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Uv Animation X Tile" )]
	class ParticleRendereruvAnimationXTileSet5 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.uvAnimationXTile = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Uv Animation Y Tile" )]
	class ParticleRendereruvAnimationYTileGet6 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.uvAnimationYTile;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Uv Animation Y Tile" )]
	class ParticleRendereruvAnimationYTileSet6 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.uvAnimationYTile = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Uv Animation Cycles" )]
	class ParticleRendereruvAnimationCyclesGet7 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.uvAnimationCycles;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Uv Animation Cycles" )]
	class ParticleRendereruvAnimationCyclesSet7 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.uvAnimationCycles = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Max Partile Size" )]
	class ParticleRenderermaxPartileSizeGet8 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxPartileSize;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Max Partile Size" )]
	class ParticleRenderermaxPartileSizeSet8 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxPartileSize = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Get Uv Tiles" )]
	class ParticleRendereruvTilesGet9 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		[ReadOnly]
		public UnityEngine.Rect[] Result;

		public override IEnumerator Execute() {
			Result = Instance.uvTiles;
			yield break;
		}

	}

	[Automation( "Rendeders/Particle Renderer/Set Uv Tiles" )]
	class ParticleRendereruvTilesSet9 : Automation {

		public UnityEngine.ParticleRenderer Instance;
		public UnityEngine.Rect[] Value;

		public override IEnumerator Execute() {
			Instance.uvTiles = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
