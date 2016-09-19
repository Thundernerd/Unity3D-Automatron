#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Editor Utility/Get Audio Master Mute" )]
	class EditorUtilityaudioMasterMuteGet0 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.audioMasterMute;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Set Audio Master Mute" )]
	class EditorUtilityaudioMasterMuteSet0 : Automation {

		public System.Boolean Value;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.audioMasterMute = Value;
			yield break;
		}

	}

	[Automation( "Editor Utility/Reveal In Finder" )]
	class EditorUtilityRevealInFinder0 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.RevealInFinder(path);
			yield break;
		}

	}

	[Automation( "Editor Utility/Set Dirty" )]
	class EditorUtilitySetDirty1 : Automation {

		public UnityEngine.Object target;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.SetDirty(target);
			yield break;
		}

	}

	[Automation( "Editor Utility/Load Window Layout" )]
	class EditorUtilityLoadWindowLayout2 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.LoadWindowLayout(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Is Persistent" )]
	class EditorUtilityIsPersistent3 : ConditionalAutomation {

		public UnityEngine.Object target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.IsPersistent(target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Display Dialog" )]
	class EditorUtilityDisplayDialog4 : ConditionalAutomation {

		public System.String title;
		public System.String message;
		public System.String ok;
		public System.String cancel;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.DisplayDialog(title,message,ok,cancel);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Display Dialog Complex" )]
	class EditorUtilityDisplayDialogComplex5 : Automation {

		public System.String title;
		public System.String message;
		public System.String ok;
		public System.String cancel;
		public System.String alt;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.DisplayDialogComplex(title,message,ok,cancel,alt);
			yield break;
		}

	}

	[Automation( "Editor Utility/Open File Panel" )]
	class EditorUtilityOpenFilePanel6 : Automation {

		public System.String title;
		public System.String directory;
		public System.String extension;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.OpenFilePanel(title,directory,extension);
			yield break;
		}

	}

	[Automation( "Editor Utility/Open File Panel With Filters" )]
	class EditorUtilityOpenFilePanelWithFilters7 : Automation {

		public System.String title;
		public System.String directory;
		public System.String[] filters;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.OpenFilePanelWithFilters(title,directory,filters);
			yield break;
		}

	}

	[Automation( "Editor Utility/Save File Panel" )]
	class EditorUtilitySaveFilePanel8 : Automation {

		public System.String title;
		public System.String directory;
		public System.String defaultName;
		public System.String extension;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.SaveFilePanel(title,directory,defaultName,extension);
			yield break;
		}

	}

	[Automation( "Editor Utility/Open Folder Panel" )]
	class EditorUtilityOpenFolderPanel9 : Automation {

		public System.String title;
		public System.String folder;
		public System.String defaultName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.OpenFolderPanel(title,folder,defaultName);
			yield break;
		}

	}

	[Automation( "Editor Utility/Save Folder Panel" )]
	class EditorUtilitySaveFolderPanel10 : Automation {

		public System.String title;
		public System.String folder;
		public System.String defaultName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.SaveFolderPanel(title,folder,defaultName);
			yield break;
		}

	}

	[Automation( "Editor Utility/Save File Panel In Project" )]
	class EditorUtilitySaveFilePanelInProject11 : Automation {

		public System.String title;
		public System.String defaultName;
		public System.String extension;
		public System.String message;
		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.SaveFilePanelInProject(title,defaultName,extension,message,path);
			yield break;
		}

	}

	[Automation( "Editor Utility/Warn Prefab" )]
	class EditorUtilityWarnPrefab12 : ConditionalAutomation {

		public UnityEngine.Object target;
		public System.String title;
		public System.String warning;
		public System.String okButton;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.WarnPrefab(target,title,warning,okButton);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Compress Texture" )]
	class EditorUtilityCompressTexture13 : Automation {

		public UnityEngine.Texture2D texture;
		public UnityEngine.TextureFormat format;
		public UnityEngine.TextureCompressionQuality quality;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.CompressTexture(texture,format,quality);
			yield break;
		}

	}

	[Automation( "Editor Utility/Invoke Diff Tool" )]
	class EditorUtilityInvokeDiffTool14 : Automation {

		public System.String leftTitle;
		public System.String leftFile;
		public System.String rightTitle;
		public System.String rightFile;
		public System.String ancestorTitle;
		public System.String ancestorFile;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.InvokeDiffTool(leftTitle,leftFile,rightTitle,rightFile,ancestorTitle,ancestorFile);
			yield break;
		}

	}

	[Automation( "Editor Utility/Copy Serialized" )]
	class EditorUtilityCopySerialized15 : Automation {

		public UnityEngine.Object source;
		public UnityEngine.Object dest;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.CopySerialized(source,dest);
			yield break;
		}

	}

	[Automation( "Editor Utility/Copy Serialized If Different" )]
	class EditorUtilityCopySerializedIfDifferent16 : Automation {

		public UnityEngine.Object source;
		public UnityEngine.Object dest;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.CopySerializedIfDifferent(source,dest);
			yield break;
		}

	}

	[Automation( "Editor Utility/Collect Dependencies" )]
	class EditorUtilityCollectDependencies17 : Automation {

		public UnityEngine.Object[] roots;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CollectDependencies(roots);
			yield break;
		}

	}

	[Automation( "Editor Utility/Collect Deep Hierarchy" )]
	class EditorUtilityCollectDeepHierarchy18 : Automation {

		public UnityEngine.Object[] roots;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CollectDeepHierarchy(roots);
			yield break;
		}

	}

	[Automation( "Editor Utility/Unload Unused Assets Immediate" )]
	class EditorUtilityUnloadUnusedAssetsImmediate20 : Automation {

		public System.Boolean includeMonoReferencesAsRoots;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.UnloadUnusedAssetsImmediate(includeMonoReferencesAsRoots);
			yield break;
		}

	}

	[Automation( "Editor Utility/Display Popup Menu" )]
	class EditorUtilityDisplayPopupMenu21 : Automation {

		public UnityEngine.Rect position;
		public System.String menuItemPath;
		public UnityEditor.MenuCommand command;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.DisplayPopupMenu(position,menuItemPath,command);
			yield break;
		}

	}

	[Automation( "Editor Utility/Display Custom Menu" )]
	class EditorUtilityDisplayCustomMenu22 : Automation {

		public UnityEngine.Rect position;
		public UnityEngine.GUIContent[] options;
		public System.Int32 selected;
		public UnityEditor.EditorUtility.SelectMenuItemFunction callback;
		public System.Object userData;
		public System.Boolean showHotkey;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.DisplayCustomMenu(position,options,selected,callback,userData,showHotkey);
			yield break;
		}

	}

	[Automation( "Editor Utility/Focus Project Window" )]
	class EditorUtilityFocusProjectWindow23 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.FocusProjectWindow();
			yield break;
		}

	}

	[Automation( "Editor Utility/Display Progress Bar" )]
	class EditorUtilityDisplayProgressBar24 : Automation {

		public System.String title;
		public System.String info;
		public System.Single progress;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.DisplayProgressBar(title,info,progress);
			yield break;
		}

	}

	[Automation( "Editor Utility/Display Cancelable Progress Bar" )]
	class EditorUtilityDisplayCancelableProgressBar25 : ConditionalAutomation {

		public System.String title;
		public System.String info;
		public System.Single progress;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.DisplayCancelableProgressBar(title,info,progress);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Clear Progress Bar" )]
	class EditorUtilityClearProgressBar26 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.ClearProgressBar();
			yield break;
		}

	}

	[Automation( "Editor Utility/Get Object Enabled" )]
	class EditorUtilityGetObjectEnabled27 : Automation {

		public UnityEngine.Object target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.GetObjectEnabled(target);
			yield break;
		}

	}

	[Automation( "Editor Utility/Set Object Enabled" )]
	class EditorUtilitySetObjectEnabled28 : Automation {

		public UnityEngine.Object target;
		public System.Boolean enabled;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.SetObjectEnabled(target,enabled);
			yield break;
		}

	}

	[Automation( "Editor Utility/Set Selected Wireframe Hidden" )]
	class EditorUtilitySetSelectedWireframeHidden29 : Automation {

		public UnityEngine.Renderer renderer;
		public System.Boolean enabled;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.SetSelectedWireframeHidden(renderer,enabled);
			yield break;
		}

	}

	[Automation( "Editor Utility/Extract Ogg File" )]
	class EditorUtilityExtractOggFile30 : ConditionalAutomation {

		public UnityEngine.Object obj;
		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.ExtractOggFile(obj,path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Editor Utility/Create Game Object With Hide Flags" )]
	class EditorUtilityCreateGameObjectWithHideFlags31 : Automation {

		public System.String name;
		public UnityEngine.HideFlags flags;
		public System.Type[] components;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.GameObject Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CreateGameObjectWithHideFlags(name,flags,components);
			yield break;
		}

	}

	[Automation( "Editor Utility/Compile C Sharp" )]
	class EditorUtilityCompileCSharp32 : Automation {

		public System.String[] sources;
		public System.String[] references;
		public System.String[] defines;
		public System.String outputFile;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.EditorUtility.CompileCSharp(sources,references,defines,outputFile);
			yield break;
		}

	}

	[Automation( "Editor Utility/Open With Default App" )]
	class EditorUtilityOpenWithDefaultApp33 : Automation {

		public System.String fileName;

		public override IEnumerator Execute() {
			UnityEditor.EditorUtility.OpenWithDefaultApp(fileName);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif