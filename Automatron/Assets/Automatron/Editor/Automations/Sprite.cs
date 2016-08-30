using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Sprite/Create Advanced" )]
	class SpriteCreate0 : Automation {

		public UnityEngine.Texture2D texture;
		public UnityEngine.Rect rect;
		public UnityEngine.Vector2 pivot;
		public System.Single pixelsPerUnit;
		public System.UInt32 extrude;
		public UnityEngine.SpriteMeshType meshType;
		public UnityEngine.Vector4 border;
		[ReadOnly]
		public UnityEngine.Sprite Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprite.Create(texture,rect,pivot,pixelsPerUnit,extrude,meshType,border);
			yield break;
		}

	}

	[Automation( "Sprite/Create Simple" )]
	class SpriteCreate4 : Automation {

		public UnityEngine.Texture2D texture;
		public UnityEngine.Rect rect;
		public UnityEngine.Vector2 pivot;
		[ReadOnly]
		public UnityEngine.Sprite Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Sprite.Create(texture,rect,pivot);
			yield break;
		}

	}


#pragma warning restore 0649
}
