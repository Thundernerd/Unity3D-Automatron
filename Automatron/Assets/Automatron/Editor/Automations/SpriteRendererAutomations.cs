using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Sprite Renderer/Get Sprite" )]
	class SpriteRendererspriteGet0 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Sprite Result;

		public override IEnumerator Execute() {
			Result = Instance.sprite;
			yield break;
		}

	}

	[Automation( "Sprite Renderer/Set Sprite" )]
	class SpriteRendererspriteSet0 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public UnityEngine.Sprite Value;

		public override IEnumerator Execute() {
			Instance.sprite = Value;
			yield break;
		}

	}

	[Automation( "Sprite Renderer/Get Color" )]
	class SpriteRenderercolorGet1 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "Sprite Renderer/Set Color" )]
	class SpriteRenderercolorSet1 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}

	[Automation( "Sprite Renderer/Get Flip X" )]
	class SpriteRendererflipXGet2 : ConditionalAutomation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.flipX;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Sprite Renderer/Set Flip X" )]
	class SpriteRendererflipXSet2 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.flipX = Value;
			yield break;
		}

	}

	[Automation( "Sprite Renderer/Get Flip Y" )]
	class SpriteRendererflipYGet3 : ConditionalAutomation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.flipY;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Sprite Renderer/Set Flip Y" )]
	class SpriteRendererflipYSet3 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.flipY = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
