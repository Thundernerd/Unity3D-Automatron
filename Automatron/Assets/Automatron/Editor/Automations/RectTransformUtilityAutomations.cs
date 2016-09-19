#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rect Transform Utility/Rectangle Contains Screen Point" )]
	class RectTransformUtilityRectangleContainsScreenPoint0 : ConditionalAutomation {

		public UnityEngine.RectTransform rect;
		public UnityEngine.Vector2 screenPoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect,screenPoint);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rect Transform Utility/Pixel Adjust Point" )]
	class RectTransformUtilityPixelAdjustPoint1 : Automation {

		public UnityEngine.Vector2 point;
		public UnityEngine.Transform elementTransform;
		public UnityEngine.Canvas canvas;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.PixelAdjustPoint(point,elementTransform,canvas);
			yield break;
		}

	}

	[Automation( "Rect Transform Utility/Pixel Adjust Rect" )]
	class RectTransformUtilityPixelAdjustRect2 : Automation {

		public UnityEngine.RectTransform rectTransform;
		public UnityEngine.Canvas canvas;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.PixelAdjustRect(rectTransform,canvas);
			yield break;
		}

	}

	[Automation( "Rect Transform Utility/Screen Point To World Point In Rectangle" )]
	class RectTransformUtilityScreenPointToWorldPointInRectangle3 : ConditionalAutomation {

		public UnityEngine.RectTransform rect;
		public UnityEngine.Vector2 screenPoint;
		public UnityEngine.Camera cam;
		public UnityEngine.Vector3 worldPoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect,screenPoint,cam,out worldPoint);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rect Transform Utility/Screen Point To Local Point In Rectangle" )]
	class RectTransformUtilityScreenPointToLocalPointInRectangle4 : ConditionalAutomation {

		public UnityEngine.RectTransform rect;
		public UnityEngine.Vector2 screenPoint;
		public UnityEngine.Camera cam;
		public UnityEngine.Vector2 localPoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect,screenPoint,cam,out localPoint);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rect Transform Utility/Screen Point To Ray" )]
	class RectTransformUtilityScreenPointToRay5 : Automation {

		public UnityEngine.Camera cam;
		public UnityEngine.Vector2 screenPos;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Ray Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.ScreenPointToRay(cam,screenPos);
			yield break;
		}

	}

	[Automation( "Rect Transform Utility/World To Screen Point" )]
	class RectTransformUtilityWorldToScreenPoint6 : Automation {

		public UnityEngine.Camera cam;
		public UnityEngine.Vector3 worldPoint;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam,worldPoint);
			yield break;
		}

	}

	[Automation( "Rect Transform Utility/Calculate Relative Rect Transform Bounds" )]
	class RectTransformUtilityCalculateRelativeRectTransformBounds7 : Automation {

		public UnityEngine.Transform trans;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Bounds Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(trans);
			yield break;
		}

	}

	[Automation( "Rect Transform Utility/Flip Layout On Axis" )]
	class RectTransformUtilityFlipLayoutOnAxis8 : Automation {

		public UnityEngine.RectTransform rect;
		public System.Int32 axis;
		public System.Boolean keepPositioning;
		public System.Boolean recursive;

		public override IEnumerator Execute() {
			UnityEngine.RectTransformUtility.FlipLayoutOnAxis(rect,axis,keepPositioning,recursive);
			yield break;
		}

	}

	[Automation( "Rect Transform Utility/Flip Layout Axes" )]
	class RectTransformUtilityFlipLayoutAxes9 : Automation {

		public UnityEngine.RectTransform rect;
		public System.Boolean keepPositioning;
		public System.Boolean recursive;

		public override IEnumerator Execute() {
			UnityEngine.RectTransformUtility.FlipLayoutAxes(rect,keepPositioning,recursive);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif