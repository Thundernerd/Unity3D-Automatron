using System.Collections;
using System.Linq;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Editor Build Settings/Get Scenes" )]
    class EditorBuildSettingsscenesGet0 : Automation {

        [ReadOnly]
        public UnityEditor.EditorBuildSettingsScene[] Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.EditorBuildSettings.scenes;
            yield break;
        }

    }

    [Automation( "Editor Build Settings/Set Scenes" )]
    class EditorBuildSettingsscenesSet0 : Automation {

        public UnityEditor.EditorBuildSettingsScene[] Value;

        public override IEnumerator Execute() {
            UnityEditor.EditorBuildSettings.scenes = Value;
            yield break;
        }

    }

    [Automation( "Editor Build Settings/Get Scene Count" )]
    class EditorBuildSettingsscenesGetCount0 : Automation {

        [ReadOnly]
        public int Result;

        public override IEnumerator Execute() {
            Result = UnityEditor.EditorBuildSettings.scenes.Length;
            yield break;
        }

    }

    [Automation( "Editor Build Settings/Add Scene" )]
    class EditorBuildSettingsscenesAdd0 : Automation {

        public UnityEditor.EditorBuildSettingsScene Value;

        public override IEnumerator Execute() {
            var scenes = UnityEditor.EditorBuildSettings.scenes;
            var temp = scenes.ToList();
            temp.Add( Value );
            UnityEditor.EditorBuildSettings.scenes = temp.ToArray();
            yield break;
        }

    }

    [Automation( "Editor Build Settings/Insert Scene" )]
    class EditorBuildSettingsscenesInsert0 : Automation {

        public int index;
        public UnityEditor.EditorBuildSettingsScene Value;

        public override IEnumerator Execute() {
            var scenes = UnityEditor.EditorBuildSettings.scenes;
            var temp = scenes.ToList();
            temp.Insert( index, Value );
            UnityEditor.EditorBuildSettings.scenes = temp.ToArray();
            yield break;
        }

    }

    [Automation( "Editor Build Settings/Remove Scene" )]
    class EditorBuildSettingsscenesRemove0 : Automation {

        public UnityEditor.EditorBuildSettingsScene Value;

        public override IEnumerator Execute() {
            var scenes = UnityEditor.EditorBuildSettings.scenes;
            var temp = scenes.ToList();
            temp.Remove( Value );
            UnityEditor.EditorBuildSettings.scenes = temp.ToArray();
            yield break;
        }

    }

    [Automation( "Editor Build Settings/Remove All" )]
    class EditorBuildSettingsscenesRemoveAll0 : Automation {

        public UnityEditor.EditorBuildSettingsScene Value;

        public override IEnumerator Execute() {
            UnityEditor.EditorBuildSettings.scenes = new UnityEditor.EditorBuildSettingsScene[0];
            yield break;
        }

    }


#pragma warning restore 0649
}
