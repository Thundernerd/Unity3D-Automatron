using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rect/Get X" )]
	class RectxGet0 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.x;
			yield break;
		}

	}

	[Automation( "Rect/Set X" )]
	class RectxSet0 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.x = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Y" )]
	class RectyGet1 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.y;
			yield break;
		}

	}

	[Automation( "Rect/Set Y" )]
	class RectySet1 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.y = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Position" )]
	class RectpositionGet2 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.position;
			yield break;
		}

	}

	[Automation( "Rect/Set Position" )]
	class RectpositionSet2 : Automation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.position = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Center" )]
	class RectcenterGet3 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.center;
			yield break;
		}

	}

	[Automation( "Rect/Set Center" )]
	class RectcenterSet3 : Automation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.center = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Min" )]
	class RectminGet4 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.min;
			yield break;
		}

	}

	[Automation( "Rect/Set Min" )]
	class RectminSet4 : Automation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.min = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Max" )]
	class RectmaxGet5 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.max;
			yield break;
		}

	}

	[Automation( "Rect/Set Max" )]
	class RectmaxSet5 : Automation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.max = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Width" )]
	class RectwidthGet6 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.width;
			yield break;
		}

	}

	[Automation( "Rect/Set Width" )]
	class RectwidthSet6 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.width = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Height" )]
	class RectheightGet7 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.height;
			yield break;
		}

	}

	[Automation( "Rect/Set Height" )]
	class RectheightSet7 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.height = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Size" )]
	class RectsizeGet8 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.size;
			yield break;
		}

	}

	[Automation( "Rect/Set Size" )]
	class RectsizeSet8 : Automation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.size = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get X Min" )]
	class RectxMinGet9 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.xMin;
			yield break;
		}

	}

	[Automation( "Rect/Set X Min" )]
	class RectxMinSet9 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.xMin = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Y Min" )]
	class RectyMinGet10 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.yMin;
			yield break;
		}

	}

	[Automation( "Rect/Set Y Min" )]
	class RectyMinSet10 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.yMin = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get X Max" )]
	class RectxMaxGet11 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.xMax;
			yield break;
		}

	}

	[Automation( "Rect/Set X Max" )]
	class RectxMaxSet11 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.xMax = Value;
			yield break;
		}

	}

	[Automation( "Rect/Get Y Max" )]
	class RectyMaxGet12 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.yMax;
			yield break;
		}

	}

	[Automation( "Rect/Set Y Max" )]
	class RectyMaxSet12 : Automation {

		public UnityEngine.Rect Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.yMax = Value;
			yield break;
		}

	}

	[Automation( "Rect/Min Max Rect" )]
	class RectMinMaxRect0 : Automation {

		public System.Single xmin;
		public System.Single ymin;
		public System.Single xmax;
		public System.Single ymax;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Rect.MinMaxRect(xmin,ymin,xmax,ymax);
			yield break;
		}

	}

	[Automation( "Rect/To String" )]
	class RectToString1 : Automation {

		public UnityEngine.Rect Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}

	[Automation( "Rect/Contains" )]
	class RectContains2 : ConditionalAutomation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Vector3 point;
		public System.Boolean allowInverse;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Contains(point,allowInverse);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rect/Overlaps" )]
	class RectOverlaps3 : ConditionalAutomation {

		public UnityEngine.Rect Instance;
		public UnityEngine.Rect other;
		public System.Boolean allowInverse;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Overlaps(other,allowInverse);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rect/Normalized To Point" )]
	class RectNormalizedToPoint4 : Automation {

		public UnityEngine.Rect rectangle;
		public UnityEngine.Vector2 normalizedRectCoordinates;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Rect.NormalizedToPoint(rectangle,normalizedRectCoordinates);
			yield break;
		}

	}

	[Automation( "Rect/Point To Normalized" )]
	class RectPointToNormalized5 : Automation {

		public UnityEngine.Rect rectangle;
		public UnityEngine.Vector2 point;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Rect.PointToNormalized(rectangle,point);
			yield break;
		}

	}


#pragma warning restore 0649
}
