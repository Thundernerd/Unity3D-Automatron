using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Sprite/Get Bounds" )]
	class SpriteboundsGet0 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = Instance.bounds;
			yield break;
		}

	}

	[Automation( "Sprite/Get Rect" )]
	class SpriterectGet1 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.rect;
			yield break;
		}

	}

	[Automation( "Sprite/Get Pixels Per Unit" )]
	class SpritepixelsPerUnitGet2 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelsPerUnit;
			yield break;
		}

	}

	[Automation( "Sprite/Get Texture" )]
	class SpritetextureGet3 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = Instance.texture;
			yield break;
		}

	}

	[Automation( "Sprite/Get Associated Alpha Split Texture" )]
	class SpriteassociatedAlphaSplitTextureGet4 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = Instance.associatedAlphaSplitTexture;
			yield break;
		}

	}

	[Automation( "Sprite/Get Texture Rect" )]
	class SpritetextureRectGet5 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.textureRect;
			yield break;
		}

	}

	[Automation( "Sprite/Get Texture Rect Offset" )]
	class SpritetextureRectOffsetGet6 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.textureRectOffset;
			yield break;
		}

	}

	[Automation( "Sprite/Get Packed" )]
	class SpritepackedGet7 : ConditionalAutomation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.packed;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Sprite/Get Packing Mode" )]
	class SpritepackingModeGet8 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.SpritePackingMode Result;

		public override IEnumerator Execute() {
			Result = Instance.packingMode;
			yield break;
		}

	}

	[Automation( "Sprite/Get Packing Rotation" )]
	class SpritepackingRotationGet9 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.SpritePackingRotation Result;

		public override IEnumerator Execute() {
			Result = Instance.packingRotation;
			yield break;
		}

	}

	[Automation( "Sprite/Get Pivot" )]
	class SpritepivotGet10 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.pivot;
			yield break;
		}

	}

	[Automation( "Sprite/Get Border" )]
	class SpriteborderGet11 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = Instance.border;
			yield break;
		}

	}

	[Automation( "Sprite/Get Vertices" )]
	class SpriteverticesGet12 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Vector2[] Result;

		public override IEnumerator Execute() {
			Result = Instance.vertices;
			yield break;
		}

	}

	[Automation( "Sprite/Get Triangles" )]
	class SpritetrianglesGet13 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public System.UInt16[] Result;

		public override IEnumerator Execute() {
			Result = Instance.triangles;
			yield break;
		}

	}

	[Automation( "Sprite/Get Uv" )]
	class SpriteuvGet14 : Automation {

		public UnityEngine.Sprite Instance;
		[ReadOnly]
		public UnityEngine.Vector2[] Result;

		public override IEnumerator Execute() {
			Result = Instance.uv;
			yield break;
		}

	}

	[Automation( "Sprite/Create" )]
	class SpriteCreate0 : Automation {

		public UnityEngine.Texture2D texture;
		public UnityEngine.Rect rect;
		public UnityEngine.Vector2 pivot;
		public System.Single pixelsPerUnit;
		[ReadOnly]
		public UnityEngine.Sprite Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprite.Create(texture,rect,pivot,pixelsPerUnit);
			yield break;
		}

	}


#pragma warning restore 0649
}
