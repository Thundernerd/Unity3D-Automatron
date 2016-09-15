using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Build Settings Scene/Get Enabled" )]
	class EditorBuildSettingsSceneenabledGet0 : ConditionalAutomation {

		public UnityEditor.EditorBuildSettingsScene Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.enabled;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Build Settings Scene/Set Enabled" )]
	class EditorBuildSettingsSceneenabledSet0 : Automation {

		public UnityEditor.EditorBuildSettingsScene Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.enabled = Value;
			yield break;
		}

	}

	[Automation( "Editor Build Settings Scene/Get Path" )]
	class EditorBuildSettingsScenepathGet1 : Automation {

		public UnityEditor.EditorBuildSettingsScene Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.path;
			yield break;
		}

	}

	[Automation( "Editor Build Settings Scene/Set Path" )]
	class EditorBuildSettingsScenepathSet1 : Automation {

		public UnityEditor.EditorBuildSettingsScene Instance;
		public System.String Value;

		public override IEnumerator Execute() {
			Instance.path = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}
