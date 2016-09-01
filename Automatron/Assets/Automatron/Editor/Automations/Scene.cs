using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Scene/Get Path" )]
	class ScenepathGet0 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.path;
			yield break;
		}

	}

	[Automation( "Scene/Get Name" )]
	class ScenenameGet1 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.name;
			yield break;
		}

	}

	[Automation( "Scene/Get Is Loaded" )]
	class SceneisLoadedGet2 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isLoaded;
			yield break;
		}

	}

	[Automation( "Scene/Get Build Index" )]
	class ScenebuildIndexGet3 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.buildIndex;
			yield break;
		}

	}

	[Automation( "Scene/Get Is Dirty" )]
	class SceneisDirtyGet4 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.isDirty;
			yield break;
		}

	}

	[Automation( "Scene/Get Root Count" )]
	class ScenerootCountGet5 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.rootCount;
			yield break;
		}

	}

	[Automation( "Generated/Scene/Is Valid" )]
	class SceneIsValid0 : ConditionalAutomation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsValid();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Scene/Get Root Game Objects" )]
	class SceneGetRootGameObjects1 : Automation {

		public UnityEngine.SceneManagement.Scene Instance;
		[ReadOnly]
		public UnityEngine.GameObject[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetRootGameObjects();
			yield break;
		}

	}


#pragma warning restore 0649
}
