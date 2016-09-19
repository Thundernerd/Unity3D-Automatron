#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Render Texture/Get Width" )]
	class RenderTexturewidthGet0 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.width;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Width" )]
	class RenderTexturewidthSet0 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.width = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Height" )]
	class RenderTextureheightGet1 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Height" )]
	class RenderTextureheightSet1 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Depth" )]
	class RenderTexturedepthGet2 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.depth;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Depth" )]
	class RenderTexturedepthSet2 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.depth = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Is Power Of Two" )]
	class RenderTextureisPowerOfTwoGet3 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isPowerOfTwo;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Set Is Power Of Two" )]
	class RenderTextureisPowerOfTwoSet3 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.isPowerOfTwo = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get SRGB" )]
	class RenderTexturesRGBGet4 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.sRGB;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Get Format" )]
	class RenderTextureformatGet5 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderTextureFormat Result;

		public override IEnumerator Execute() {
			Result = Instance.format;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Format" )]
	class RenderTextureformatSet5 : Automation {

		public UnityEngine.RenderTexture Instance;
		public UnityEngine.RenderTextureFormat Value;

		public override IEnumerator Execute() {
			Instance.format = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Use Mip Map" )]
	class RenderTextureuseMipMapGet6 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.useMipMap;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Set Use Mip Map" )]
	class RenderTextureuseMipMapSet6 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.useMipMap = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Generate Mips" )]
	class RenderTexturegenerateMipsGet7 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.generateMips;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Set Generate Mips" )]
	class RenderTexturegenerateMipsSet7 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.generateMips = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Dimension" )]
	class RenderTexturedimensionGet8 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rendering.TextureDimension Result;

		public override IEnumerator Execute() {
			Result = Instance.dimension;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Dimension" )]
	class RenderTexturedimensionSet8 : Automation {

		public UnityEngine.RenderTexture Instance;
		public UnityEngine.Rendering.TextureDimension Value;

		public override IEnumerator Execute() {
			Instance.dimension = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Volume Depth" )]
	class RenderTexturevolumeDepthGet9 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.volumeDepth;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Volume Depth" )]
	class RenderTexturevolumeDepthSet9 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.volumeDepth = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Anti Aliasing" )]
	class RenderTextureantiAliasingGet10 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.antiAliasing;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Anti Aliasing" )]
	class RenderTextureantiAliasingSet10 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.antiAliasing = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Enable Random Write" )]
	class RenderTextureenableRandomWriteGet11 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enableRandomWrite;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Set Enable Random Write" )]
	class RenderTextureenableRandomWriteSet11 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enableRandomWrite = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Color Buffer" )]
	class RenderTexturecolorBufferGet12 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderBuffer Result;

		public override IEnumerator Execute() {
			Result = Instance.colorBuffer;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Depth Buffer" )]
	class RenderTexturedepthBufferGet13 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderBuffer Result;

		public override IEnumerator Execute() {
			Result = Instance.depthBuffer;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Active" )]
	class RenderTextureactiveGet14 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderTexture Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RenderTexture.active;
			yield break;
		}

	}

	[Automation( "Render Texture/Set Active" )]
	class RenderTextureactiveSet14 : Automation {

		public UnityEngine.RenderTexture Value;

		public override IEnumerator Execute() {
			UnityEngine.RenderTexture.active = Value;
			yield break;
		}

	}

	[Automation( "Render Texture/Get Temporary" )]
	class RenderTextureGetTemporary0 : Automation {

		public System.Int32 width;
		public System.Int32 height;
		public System.Int32 depthBuffer;
		public UnityEngine.RenderTextureFormat format;
		public UnityEngine.RenderTextureReadWrite readWrite;
		public System.Int32 antiAliasing;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderTexture Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RenderTexture.GetTemporary(width,height,depthBuffer,format,readWrite,antiAliasing);
			yield break;
		}

	}

	[Automation( "Render Texture/Release Temporary" )]
	class RenderTextureReleaseTemporary1 : Automation {

		public UnityEngine.RenderTexture temp;

		public override IEnumerator Execute() {
			UnityEngine.RenderTexture.ReleaseTemporary(temp);
			yield break;
		}

	}

	[Automation( "Render Texture/Create" )]
	class RenderTextureCreate2 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Create();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Release" )]
	class RenderTextureRelease3 : Automation {

		public UnityEngine.RenderTexture Instance;

		public override IEnumerator Execute() {
			Instance.Release();
			yield break;
		}

	}

	[Automation( "Render Texture/Is Created" )]
	class RenderTextureIsCreated4 : ConditionalAutomation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsCreated();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Render Texture/Discard Contents" )]
	class RenderTextureDiscardContents5 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.Boolean discardColor;
		public System.Boolean discardDepth;

		public override IEnumerator Execute() {
			Instance.DiscardContents(discardColor,discardDepth);
			yield break;
		}

	}

	[Automation( "Render Texture/Mark Restore Expected" )]
	class RenderTextureMarkRestoreExpected6 : Automation {

		public UnityEngine.RenderTexture Instance;

		public override IEnumerator Execute() {
			Instance.MarkRestoreExpected();
			yield break;
		}

	}

	[Automation( "Render Texture/Get Native Depth Buffer Ptr" )]
	class RenderTextureGetNativeDepthBufferPtr7 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IntPtr Result;

		public override IEnumerator Execute() {
			Result = Instance.GetNativeDepthBufferPtr();
			yield break;
		}

	}

	[Automation( "Render Texture/Set Global Shader Property" )]
	class RenderTextureSetGlobalShaderProperty8 : Automation {

		public UnityEngine.RenderTexture Instance;
		public System.String propertyName;

		public override IEnumerator Execute() {
			Instance.SetGlobalShaderProperty(propertyName);
			yield break;
		}

	}

	[Automation( "Render Texture/Get Texel Offset" )]
	class RenderTextureGetTexelOffset9 : Automation {

		public UnityEngine.RenderTexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.GetTexelOffset();
			yield break;
		}

	}

	[Automation( "Render Texture/Supports Stencil" )]
	class RenderTextureSupportsStencil10 : ConditionalAutomation {

		public UnityEngine.RenderTexture rt;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RenderTexture.SupportsStencil(rt);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}

#endif