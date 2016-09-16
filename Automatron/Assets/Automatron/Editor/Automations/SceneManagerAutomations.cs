using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Scene Manager/Get Scene Count" )]
	class SceneManagersceneCountGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.sceneCount;
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Scene Count In Build Settings" )]
	class SceneManagersceneCountInBuildSettingsGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Active Scene" )]
	class SceneManagerGetActiveScene0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
			yield break;
		}

	}

	[Automation( "Scene Manager/Set Active Scene" )]
	class SceneManagerSetActiveScene1 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene scene;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Scene Manager/Get Scene By Path" )]
	class SceneManagerGetSceneByPath2 : Automation {

		public System.String scenePath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.GetSceneByPath(scenePath);
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Scene By Name" )]
	class SceneManagerGetSceneByName3 : Automation {

		public System.String name;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name);
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Scene At" )]
	class SceneManagerGetSceneAt4 : Automation {

		public System.Int32 index;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index);
			yield break;
		}

	}

	[Automation( "Scene Manager/Load Scene" )]
	class SceneManagerLoadScene5 : Automation {

		public System.String sceneName;
		public UnityEngine.SceneManagement.LoadSceneMode mode;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName,mode);
			yield break;
		}

	}

	[Automation( "Scene Manager/Create Scene" )]
	class SceneManagerCreateScene6 : Automation {

		public System.String sceneName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.CreateScene(sceneName);
			yield break;
		}

	}

	[Automation( "Scene Manager/Unload Scene" )]
	class SceneManagerUnloadScene7 : ConditionalAutomation {

		public System.String sceneName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.UnloadScene(sceneName);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Scene Manager/Merge Scenes" )]
	class SceneManagerMergeScenes8 : Automation {

		public UnityEngine.SceneManagement.Scene sourceScene;
		public UnityEngine.SceneManagement.Scene destinationScene;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.MergeScenes(sourceScene,destinationScene);
			yield break;
		}

	}

	[Automation( "Scene Manager/Move Game Object To Scene" )]
	class SceneManagerMoveGameObjectToScene9 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.SceneManagement.Scene scene;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go,scene);
			yield break;
		}

	}


#pragma warning restore 0649
}
