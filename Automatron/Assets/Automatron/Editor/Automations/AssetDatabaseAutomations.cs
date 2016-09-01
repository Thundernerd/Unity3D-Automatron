using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Asset Database/Contains" )]
	class AssetDatabaseContains0 : ConditionalAutomation {

		public UnityEngine.Object obj;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
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
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPathFromTextMetaFilePath(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Load Asset At Path" )]
	class AssetDatabaseLoadAssetAtPath25 : Automation {

		public System.String assetPath;
		public System.Type type;
		[ReadOnly]
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
		public UnityEngine.Object[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.LoadAllAssetsAtPath(assetPath);
			yield break;
		}

	}

	[Automation( "Asset Database/Get All Asset Paths" )]
	class AssetDatabaseGetAllAssetPaths29 : Automation {

		[ReadOnly]
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
	class AssetDatabaseOpenAsset31 : ConditionalAutomation {

		public UnityEngine.Object target;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AssetDatabase.OpenAsset(target);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Open Assets" )]
	class AssetDatabaseOpenAsset32 : ConditionalAutomation {

		public UnityEngine.Object[] objects;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AssetDatabase.OpenAsset(objects);
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
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
			yield break;
		}

	}

	[Automation( "Asset Database/Save Assets" )]
	class AssetDatabaseSaveAssets35 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.SaveAssets();
			yield break;
		}

	}

	[Automation( "Asset Database/Get Cached Icon" )]
	class AssetDatabaseGetCachedIcon36 : Automation {

		public System.String path;
		[ReadOnly]
		public UnityEngine.Texture Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetCachedIcon(path);
			yield break;
		}

	}

	[Automation( "Asset Database/Set Labels" )]
	class AssetDatabaseSetLabels37 : Automation {

		public UnityEngine.Object obj;
		public System.String[] labels;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.SetLabels(obj,labels);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Labels" )]
	class AssetDatabaseGetLabels38 : Automation {

		public UnityEngine.Object obj;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetLabels(obj);
			yield break;
		}

	}

	[Automation( "Asset Database/Clear Labels" )]
	class AssetDatabaseClearLabels39 : Automation {

		public UnityEngine.Object obj;

		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.ClearLabels(obj);
			yield break;
		}

	}

	[Automation( "Asset Database/Get All Asset Bundle Names" )]
	class AssetDatabaseGetAllAssetBundleNames40 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAllAssetBundleNames();
			yield break;
		}

	}

	[Automation( "Asset Database/Get Unused Asset Bundle Names" )]
	class AssetDatabaseGetUnusedAssetBundleNames41 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetUnusedAssetBundleNames();
			yield break;
		}

	}

	[Automation( "Asset Database/Remove Asset Bundle Name" )]
	class AssetDatabaseRemoveAssetBundleName42 : ConditionalAutomation {

		public System.String assetBundleName;
		public System.Boolean forceRemove;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AssetDatabase.RemoveAssetBundleName(assetBundleName,forceRemove);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Remove Unused Asset Bundle Names" )]
	class AssetDatabaseRemoveUnusedAssetBundleNames43 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.AssetDatabase.RemoveUnusedAssetBundleNames();
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Paths From Asset Bundle" )]
	class AssetDatabaseGetAssetPathsFromAssetBundle44 : Automation {

		public System.String assetBundleName;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Asset Paths From Asset Bundle And Asset Name" )]
	class AssetDatabaseGetAssetPathsFromAssetBundleAndAssetName45 : Automation {

		public System.String assetBundleName;
		public System.String assetName;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundleAndAssetName(assetBundleName,assetName);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Dependencies" )]
	class AssetDatabaseGetDependencies46 : Automation {

		public System.String pathName;
		public System.Boolean recursive;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetDependencies(pathName,recursive);
			yield break;
		}

	}

	[Automation( "Asset Database/Get Dependencies (Multiple)" )]
	class AssetDatabaseGetDependencies47 : Automation {

		public System.String[] pathNames;
		public System.Boolean recursive;
		[ReadOnly]
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

	[Automation( "Asset Database/Is Open For Edit" )]
	class AssetDatabaseIsOpenForEdit49 : ConditionalAutomation {

		public UnityEngine.Object assetObject;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AssetDatabase.IsOpenForEdit(assetObject);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Is Meta File Open For Edit" )]
	class AssetDatabaseIsMetaFileOpenForEdit50 : ConditionalAutomation {

		public UnityEngine.Object assetObject;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit(assetObject);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Asset Database/Get Builtin Extra Resource" )]
	class AssetDatabaseGetBuiltinExtraResource51 : Automation {

		public System.Type type;
		public System.String path;
		[ReadOnly]
		public UnityEngine.Object Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.GetBuiltinExtraResource(type,path);
			yield break;
		}

	}

	[Automation( "Asset Database/Find Assets" )]
	class AssetDatabaseFindAssets52 : Automation {

		public System.String filter;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.FindAssets(filter);
			yield break;
		}

	}

	[Automation( "Asset Database/Find Assets In Folders" )]
	class AssetDatabaseFindAssets53 : Automation {

		public System.String filter;
		public System.String[] searchInFolders;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.AssetDatabase.FindAssets(filter,searchInFolders);
			yield break;
		}

	}


#pragma warning restore 0649
}
