using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Sprite Data Utility/Get Inner UV" )]
	class DataUtilityGetInnerUV0 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetInnerUV(sprite);
			yield break;
		}

	}

	[Automation( "Sprite Data Utility/Get Outer UV" )]
	class DataUtilityGetOuterUV1 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetOuterUV(sprite);
			yield break;
		}

	}

	[Automation( "Sprite Data Utility/Get Padding" )]
	class DataUtilityGetPadding2 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector4 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetPadding(sprite);
			yield break;
		}

	}

	[Automation( "Sprite Data Utility/Get Min Size" )]
	class DataUtilityGetMinSize3 : Automation {

		public UnityEngine.Sprite sprite;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprites.DataUtility.GetMinSize(sprite);
			yield break;
		}

	}


#pragma warning restore 0649
}
