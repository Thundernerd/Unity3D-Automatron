using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Sprite Utility/Get Sprite Texture" )]
	class SpriteUtilityGetSpriteTexture0 : Automation {

		public UnityEngine.Sprite sprite;
		public System.Boolean getAtlasData;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Sprites.SpriteUtility.GetSpriteTexture(sprite,getAtlasData);
			yield break;
		}

	}

	[Automation( "Sprite Utility/Get Sprite U Vs" )]
	class SpriteUtilityGetSpriteUVs1 : Automation {

		public UnityEngine.Sprite sprite;
		public System.Boolean getAtlasData;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Sprites.SpriteUtility.GetSpriteUVs(sprite,getAtlasData);
			yield break;
		}

	}


#pragma warning restore 0649
}
