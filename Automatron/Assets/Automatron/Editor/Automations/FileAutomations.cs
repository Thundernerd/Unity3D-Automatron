using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "File/Append All Text" )]
	class FileAppendAllText0 : Automation {

		public System.String path;
		public System.String contents;

		public override IEnumerator Execute() {
			System.IO.File.AppendAllText(path,contents);
			yield break;
		}

	}

	[Automation( "File/Copy" )]
	class FileCopy1 : Automation {

		public System.String sourceFileName;
		public System.String destFileName;
		public System.Boolean overwrite;

		public override IEnumerator Execute() {
			System.IO.File.Copy(sourceFileName,destFileName,overwrite);
			yield break;
		}

	}

	[Automation( "File/Create" )]
	class FileCreate2 : Automation {

		public System.String path;
		[ReadOnly]
		public System.IO.FileStream Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.Create(path);
			yield break;
		}

	}

	[Automation( "File/Delete" )]
	class FileDelete3 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.File.Delete(path);
			yield break;
		}

	}

	[Automation( "File/Exists" )]
	class FileExists4 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.IO.File.Exists(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "File/Get Attributes" )]
	class FileGetAttributes5 : Automation {

		public System.String path;
		[ReadOnly]
		public System.IO.FileAttributes Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetAttributes(path);
			yield break;
		}

	}

	[Automation( "File/Get Creation Time" )]
	class FileGetCreationTime6 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetCreationTime(path);
			yield break;
		}

	}

	[Automation( "File/Get Creation Time Utc" )]
	class FileGetCreationTimeUtc7 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetCreationTimeUtc(path);
			yield break;
		}

	}

	[Automation( "File/Get Last Access Time" )]
	class FileGetLastAccessTime8 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastAccessTime(path);
			yield break;
		}

	}

	[Automation( "File/Get Last Access Time Utc" )]
	class FileGetLastAccessTimeUtc9 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastAccessTimeUtc(path);
			yield break;
		}

	}

	[Automation( "File/Get Last Write Time" )]
	class FileGetLastWriteTime10 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastWriteTime(path);
			yield break;
		}

	}

	[Automation( "File/Get Last Write Time Utc" )]
	class FileGetLastWriteTimeUtc11 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastWriteTimeUtc(path);
			yield break;
		}

	}

	[Automation( "File/Move" )]
	class FileMove12 : Automation {

		public System.String sourceFileName;
		public System.String destFileName;

		public override IEnumerator Execute() {
			System.IO.File.Move(sourceFileName,destFileName);
			yield break;
		}

	}

	[Automation( "File/Replace" )]
	class FileReplace13 : Automation {

		public System.String sourceFileName;
		public System.String destinationFileName;
		public System.String destinationBackupFileName;
		public System.Boolean ignoreMetadataErrors;

		public override IEnumerator Execute() {
			System.IO.File.Replace(sourceFileName,destinationFileName,destinationBackupFileName,ignoreMetadataErrors);
			yield break;
		}

	}

	[Automation( "File/Set Creation Time" )]
	class FileSetCreationTime14 : Automation {

		public System.String path;
		public System.DateTime creationTime;

		public override IEnumerator Execute() {
			System.IO.File.SetCreationTime(path,creationTime);
			yield break;
		}

	}

	[Automation( "File/Set Creation Time Utc" )]
	class FileSetCreationTimeUtc15 : Automation {

		public System.String path;
		public System.DateTime creationTimeUtc;

		public override IEnumerator Execute() {
			System.IO.File.SetCreationTimeUtc(path,creationTimeUtc);
			yield break;
		}

	}

	[Automation( "File/Set Last Access Time" )]
	class FileSetLastAccessTime16 : Automation {

		public System.String path;
		public System.DateTime lastAccessTime;

		public override IEnumerator Execute() {
			System.IO.File.SetLastAccessTime(path,lastAccessTime);
			yield break;
		}

	}

	[Automation( "File/Set Last Access Time Utc" )]
	class FileSetLastAccessTimeUtc17 : Automation {

		public System.String path;
		public System.DateTime lastAccessTimeUtc;

		public override IEnumerator Execute() {
			System.IO.File.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
			yield break;
		}

	}

	[Automation( "File/Set Last Write Time" )]
	class FileSetLastWriteTime18 : Automation {

		public System.String path;
		public System.DateTime lastWriteTime;

		public override IEnumerator Execute() {
			System.IO.File.SetLastWriteTime(path,lastWriteTime);
			yield break;
		}

	}

	[Automation( "File/Set Last Write Time Utc" )]
	class FileSetLastWriteTimeUtc19 : Automation {

		public System.String path;
		public System.DateTime lastWriteTimeUtc;

		public override IEnumerator Execute() {
			System.IO.File.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
			yield break;
		}

	}

	[Automation( "File/Read All Bytes" )]
	class FileReadAllBytes20 : Automation {

		public System.String path;
		[ReadOnly]
		public System.Byte[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.ReadAllBytes(path);
			yield break;
		}

	}

	[Automation( "File/Read All Lines" )]
	class FileReadAllLines21 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.ReadAllLines(path);
			yield break;
		}

	}

	[Automation( "File/Read All Text" )]
	class FileReadAllText22 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.ReadAllText(path);
			yield break;
		}

	}

	[Automation( "File/Write All Bytes" )]
	class FileWriteAllBytes23 : Automation {

		public System.String path;
		public System.Byte[] bytes;

		public override IEnumerator Execute() {
			System.IO.File.WriteAllBytes(path,bytes);
			yield break;
		}

	}

	[Automation( "File/Write All Lines" )]
	class FileWriteAllLines24 : Automation {

		public System.String path;
		public System.String[] contents;

		public override IEnumerator Execute() {
			System.IO.File.WriteAllLines(path,contents);
			yield break;
		}

	}

	[Automation( "File/Write All Text" )]
	class FileWriteAllText25 : Automation {

		public System.String path;
		public System.String contents;

		public override IEnumerator Execute() {
			System.IO.File.WriteAllText(path,contents);
			yield break;
		}

	}

	[Automation( "File/Encrypt" )]
	class FileEncrypt26 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.File.Encrypt(path);
			yield break;
		}

	}

	[Automation( "File/Decrypt" )]
	class FileDecrypt27 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.File.Decrypt(path);
			yield break;
		}

	}


#pragma warning restore 0649
}
