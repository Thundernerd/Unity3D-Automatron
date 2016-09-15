using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Particle System Renderer/Get Render Mode" )]
	class ParticleSystemRendererrenderModeGet0 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystemRenderMode Result;

		public override IEnumerator Execute() {
			Result = Instance.renderMode;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Render Mode" )]
	class ParticleSystemRendererrenderModeSet0 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.ParticleSystemRenderMode Value;

		public override IEnumerator Execute() {
			Instance.renderMode = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Length Scale" )]
	class ParticleSystemRendererlengthScaleGet1 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.lengthScale;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Length Scale" )]
	class ParticleSystemRendererlengthScaleSet1 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.lengthScale = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Velocity Scale" )]
	class ParticleSystemRenderervelocityScaleGet2 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.velocityScale;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Velocity Scale" )]
	class ParticleSystemRenderervelocityScaleSet2 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.velocityScale = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Camera Velocity Scale" )]
	class ParticleSystemRenderercameraVelocityScaleGet3 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.cameraVelocityScale;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Camera Velocity Scale" )]
	class ParticleSystemRenderercameraVelocityScaleSet3 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.cameraVelocityScale = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Normal Direction" )]
	class ParticleSystemRenderernormalDirectionGet4 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.normalDirection;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Normal Direction" )]
	class ParticleSystemRenderernormalDirectionSet4 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.normalDirection = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Alignment" )]
	class ParticleSystemRendereralignmentGet5 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystemRenderSpace Result;

		public override IEnumerator Execute() {
			Result = Instance.alignment;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Alignment" )]
	class ParticleSystemRendereralignmentSet5 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.ParticleSystemRenderSpace Value;

		public override IEnumerator Execute() {
			Instance.alignment = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Pivot" )]
	class ParticleSystemRendererpivotGet6 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.pivot;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Pivot" )]
	class ParticleSystemRendererpivotSet6 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.pivot = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Sort Mode" )]
	class ParticleSystemRenderersortModeGet7 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public UnityEngine.ParticleSystemSortMode Result;

		public override IEnumerator Execute() {
			Result = Instance.sortMode;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Sort Mode" )]
	class ParticleSystemRenderersortModeSet7 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.ParticleSystemSortMode Value;

		public override IEnumerator Execute() {
			Instance.sortMode = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Sorting Fudge" )]
	class ParticleSystemRenderersortingFudgeGet8 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingFudge;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Sorting Fudge" )]
	class ParticleSystemRenderersortingFudgeSet8 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.sortingFudge = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Min Particle Size" )]
	class ParticleSystemRendererminParticleSizeGet9 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.minParticleSize;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Min Particle Size" )]
	class ParticleSystemRendererminParticleSizeSet9 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.minParticleSize = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Max Particle Size" )]
	class ParticleSystemRenderermaxParticleSizeGet10 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.maxParticleSize;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Max Particle Size" )]
	class ParticleSystemRenderermaxParticleSizeSet10 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.maxParticleSize = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Mesh" )]
	class ParticleSystemRenderermeshGet11 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public UnityEngine.Mesh Result;

		public override IEnumerator Execute() {
			Result = Instance.mesh;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Mesh" )]
	class ParticleSystemRenderermeshSet11 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.Mesh Value;

		public override IEnumerator Execute() {
			Instance.mesh = Value;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Mesh Count" )]
	class ParticleSystemRenderermeshCountGet12 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.meshCount;
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Get Meshes" )]
	class ParticleSystemRendererGetMeshes0 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.Mesh[] meshes;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMeshes(meshes);
			yield break;
		}

	}

	[Automation( "Particle System Renderer/Set Meshes" )]
	class ParticleSystemRendererSetMeshes1 : Automation {

		public UnityEngine.ParticleSystemRenderer Instance;
		public UnityEngine.Mesh[] meshes;
		public System.Int32 size;

		public override IEnumerator Execute() {
			Instance.SetMeshes(meshes,size);
			yield break;
		}

	}


#pragma warning restore 0649
}
