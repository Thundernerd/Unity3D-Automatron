using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Skinned Mesh Renderer/Get Bones" )]
	class SkinnedMeshRendererbonesGet0 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		[ReadOnly]
		public UnityEngine.Transform[] Result;

		public override IEnumerator Execute() {
			Result = Instance.bones;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Set Bones" )]
	class SkinnedMeshRendererbonesSet0 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public UnityEngine.Transform[] Value;

		public override IEnumerator Execute() {
			Instance.bones = Value;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Get Root Bone" )]
	class SkinnedMeshRendererrootBoneGet1 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		[ReadOnly]
		public UnityEngine.Transform Result;

		public override IEnumerator Execute() {
			Result = Instance.rootBone;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Set Root Bone" )]
	class SkinnedMeshRendererrootBoneSet1 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public UnityEngine.Transform Value;

		public override IEnumerator Execute() {
			Instance.rootBone = Value;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Get Quality" )]
	class SkinnedMeshRendererqualityGet2 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		[ReadOnly]
		public UnityEngine.SkinQuality Result;

		public override IEnumerator Execute() {
			Result = Instance.quality;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Set Quality" )]
	class SkinnedMeshRendererqualitySet2 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public UnityEngine.SkinQuality Value;

		public override IEnumerator Execute() {
			Instance.quality = Value;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Get Shared Mesh" )]
	class SkinnedMeshRenderersharedMeshGet3 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		[ReadOnly]
		public UnityEngine.Mesh Result;

		public override IEnumerator Execute() {
			Result = Instance.sharedMesh;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Set Shared Mesh" )]
	class SkinnedMeshRenderersharedMeshSet3 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public UnityEngine.Mesh Value;

		public override IEnumerator Execute() {
			Instance.sharedMesh = Value;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Get Update When Offscreen" )]
	class SkinnedMeshRendererupdateWhenOffscreenGet4 : ConditionalAutomation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.updateWhenOffscreen;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Skinned Mesh Renderer/Set Update When Offscreen" )]
	class SkinnedMeshRendererupdateWhenOffscreenSet4 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.updateWhenOffscreen = Value;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Get Local Bounds" )]
	class SkinnedMeshRendererlocalBoundsGet5 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.localBounds;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Set Local Bounds" )]
	class SkinnedMeshRendererlocalBoundsSet5 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public UnityEngine.Bounds Value;

		public override IEnumerator Execute() {
			Instance.localBounds = Value;
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Bake Mesh" )]
	class SkinnedMeshRendererBakeMesh0 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public UnityEngine.Mesh mesh;

		public override IEnumerator Execute() {
			Instance.BakeMesh(mesh);
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Get Blend Shape Weight" )]
	class SkinnedMeshRendererGetBlendShapeWeight1 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public System.Int32 index;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetBlendShapeWeight(index);
			yield break;
		}

	}

	[Automation( "Skinned Mesh Renderer/Set Blend Shape Weight" )]
	class SkinnedMeshRendererSetBlendShapeWeight2 : Automation {

		public UnityEngine.SkinnedMeshRenderer Instance;
		public System.Int32 index;
		public System.Single value;

		public override IEnumerator Execute() {
			Instance.SetBlendShapeWeight(index,value);
			yield break;
		}

	}


#pragma warning restore 0649
}
