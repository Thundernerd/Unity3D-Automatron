using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Asset Database/Contains" )]
	class AssetDatabaseContains0 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.Contains(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Create Folder" )]
	class AssetDatabaseCreateFolder1 : Automation {

		public System.String parentFolder;
		public System.String newFolderName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.CreateFolder(parentFolder,newFolderName);
			yield break;
		}

	}

	[Automation( "Asset Database/Is Main Asset" )]
	class AssetDatabaseIsMainAsset2 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsMainAsset(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Is Sub Asset" )]
	class AssetDatabaseIsSubAsset3 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsSubAsset(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Is Foreign Asset" )]
	class AssetDatabaseIsForeignAsset4 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsForeignAsset(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Is Native Asset" )]
	class AssetDatabaseIsNativeAsset5 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsNativeAsset(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Generate Unique Asset Path" )]
	class AssetDatabaseGenerateUniqueAssetPath6 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Start Asset Editing" )]
	class AssetDatabaseStartAssetEditing7 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.StartAssetEditing();
			yield break;
		}

	}

	[Automation( "Asset Database/Stop Asset Editing" )]
	class AssetDatabaseStopAssetEditing8 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.StopAssetEditing();
			yield break;
		}

	}

	[Automation( "Asset Database/Validate Move Asset" )]
	class AssetDatabaseValidateMoveAsset9 : Automation {

		public System.String oldPath;
		public System.String newPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.ValidateMoveAsset(oldPath,newPath);
			yield break;
		}

	}

	[Automation( "Asset Database/Move Asset" )]
	class AssetDatabaseMoveAsset10 : Automation {

		public System.String oldPath;
		public System.String newPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.MoveAsset(oldPath,newPath);
			yield break;
		}

	}

	[Automation( "Asset Database/Rename Asset" )]
	class AssetDatabaseRenameAsset11 : Automation {

		public System.String pathName;
		public System.String newName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.RenameAsset(pathName,newName);
			yield break;
		}

	}

	[Automation( "Asset Database/Move Asset To Trash" )]
	class AssetDatabaseMoveAssetToTrash12 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.MoveAssetToTrash(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Delete Asset" )]
	class AssetDatabaseDeleteAsset13 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.DeleteAsset(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Import Asset" )]
	class AssetDatabaseImportAsset14 : Automation {

		public System.String path;
		public UnityEditor.ImportAssetOptions options;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.ImportAsset(path,options);
			yield break;
		}

	}

	[Automation( "Asset Database/Copy Asset" )]
	class AssetDatabaseCopyAsset15 : ConditionalAutomation {

		public System.String path;
		public System.String newPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.CopyAsset(path,newPath);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Write Import Settings If Dirty" )]
	class AssetDatabaseWriteImportSettingsIfDirty16 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.WriteImportSettingsIfDirty(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Get Sub Folders" )]
	class AssetDatabaseGetSubFolders17 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetSubFolders(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Is Valid Folder" )]
	class AssetDatabaseIsValidFolder18 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsValidFolder(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Create Asset" )]
	class AssetDatabaseCreateAsset19 : Automation {

		public UnityEngine.Object asset;
		public System.String path;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.CreateAsset(asset,path);
			yield break;
		}

	}

	[Automation( "Asset Database/Add Object To Asset" )]
	class AssetDatabaseAddObjectToAsset20 : Automation {

		public UnityEngine.Object objectToAdd;
		public UnityEngine.Object assetObject;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.AddObjectToAsset(objectToAdd,assetObject);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Path" )]
	class AssetDatabaseGetAssetPath21 : Automation {

		public UnityEngine.Object assetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPath(assetObject);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Or Scene Path" )]
	class AssetDatabaseGetAssetOrScenePath22 : Automation {

		public UnityEngine.Object assetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetOrScenePath(assetObject);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Text Meta File Path From Asset Path" )]
	class AssetDatabaseGetTextMetaFilePathFromAssetPath23 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetTextMetaFilePathFromAssetPath(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Path From Text Meta File Path" )]
	class AssetDatabaseGetAssetPathFromTextMetaFilePath24 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPathFromTextMetaFilePath(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Load Asset At Path" )]
	class AssetDatabaseLoadAssetAtPath25 : Automation {

		public System.String assetPath;
        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.LoadAssetAtPath(assetPath,type);
			yield break;
		}

	}

	[Automation( "Asset Database/Load Main Asset At Path" )]
	class AssetDatabaseLoadMainAssetAtPath26 : Automation {

		public System.String assetPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.LoadMainAssetAtPath(assetPath);
			yield break;
		}

	}

	[Automation( "Asset Database/Load All Asset Representations At Path" )]
	class AssetDatabaseLoadAllAssetRepresentationsAtPath27 : Automation {

		public System.String assetPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.LoadAllAssetRepresentationsAtPath(assetPath);
			yield break;
		}

	}

	[Automation( "Asset Database/Load All Assets At Path" )]
	class AssetDatabaseLoadAllAssetsAtPath28 : Automation {

		public System.String assetPath;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.LoadAllAssetsAtPath(assetPath);
			yield break;
		}

	}

	[Automation( "Asset Database/Get All Asset Paths" )]
	class AssetDatabaseGetAllAssetPaths29 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAllAssetPaths();
			yield break;
		}

	}

	[Automation( "Asset Database/Refresh" )]
	class AssetDatabaseRefresh30 : Automation {

		public UnityEditor.ImportAssetOptions options;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.Refresh(options);
			yield break;
		}

	}

	[Automation( "Asset Database/Open Asset" )]
	class AssetDatabaseOpenAsset32 : ConditionalAutomation {

		public UnityEngine.Object target;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.OpenAsset(target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Asset Path To GUID" )]
	class AssetDatabaseAssetPathToGUID33 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.AssetPathToGUID(path);
			yield break;
		}

	}

	[Automation( "Asset Database/GUID To Asset Path" )]
	class AssetDatabaseGUIDToAssetPath34 : Automation {

		public System.String guid;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Dependency Hash" )]
	class AssetDatabaseGetAssetDependencyHash35 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Hash128 Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetDependencyHash(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Save Assets" )]
	class AssetDatabaseSaveAssets36 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.SaveAssets();
			yield break;
		}

	}

	[Automation( "Asset Database/Get Cached Icon" )]
	class AssetDatabaseGetCachedIcon37 : Automation {

		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetCachedIcon(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Set Labels" )]
	class AssetDatabaseSetLabels38 : Automation {

		public UnityEngine.Object obj;
		public System.String[] labels;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.SetLabels(obj,labels);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Labels" )]
	class AssetDatabaseGetLabels39 : Automation {

		public UnityEngine.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetLabels(obj);
			yield break;
		}

	}

	[Automation( "Asset Database/Clear Labels" )]
	class AssetDatabaseClearLabels40 : Automation {

		public UnityEngine.Object obj;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.ClearLabels(obj);
			yield break;
		}

	}

	[Automation( "Asset Database/Get All Asset Bundle Names" )]
	class AssetDatabaseGetAllAssetBundleNames41 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAllAssetBundleNames();
			yield break;
		}

	}

	[Automation( "Asset Database/Get Unused Asset Bundle Names" )]
	class AssetDatabaseGetUnusedAssetBundleNames42 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetUnusedAssetBundleNames();
			yield break;
		}

	}

	[Automation( "Asset Database/Remove Asset Bundle Name" )]
	class AssetDatabaseRemoveAssetBundleName43 : ConditionalAutomation {

		public System.String assetBundleName;
		public System.Boolean forceRemove;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.RemoveAssetBundleName(assetBundleName,forceRemove);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Remove Unused Asset Bundle Names" )]
	class AssetDatabaseRemoveUnusedAssetBundleNames44 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.RemoveUnusedAssetBundleNames();
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Paths From Asset Bundle" )]
	class AssetDatabaseGetAssetPathsFromAssetBundle45 : Automation {

		public System.String assetBundleName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Paths From Asset Bundle And Asset Name" )]
	class AssetDatabaseGetAssetPathsFromAssetBundleAndAssetName46 : Automation {

		public System.String assetBundleName;
		public System.String assetName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundleAndAssetName(assetBundleName,assetName);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Dependencies" )]
	class AssetDatabaseGetDependencies47 : Automation {

		public System.String[] pathNames;
		public System.Boolean recursive;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetDependencies(pathNames,recursive);
			yield break;
		}

	}

	[Automation( "Asset Database/Export Package" )]
	class AssetDatabaseExportPackage48 : Automation {

		public System.String[] assetPathNames;
		public System.String fileName;
		public UnityEditor.ExportPackageOptions flags;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.ExportPackage(assetPathNames,fileName,flags);
			yield break;
		}

	}

	[Automation( "Asset Database/Import Package" )]
	class AssetDatabaseImportPackage50 : Automation {

		public System.String packagePath;
		public System.Boolean interactive;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.ImportPackage(packagePath,interactive);
			yield break;
		}

	}

	[Automation( "Asset Database/Is Open For Edit" )]
	class AssetDatabaseIsOpenForEdit51 : ConditionalAutomation {

		public UnityEngine.Object assetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsOpenForEdit(assetObject);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Is Meta File Open For Edit" )]
	class AssetDatabaseIsMetaFileOpenForEdit52 : ConditionalAutomation {

		public UnityEngine.Object assetObject;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit(assetObject);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Get Builtin Extra Resource" )]
	class AssetDatabaseGetBuiltinExtraResource53 : Automation {

        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetBuiltinExtraResource(type,path);
			yield break;
		}

	}

	[Automation( "Asset Database/Find Assets" )]
	class AssetDatabaseFindAssets54 : Automation {

		public System.String filter;
		public System.String[] searchInFolders;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.FindAssets(filter,searchInFolders);
			yield break;
		}

	}


#pragma warning restore 0649
}
