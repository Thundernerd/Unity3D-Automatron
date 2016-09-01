using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Path/Get Alt Directory Separator Char" )]
	class PathAltDirectorySeparatorCharGet0 : Automation {

		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.AltDirectorySeparatorChar;
			yield break;
		}

	}

	[Automation( "Path/Get Directory Separator Char" )]
	class PathDirectorySeparatorCharGet1 : Automation {

		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.DirectorySeparatorChar;
			yield break;
		}

	}

	[Automation( "Path/Get Path Separator" )]
	class PathPathSeparatorGet2 : Automation {

		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.PathSeparator;
			yield break;
		}

	}

	[Automation( "Path/Get Volume Separator Char" )]
	class PathVolumeSeparatorCharGet3 : Automation {

		[ReadOnly]
		public System.Char Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.VolumeSeparatorChar;
			yield break;
		}

	}

	[Automation( "Path/Change Extension" )]
	class PathChangeExtension0 : Automation {

		public System.String path;
		public System.String extension;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.ChangeExtension(path,extension);
			yield break;
		}

	}

	[Automation( "Path/Combine" )]
	class PathCombine1 : Automation {

		public System.String path1;
		public System.String path2;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.Combine(path1,path2);
			yield break;
		}

	}

	[Automation( "Path/Get Directory Name" )]
	class PathGetDirectoryName2 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetDirectoryName(path);
			yield break;
		}

	}

	[Automation( "Path/Get Extension" )]
	class PathGetExtension3 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetExtension(path);
			yield break;
		}

	}

	[Automation( "Path/Get File Name" )]
	class PathGetFileName4 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetFileName(path);
			yield break;
		}

	}

	[Automation( "Path/Get File Name Without Extension" )]
	class PathGetFileNameWithoutExtension5 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetFileNameWithoutExtension(path);
			yield break;
		}

	}

	[Automation( "Path/Get Full Path" )]
	class PathGetFullPath6 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetFullPath(path);
			yield break;
		}

	}

	[Automation( "Path/Get Path Root" )]
	class PathGetPathRoot7 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetPathRoot(path);
			yield break;
		}

	}

	[Automation( "Path/Get Temp File Name" )]
	class PathGetTempFileName8 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetTempFileName();
			yield break;
		}

	}

	[Automation( "Path/Get Temp Path" )]
	class PathGetTempPath9 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetTempPath();
			yield break;
		}

	}

	[Automation( "Path/Has Extension" )]
	class PathHasExtension10 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.IO.Path.HasExtension(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Path/Is Path Rooted" )]
	class PathIsPathRooted11 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.IO.Path.IsPathRooted(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Path/Get Invalid File Name Chars" )]
	class PathGetInvalidFileNameChars12 : Automation {

		[ReadOnly]
		public System.Char[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetInvalidFileNameChars();
			yield break;
		}

	}

	[Automation( "Path/Get Invalid Path Chars" )]
	class PathGetInvalidPathChars13 : Automation {

		[ReadOnly]
		public System.Char[] Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetInvalidPathChars();
			yield break;
		}

	}

	[Automation( "Path/Get Random File Name" )]
	class PathGetRandomFileName14 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.IO.Path.GetRandomFileName();
			yield break;
		}

	}


#pragma warning restore 0649
}
