using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "IO/File Info/Get Exists" )]
	class FileInfoExistsGet0 : ConditionalAutomation {

		public System.IO.FileInfo Instance;
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

	[Automation( "IO/File Info/Get Name" )]
	class FileInfoNameGet1 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Name;
			yield break;
		}

	}

	[Automation( "IO/File Info/Get Is Read Only" )]
	class FileInfoIsReadOnlyGet2 : ConditionalAutomation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsReadOnly;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "IO/File Info/Set Is Read Only" )]
	class FileInfoIsReadOnlySet2 : Automation {

		public System.IO.FileInfo Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.IsReadOnly = Value;
			yield break;
		}

	}

	[Automation( "IO/File Info/Get Directory Name" )]
	class FileInfoDirectoryNameGet3 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.DirectoryName;
			yield break;
		}

	}

	[Automation( "IO/File Info/Get Directory" )]
	class FileInfoDirectoryGet4 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Directory;
			yield break;
		}

	}

	[Automation( "IO/File Info/Encrypt" )]
	class FileInfoEncrypt0 : Automation {

		public System.IO.FileInfo Instance;

		public override IEnumerator Execute() {
			Instance.Encrypt();
			yield break;
		}

	}

	[Automation( "IO/File Info/Decrypt" )]
	class FileInfoDecrypt1 : Automation {

		public System.IO.FileInfo Instance;

		public override IEnumerator Execute() {
			Instance.Decrypt();
			yield break;
		}

	}

	[Automation( "IO/File Info/Delete" )]
	class FileInfoDelete2 : Automation {

		public System.IO.FileInfo Instance;

		public override IEnumerator Execute() {
			Instance.Delete();
			yield break;
		}

	}

	[Automation( "IO/File Info/Move To" )]
	class FileInfoMoveTo3 : Automation {

		public System.IO.FileInfo Instance;
		public System.String destFileName;

		public override IEnumerator Execute() {
			Instance.MoveTo(destFileName);
			yield break;
		}

	}

	[Automation( "IO/File Info/Copy To" )]
	class FileInfoCopyTo4 : Automation {

		public System.IO.FileInfo Instance;
		public System.String destFileName;
		public System.Boolean overwrite;
		[ReadOnly]
		public System.IO.FileInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.CopyTo(destFileName,overwrite);
			yield break;
		}

	}

	[Automation( "IO/File Info/Replace" )]
	class FileInfoReplace5 : Automation {

		public System.IO.FileInfo Instance;
		public System.String destinationFileName;
		public System.String destinationBackupFileName;
		public System.Boolean ignoreMetadataErrors;
		[ReadOnly]
		public System.IO.FileInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Replace(destinationFileName,destinationBackupFileName,ignoreMetadataErrors);
			yield break;
		}

	}


#pragma warning restore 0649
}
