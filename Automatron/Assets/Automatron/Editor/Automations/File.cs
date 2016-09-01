using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "IO/File/Append All Text" )]
	class FileAppendAllText0 : Automation {

		public System.String path;
		public System.String contents;

		public override IEnumerator Execute() {
			System.IO.File.AppendAllText(path,contents);
			yield break;
		}

	}

	[Automation( "IO/File/Copy" )]
	class FileCopy4 : Automation {

		public System.String sourceFileName;
		public System.String destFileName;
		public System.Boolean overwrite;

		public override IEnumerator Execute() {
			System.IO.File.Copy(sourceFileName,destFileName,overwrite);
			yield break;
		}

	}

	[Automation( "Generated/File/Create" )]
	class FileCreate5 : Automation {

		public System.String path;
		[ReadOnly]
		public System.IO.FileStream Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.Create(path);
			yield break;
		}

	}
	[Automation( "IO/File/Delete" )]
	class FileDelete10 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.File.Delete(path);
			yield break;
		}

	}

	[Automation( "IO/File/Exists" )]
	class FileExists11 : ConditionalAutomation {

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

	[Automation( "IO/File/Get Attributes" )]
	class FileGetAttributes14 : Automation {

		public System.String path;
		[ReadOnly]
		public System.IO.FileAttributes Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetAttributes(path);
			yield break;
		}

	}

	[Automation( "IO/File/Get Creation Time" )]
	class FileGetCreationTime15 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetCreationTime(path);
			yield break;
		}

	}

	[Automation( "IO/File/Get Creation Time Utc" )]
	class FileGetCreationTimeUtc16 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetCreationTimeUtc(path);
			yield break;
		}

	}

	[Automation( "IO/File/Get Last Access Time" )]
	class FileGetLastAccessTime17 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastAccessTime(path);
			yield break;
		}

	}

	[Automation( "IO/File/Get Last Access Time Utc" )]
	class FileGetLastAccessTimeUtc18 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastAccessTimeUtc(path);
			yield break;
		}

	}

	[Automation( "IO/File/Get Last Write Time" )]
	class FileGetLastWriteTime19 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastWriteTime(path);
			yield break;
		}

	}

	[Automation( "IO/File/Get Last Write Time Utc" )]
	class FileGetLastWriteTimeUtc20 : Automation {

		public System.String path;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.GetLastWriteTimeUtc(path);
			yield break;
		}

	}

	[Automation( "IO/File/Move" )]
	class FileMove21 : Automation {

		public System.String sourceFileName;
		public System.String destFileName;

		public override IEnumerator Execute() {
			System.IO.File.Move(sourceFileName,destFileName);
			yield break;
		}

	}

	[Automation( "IO/File/Replace" )]
	class FileReplace28 : Automation {

		public System.String sourceFileName;
		public System.String destinationFileName;
		public System.String destinationBackupFileName;

		public override IEnumerator Execute() {
			System.IO.File.Replace(sourceFileName,destinationFileName,destinationBackupFileName);
			yield break;
		}

	}

	[Automation( "IO/File/Set Attributes" )]
	class FileSetAttributes31 : Automation {

		public System.String path;
		public System.IO.FileAttributes fileAttributes;

		public override IEnumerator Execute() {
			System.IO.File.SetAttributes(path,fileAttributes);
			yield break;
		}

	}

	[Automation( "IO/File/Set Creation Time" )]
	class FileSetCreationTime32 : Automation {

		public System.String path;
		public System.DateTime creationTime;

		public override IEnumerator Execute() {
			System.IO.File.SetCreationTime(path,creationTime);
			yield break;
		}

	}

	[Automation( "IO/File/Set Creation Time Utc" )]
	class FileSetCreationTimeUtc33 : Automation {

		public System.String path;
		public System.DateTime creationTimeUtc;

		public override IEnumerator Execute() {
			System.IO.File.SetCreationTimeUtc(path,creationTimeUtc);
			yield break;
		}

	}

	[Automation( "IO/File/Set Last Access Time" )]
	class FileSetLastAccessTime34 : Automation {

		public System.String path;
		public System.DateTime lastAccessTime;

		public override IEnumerator Execute() {
			System.IO.File.SetLastAccessTime(path,lastAccessTime);
			yield break;
		}

	}

	[Automation( "IO/File/Set Last Access Time Utc" )]
	class FileSetLastAccessTimeUtc35 : Automation {

		public System.String path;
		public System.DateTime lastAccessTimeUtc;

		public override IEnumerator Execute() {
			System.IO.File.SetLastAccessTimeUtc(path,lastAccessTimeUtc);
			yield break;
		}

	}

	[Automation( "IO/File/Set Last Write Time" )]
	class FileSetLastWriteTime36 : Automation {

		public System.String path;
		public System.DateTime lastWriteTime;

		public override IEnumerator Execute() {
			System.IO.File.SetLastWriteTime(path,lastWriteTime);
			yield break;
		}

	}

	[Automation( "IO/File/Set Last Write Time Utc" )]
	class FileSetLastWriteTimeUtc37 : Automation {

		public System.String path;
		public System.DateTime lastWriteTimeUtc;

		public override IEnumerator Execute() {
			System.IO.File.SetLastWriteTimeUtc(path,lastWriteTimeUtc);
			yield break;
		}

	}

	[Automation( "IO/File/Read All Lines" )]
	class FileReadAllLines39 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.ReadAllLines(path);
			yield break;
		}

	}

	[Automation( "IO/File/Read All Text" )]
	class FileReadAllText41 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.File.ReadAllText(path);
			yield break;
		}

	}

	[Automation( "IO/File/Write All Lines" )]
	class FileWriteAllLines44 : Automation {

		public System.String path;
		public System.String[] contents;

		public override IEnumerator Execute() {
			System.IO.File.WriteAllLines(path,contents);
			yield break;
		}

	}

	[Automation( "IO/File/Write All Text" )]
	class FileWriteAllText46 : Automation {

		public System.String path;
		public System.String contents;

		public override IEnumerator Execute() {
			System.IO.File.WriteAllText(path,contents);
			yield break;
		}

	}

	[Automation( "IO/File/Encrypt" )]
	class FileEncrypt48 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.File.Encrypt(path);
			yield break;
		}

	}

	[Automation( "IO/File/Decrypt" )]
	class FileDecrypt49 : Automation {

		public System.String path;

		public override IEnumerator Execute() {
			System.IO.File.Decrypt(path);
			yield break;
		}

	}


#pragma warning restore 0649
}
