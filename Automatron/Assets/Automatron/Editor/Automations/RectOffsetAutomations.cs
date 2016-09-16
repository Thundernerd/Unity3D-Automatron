using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rect Offset/Get Left" )]
	class RectOffsetleftGet0 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.left;
			yield break;
		}

	}

	[Automation( "Rect Offset/Set Left" )]
	class RectOffsetleftSet0 : Automation {

		public UnityEngine.RectOffset Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.left = Value;
			yield break;
		}

	}

	[Automation( "Rect Offset/Get Right" )]
	class RectOffsetrightGet1 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.right;
			yield break;
		}

	}

	[Automation( "Rect Offset/Set Right" )]
	class RectOffsetrightSet1 : Automation {

		public UnityEngine.RectOffset Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.right = Value;
			yield break;
		}

	}

	[Automation( "Rect Offset/Get Top" )]
	class RectOffsettopGet2 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.top;
			yield break;
		}

	}

	[Automation( "Rect Offset/Set Top" )]
	class RectOffsettopSet2 : Automation {

		public UnityEngine.RectOffset Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.top = Value;
			yield break;
		}

	}

	[Automation( "Rect Offset/Get Bottom" )]
	class RectOffsetbottomGet3 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.bottom;
			yield break;
		}

	}

	[Automation( "Rect Offset/Set Bottom" )]
	class RectOffsetbottomSet3 : Automation {

		public UnityEngine.RectOffset Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.bottom = Value;
			yield break;
		}

	}

	[Automation( "Rect Offset/Get Horizontal" )]
	class RectOffsethorizontalGet4 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.horizontal;
			yield break;
		}

	}

	[Automation( "Rect Offset/Get Vertical" )]
	class RectOffsetverticalGet5 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.vertical;
			yield break;
		}

	}

	[Automation( "Rect Offset/Add" )]
	class RectOffsetAdd0 : Automation {

		public UnityEngine.RectOffset Instance;
		public UnityEngine.Rect rect;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.Add(rect);
			yield break;
		}

	}

	[Automation( "Rect Offset/Remove" )]
	class RectOffsetRemove1 : Automation {

		public UnityEngine.RectOffset Instance;
		public UnityEngine.Rect rect;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.Remove(rect);
			yield break;
		}

	}

	[Automation( "Rect Offset/To String" )]
	class RectOffsetToString2 : Automation {

		public UnityEngine.RectOffset Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
