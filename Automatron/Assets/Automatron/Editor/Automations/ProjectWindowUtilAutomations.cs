using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Project Window Util/Create New GUI Skin" )]
	class ProjectWindowUtilCreateNewGUISkin0 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.CreateNewGUISkin();
			yield break;
		}

	}

	[Automation( "Project Window Util/Create Asset" )]
	class ProjectWindowUtilCreateAsset1 : Automation {

		public UnityEngine.Object asset;
		public System.String pathName;

		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.CreateAsset(asset,pathName);
			yield break;
		}

	}

	[Automation( "Project Window Util/Create Folder" )]
	class ProjectWindowUtilCreateFolder2 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.CreateFolder();
			yield break;
		}

	}

	[Automation( "Project Window Util/Create Scene" )]
	class ProjectWindowUtilCreateScene3 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.CreateScene();
			yield break;
		}

	}

	[Automation( "Project Window Util/Create Prefab" )]
	class ProjectWindowUtilCreatePrefab4 : Automation {


		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.CreatePrefab();
			yield break;
		}

	}

	[Automation( "Project Window Util/Show Created Asset" )]
	class ProjectWindowUtilShowCreatedAsset5 : Automation {

		public UnityEngine.Object o;

		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.ShowCreatedAsset(o);
			yield break;
		}

	}

	[Automation( "Project Window Util/Start Name Editing If Project Window Exists" )]
	class ProjectWindowUtilStartNameEditingIfProjectWindowExists6 : Automation {

		public System.Int32 instanceID;
		public UnityEditor.ProjectWindowCallback.EndNameEditAction endAction;
		public System.String pathName;
		public UnityEngine.Texture2D icon;
		public System.String resourceFile;

		public override IEnumerator Execute() {
			UnityEditor.ProjectWindowUtil.StartNameEditingIfProjectWindowExists(instanceID,endAction,pathName,icon,resourceFile);
			yield break;
		}

	}

	[Automation( "Project Window Util/Get Ancestors" )]
	class ProjectWindowUtilGetAncestors7 : Automation {

		public System.Int32 instanceID;
		[ReadOnly]
		public System.Int32[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ProjectWindowUtil.GetAncestors(instanceID);
			yield break;
		}

	}

	[Automation( "Project Window Util/Is Folder" )]
	class ProjectWindowUtilIsFolder8 : ConditionalAutomation {

		public System.Int32 instanceID;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ProjectWindowUtil.IsFolder(instanceID);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Project Window Util/Get Containing Folder" )]
	class ProjectWindowUtilGetContainingFolder9 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ProjectWindowUtil.GetContainingFolder(path);
			yield break;
		}

	}

	[Automation( "Project Window Util/Get Base Folders" )]
	class ProjectWindowUtilGetBaseFolders10 : Automation {

		public System.String[] folders;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.ProjectWindowUtil.GetBaseFolders(folders);
			yield break;
		}

	}


#pragma warning restore 0649
}
