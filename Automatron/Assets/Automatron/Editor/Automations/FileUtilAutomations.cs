using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "IO/File Util/Delete File Or Directory" )]
	class FileUtilDeleteFileOrDirectory0 : ConditionalAutomation {

		public System.String path;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = UnityEditor.FileUtil.DeleteFileOrDirectory(path);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "IO/File Util/Copy File Or Directory" )]
	class FileUtilCopyFileOrDirectory1 : Automation {

		public System.String from;
		public System.String to;

		public override IEnumerator Execute() {
			UnityEditor.FileUtil.CopyFileOrDirectory(from,to);
			yield break;
		}

	}

	[Automation( "IO/File Util/Copy File Or Directory Follow Symlinks" )]
	class FileUtilCopyFileOrDirectoryFollowSymlinks2 : Automation {

		public System.String from;
		public System.String to;

		public override IEnumerator Execute() {
			UnityEditor.FileUtil.CopyFileOrDirectoryFollowSymlinks(from,to);
			yield break;
		}

	}

	[Automation( "IO/File Util/Move File Or Directory" )]
	class FileUtilMoveFileOrDirectory3 : Automation {

		public System.String from;
		public System.String to;

		public override IEnumerator Execute() {
			UnityEditor.FileUtil.MoveFileOrDirectory(from,to);
			yield break;
		}

	}

	[Automation( "IO/File Util/Get Unique Temp Path In Project" )]
	class FileUtilGetUniqueTempPathInProject4 : Automation {

		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.FileUtil.GetUniqueTempPathInProject();
			yield break;
		}

	}

	[Automation( "IO/File Util/Get Project Relative Path" )]
	class FileUtilGetProjectRelativePath5 : Automation {

		public System.String path;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = UnityEditor.FileUtil.GetProjectRelativePath(path);
			yield break;
		}

	}

	[Automation( "IO/File Util/Replace File" )]
	class FileUtilReplaceFile6 : Automation {

		public System.String src;
		public System.String dst;

		public override IEnumerator Execute() {
			UnityEditor.FileUtil.ReplaceFile(src,dst);
			yield break;
		}

	}

	[Automation( "IO/File Util/Replace Directory" )]
	class FileUtilReplaceDirectory7 : Automation {

		public System.String src;
		public System.String dst;

		public override IEnumerator Execute() {
			UnityEditor.FileUtil.ReplaceDirectory(src,dst);
			yield break;
		}

	}


#pragma warning restore 0649
}
