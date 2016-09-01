using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "WWW/Get Error" )]
	class WWWerrorGet0 : Automation {

		public UnityEngine.WWW Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.error;
			yield break;
		}

	}

	[Automation( "WWW/Get Texture" )]
	class WWWtextureGet1 : Automation {

		public UnityEngine.WWW Instance;
		[ReadOnly]
		public UnityEngine.Texture2D Result;

		public override IEnumerator Execute() {
			Result = Instance.texture;
			yield break;
		}

	}

	[Automation( "WWW/Get Movie" )]
	class WWWmovieGet3 : Automation {

		public UnityEngine.WWW Instance;
		[ReadOnly]
		public UnityEngine.MovieTexture Result;

		public override IEnumerator Execute() {
			Result = Instance.movie;
			yield break;
		}

	}

	[Automation( "WWW/Get Is Done" )]
	class WWWisDoneGet4 : ConditionalAutomation {

		public UnityEngine.WWW Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.isDone;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "WWW/Get Url" )]
	class WWWurlGet5 : Automation {

		public UnityEngine.WWW Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.url;
			yield break;
		}

	}

	[Automation( "WWW/Escape URL" )]
	class WWWEscapeURL0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.WWW.EscapeURL(s);
			yield break;
		}

	}

	[Automation( "WWW/Un Escape URL" )]
	class WWWUnEscapeURL1 : Automation {

		public System.String s;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.WWW.UnEscapeURL(s);
			yield break;
		}

	}

	[Automation( "WWW/Get Audio Clip" )]
	class WWWGetAudioClip2 : Automation {

		public UnityEngine.WWW Instance;
		public System.Boolean threeD;
		public System.Boolean stream;
		public UnityEngine.AudioType audioType;
		[ReadOnly]
		public UnityEngine.AudioClip Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAudioClip(threeD,stream,audioType);
			yield break;
		}

	}

	[Automation( "WWW/Get Audio Clip Compressed" )]
	class WWWGetAudioClipCompressed3 : Automation {

		public UnityEngine.WWW Instance;
		public System.Boolean threeD;
		public UnityEngine.AudioType audioType;
		[ReadOnly]
		public UnityEngine.AudioClip Result;

		public override IEnumerator Execute() {
			Result = Instance.GetAudioClipCompressed(threeD,audioType);
			yield break;
		}

	}


#pragma warning restore 0649
}
