using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "IO/Directory/Create Directory" )]
	class DirectoryCreateDirectory0 : Automation {

		public System.String path;
		[ReadOnly]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.CreateDirectory(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Delete" )]
	class DirectoryDelete1 : Automation {

		public System.String path;
		public System.Boolean recursive;

		public override IEnumerator Execute() {
			System.IO.Directory.Delete(path,recursive);
			yield break;
		}

	}

	[Automation( "IO/Directory/Exists" )]
	class DirectoryExists2 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.IO.Directory.Exists(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "IO/Directory/Get Last Access Time" )]
	class DirectoryGetLastAccessTime3 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetLastAccessTime(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Last Access Time Utc" )]
	class DirectoryGetLastAccessTimeUtc4 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetLastAccessTimeUtc(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Last Write Time" )]
	class DirectoryGetLastWriteTime5 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetLastWriteTime(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Last Write Time Utc" )]
	class DirectoryGetLastWriteTimeUtc6 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetLastWriteTimeUtc(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Creation Time" )]
	class DirectoryGetCreationTime7 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetCreationTime(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Creation Time Utc" )]
	class DirectoryGetCreationTimeUtc8 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetCreationTimeUtc(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Current Directory" )]
	class DirectoryGetCurrentDirectory9 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetCurrentDirectory();
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Directories" )]
	class DirectoryGetDirectories10 : Automation {

		public System.String path;
		public System.String searchPattern;
		public System.IO.SearchOption searchOption;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetDirectories(path,searchPattern,searchOption);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Directory Root" )]
	class DirectoryGetDirectoryRoot11 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetDirectoryRoot(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Files" )]
	class DirectoryGetFiles12 : Automation {

		public System.String path;
		public System.String searchPattern;
		public System.IO.SearchOption searchOption;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetFiles(path,searchPattern,searchOption);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get File System Entries" )]
	class DirectoryGetFileSystemEntries13 : Automation {

		public System.String path;
		public System.String searchPattern;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetFileSystemEntries(path,searchPattern);
			yield break;
		}

	}

	[Automation( "IO/Directory/Get Logical Drives" )]
	class DirectoryGetLogicalDrives14 : Automation {

		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.Directory.GetLogicalDrives();
			yield break;
		}

	}

	[Automation( "IO/Directory/Move" )]
	class DirectoryMove15 : Automation {

		public System.String sourceDirName;
		public System.String destDirName;

		public override IEnumerator Execute() {
			System.IO.Directory.Move(sourceDirName,destDirName);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Creation Time" )]
	class DirectorySetCreationTime16 : Automation {

		public System.String path;
		public System.DateTime creationTime;

		public override IEnumerator Execute() {
			System.IO.Directory.SetCreationTime(path,creationTime);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Creation Time Utc" )]
	class DirectorySetCreationTimeUtc17 : Automation {

		public System.String path;
		public System.DateTime creationTimeUtc;

		public override IEnumerator Execute() {
			System.IO.Directory.SetCreationTimeUtc(path,creationTimeUtc);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Current Directory" )]
	class DirectorySetCurrentDirectory18 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.Directory.SetCurrentDirectory(path);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Last Access Time" )]
	class DirectorySetLastAccessTime19 : Automation {

		public System.String path;
		public System.DateTime lastAccessTime;

		public override IEnumerator Execute() {
			System.IO.Directory.SetLastAccessTime(path,lastAccessTime);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Last Access Time Utc" )]
	class DirectorySetLastAccessTimeUtc20 : Automation {

		public System.String path;
		public System.DateTime lastAccessTimeUtc;

		public override IEnumerator Execute() {
			System.IO.Directory.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Last Write Time" )]
	class DirectorySetLastWriteTime21 : Automation {

		public System.String path;
		public System.DateTime lastWriteTime;

		public override IEnumerator Execute() {
			System.IO.Directory.SetLastWriteTime(path,lastWriteTime);
			yield break;
		}

	}

	[Automation( "IO/Directory/Set Last Write Time Utc" )]
	class DirectorySetLastWriteTimeUtc22 : Automation {

		public System.String path;
		public System.DateTime lastWriteTimeUtc;

		public override IEnumerator Execute() {
			System.IO.Directory.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
			yield break;
		}

	}


#pragma warning restore 0649
}
