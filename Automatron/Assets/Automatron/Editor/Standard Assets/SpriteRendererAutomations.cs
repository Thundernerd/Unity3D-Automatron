using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Rendeders/Sprite Renderer/Get Sprite" )]
	class SpriteRendererspriteGet0 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		public UnityEngine.Sprite Result;

		public override IEnumerator Execute() {
			Result = Instance.sprite;
			yield break;
		}

	}

	[Automation( "Rendeders/Sprite Renderer/Set Sprite" )]
	class SpriteRendererspriteSet0 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public UnityEngine.Sprite Value;

		public override IEnumerator Execute() {
			Instance.sprite = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Sprite Renderer/Get Color" )]
	class SpriteRenderercolorGet1 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = Instance.color;
			yield break;
		}

	}

	[Automation( "Rendeders/Sprite Renderer/Set Color" )]
	class SpriteRenderercolorSet1 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public UnityEngine.Color Value;

		public override IEnumerator Execute() {
			Instance.color = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Sprite Renderer/Get Flip X" )]
	class SpriteRendererflipXGet2 : ConditionalAutomation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.flipX;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Sprite Renderer/Set Flip X" )]
	class SpriteRendererflipXSet2 : Automation {

		public UnityEngine.SpriteRenderer Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.flipX = Value;
			yield break;
		}

	}

	[Automation( "Rendeders/Sprite Renderer/Get Flip Y" )]
	class SpriteRendererflipYGet3 : ConditionalAutomation {

		public UnityEngine.SpriteRenderer Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.flipY;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Rendeders/Sprite Renderer/Set Flip Y" )]
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
