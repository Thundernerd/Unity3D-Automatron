using System.Collections;
using UnityEditor;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Build Settings/Get Build Location" )]
    class GetBuildLocation : Automation {

        public BuildTarget target;
        [ReadOnly]
        public string Result;

        public override IEnumerator Execute() {
            Result = EditorUserBuildSettings.GetBuildLocation( target );
            yield break;
        }
    }

    [Automation( "Build Settings/Get WSA Dot Net Native" )]
    class GetWSADotNetNative : Automation {

        public WSABuildType config;
        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = EditorUserBuildSettings.GetWSADotNetNative( config );
            yield break;
        }
    }

    [Automation( "Build Settings/Set Build Location" )]
    class SetBuildLocation : Automation {

        public BuildTarget target;
        public string location;

        public override IEnumerator Execute() {
            EditorUserBuildSettings.SetBuildLocation( target, location );
            yield break;
        }
    }

    [Automation( "Build Settings/SetWSADotNetNative" )]
    class SetWSADotNetNative : Automation {

        public WSABuildType target;
        public bool enabled;

        public override IEnumerator Execute() {
            EditorUserBuildSettings.SetWSADotNetNative( target, enabled );
            yield break;
        }
    }

    [Automation( "Build Settings/SwitchActiveBuildTarget" )]
    class SwitchActiveBuildTarget : Automation {

        public BuildTarget target;
        [ReadOnly]
        public bool Result;

        public override IEnumerator Execute() {
            Result = EditorUserBuildSettings.SwitchActiveBuildTarget( target );
            yield break;
        }
    }

#pragma warning restore 0649
}
