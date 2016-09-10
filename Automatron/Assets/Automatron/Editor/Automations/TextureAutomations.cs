using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Texture/Get Anisotropic Filtering" )]
	class TextureanisotropicFilteringGet0 : Automation {

		[ReadOnly]
		public UnityEngine.AnisotropicFiltering Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Texture.anisotropicFiltering;
			yield break;
		}

	}

	[Automation( "Texture/Set Anisotropic Filtering" )]
	class TextureanisotropicFilteringSet0 : Automation {

		public UnityEngine.AnisotropicFiltering Value;

		public override IEnumerator Execute() {
			UnityEngine.Texture.anisotropicFiltering = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Width" )]
	class TexturewidthGet1 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.width;
			yield break;
		}

	}

	[Automation( "Texture/Set Width" )]
	class TexturewidthSet1 : Automation {

		public UnityEngine.Texture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.width = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Height" )]
	class TextureheightGet2 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Texture/Set Height" )]
	class TextureheightSet2 : Automation {

		public UnityEngine.Texture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Filter Mode" )]
	class TexturefilterModeGet3 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public UnityEngine.FilterMode Result;

		public override IEnumerator Execute() {
			Result = Instance.filterMode;
			yield break;
		}

	}

	[Automation( "Texture/Set Filter Mode" )]
	class TexturefilterModeSet3 : Automation {

		public UnityEngine.Texture Instance;
		public UnityEngine.FilterMode Value;

		public override IEnumerator Execute() {
			Instance.filterMode = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Aniso Level" )]
	class TextureanisoLevelGet4 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.anisoLevel;
			yield break;
		}

	}

	[Automation( "Texture/Set Aniso Level" )]
	class TextureanisoLevelSet4 : Automation {

		public UnityEngine.Texture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.anisoLevel = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Wrap Mode" )]
	class TexturewrapModeGet5 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public UnityEngine.TextureWrapMode Result;

		public override IEnumerator Execute() {
			Result = Instance.wrapMode;
			yield break;
		}

	}

	[Automation( "Texture/Set Wrap Mode" )]
	class TexturewrapModeSet5 : Automation {

		public UnityEngine.Texture Instance;
		public UnityEngine.TextureWrapMode Value;

		public override IEnumerator Execute() {
			Instance.wrapMode = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Mip Map Bias" )]
	class TexturemipMapBiasGet6 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.mipMapBias;
			yield break;
		}

	}

	[Automation( "Texture/Set Mip Map Bias" )]
	class TexturemipMapBiasSet6 : Automation {

		public UnityEngine.Texture Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.mipMapBias = Value;
			yield break;
		}

	}

	[Automation( "Texture/Get Texel Size" )]
	class TexturetexelSizeGet7 : Automation {

		public UnityEngine.Texture Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.texelSize;
			yield break;
		}

	}


#pragma warning restore 0649
}
