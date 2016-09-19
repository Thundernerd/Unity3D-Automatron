#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Directory Info/Get Exists" )]
	class DirectoryInfoExistsGet0 : ConditionalAutomation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Exists;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Directory Info/Get Name" )]
	class DirectoryInfoNameGet1 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Name;
			yield break;
		}

	}

	[Automation( "Directory Info/Get Parent" )]
	class DirectoryInfoParentGet2 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Parent;
			yield break;
		}

	}

	[Automation( "Directory Info/Get Root" )]
	class DirectoryInfoRootGet3 : Automation {

		public System.IO.DirectoryInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Root;
			yield break;
		}

	}

	[Automation( "Directory Info/Create" )]
	class DirectoryInfoCreate0 : Automation {

		public System.IO.DirectoryInfo Instance;

		public override IEnumerator Execute() {
			Instance.Create();
			yield break;
		}

	}

	[Automation( "Directory Info/Create Subdirectory" )]
	class DirectoryInfoCreateSubdirectory1 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String path;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.CreateSubdirectory(path);
			yield break;
		}

	}

	[Automation( "Directory Info/Delete" )]
	class DirectoryInfoDelete3 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.Boolean recursive;

		public override IEnumerator Execute() {
			Instance.Delete(recursive);
			yield break;
		}

	}

	[Automation( "Directory Info/Move To" )]
	class DirectoryInfoMoveTo4 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String destDirName;

		public override IEnumerator Execute() {
			Instance.MoveTo(destDirName);
			yield break;
		}

	}

	[Automation( "Directory Info/Get Directories" )]
	class DirectoryInfoGetDirectories5 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String searchPattern;
		public System.IO.SearchOption searchOption;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.DirectoryInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDirectories(searchPattern,searchOption);
			yield break;
		}

	}

	[Automation( "Directory Info/Get Files" )]
	class DirectoryInfoGetFiles6 : Automation {

		public System.IO.DirectoryInfo Instance;
		public System.String searchPattern;
		public System.IO.SearchOption searchOption;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.FileInfo[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetFiles(searchPattern,searchOption);
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif