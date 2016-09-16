using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Text Mesh/Get Text" )]
	class TextMeshtextGet0 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.text;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Text" )]
	class TextMeshtextSet0 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.text = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Font" )]
	class TextMeshfontGet1 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Font Result;

		public override IEnumerator Execute() {
			Result = Instance.font;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Font" )]
	class TextMeshfontSet1 : Automation {

		public UnityEngine.TextMesh Instance;
		public UnityEngine.Font Value;

		public override IEnumerator Execute() {
			Instance.font = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Font Size" )]
	class TextMeshfontSizeGet2 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.fontSize;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Font Size" )]
	class TextMeshfontSizeSet2 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.Int32 Value;

		public override IEnumerator Execute() {
			Instance.fontSize = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Font Style" )]
	class TextMeshfontStyleGet3 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.FontStyle Result;

		public override IEnumerator Execute() {
			Result = Instance.fontStyle;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Font Style" )]
	class TextMeshfontStyleSet3 : Automation {

		public UnityEngine.TextMesh Instance;
		public UnityEngine.FontStyle Value;

		public override IEnumerator Execute() {
			Instance.fontStyle = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Offset Z" )]
	class TextMeshoffsetZGet4 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.offsetZ;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Offset Z" )]
	class TextMeshoffsetZSet4 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.offsetZ = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Alignment" )]
	class TextMeshalignmentGet5 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.TextAlignment Result;

		public override IEnumerator Execute() {
			Result = Instance.alignment;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Alignment" )]
	class TextMeshalignmentSet5 : Automation {

		public UnityEngine.TextMesh Instance;
		public UnityEngine.TextAlignment Value;

		public override IEnumerator Execute() {
			Instance.alignment = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Anchor" )]
	class TextMeshanchorGet6 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.TextAnchor Result;

		public override IEnumerator Execute() {
			Result = Instance.anchor;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Anchor" )]
	class TextMeshanchorSet6 : Automation {

		public UnityEngine.TextMesh Instance;
		public UnityEngine.TextAnchor Value;

		public override IEnumerator Execute() {
			Instance.anchor = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Character Size" )]
	class TextMeshcharacterSizeGet7 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.characterSize;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Character Size" )]
	class TextMeshcharacterSizeSet7 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.characterSize = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Line Spacing" )]
	class TextMeshlineSpacingGet8 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.lineSpacing;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Line Spacing" )]
	class TextMeshlineSpacingSet8 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.lineSpacing = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Tab Size" )]
	class TextMeshtabSizeGet9 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = Instance.tabSize;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Tab Size" )]
	class TextMeshtabSizeSet9 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.Single Value;

		public override IEnumerator Execute() {
			Instance.tabSize = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Rich Text" )]
	class TextMeshrichTextGet10 : ConditionalAutomation {

		public UnityEngine.TextMesh Instance;
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

	[Automation( "Text Mesh/Set Rich Text" )]
	class TextMeshrichTextSet10 : Automation {

		public UnityEngine.TextMesh Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.richText = Value;
			yield break;
		}

	}

	[Automation( "Text Mesh/Get Color" )]
	class TextMeshcolorGet11 : Automation {

		public UnityEngine.TextMesh Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "Text Mesh/Set Color" )]
	class TextMeshcolorSet11 : Automation {

		public UnityEngine.TextMesh Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
