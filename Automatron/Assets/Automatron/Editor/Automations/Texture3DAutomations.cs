#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Texture 3D/Get Depth" )]
	class Texture3DdepthGet0 : Automation {

		public UnityEngine.Texture3D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.depth;
			yield break;
		}

	}

	[Automation( "Texture 3D/Get Format" )]
	class Texture3DformatGet1 : Automation {

		public UnityEngine.Texture3D Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.TextureFormat Result;

		public override IEnumerator Execute() {
			Result = Instance.format;
			yield break;
		}

	}

	[Automation( "Texture 3D/Get Pixels" )]
	class Texture3DGetPixels0 : Automation {

		public UnityEngine.Texture3D Instance;
		public System.Int32 miplevel;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPixels(miplevel);
			yield break;
		}

	}

	[Automation( "Texture 3D/Get Pixels 32" )]
	class Texture3DGetPixels321 : Automation {

		public UnityEngine.Texture3D Instance;
		public System.Int32 miplevel;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color32[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPixels32(miplevel);
			yield break;
		}

	}

	[Automation( "Texture 3D/Set Pixels" )]
	class Texture3DSetPixels2 : Automation {

		public UnityEngine.Texture3D Instance;
		public UnityEngine.Color[] colors;
		public System.Int32 miplevel;

		public override IEnumerator Execute() {
			Instance.SetPixels(colors,miplevel);
			yield break;
		}

	}

	[Automation( "Texture 3D/Set Pixels 32" )]
	class Texture3DSetPixels323 : Automation {

		public UnityEngine.Texture3D Instance;
		public UnityEngine.Color32[] colors;
		public System.Int32 miplevel;

		public override IEnumerator Execute() {
			Instance.SetPixels32(colors,miplevel);
			yield break;
		}

	}

	[Automation( "Texture 3D/Apply" )]
	class Texture3DApply4 : Automation {

		public UnityEngine.Texture3D Instance;
		public System.Boolean updateMipmaps;
		public System.Boolean makeNoLongerReadable;

		public override IEnumerator Execute() {
			Instance.Apply(updateMipmaps,makeNoLongerReadable);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif