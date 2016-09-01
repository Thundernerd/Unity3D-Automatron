using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Editor Scene Manager/Get Loaded Scene Count" )]
	class EditorSceneManagerloadedSceneCountGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.loadedSceneCount;
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Open Scene" )]
	class EditorSceneManagerOpenScene0 : Automation {

		public System.String scenePath;
		public UnityEditor.SceneManagement.OpenSceneMode mode;
		[ReadOnly]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.OpenScene(scenePath,mode);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/New Scene" )]
	class EditorSceneManagerNewScene2 : Automation {

		public UnityEditor.SceneManagement.NewSceneSetup setup;
		public UnityEditor.SceneManagement.NewSceneMode mode;
		[ReadOnly]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.NewScene(setup,mode);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Close Scene" )]
	class EditorSceneManagerCloseScene4 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		public System.Boolean removeScene;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.CloseScene(scene,removeScene);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Move Scene Before" )]
	class EditorSceneManagerMoveSceneBefore5 : Automation {

		public UnityEngine.SceneManagement.Scene src;
		public UnityEngine.SceneManagement.Scene dst;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.MoveSceneBefore(src,dst);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Move Scene After" )]
	class EditorSceneManagerMoveSceneAfter6 : Automation {

		public UnityEngine.SceneManagement.Scene src;
		public UnityEngine.SceneManagement.Scene dst;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.MoveSceneAfter(src,dst);
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Save Scene" )]
	class EditorSceneManagerSaveScene7 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		public System.String dstScenePath;
		public System.Boolean saveAsCopy;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveScene(scene,dstScenePath,saveAsCopy);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Open Scenes" )]
	class EditorSceneManagerSaveOpenScenes10 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveOpenScenes();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Scenes" )]
	class EditorSceneManagerSaveScenes11 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene[] scenes;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveScenes(scenes);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Current Modified Scenes If User Wants To" )]
	class EditorSceneManagerSaveCurrentModifiedScenesIfUserWantsTo12 : ConditionalAutomation {

		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Save Modified Scenes If User Wants To" )]
	class EditorSceneManagerSaveModifiedScenesIfUserWantsTo13 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene[] scenes;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.SaveModifiedScenesIfUserWantsTo(scenes);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Mark Scene Dirty" )]
	class EditorSceneManagerMarkSceneDirty14 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.MarkSceneDirty(scene);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Scene Manager/Mark All Scenes Dirty" )]
	class EditorSceneManagerMarkAllScenesDirty15 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.MarkAllScenesDirty();
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Get Scene Manager Setup" )]
	class EditorSceneManagerGetSceneManagerSetup16 : Automation {

		[ReadOnly]
		public UnityEditor.SceneManagement.SceneSetup[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.SceneManagement.EditorSceneManager.GetSceneManagerSetup();
			yield break;
		}

	}

	[Automation( "Editor Scene Manager/Restore Scene Manager Setup" )]
	class EditorSceneManagerRestoreSceneManagerSetup17 : Automation {

		public UnityEditor.SceneManagement.SceneSetup[] value;

		public override IEnumerator Execute() {
			UnityEditor.SceneManagement.EditorSceneManager.RestoreSceneManagerSetup(value);
			yield break;
		}

	}


#pragma warning restore 0649
}
