using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/SpriteData Utility/Get Inner UV" )]
	class DataUtilityGetInnerUV0 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetInnerUV(sprite);
			yield break;
		}

	}

	[Automation( "Utilities/SpriteData Utility/Get Outer UV" )]
	class DataUtilityGetOuterUV1 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetOuterUV(sprite);
			yield break;
		}

	}

	[Automation( "Utilities/SpriteData Utility/Get Padding" )]
	class DataUtilityGetPadding2 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetPadding(sprite);
			yield break;
		}

	}

	[Automation( "Utilities/SpriteData Utility/Get Min Size" )]
	class DataUtilityGetMinSize3 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetMinSize(sprite);
			yield break;
		}

	}


#pragma warning restore 0649
}
