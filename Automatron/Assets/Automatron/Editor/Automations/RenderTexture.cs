using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Render Texture/Get Temporary" )]
	class RenderTextureGetTemporary0 : Automation {

		public System.Int32 width;
		public System.Int32 height;
		public System.Int32 depthBuffer;
		public UnityEngine.RenderTextureFormat format;
		public UnityEngine.RenderTextureReadWrite readWrite;
		public System.Int32 antiAliasing;
		[ReadOnly]
		public UnityEngine.RenderTexture Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RenderTexture.GetTemporary(width,height,depthBuffer,format,readWrite,antiAliasing);
			yield break;
		}

	}

	[Automation( "Render Texture/Release Temporary" )]
	class RenderTextureReleaseTemporary5 : Automation {

		public UnityEngine.RenderTexture temp;

		public override IEnumerator Execute() {
			UnityEngine.RenderTexture.ReleaseTemporary(temp);
			yield break;
		}

	}

	[Automation( "Render Texture/Supports Stencil" )]
	class RenderTextureSupportsStencil6 : Automation {

		public UnityEngine.RenderTexture rt;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RenderTexture.SupportsStencil(rt);
			yield break;
		}

	}


#pragma warning restore 0649
}
