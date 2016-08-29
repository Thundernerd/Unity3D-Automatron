using System.Collections;
using UnityEditor;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "File/Copy File or Directory" )]
    public class FileCopy : Automation {

        public string From;
        public string To;

        public override IEnumerator Execute() {
            FileUtil.CopyFileOrDirectory( From, To );
            yield break;
        }
    }

    [Automation( "File/Copy File Or Directory" )]
    public class FileDelete : Automation {

        public string Path;
        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = FileUtil.DeleteFileOrDirectory( Path );
            yield break;
        }
    }

    [Automation( "File/Get Project Relative Path" )]
    public class FileGetProjectRelativePath : Automation {

        public string Path;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = FileUtil.GetProjectRelativePath( Path );
            yield break;
        }
    }

    [Automation( "File/Get Unique Temp Path In Project" )]
    public class FileGetUniqueTempPathInProject : Automation {

        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = FileUtil.GetUniqueTempPathInProject();
            yield break;
        }
    }

    [Automation( "File/Move File Or Directory" )]
    public class FileMoveFileOrDirectory : Automation {

        public string From;
        public string To;

        public override IEnumerator Execute() {
            FileUtil.MoveFileOrDirectory( From,To );
            yield break;
        }
    }

    [Automation( "File/Replace Directory" )]
    public class FileReplaceDirectory : Automation {

        public string Src;
        public string Dst;

        public override IEnumerator Execute() {
            FileUtil.ReplaceDirectory( Src, Dst );
            yield break;
        }
    }

    [Automation( "File/Replace File" )]
    public class FileReplaceFile : Automation {

        public string Src;
        public string Dst;

        public override IEnumerator Execute() {
            FileUtil.ReplaceFile( Src, Dst );
            yield break;
        }
    }

#pragma warning restore 0649
}