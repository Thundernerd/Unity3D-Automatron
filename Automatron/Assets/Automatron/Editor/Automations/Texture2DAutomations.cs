using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Texture 2D/Get Mipmap Count" )]
	class Texture2DmipmapCountGet0 : Automation {

		public UnityEngine.Texture2D Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.mipmapCount;
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Format" )]
	class Texture2DformatGet1 : Automation {

		public UnityEngine.Texture2D Instance;
		[ReadOnly]
		public UnityEngine.TextureFormat Result;

		public override IEnumerator Execute() {
			Result = Instance.format;
			yield break;
		}

	}

	[Automation( "Texture 2D/Get White Texture" )]
	class Texture2DwhiteTextureGet2 : Automation {

		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Texture2D.whiteTexture;
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Black Texture" )]
	class Texture2DblackTextureGet3 : Automation {

		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Texture2D.blackTexture;
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Alpha Is Transparency" )]
	class Texture2DalphaIsTransparencyGet4 : ConditionalAutomation {

		public UnityEngine.Texture2D Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.alphaIsTransparency;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Texture 2D/Set Alpha Is Transparency" )]
	class Texture2DalphaIsTransparencySet4 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.alphaIsTransparency = Value;
			yield break;
		}

	}

	[Automation( "Texture 2D/Create External Texture" )]
	class Texture2DCreateExternalTexture0 : Automation {

		public System.Int32 width;
		public System.Int32 height;
		public UnityEngine.TextureFormat format;
		public System.Boolean mipmap;
		public System.Boolean linear;
		public System.IntPtr nativeTex;
		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Texture2D.CreateExternalTexture(width,height,format,mipmap,linear,nativeTex);
			yield break;
		}

	}

	[Automation( "Texture 2D/Update External Texture" )]
	class Texture2DUpdateExternalTexture1 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.IntPtr nativeTex;

		public override IEnumerator Execute() {
			Instance.UpdateExternalTexture(nativeTex);
			yield break;
		}

	}

	[Automation( "Texture 2D/Set Pixel" )]
	class Texture2DSetPixel2 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 x;
		public System.Int32 y;
		public UnityEngine.Color color;

		public override IEnumerator Execute() {
			Instance.SetPixel(x,y,color);
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Pixel" )]
	class Texture2DGetPixel3 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 x;
		public System.Int32 y;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPixel(x,y);
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Pixel Bilinear" )]
	class Texture2DGetPixelBilinear4 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Single u;
		public System.Single v;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPixelBilinear(u,v);
			yield break;
		}

	}

	[Automation( "Texture 2D/Set Pixels" )]
	class Texture2DSetPixels5 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 x;
		public System.Int32 y;
		public System.Int32 blockWidth;
		public System.Int32 blockHeight;
		public UnityEngine.Color[] colors;
		public System.Int32 miplevel;

		public override IEnumerator Execute() {
			Instance.SetPixels(x,y,blockWidth,blockHeight,colors,miplevel);
			yield break;
		}

	}

	[Automation( "Texture 2D/Set Pixels 32" )]
	class Texture2DSetPixels326 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 x;
		public System.Int32 y;
		public System.Int32 blockWidth;
		public System.Int32 blockHeight;
		public UnityEngine.Color32[] colors;
		public System.Int32 miplevel;

		public override IEnumerator Execute() {
			Instance.SetPixels32(x,y,blockWidth,blockHeight,colors,miplevel);
			yield break;
		}

	}

	[Automation( "Texture 2D/Load Image" )]
	class Texture2DLoadImage7 : ConditionalAutomation {

		public UnityEngine.Texture2D Instance;
		public System.Byte[] data;
		public System.Boolean markNonReadable;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.LoadImage(data,markNonReadable);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Texture 2D/Load Raw Texture Data" )]
	class Texture2DLoadRawTextureData8 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Byte[] data;

		public override IEnumerator Execute() {
			Instance.LoadRawTextureData(data);
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Raw Texture Data" )]
	class Texture2DGetRawTextureData9 : Automation {

		public UnityEngine.Texture2D Instance;
		[ReadOnly]
		public System.Byte[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRawTextureData();
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Pixels" )]
	class Texture2DGetPixels10 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 x;
		public System.Int32 y;
		public System.Int32 blockWidth;
		public System.Int32 blockHeight;
		public System.Int32 miplevel;
		[ReadOnly]
		public UnityEngine.Color[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPixels(x,y,blockWidth,blockHeight,miplevel);
			yield break;
		}

	}

	[Automation( "Texture 2D/Get Pixels 32" )]
	class Texture2DGetPixels3211 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 miplevel;
		[ReadOnly]
		public UnityEngine.Color32[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPixels32(miplevel);
			yield break;
		}

	}

	[Automation( "Texture 2D/Apply" )]
	class Texture2DApply12 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Boolean updateMipmaps;
		public System.Boolean makeNoLongerReadable;

		public override IEnumerator Execute() {
			Instance.Apply(updateMipmaps,makeNoLongerReadable);
			yield break;
		}

	}

	[Automation( "Texture 2D/Resize" )]
	class Texture2DResize13 : ConditionalAutomation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 width;
		public System.Int32 height;
		public UnityEngine.TextureFormat format;
		public System.Boolean hasMipMap;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Resize(width,height,format,hasMipMap);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Texture 2D/Compress" )]
	class Texture2DCompress14 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Boolean highQuality;

		public override IEnumerator Execute() {
			Instance.Compress(highQuality);
			yield break;
		}

	}

	[Automation( "Texture 2D/Pack Textures" )]
	class Texture2DPackTextures15 : Automation {

		public UnityEngine.Texture2D Instance;
		public UnityEngine.Texture2D[] textures;
		public System.Int32 padding;
		public System.Int32 maximumAtlasSize;
		public System.Boolean makeNoLongerReadable;
		[ReadOnly]
		public UnityEngine.Rect[] Result;

		public override IEnumerator Execute() {
			Result = Instance.PackTextures(textures,padding,maximumAtlasSize,makeNoLongerReadable);
			yield break;
		}

	}

	[Automation( "Texture 2D/Read Pixels" )]
	class Texture2DReadPixels16 : Automation {

		public UnityEngine.Texture2D Instance;
		public UnityEngine.Rect source;
		public System.Int32 destX;
		public System.Int32 destY;
		public System.Boolean recalculateMipMaps;

		public override IEnumerator Execute() {
			Instance.ReadPixels(source,destX,destY,recalculateMipMaps);
			yield break;
		}

	}

	[Automation( "Texture 2D/Encode To PNG" )]
	class Texture2DEncodeToPNG17 : Automation {

		public UnityEngine.Texture2D Instance;
		[ReadOnly]
		public System.Byte[] Result;

		public override IEnumerator Execute() {
			Result = Instance.EncodeToPNG();
			yield break;
		}

	}

	[Automation( "Texture 2D/Encode To JPG" )]
	class Texture2DEncodeToJPG18 : Automation {

		public UnityEngine.Texture2D Instance;
		public System.Int32 quality;
		[ReadOnly]
		public System.Byte[] Result;

		public override IEnumerator Execute() {
			Result = Instance.EncodeToJPG(quality);
			yield break;
		}

	}


#pragma warning restore 0649
}
