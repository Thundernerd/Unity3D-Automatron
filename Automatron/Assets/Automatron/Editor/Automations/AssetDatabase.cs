using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Asset Database/Contains" )]
    class AssetDatabaseContains0 : Automation {

        public UnityEngine.Object obj;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.Contains( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Create Folder" )]
    class AssetDatabaseCreateFolder2 : Automation {

        public System.String parentFolder;
        public System.String newFolderName;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.CreateFolder( parentFolder, newFolderName );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Main Asset" )]
    class AssetDatabaseIsMainAsset3 : Automation {

        public UnityEngine.Object obj;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsMainAsset( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Sub Asset" )]
    class AssetDatabaseIsSubAsset5 : Automation {

        public UnityEngine.Object obj;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsSubAsset( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Foreign Asset" )]
    class AssetDatabaseIsForeignAsset7 : Automation {

        public UnityEngine.Object obj;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsForeignAsset( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Native Asset" )]
    class AssetDatabaseIsNativeAsset9 : Automation {

        public UnityEngine.Object obj;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsNativeAsset( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Generate Unique Asset Path" )]
    class AssetDatabaseGenerateUniqueAssetPath11 : Automation {

        public System.String path;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GenerateUniqueAssetPath( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Start Asset Editing" )]
    class AssetDatabaseStartAssetEditing12 : Automation {


        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.StartAssetEditing();
            yield break;
        }

    }

    [Automation( "Asset Database/Stop Asset Editing" )]
    class AssetDatabaseStopAssetEditing13 : Automation {


        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.StopAssetEditing();
            yield break;
        }

    }

    [Automation( "Asset Database/Validate Move Asset" )]
    class AssetDatabaseValidateMoveAsset14 : Automation {

        public System.String oldPath;
        public System.String newPath;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.ValidateMoveAsset( oldPath, newPath );
            yield break;
        }

    }

    [Automation( "Asset Database/Move Asset" )]
    class AssetDatabaseMoveAsset15 : Automation {

        public System.String oldPath;
        public System.String newPath;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.MoveAsset( oldPath, newPath );
            yield break;
        }

    }

    [Automation( "Asset Database/Rename Asset" )]
    class AssetDatabaseRenameAsset16 : Automation {

        public System.String pathName;
        public System.String newName;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.RenameAsset( pathName, newName );
            yield break;
        }

    }

    [Automation( "Asset Database/Move Asset To Trash" )]
    class AssetDatabaseMoveAssetToTrash17 : Automation {

        public System.String path;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.MoveAssetToTrash( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Delete Asset" )]
    class AssetDatabaseDeleteAsset18 : Automation {

        public System.String path;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.DeleteAsset( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Import Asset" )]
    class AssetDatabaseImportAsset19 : Automation {

        public System.String path;
        public UnityEditor.ImportAssetOptions options;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.ImportAsset( path, options );
            yield break;
        }

    }

    [Automation( "Asset Database/Copy Asset" )]
    class AssetDatabaseCopyAsset21 : Automation {

        public System.String path;
        public System.String newPath;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.CopyAsset( path, newPath );
            yield break;
        }

    }

    [Automation( "Asset Database/Write Import Settings If Dirty" )]
    class AssetDatabaseWriteImportSettingsIfDirty22 : Automation {

        public System.String path;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.WriteImportSettingsIfDirty( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Sub Folders" )]
    class AssetDatabaseGetSubFolders23 : Automation {

        public System.String path;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetSubFolders( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Valid Folder" )]
    class AssetDatabaseIsValidFolder24 : Automation {

        public System.String path;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsValidFolder( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Create Asset" )]
    class AssetDatabaseCreateAsset25 : Automation {

        public UnityEngine.Object asset;
        public System.String path;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.CreateAsset( asset, path );
            yield break;
        }

    }

    [Automation( "Asset Database/Add Object To Asset (path)" )]
    class AssetDatabaseAddObjectToAsset26 : Automation {

        public UnityEngine.Object objectToAdd;
        public System.String path;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.AddObjectToAsset( objectToAdd, path );
            yield break;
        }

    }

    [Automation( "Asset Database/Add Object To Asset" )]
    class AssetDatabaseAddObjectToAsset27 : Automation {

        public UnityEngine.Object objectToAdd;
        public UnityEngine.Object assetObject;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.AddObjectToAsset( objectToAdd, assetObject );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Asset Path" )]
    class AssetDatabaseGetAssetPath28 : Automation {

        public UnityEngine.Object assetObject;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAssetPath( assetObject );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Asset Or Scene Path" )]
    class AssetDatabaseGetAssetOrScenePath30 : Automation {

        public UnityEngine.Object assetObject;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAssetOrScenePath( assetObject );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Text Meta File Path From Asset Path" )]
    class AssetDatabaseGetTextMetaFilePathFromAssetPath31 : Automation {

        public System.String path;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetTextMetaFilePathFromAssetPath( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Asset Path From Text Meta File Path" )]
    class AssetDatabaseGetAssetPathFromTextMetaFilePath32 : Automation {

        public System.String path;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAssetPathFromTextMetaFilePath( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Load Asset At Path" )]
    class AssetDatabaseLoadAssetAtPath33 : Automation {

        public System.String assetPath;
        [TypeLimit( typeof( UnityEngine.Object ) )]
        public System.Type type;
        [ReadOnly]
        public UnityEngine.Object Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.LoadAssetAtPath( assetPath, type );
            yield break;
        }

    }

    [Automation( "Asset Database/Load Main Asset At Path" )]
    class AssetDatabaseLoadMainAssetAtPath34 : Automation {

        public System.String assetPath;
        [ReadOnly]
        public UnityEngine.Object Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.LoadMainAssetAtPath( assetPath );
            yield break;
        }

    }

    [Automation( "Asset Database/Load All Asset Representations At Path" )]
    class AssetDatabaseLoadAllAssetRepresentationsAtPath35 : Automation {

        public System.String assetPath;
        [ReadOnly]
        public UnityEngine.Object[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.LoadAllAssetRepresentationsAtPath( assetPath );
            yield break;
        }

    }

    [Automation( "Asset Database/Load All Assets At Path" )]
    class AssetDatabaseLoadAllAssetsAtPath36 : Automation {

        public System.String assetPath;
        [ReadOnly]
        public UnityEngine.Object[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.LoadAllAssetsAtPath( assetPath );
            yield break;
        }

    }

    [Automation( "Asset Database/Get All Asset Paths" )]
    class AssetDatabaseGetAllAssetPaths37 : Automation {

        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAllAssetPaths();
            yield break;
        }

    }

    [Automation( "Asset Database/Refresh" )]
    class AssetDatabaseRefresh38 : Automation {

        public UnityEditor.ImportAssetOptions options;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.Refresh( options );
            yield break;
        }

    }

    [Automation( "Asset Database/Open Asset" )]
    class AssetDatabaseOpenAsset42 : Automation {

        public UnityEngine.Object target;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.OpenAsset( target );
            yield break;
        }

    }

    [Automation( "Asset Database/Open Assets" )]
    class AssetDatabaseOpenAsset44 : Automation {

        public UnityEngine.Object[] objects;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.OpenAsset( objects );
            yield break;
        }

    }

    [Automation( "Asset Database/Asset Path To GUID" )]
    class AssetDatabaseAssetPathToGUID45 : Automation {

        public System.String path;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.AssetPathToGUID( path );
            yield break;
        }

    }

    [Automation( "Asset Database/GUID To Asset Path" )]
    class AssetDatabaseGUIDToAssetPath46 : Automation {

        public System.String guid;
        [ReadOnly]
        public System.String Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GUIDToAssetPath( guid );
            yield break;
        }

    }

    [Automation( "Asset Database/Save Assets" )]
    class AssetDatabaseSaveAssets47 : Automation {


        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.SaveAssets();
            yield break;
        }

    }

    [Automation( "Asset Database/Get Cached Icon" )]
    class AssetDatabaseGetCachedIcon48 : Automation {

        public System.String path;
        [ReadOnly]
        public UnityEngine.Texture Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetCachedIcon( path );
            yield break;
        }

    }

    [Automation( "Asset Database/Set Labels" )]
    class AssetDatabaseSetLabels49 : Automation {

        public UnityEngine.Object obj;
        public System.String[] labels;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.SetLabels( obj, labels );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Labels" )]
    class AssetDatabaseGetLabels50 : Automation {

        public UnityEngine.Object obj;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetLabels( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Clear Labels" )]
    class AssetDatabaseClearLabels51 : Automation {

        public UnityEngine.Object obj;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.ClearLabels( obj );
            yield break;
        }

    }

    [Automation( "Asset Database/Get All Asset Bundle Names" )]
    class AssetDatabaseGetAllAssetBundleNames52 : Automation {

        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAllAssetBundleNames();
            yield break;
        }

    }

    [Automation( "Asset Database/Get Unused Asset Bundle Names" )]
    class AssetDatabaseGetUnusedAssetBundleNames53 : Automation {

        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetUnusedAssetBundleNames();
            yield break;
        }

    }

    [Automation( "Asset Database/Remove Asset Bundle Name" )]
    class AssetDatabaseRemoveAssetBundleName54 : Automation {

        public System.String assetBundleName;
        public System.Boolean forceRemove;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.RemoveAssetBundleName( assetBundleName, forceRemove );
            yield break;
        }

    }

    [Automation( "Asset Database/Remove Unused Asset Bundle Names" )]
    class AssetDatabaseRemoveUnusedAssetBundleNames55 : Automation {


        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.RemoveUnusedAssetBundleNames();
            yield break;
        }

    }

    [Automation( "Asset Database/Get Asset Paths From Asset Bundle" )]
    class AssetDatabaseGetAssetPathsFromAssetBundle56 : Automation {

        public System.String assetBundleName;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundle( assetBundleName );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Asset Paths From Asset Bundle And Asset Name" )]
    class AssetDatabaseGetAssetPathsFromAssetBundleAndAssetName57 : Automation {

        public System.String assetBundleName;
        public System.String assetName;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetAssetPathsFromAssetBundleAndAssetName( assetBundleName, assetName );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Dependencies" )]
    class AssetDatabaseGetDependencies61 : Automation {

        public System.String[] pathNames;
        public System.Boolean recursive;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetDependencies( pathNames, recursive );
            yield break;
        }

    }

    [Automation( "Asset Database/Export Package" )]
    class AssetDatabaseExportPackage64 : Automation {

        public System.String[] assetPathNames;
        public System.String fileName;
        public UnityEditor.ExportPackageOptions flags;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.ExportPackage( assetPathNames, fileName, flags );
            yield break;
        }

    }

    [Automation( "Asset Database/Import Package" )]
    class AssetDatabaseImportPackage66 : Automation {

        public System.String packagePath;
        public System.Boolean interactive;

        public override IEnumerator Execute() {
            UnityEditor.AssetDatabase.ImportPackage( packagePath, interactive );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Open For Edit" )]
    class AssetDatabaseIsOpenForEdit67 : Automation {

        public UnityEngine.Object assetObject;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsOpenForEdit( assetObject );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Open For Edit (path)" )]
    class AssetDatabaseIsOpenForEdit68 : Automation {

        public System.String assetOrMetaFilePath;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsOpenForEdit( assetOrMetaFilePath );
            yield break;
        }

    }

    [Automation( "Asset Database/Is Meta File Open For Edit" )]
    class AssetDatabaseIsMetaFileOpenForEdit71 : Automation {

        public UnityEngine.Object assetObject;
        [ReadOnly]
        public System.Boolean Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.IsMetaFileOpenForEdit( assetObject );
            yield break;
        }

    }

    [Automation( "Asset Database/Get Builtin Extra Resource" )]
    class AssetDatabaseGetBuiltinExtraResource73 : Automation {

        public System.Type type;
        public System.String path;
        [ReadOnly]
        public UnityEngine.Object Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.GetBuiltinExtraResource( type, path );
            yield break;
        }

    }

    [Automation( "Asset Database/Find Assets" )]
    class AssetDatabaseFindAssets74 : Automation {

        public System.String filter;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.FindAssets( filter );
            yield break;
        }

    }

    [Automation( "Asset Database/Find Assets (folders)" )]
    class AssetDatabaseFindAssets75 : Automation {

        public System.String filter;
        public System.String[] searchInFolders;
        [ReadOnly]
        public System.String[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.AssetDatabase.FindAssets( filter, searchInFolders );
            yield break;
        }

    }


#pragma warning restore 0649
}
