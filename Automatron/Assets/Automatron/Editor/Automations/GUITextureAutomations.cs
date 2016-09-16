using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "GUI Texture/Get Color" )]
	class GUITexturecolorGet0 : Automation {

		public UnityEngine.GUITexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "GUI Texture/Set Color" )]
	class GUITexturecolorSet0 : Automation {

		public UnityEngine.GUITexture Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}

	[Automation( "GUI Texture/Get Texture" )]
	class GUITexturetextureGet1 : Automation {

		public UnityEngine.GUITexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = Instance.texture;
			yield break;
		}

	}

	[Automation( "GUI Texture/Set Texture" )]
	class GUITexturetextureSet1 : Automation {

		public UnityEngine.GUITexture Instance;
		public UnityEngine.Texture Value;

		public override IEnumerator Execute() {
			Instance.texture = Value;
			yield break;
		}

	}

	[Automation( "GUI Texture/Get Pixel Inset" )]
	class GUITexturepixelInsetGet2 : Automation {

		public UnityEngine.GUITexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Rect Result;

		public override IEnumerator Execute() {
			Result = Instance.pixelInset;
			yield break;
		}

	}

	[Automation( "GUI Texture/Set Pixel Inset" )]
	class GUITexturepixelInsetSet2 : Automation {

		public UnityEngine.GUITexture Instance;
		public UnityEngine.Rect Value;

		public override IEnumerator Execute() {
			Instance.pixelInset = Value;
			yield break;
		}

	}

	[Automation( "GUI Texture/Get Border" )]
	class GUITextureborderGet3 : Automation {

		public UnityEngine.GUITexture Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.RectOffset Result;

		public override IEnumerator Execute() {
			Result = Instance.border;
			yield break;
		}

	}

	[Automation( "GUI Texture/Set Border" )]
	class GUITextureborderSet3 : Automation {

		public UnityEngine.GUITexture Instance;
		public UnityEngine.RectOffset Value;

		public override IEnumerator Execute() {
			Instance.border = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
