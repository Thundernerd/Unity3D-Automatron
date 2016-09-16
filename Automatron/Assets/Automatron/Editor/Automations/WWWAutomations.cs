using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "WWW/Escape URL" )]
	class WWWEscapeURL0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.WWW.UnEscapeURL(s);
			yield break;
		}

	}


#pragma warning restore 0649
}
