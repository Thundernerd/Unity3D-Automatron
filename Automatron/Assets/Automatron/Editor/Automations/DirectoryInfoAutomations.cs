using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "IO/Directory Info/Get Exists" )]
	class DirectoryInfoExistsGet0 : ConditionalAutomation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.Exists;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "IO/Directory Info/Get Name" )]
	class DirectoryInfoNameGet1 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Name;
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Get Parent" )]
	class DirectoryInfoParentGet2 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Parent;
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Get Root" )]
	class DirectoryInfoRootGet3 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Root;
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Create Subdirectory" )]
	class DirectoryInfoCreateSubdirectory0 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String path;
		[ReadOnly]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.CreateSubdirectory(path);
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Delete" )]
	class DirectoryInfoDelete1 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.Boolean recursive;

		public override IEnumerator Execute() {
			Instance.Delete(recursive);
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Move To" )]
	class DirectoryInfoMoveTo2 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String destDirName;

		public override IEnumerator Execute() {
			Instance.MoveTo(destDirName);
			yield break;
		}

	}

	[Automation( "IO/Directory Info/To String" )]
	class DirectoryInfoToString3 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Get Directories" )]
	class DirectoryInfoGetDirectories4 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String searchPattern;
		public System.IO.SearchOption searchOption;
		[ReadOnly]
		public System.IO.DirectoryInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDirectories(searchPattern,searchOption);
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Get Files" )]
	class DirectoryInfoGetFiles5 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String searchPattern;
		public System.IO.SearchOption searchOption;
		[ReadOnly]
		public System.IO.FileInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetFiles(searchPattern,searchOption);
			yield break;
		}

	}

	[Automation( "IO/Directory Info/Create" )]
	class DirectoryInfoCreate6 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.Security.AccessControl.DirectorySecurity directorySecurity;

		public override IEnumerator Execute() {
			Instance.Create(directorySecurity);
			yield break;
		}

	}


#pragma warning restore 0649
}
