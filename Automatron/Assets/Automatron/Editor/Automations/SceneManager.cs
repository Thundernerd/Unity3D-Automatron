using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Scene Manager/Get Scene Count" )]
	class SceneManagersceneCountGet0 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.sceneCount;
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Scene Count In Build Settings" )]
	class SceneManagersceneCountInBuildSettingsGet1 : Automation {

		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Active Scene" )]
	class SceneManagerGetActiveScene0 : Automation {

		[ReadOnly]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
			yield break;
		}

	}

	[Automation( "Scene Manager/Set Active Scene" )]
	class SceneManagerSetActiveScene1 : Automation {

		public UnityEngine.SceneManagement.Scene scene;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene);
			yield break;
		}

	}

	[Automation( "Scene Manager/Get Scene By Path" )]
	class SceneManagerGetSceneByPath2 : Automation {

		public System.String scenePath;
		[ReadOnly]
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
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index);
			yield break;
		}

	}

	[Automation( "Scene Manager/Load Scene" )]
	class SceneManagerLoadScene6 : Automation {

		public System.String sceneName;
		public UnityEngine.SceneManagement.LoadSceneMode mode;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName,mode);
			yield break;
		}

	}

	[Automation( "Scene Manager/Load Scene By ID" )]
	class SceneManagerLoadScene8 : Automation {

		public System.Int32 sceneBuildIndex;
		public UnityEngine.SceneManagement.LoadSceneMode mode;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex,mode);
			yield break;
		}

	}
    
	[Automation( "Scene Manager/Create Scene" )]
	class SceneManagerCreateScene13 : Automation {

		public System.String sceneName;
		[ReadOnly]
		public UnityEngine.SceneManagement.Scene Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.CreateScene(sceneName);
			yield break;
		}

	}

	[Automation( "Scene Manager/Unload Scene By ID" )]
	class SceneManagerUnloadScene14 : Automation {

		public System.Int32 sceneBuildIndex;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.UnloadScene(sceneBuildIndex);
			yield break;
		}

	}

	[Automation( "Scene Manager/Unload Scene" )]
	class SceneManagerUnloadScene15 : Automation {

		public System.String sceneName;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.SceneManagement.SceneManager.UnloadScene(sceneName);
			yield break;
		}

	}

	[Automation( "Scene Manager/Merge Scenes" )]
	class SceneManagerMergeScenes16 : Automation {

		public UnityEngine.SceneManagement.Scene sourceScene;
		public UnityEngine.SceneManagement.Scene destinationScene;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.MergeScenes(sourceScene,destinationScene);
			yield break;
		}

	}

	[Automation( "Scene Manager/Move Game Object To Scene" )]
	class SceneManagerMoveGameObjectToScene17 : Automation {

		public UnityEngine.GameObject go;
		public UnityEngine.SceneManagement.Scene scene;

		public override IEnumerator Execute() {
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(go,scene);
			yield break;
		}

	}


#pragma warning restore 0649
}
