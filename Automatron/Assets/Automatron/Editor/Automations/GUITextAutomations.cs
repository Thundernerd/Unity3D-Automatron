#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "GUI Text/Get Text" )]
	class GUITexttextGet0 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.text;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Text" )]
	class GUITexttextSet0 : Automation {

		public UnityEngine.GUIText Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.text = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Material" )]
	class GUITextmaterialGet1 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Material Result;

		public override IEnumerator Execute() {
			Result = Instance.material;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Material" )]
	class GUITextmaterialSet1 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.Material Value;

		public override IEnumerator Execute() {
			Instance.material = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Pixel Offset" )]
	class GUITextpixelOffsetGet2 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelOffset;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Pixel Offset" )]
	class GUITextpixelOffsetSet2 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.Vector2 Value;

		public override IEnumerator Execute() {
			Instance.pixelOffset = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Font" )]
	class GUITextfontGet3 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Font Result;

		public override IEnumerator Execute() {
			Result = Instance.font;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Font" )]
	class GUITextfontSet3 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.Font Value;

		public override IEnumerator Execute() {
			Instance.font = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Alignment" )]
	class GUITextalignmentGet4 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.TextAlignment Result;

		public override IEnumerator Execute() {
			Result = Instance.alignment;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Alignment" )]
	class GUITextalignmentSet4 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.TextAlignment Value;

		public override IEnumerator Execute() {
			Instance.alignment = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Anchor" )]
	class GUITextanchorGet5 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.TextAnchor Result;

		public override IEnumerator Execute() {
			Result = Instance.anchor;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Anchor" )]
	class GUITextanchorSet5 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.TextAnchor Value;

		public override IEnumerator Execute() {
			Instance.anchor = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Line Spacing" )]
	class GUITextlineSpacingGet6 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.lineSpacing;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Line Spacing" )]
	class GUITextlineSpacingSet6 : Automation {

		public UnityEngine.GUIText Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.lineSpacing = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Tab Size" )]
	class GUITexttabSizeGet7 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.tabSize;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Tab Size" )]
	class GUITexttabSizeSet7 : Automation {

		public UnityEngine.GUIText Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.tabSize = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Font Size" )]
	class GUITextfontSizeGet8 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.fontSize;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Font Size" )]
	class GUITextfontSizeSet8 : Automation {

		public UnityEngine.GUIText Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.fontSize = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Font Style" )]
	class GUITextfontStyleGet9 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.FontStyle Result;

		public override IEnumerator Execute() {
			Result = Instance.fontStyle;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Font Style" )]
	class GUITextfontStyleSet9 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.FontStyle Value;

		public override IEnumerator Execute() {
			Instance.fontStyle = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Rich Text" )]
	class GUITextrichTextGet10 : ConditionalAutomation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.richText;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "GUI Text/Set Rich Text" )]
	class GUITextrichTextSet10 : Automation {

		public UnityEngine.GUIText Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.richText = Value;
			yield break;
		}

	}

	[Automation( "GUI Text/Get Color" )]
	class GUITextcolorGet11 : Automation {

		public UnityEngine.GUIText Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "GUI Text/Set Color" )]
	class GUITextcolorSet11 : Automation {

		public UnityEngine.GUIText Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif