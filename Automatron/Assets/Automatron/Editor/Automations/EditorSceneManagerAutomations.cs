using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Scene Manager/Get Loaded Scene Count" )]
	class EditorSceneManagerloadedSceneCountGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.loadedSceneCount;
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Get Prevent Cross Scene References" )]
	class EditorSceneManagerpreventCrossSceneReferencesGet1 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Set Prevent Cross Scene References" )]
	class EditorSceneManagerpreventCrossSceneReferencesSet1 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.preventCrossSceneReferences = Value;
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Open Scene" )]
	class EditorSceneManagerOpenScene0 : Automation {

		public System.String scenePath;
		public UnityEditor.SceneManagement.OpenSceneMode mode;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.OpenScene(scenePath,mode);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/New Scene" )]
	class EditorSceneManagerNewScene1 : Automation {

		public UnityEditor.SceneManagement.NewSceneSetup setup;
		public UnityEditor.SceneManagement.NewSceneMode mode;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.NewScene(setup,mode);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Close Scene" )]
	class EditorSceneManagerCloseScene2 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		public System.Boolean removeScene;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,removeScene);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Move Scene Before" )]
	class EditorSceneManagerMoveSceneBefore3 : Automation {

		public UnityEngine.SceneManagement.Scene src;
		public UnityEngine.SceneManagement.Scene dst;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.MoveSceneBefore(src,dst);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Move Scene After" )]
	class EditorSceneManagerMoveSceneAfter4 : Automation {

		public UnityEngine.SceneManagement.Scene src;
		public UnityEngine.SceneManagement.Scene dst;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.MoveSceneAfter(src,dst);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Save Scene" )]
	class EditorSceneManagerSaveScene5 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		public System.String dstScenePath;
		public System.Boolean saveAsCopy;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveScene(scene,dstScenePath,saveAsCopy);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Open Scenes" )]
	class EditorSceneManagerSaveOpenScenes6 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveOpenScenes();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Scenes" )]
	class EditorSceneManagerSaveScenes7 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene[] scenes;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveScenes(scenes);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Current Modified Scenes If User Wants To" )]
	class EditorSceneManagerSaveCurrentModifiedScenesIfUserWantsTo8 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Modified Scenes If User Wants To" )]
	class EditorSceneManagerSaveModifiedScenesIfUserWantsTo9 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene[] scenes;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveModifiedScenesIfUserWantsTo(scenes);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Mark Scene Dirty" )]
	class EditorSceneManagerMarkSceneDirty10 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(scene);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Mark All Scenes Dirty" )]
	class EditorSceneManagerMarkAllScenesDirty11 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.MarkAllScenesDirty();
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Get Scene Manager Setup" )]
	class EditorSceneManagerGetSceneManagerSetup12 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEditor.SceneManagement.SceneSetup[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.GetSceneManagerSetup();
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Restore Scene Manager Setup" )]
	class EditorSceneManagerRestoreSceneManagerSetup13 : Automation {

		public UnityEditor.SceneManagement.SceneSetup[] value;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.RestoreSceneManagerSetup(value);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Detect Cross Scene References" )]
	class EditorSceneManagerDetectCrossSceneReferences14 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.DetectCrossSceneReferences(scene);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
