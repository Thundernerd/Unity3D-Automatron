using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Utilities/Editor Utility/Reveal In Finder" )]
	class EditorUtilityRevealInFinder0 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.RevealInFinder(path);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Set Dirty" )]
	class EditorUtilitySetDirty1 : Automation {

		public UnityEngine.Object target;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.SetDirty(target);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Is Persistent" )]
	class EditorUtilityIsPersistent2 : ConditionalAutomation {

		public UnityEngine.Object target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.EditorUtility.IsPersistent(target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Editor Utility/Display Dialog" )]
	class EditorUtilityDisplayDialog3 : ConditionalAutomation {

		public System.String title;
		public System.String message;
		public System.String ok;
		public System.String cancel;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.EditorUtility.DisplayDialog(title,message,ok,cancel);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Editor Utility/Open File Panel" )]
	class EditorUtilityOpenFilePanel4 : Automation {

		public System.String title;
		public System.String directory;
		public System.String extension;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.OpenFilePanel(title,directory,extension);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Save File Panel" )]
	class EditorUtilitySaveFilePanel5 : Automation {

		public System.String title;
		public System.String directory;
		public System.String defaultName;
		public System.String extension;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.SaveFilePanel(title,directory,defaultName,extension);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Open Folder Panel" )]
	class EditorUtilityOpenFolderPanel6 : Automation {

		public System.String title;
		public System.String folder;
		public System.String defaultName;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.OpenFolderPanel(title,folder,defaultName);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Save Folder Panel" )]
	class EditorUtilitySaveFolderPanel7 : Automation {

		public System.String title;
		public System.String folder;
		public System.String defaultName;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.SaveFolderPanel(title,folder,defaultName);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Save File Panel In Project" )]
	class EditorUtilitySaveFilePanelInProject8 : Automation {

		public System.String title;
		public System.String defaultName;
		public System.String extension;
		public System.String message;
		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.SaveFilePanelInProject(title,defaultName,extension,message,path);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Warn Prefab" )]
	class EditorUtilityWarnPrefab9 : ConditionalAutomation {

		public UnityEngine.Object target;
		public System.String title;
		public System.String warning;
		public System.String okButton;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.EditorUtility.WarnPrefab(target,title,warning,okButton);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Editor Utility/Compress Texture" )]
	class EditorUtilityCompressTexture10 : Automation {

		public UnityEngine.Texture2D texture;
		public UnityEngine.TextureFormat format;
		public UnityEngine.TextureCompressionQuality quality;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.CompressTexture(texture,format,quality);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Copy Serialized" )]
	class EditorUtilityCopySerialized11 : Automation {

		public UnityEngine.Object source;
		public UnityEngine.Object dest;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.CopySerialized(source,dest);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Collect Dependencies" )]
	class EditorUtilityCollectDependencies12 : Automation {

		public UnityEngine.Object[] roots;
		[ReadOnly]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CollectDependencies(roots);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Collect Deep Hierarchy" )]
	class EditorUtilityCollectDeepHierarchy13 : Automation {

		public UnityEngine.Object[] roots;
		[ReadOnly]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CollectDeepHierarchy(roots);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Unload Unused Assets Immediate" )]
	class EditorUtilityUnloadUnusedAssetsImmediate14 : Automation {

		public System.Boolean ignoreReferencesFromScript;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate(ignoreReferencesFromScript);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Get Object Enabled" )]
	class EditorUtilityGetObjectEnabled15 : Automation {

		public UnityEngine.Object target;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.GetObjectEnabled(target);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Set Object Enabled" )]
	class EditorUtilitySetObjectEnabled16 : Automation {

		public UnityEngine.Object target;
		public System.Boolean enabled;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.SetObjectEnabled(target,enabled);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Extract Ogg File" )]
	class EditorUtilityExtractOggFile17 : ConditionalAutomation {

		public UnityEngine.Object obj;
		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.EditorUtility.ExtractOggFile(obj,path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Utilities/Editor Utility/Create Game Object With Hide Flags" )]
	class EditorUtilityCreateGameObjectWithHideFlags18 : Automation {

		public System.String name;
		public UnityEngine.HideFlags flags;
		public System.Type[] components;
		[ReadOnly]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CreateGameObjectWithHideFlags(name,flags,components);
			yield break;
		}

	}

	[Automation( "Utilities/Editor Utility/Open With Default App" )]
	class EditorUtilityOpenWithDefaultApp19 : Automation {

		public System.String fileName;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.OpenWithDefaultApp(fileName);
			yield break;
		}

	}


#pragma warning restore 0649
}
