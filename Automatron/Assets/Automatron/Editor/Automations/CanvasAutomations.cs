#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Canvas/Get Render Mode" )]
	class CanvasrenderModeGet0 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RenderMode Result;

		public override IEnumerator Execute() {
			Result = Instance.renderMode;
			yield break;
		}

	}

	[Automation( "Canvas/Set Render Mode" )]
	class CanvasrenderModeSet0 : Automation {

		public UnityEngine.Canvas Instance;
		public UnityEngine.RenderMode Value;

		public override IEnumerator Execute() {
			Instance.renderMode = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Is Root Canvas" )]
	class CanvasisRootCanvasGet1 : ConditionalAutomation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isRootCanvas;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas/Get World Camera" )]
	class CanvasworldCameraGet2 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Camera Result;

		public override IEnumerator Execute() {
			Result = Instance.worldCamera;
			yield break;
		}

	}

	[Automation( "Canvas/Set World Camera" )]
	class CanvasworldCameraSet2 : Automation {

		public UnityEngine.Canvas Instance;
		public UnityEngine.Camera Value;

		public override IEnumerator Execute() {
			Instance.worldCamera = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Pixel Rect" )]
	class CanvaspixelRectGet3 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelRect;
			yield break;
		}

	}

	[Automation( "Canvas/Get Scale Factor" )]
	class CanvasscaleFactorGet4 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.scaleFactor;
			yield break;
		}

	}

	[Automation( "Canvas/Set Scale Factor" )]
	class CanvasscaleFactorSet4 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.scaleFactor = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Reference Pixels Per Unit" )]
	class CanvasreferencePixelsPerUnitGet5 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.referencePixelsPerUnit;
			yield break;
		}

	}

	[Automation( "Canvas/Set Reference Pixels Per Unit" )]
	class CanvasreferencePixelsPerUnitSet5 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.referencePixelsPerUnit = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Override Pixel Perfect" )]
	class CanvasoverridePixelPerfectGet6 : ConditionalAutomation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.overridePixelPerfect;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas/Set Override Pixel Perfect" )]
	class CanvasoverridePixelPerfectSet6 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.overridePixelPerfect = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Pixel Perfect" )]
	class CanvaspixelPerfectGet7 : ConditionalAutomation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelPerfect;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas/Set Pixel Perfect" )]
	class CanvaspixelPerfectSet7 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.pixelPerfect = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Plane Distance" )]
	class CanvasplaneDistanceGet8 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.planeDistance;
			yield break;
		}

	}

	[Automation( "Canvas/Set Plane Distance" )]
	class CanvasplaneDistanceSet8 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.planeDistance = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Render Order" )]
	class CanvasrenderOrderGet9 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.renderOrder;
			yield break;
		}

	}

	[Automation( "Canvas/Get Override Sorting" )]
	class CanvasoverrideSortingGet10 : ConditionalAutomation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.overrideSorting;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Canvas/Set Override Sorting" )]
	class CanvasoverrideSortingSet10 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.overrideSorting = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Sorting Order" )]
	class CanvassortingOrderGet11 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingOrder;
			yield break;
		}

	}

	[Automation( "Canvas/Set Sorting Order" )]
	class CanvassortingOrderSet11 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingOrder = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Target Display" )]
	class CanvastargetDisplayGet12 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.targetDisplay;
			yield break;
		}

	}

	[Automation( "Canvas/Set Target Display" )]
	class CanvastargetDisplaySet12 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.targetDisplay = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Sorting Grid Normalized Size" )]
	class CanvassortingGridNormalizedSizeGet13 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingGridNormalizedSize;
			yield break;
		}

	}

	[Automation( "Canvas/Set Sorting Grid Normalized Size" )]
	class CanvassortingGridNormalizedSizeSet13 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingGridNormalizedSize = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Sorting Layer ID" )]
	class CanvassortingLayerIDGet14 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingLayerID;
			yield break;
		}

	}

	[Automation( "Canvas/Set Sorting Layer ID" )]
	class CanvassortingLayerIDSet14 : Automation {

		public UnityEngine.Canvas Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.sortingLayerID = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Cached Sorting Layer Value" )]
	class CanvascachedSortingLayerValueGet15 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.cachedSortingLayerValue;
			yield break;
		}

	}

	[Automation( "Canvas/Get Sorting Layer Name" )]
	class CanvassortingLayerNameGet16 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.sortingLayerName;
			yield break;
		}

	}

	[Automation( "Canvas/Set Sorting Layer Name" )]
	class CanvassortingLayerNameSet16 : Automation {

		public UnityEngine.Canvas Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.sortingLayerName = Value;
			yield break;
		}

	}

	[Automation( "Canvas/Get Root Canvas" )]
	class CanvasrootCanvasGet17 : Automation {

		public UnityEngine.Canvas Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Canvas Result;

		public override IEnumerator Execute() {
			Result = Instance.rootCanvas;
			yield break;
		}

	}

	[Automation( "Canvas/Get Default Canvas Material" )]
	class CanvasGetDefaultCanvasMaterial0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Canvas.GetDefaultCanvasMaterial();
			yield break;
		}

	}

	[Automation( "Canvas/Get ETC1 Supported Canvas Material" )]
	class CanvasGetETC1SupportedCanvasMaterial1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Canvas.GetETC1SupportedCanvasMaterial();
			yield break;
		}

	}

	[Automation( "Canvas/Force Update Canvases" )]
	class CanvasForceUpdateCanvases2 : Automation {


		public override IEnumerator Execute() {
			UnityEngine.Canvas.ForceUpdateCanvases();
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif