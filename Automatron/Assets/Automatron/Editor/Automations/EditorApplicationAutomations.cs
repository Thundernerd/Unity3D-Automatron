#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Application/Get Is Playing" )]
	class EditorApplicationisPlayingGet0 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.isPlaying;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Set Is Playing" )]
	class EditorApplicationisPlayingSet0 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.isPlaying = Value;
			yield break;
		}

	}

	[Automation( "Editor Application/Get Is Playing Or Will Change Playmode" )]
	class EditorApplicationisPlayingOrWillChangePlaymodeGet1 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Get Is Paused" )]
	class EditorApplicationisPausedGet2 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.isPaused;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Set Is Paused" )]
	class EditorApplicationisPausedSet2 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.isPaused = Value;
			yield break;
		}

	}

	[Automation( "Editor Application/Get Is Compiling" )]
	class EditorApplicationisCompilingGet3 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.isCompiling;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Get Is Updating" )]
	class EditorApplicationisUpdatingGet4 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.isUpdating;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Get Is Remote Connected" )]
	class EditorApplicationisRemoteConnectedGet5 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.isRemoteConnected;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Get Application Contents Path" )]
	class EditorApplicationapplicationContentsPathGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.applicationContentsPath;
			yield break;
		}

	}

	[Automation( "Editor Application/Get Application Path" )]
	class EditorApplicationapplicationPathGet7 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.applicationPath;
			yield break;
		}

	}

	[Automation( "Editor Application/Get Time Since Startup" )]
	class EditorApplicationtimeSinceStartupGet8 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.timeSinceStartup;
			yield break;
		}

	}

	[Automation( "Editor Application/Load Level In Play Mode" )]
	class EditorApplicationLoadLevelInPlayMode0 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.LoadLevelInPlayMode(path);
			yield break;
		}

	}

	[Automation( "Editor Application/Load Level Additive In Play Mode" )]
	class EditorApplicationLoadLevelAdditiveInPlayMode1 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.LoadLevelAdditiveInPlayMode(path);
			yield break;
		}

	}

	[Automation( "Editor Application/Open Project" )]
	class EditorApplicationOpenProject2 : Automation {

		public System.String projectPath;
		public System.String[] args;

		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.OpenProject(projectPath,args);
			yield break;
		}

	}

	[Automation( "Editor Application/Save Assets" )]
	class EditorApplicationSaveAssets3 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.SaveAssets();
			yield break;
		}

	}

	[Automation( "Editor Application/Step" )]
	class EditorApplicationStep4 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.Step();
			yield break;
		}

	}

	[Automation( "Editor Application/Lock Reload Assemblies" )]
	class EditorApplicationLockReloadAssemblies5 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.LockReloadAssemblies();
			yield break;
		}

	}

	[Automation( "Editor Application/Execute Menu Item" )]
	class EditorApplicationExecuteMenuItem6 : ConditionalAutomation {

		public System.String menuItemPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorApplication.ExecuteMenuItem(menuItemPath);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Application/Unlock Reload Assemblies" )]
	class EditorApplicationUnlockReloadAssemblies7 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.UnlockReloadAssemblies();
			yield break;
		}

	}

	[Automation( "Editor Application/Exit" )]
	class EditorApplicationExit8 : Automation {

		public System.Int32 returnValue;

		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.Exit(returnValue);
			yield break;
		}

	}

	[Automation( "Editor Application/Repaint Project Window" )]
	class EditorApplicationRepaintProjectWindow9 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.RepaintProjectWindow();
			yield break;
		}

	}

	[Automation( "Editor Application/Repaint Animation Window" )]
	class EditorApplicationRepaintAnimationWindow10 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.RepaintAnimationWindow();
			yield break;
		}

	}

	[Automation( "Editor Application/Repaint Hierarchy Window" )]
	class EditorApplicationRepaintHierarchyWindow11 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.RepaintHierarchyWindow();
			yield break;
		}

	}

	[Automation( "Editor Application/Dirty Hierarchy Window Sorting" )]
	class EditorApplicationDirtyHierarchyWindowSorting12 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.DirtyHierarchyWindowSorting();
			yield break;
		}

	}

	[Automation( "Editor Application/Beep" )]
	class EditorApplicationBeep13 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorApplication.Beep();
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif