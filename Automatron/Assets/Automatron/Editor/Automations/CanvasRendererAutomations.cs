using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Canvas Renderer/Get Has Rect Clipping" )]
	class CanvasRendererhasRectClippingGet0 : ConditionalAutomation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasRectClipping;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Renderer/Get Has Pop Instruction" )]
	class CanvasRendererhasPopInstructionGet1 : ConditionalAutomation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasPopInstruction;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Renderer/Set Has Pop Instruction" )]
	class CanvasRendererhasPopInstructionSet1 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.hasPopInstruction = Value;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Material Count" )]
	class CanvasRenderermaterialCountGet2 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.materialCount;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Material Count" )]
	class CanvasRenderermaterialCountSet2 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.materialCount = Value;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Pop Material Count" )]
	class CanvasRendererpopMaterialCountGet3 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.popMaterialCount;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Pop Material Count" )]
	class CanvasRendererpopMaterialCountSet3 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.popMaterialCount = Value;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Relative Depth" )]
	class CanvasRendererrelativeDepthGet4 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.relativeDepth;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Cull" )]
	class CanvasRenderercullGet5 : ConditionalAutomation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.cull;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Renderer/Set Cull" )]
	class CanvasRenderercullSet5 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.cull = Value;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Absolute Depth" )]
	class CanvasRendererabsoluteDepthGet6 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.absoluteDepth;
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Has Moved" )]
	class CanvasRendererhasMovedGet7 : ConditionalAutomation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.hasMoved;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas Renderer/Set Color" )]
	class CanvasRendererSetColor0 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public UnityEngine.Color color;

		public override IEnumerator Execute() {
			Instance.SetColor(color);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Color" )]
	class CanvasRendererGetColor1 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.GetColor();
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Alpha" )]
	class CanvasRendererGetAlpha2 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAlpha();
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Alpha" )]
	class CanvasRendererSetAlpha3 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public System.Single alpha;

		public override IEnumerator Execute() {
			Instance.SetAlpha(alpha);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Enable Rect Clipping" )]
	class CanvasRendererEnableRectClipping4 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public UnityEngine.Rect rect;

		public override IEnumerator Execute() {
			Instance.EnableRectClipping(rect);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Disable Rect Clipping" )]
	class CanvasRendererDisableRectClipping5 : Automation {

		public UnityEngine.CanvasRenderer Instance;

		public override IEnumerator Execute() {
			Instance.DisableRectClipping();
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Material" )]
	class CanvasRendererSetMaterial6 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public UnityEngine.Material material;
		public UnityEngine.Texture texture;

		public override IEnumerator Execute() {
			Instance.SetMaterial(material,texture);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Material" )]
	class CanvasRendererGetMaterial7 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		[ReadOnly]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.GetMaterial();
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Pop Material" )]
	class CanvasRendererSetPopMaterial8 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public UnityEngine.Material material;
		public System.Int32 index;

		public override IEnumerator Execute() {
			Instance.SetPopMaterial(material,index);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Get Pop Material" )]
	class CanvasRendererGetPopMaterial9 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public System.Int32 index;
		[ReadOnly]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.GetPopMaterial(index);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Texture" )]
	class CanvasRendererSetTexture10 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public UnityEngine.Texture texture;

		public override IEnumerator Execute() {
			Instance.SetTexture(texture);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Set Mesh" )]
	class CanvasRendererSetMesh11 : Automation {

		public UnityEngine.CanvasRenderer Instance;
		public UnityEngine.Mesh mesh;

		public override IEnumerator Execute() {
			Instance.SetMesh(mesh);
			yield break;
		}

	}

	[Automation( "Canvas Renderer/Clear" )]
	class CanvasRendererClear12 : Automation {

		public UnityEngine.CanvasRenderer Instance;

		public override IEnumerator Execute() {
			Instance.Clear();
			yield break;
		}

	}


#pragma warning restore 0649
}
