using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsupported/Capture Screenshot Immediate" )]
	class UnsupportedCaptureScreenshotImmediate0 : Automation {

		public System.String filePath;
		public System.Int32 x;
		public System.Int32 y;
		public System.Int32 width;
		public System.Int32 height;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.CaptureScreenshotImmediate(filePath,x,y,width,height);
			yield break;
		}

	}

	[Automation( "Unsupported/Get Submenus Commands" )]
	class UnsupportedGetSubmenusCommands1 : Automation {

		public System.String menuPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetSubmenusCommands(menuPath);
			yield break;
		}

	}

	[Automation( "Unsupported/Get Type From Full Name" )]
	class UnsupportedGetTypeFromFullName2 : Automation {

		public System.String fullName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Type Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetTypeFromFullName(fullName);
			yield break;
		}

	}

	[Automation( "Unsupported/Get Submenus" )]
	class UnsupportedGetSubmenus3 : Automation {

		public System.String menuPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetSubmenus(menuPath);
			yield break;
		}

	}

	[Automation( "Unsupported/Get Submenus Including Separators" )]
	class UnsupportedGetSubmenusIncludingSeparators4 : Automation {

		public System.String menuPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetSubmenusIncludingSeparators(menuPath);
			yield break;
		}

	}

	[Automation( "Unsupported/Prepare Object Context Menu" )]
	class UnsupportedPrepareObjectContextMenu5 : Automation {

		public UnityEngine.Object c;
		public System.Int32 contextUserData;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.PrepareObjectContextMenu(c,contextUserData);
			yield break;
		}

	}

	[Automation( "Unsupported/Is Developer Build" )]
	class UnsupportedIsDeveloperBuild6 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.IsDeveloperBuild();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Is Bleeding Edge Build" )]
	class UnsupportedIsBleedingEdgeBuild7 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.IsBleedingEdgeBuild();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Is Destroy Scriptable Object" )]
	class UnsupportedIsDestroyScriptableObject8 : ConditionalAutomation {

		public UnityEngine.ScriptableObject target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.IsDestroyScriptableObject(target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Is Native Code Built In Release Mode" )]
	class UnsupportedIsNativeCodeBuiltInReleaseMode9 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.IsNativeCodeBuiltInReleaseMode();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Get Base Unity Developer Folder" )]
	class UnsupportedGetBaseUnityDeveloperFolder10 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetBaseUnityDeveloperFolder();
			yield break;
		}

	}

	[Automation( "Unsupported/Stop Playing Immediately" )]
	class UnsupportedStopPlayingImmediately11 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.StopPlayingImmediately();
			yield break;
		}

	}

	[Automation( "Unsupported/Scene Tracker Flush Dirty" )]
	class UnsupportedSceneTrackerFlushDirty12 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SceneTrackerFlushDirty();
			yield break;
		}

	}

	[Automation( "Unsupported/Set Allow Cursor Hide" )]
	class UnsupportedSetAllowCursorHide13 : Automation {

		public System.Boolean allow;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SetAllowCursorHide(allow);
			yield break;
		}

	}

	[Automation( "Unsupported/Set Allow Cursor Lock" )]
	class UnsupportedSetAllowCursorLock14 : Automation {

		public System.Boolean allow;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SetAllowCursorLock(allow);
			yield break;
		}

	}

	[Automation( "Unsupported/Set Render Settings Use Fog No Dirty" )]
	class UnsupportedSetRenderSettingsUseFogNoDirty15 : Automation {

		public System.Boolean fog;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SetRenderSettingsUseFogNoDirty(fog);
			yield break;
		}

	}

	[Automation( "Unsupported/Set Quality Settings Shadow Distance Temporarily" )]
	class UnsupportedSetQualitySettingsShadowDistanceTemporarily16 : Automation {

		public System.Single distance;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SetQualitySettingsShadowDistanceTemporarily(distance);
			yield break;
		}

	}

	[Automation( "Unsupported/Delete Game Object Selection" )]
	class UnsupportedDeleteGameObjectSelection17 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.DeleteGameObjectSelection();
			yield break;
		}

	}

	[Automation( "Unsupported/Copy Game Objects To Pasteboard" )]
	class UnsupportedCopyGameObjectsToPasteboard18 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.CopyGameObjectsToPasteboard();
			yield break;
		}

	}

	[Automation( "Unsupported/Paste Game Objects From Pasteboard" )]
	class UnsupportedPasteGameObjectsFromPasteboard19 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.PasteGameObjectsFromPasteboard();
			yield break;
		}

	}

	[Automation( "Unsupported/Get Serialized Asset Interface Singleton" )]
	class UnsupportedGetSerializedAssetInterfaceSingleton20 : Automation {

		public System.String className;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetSerializedAssetInterfaceSingleton(className);
			yield break;
		}

	}

	[Automation( "Unsupported/Duplicate Game Objects Using Pasteboard" )]
	class UnsupportedDuplicateGameObjectsUsingPasteboard21 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.DuplicateGameObjectsUsingPasteboard();
			yield break;
		}

	}

	[Automation( "Unsupported/Copy Component To Pasteboard" )]
	class UnsupportedCopyComponentToPasteboard22 : ConditionalAutomation {

		public UnityEngine.Component component;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.CopyComponentToPasteboard(component);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Paste Component From Pasteboard" )]
	class UnsupportedPasteComponentFromPasteboard23 : ConditionalAutomation {

		public UnityEngine.GameObject go;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.PasteComponentFromPasteboard(go);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Paste Component Values From Pasteboard" )]
	class UnsupportedPasteComponentValuesFromPasteboard24 : ConditionalAutomation {

		public UnityEngine.Component component;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.PasteComponentValuesFromPasteboard(component);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Copy State Machine Data To Pasteboard" )]
	class UnsupportedCopyStateMachineDataToPasteboard25 : Automation {

		public UnityEngine.Object[] stateMachineObjects;
		public UnityEngine.Vector3[] monoPositions;
		public UnityEditor.Animations.AnimatorController controller;
		public System.Int32 layerIndex;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.CopyStateMachineDataToPasteboard(stateMachineObjects,monoPositions,controller,layerIndex);
			yield break;
		}

	}

	[Automation( "Unsupported/Paste To State Machine From Pasteboard" )]
	class UnsupportedPasteToStateMachineFromPasteboard26 : Automation {

		public UnityEditor.Animations.AnimatorStateMachine sm;
		public UnityEditor.Animations.AnimatorController controller;
		public System.Int32 layerIndex;
		public UnityEngine.Vector3 position;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.PasteToStateMachineFromPasteboard(sm,controller,layerIndex,position);
			yield break;
		}

	}

	[Automation( "Unsupported/Has State Machine Data In Pasteboard" )]
	class UnsupportedHasStateMachineDataInPasteboard27 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.HasStateMachineDataInPasteboard();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Smart Reset" )]
	class UnsupportedSmartReset28 : Automation {

		public UnityEngine.Object obj;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SmartReset(obj);
			yield break;
		}

	}

	[Automation( "Unsupported/Resolve Symlinks" )]
	class UnsupportedResolveSymlinks29 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.ResolveSymlinks(path);
			yield break;
		}

	}

	[Automation( "Unsupported/Set Application Setting Compress Assets On Import" )]
	class UnsupportedSetApplicationSettingCompressAssetsOnImport30 : Automation {

		public System.Boolean value;

		public override IEnumerator Execute() {
			UnityEditor.Unsupported.SetApplicationSettingCompressAssetsOnImport(value);
			yield break;
		}

	}

	[Automation( "Unsupported/Get Application Setting Compress Assets On Import" )]
	class UnsupportedGetApplicationSettingCompressAssetsOnImport31 : ConditionalAutomation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetApplicationSettingCompressAssetsOnImport();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Get Local Identifier In File" )]
	class UnsupportedGetLocalIdentifierInFile32 : Automation {

		public System.Int32 instanceID;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.GetLocalIdentifierInFile(instanceID);
			yield break;
		}

	}

	[Automation( "Unsupported/Is Hidden File" )]
	class UnsupportedIsHiddenFile33 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.Unsupported.IsHiddenFile(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Unsupported/Clear Skin Cache" )]
	class UnsupportedClearSkinCache34 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.Unsupported.ClearSkinCache();
			yield break;
		}

	}


#pragma warning restore 0649
}
