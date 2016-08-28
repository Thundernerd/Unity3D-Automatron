using System.Collections;
using System.Collections.Generic;
using TNRD.Editor.Serialization;
using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Asset Database/Asset Path to GUID" )]
    class AssetPathToGUID : Automation {

        public string Path;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.AssetPathToGUID( Path );
            yield break;
        }
    }

    [Automation( "Asset Database/Copy Asset" )]
    class CopyAsset : Automation {

        public string Path;
        public string newPath;
        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.CopyAsset( Path, newPath );
            yield break;
        }
    }

    [Automation( "Asset Database/Find Assets" )]
    class FindAssets : Automation {

        public string filter;
        public string[] searchInFolders;
        [ReadOnly]
        public string[] Result;

        public override IEnumerator Execute() {
            if ( searchInFolders.Length == 0 ) {
                Result = AssetDatabase.FindAssets( filter );
            } else {
                Result = AssetDatabase.FindAssets( filter, searchInFolders );
            }
            yield break;
        }
    }

    [Automation( "Asset Database/Get Asset or Scene Path" )]
    class GetAssetOrScenePath : Automation {

        [IgnoreSerialization]
        public Object Asset;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.GetAssetOrScenePath( Asset );
            yield break;
        }
    }

    [Automation( "Asset Database/Get Asset Path" )]
    class GetAssetPath : Automation {

        [IgnoreSerialization]
        public Object Asset;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.GetAssetPath( Asset );
            yield break;
        }
    }

    [Automation( "Asset Database/GUID to Asset Path" )]
    class GUIDToAssetPath : Automation {

        public string GUID;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.GUIDToAssetPath( GUID );
            yield break;
        }
    }

    [Automation( "Asset Database/Load Assets at Path" )]
    class LoadAssetsAtPath : Automation {

        public string Path;
        [ReadOnly]
        [IgnoreSerialization]
        public Object[] Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.LoadAllAssetsAtPath( Path );
            yield break;
        }
    }

    //[Automation( "Asset Database/Load Asset at Path" )]
    //class LoadAssetAtPath : Automation {

    //    public string Path;
    //    public ComponentType Type;
    //    [ReadOnly]
    //    [IgnoreSerialization]
    //    public Object Result;

    //    public override IEnumerator Execute() {
    //        Result = AssetDatabase.LoadAssetAtPath( Path, Type.Type );
    //        yield break;
    //    }
    //}

    [Automation( "Asset Database/Move Asset" )]
    class MoveAsset : Automation {

        public string OldPath;
        public string NewPath;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.MoveAsset( OldPath, NewPath );
            yield break;
        }
    }

    [Automation( "Asset Database/Move Asset to Trash" )]
    class MoveAssetTrash : Automation {

        public string Path;
        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.MoveAssetToTrash( Path );
            yield break;
        }
    }

    [Automation( "Asset Database/Refresh" )]
    class Refresh : Automation {

        public ImportAssetOptions Options = ImportAssetOptions.Default;

        public override IEnumerator Execute() {
            AssetDatabase.Refresh( Options );
            yield break;
        }
    }

    [Automation( "Asset Database/Rename Asset" )]
    class RenameAsset : Automation {

        public string Path;
        public string NewName;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = AssetDatabase.RenameAsset( Path, NewName );
            yield break;
        }
    }

    [Automation( "Asset Database/Save Assets" )]
    class SaveAssets : Automation {

        public override IEnumerator Execute() {
            AssetDatabase.SaveAssets();
            yield break;
        }
    }

#pragma warning restore 0649
}