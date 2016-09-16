using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rect Transform/Get Rect" )]
	class RectTransformrectGet0 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.rect;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Anchor Min" )]
	class RectTransformanchorMinGet1 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchorMin;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Anchor Min" )]
	class RectTransformanchorMinSet1 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.anchorMin = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Anchor Max" )]
	class RectTransformanchorMaxGet2 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchorMax;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Anchor Max" )]
	class RectTransformanchorMaxSet2 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.anchorMax = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Anchored Position 3D" )]
	class RectTransformanchoredPosition3DGet3 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchoredPosition3D;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Anchored Position 3D" )]
	class RectTransformanchoredPosition3DSet3 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector3 Value;

		public override IEnumerator Execute() {
			Instance.anchoredPosition3D = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Anchored Position" )]
	class RectTransformanchoredPositionGet4 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.anchoredPosition;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Anchored Position" )]
	class RectTransformanchoredPositionSet4 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.anchoredPosition = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Size Delta" )]
	class RectTransformsizeDeltaGet5 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.sizeDelta;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Size Delta" )]
	class RectTransformsizeDeltaSet5 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.sizeDelta = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Pivot" )]
	class RectTransformpivotGet6 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.pivot;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Pivot" )]
	class RectTransformpivotSet6 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.pivot = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Offset Min" )]
	class RectTransformoffsetMinGet7 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.offsetMin;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Offset Min" )]
	class RectTransformoffsetMinSet7 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.offsetMin = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Offset Max" )]
	class RectTransformoffsetMaxGet8 : Automation {

		public UnityEngine.RectTransform Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.offsetMax;
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Offset Max" )]
	class RectTransformoffsetMaxSet8 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.offsetMax = Value;
			yield break;
		}

	}

	[Automation( "Rect Transform/Get Local Corners" )]
	class RectTransformGetLocalCorners0 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector3[] fourCornersArray;

		public override IEnumerator Execute() {
			Instance.GetLocalCorners(fourCornersArray);
			yield break;
		}

	}

	[Automation( "Rect Transform/Get World Corners" )]
	class RectTransformGetWorldCorners1 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.Vector3[] fourCornersArray;

		public override IEnumerator Execute() {
			Instance.GetWorldCorners(fourCornersArray);
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Inset And Size From Parent Edge" )]
	class RectTransformSetInsetAndSizeFromParentEdge2 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.RectTransform.Edge edge;
		public System.Single inset;
		public System.Single size;

		public override IEnumerator Execute() {
			Instance.SetInsetAndSizeFromParentEdge(edge,inset,size);
			yield break;
		}

	}

	[Automation( "Rect Transform/Set Size With Current Anchors" )]
	class RectTransformSetSizeWithCurrentAnchors3 : Automation {

		public UnityEngine.RectTransform Instance;
		public UnityEngine.RectTransform.Axis axis;
		public System.Single size;

		public override IEnumerator Execute() {
			Instance.SetSizeWithCurrentAnchors(axis,size);
			yield break;
		}

	}


#pragma warning restore 0649
}
