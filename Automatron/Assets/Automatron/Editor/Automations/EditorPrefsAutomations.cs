using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Prefs/Set Int" )]
	class EditorPrefsSetInt0 : Automation {

		public System.String key;
		public System.Int32 value;

		public override IEnumerator Execute() {
			UnityEditor.EditorPrefs.SetInt(key,value);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Get Int" )]
	class EditorPrefsGetInt1 : Automation {

		public System.String key;
		public System.Int32 defaultValue;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorPrefs.GetInt(key,defaultValue);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Set Float" )]
	class EditorPrefsSetFloat2 : Automation {

		public System.String key;
		public System.Single value;

		public override IEnumerator Execute() {
			UnityEditor.EditorPrefs.SetFloat(key,value);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Get Float" )]
	class EditorPrefsGetFloat3 : Automation {

		public System.String key;
		public System.Single defaultValue;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorPrefs.GetFloat(key,defaultValue);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Set String" )]
	class EditorPrefsSetString4 : Automation {

		public System.String key;
		public System.String value;

		public override IEnumerator Execute() {
			UnityEditor.EditorPrefs.SetString(key,value);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Get String" )]
	class EditorPrefsGetString5 : Automation {

		public System.String key;
		public System.String defaultValue;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorPrefs.GetString(key,defaultValue);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Set Bool" )]
	class EditorPrefsSetBool6 : Automation {

		public System.String key;
		public System.Boolean value;

		public override IEnumerator Execute() {
			UnityEditor.EditorPrefs.SetBool(key,value);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Get Bool" )]
	class EditorPrefsGetBool7 : ConditionalAutomation {

		public System.String key;
		public System.Boolean defaultValue;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorPrefs.GetBool(key,defaultValue);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Prefs/Has Key" )]
	class EditorPrefsHasKey8 : ConditionalAutomation {

		public System.String key;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorPrefs.HasKey(key);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Prefs/Delete Key" )]
	class EditorPrefsDeleteKey9 : Automation {

		public System.String key;

		public override IEnumerator Execute() {
			UnityEditor.EditorPrefs.DeleteKey(key);
			yield break;
		}

	}

	[Automation( "Editor Prefs/Delete All" )]
	class EditorPrefsDeleteAll10 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorPrefs.DeleteAll();
			yield break;
		}

	}


#pragma warning restore 0649
}
