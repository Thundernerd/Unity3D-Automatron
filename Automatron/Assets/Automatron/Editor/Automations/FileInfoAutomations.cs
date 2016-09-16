using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "File Info/Get Exists" )]
	class FileInfoExistsGet0 : ConditionalAutomation {

		public System.IO.FileInfo Instance;
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

	[Automation( "File Info/Get Name" )]
	class FileInfoNameGet1 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.Name;
			yield break;
		}

	}

	[Automation( "File Info/Get Is Read Only" )]
	class FileInfoIsReadOnlyGet2 : ConditionalAutomation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.IsReadOnly;
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "File Info/Set Is Read Only" )]
	class FileInfoIsReadOnlySet2 : Automation {

		public System.IO.FileInfo Instance;
		public System.Boolean Value;

		public override IEnumerator Execute() {
			Instance.IsReadOnly = Value;
			yield break;
		}

	}

	[Automation( "File Info/Get Length" )]
	class FileInfoLengthGet3 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.Length;
			yield break;
		}

	}

	[Automation( "File Info/Get Directory Name" )]
	class FileInfoDirectoryNameGet4 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.DirectoryName;
			yield break;
		}

	}

	[Automation( "File Info/Get Directory" )]
	class FileInfoDirectoryGet5 : Automation {

		public System.IO.FileInfo Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.DirectoryInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Directory;
			yield break;
		}

	}

	[Automation( "File Info/Encrypt" )]
	class FileInfoEncrypt0 : Automation {

		public System.IO.FileInfo Instance;

		public override IEnumerator Execute() {
			Instance.Encrypt();
			yield break;
		}

	}

	[Automation( "File Info/Decrypt" )]
	class FileInfoDecrypt1 : Automation {

		public System.IO.FileInfo Instance;

		public override IEnumerator Execute() {
			Instance.Decrypt();
			yield break;
		}

	}

	[Automation( "File Info/Delete" )]
	class FileInfoDelete2 : Automation {

		public System.IO.FileInfo Instance;

		public override IEnumerator Execute() {
			Instance.Delete();
			yield break;
		}

	}

	[Automation( "File Info/Move To" )]
	class FileInfoMoveTo3 : Automation {

		public System.IO.FileInfo Instance;
		public System.String destFileName;

		public override IEnumerator Execute() {
			Instance.MoveTo(destFileName);
			yield break;
		}

	}

	[Automation( "File Info/Copy To" )]
	class FileInfoCopyTo4 : Automation {

		public System.IO.FileInfo Instance;
		public System.String destFileName;
		public System.Boolean overwrite;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.FileInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.CopyTo(destFileName,overwrite);
			yield break;
		}

	}

	[Automation( "File Info/Replace" )]
	class FileInfoReplace5 : Automation {

		public System.IO.FileInfo Instance;
		public System.String destinationFileName;
		public System.String destinationBackupFileName;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.IO.FileInfo Result;

		public override IEnumerator Execute() {
			Result = Instance.Replace(destinationFileName,destinationBackupFileName);
			yield break;
		}

	}


#pragma warning restore 0649
}
