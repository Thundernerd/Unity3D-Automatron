#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Build Settings/Get Scenes" )]
	class EditorBuildSettingsscenesGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.EditorBuildSettingsScene[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorBuildSettings.scenes;
			yield break;
		}

	}

	[Automation( "Editor Build Settings/Set Scenes" )]
	class EditorBuildSettingsscenesSet0 : Automation {

		public UnityEditor.EditorBuildSettingsScene[] Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorBuildSettings.scenes = Value;
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif