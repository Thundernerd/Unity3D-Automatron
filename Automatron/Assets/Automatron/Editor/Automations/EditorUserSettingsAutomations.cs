#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor User Settings/Get Automatic Add" )]
	class EditorUserSettingsAutomaticAddGet0 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserSettings.AutomaticAdd;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor User Settings/Set Automatic Add" )]
	class EditorUserSettingsAutomaticAddSet0 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserSettings.AutomaticAdd = Value;
			yield break;
		}

	}

	[Automation( "Editor User Settings/Get Work Offline" )]
	class EditorUserSettingsWorkOfflineGet1 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserSettings.WorkOffline;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor User Settings/Set Work Offline" )]
	class EditorUserSettingsWorkOfflineSet1 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserSettings.WorkOffline = Value;
			yield break;
		}

	}

	[Automation( "Editor User Settings/Get Show Failed Checkout" )]
	class EditorUserSettingsshowFailedCheckoutGet2 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserSettings.showFailedCheckout;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor User Settings/Set Show Failed Checkout" )]
	class EditorUserSettingsshowFailedCheckoutSet2 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserSettings.showFailedCheckout = Value;
			yield break;
		}

	}

	[Automation( "Editor User Settings/Get Semantic Merge Mode" )]
	class EditorUserSettingssemanticMergeModeGet3 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.SemanticMergeMode Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserSettings.semanticMergeMode;
			yield break;
		}

	}

	[Automation( "Editor User Settings/Set Semantic Merge Mode" )]
	class EditorUserSettingssemanticMergeModeSet3 : Automation {

		public UnityEditor.SemanticMergeMode Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserSettings.semanticMergeMode = Value;
			yield break;
		}

	}

	[Automation( "Editor User Settings/Get Config Value" )]
	class EditorUserSettingsGetConfigValue0 : Automation {

		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUserSettings.GetConfigValue(name);
			yield break;
		}

	}

	[Automation( "Editor User Settings/Set Config Value" )]
	class EditorUserSettingsSetConfigValue1 : Automation {

		public System.String name;
		public System.String value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUserSettings.SetConfigValue(name,value);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif