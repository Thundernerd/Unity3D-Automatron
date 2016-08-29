using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Quality Settings/Decrease Level" )]
    class DecreaseLevel : Automation {

        public bool applyExpensiveChanges;

        public override IEnumerator Execute() {
            QualitySettings.DecreaseLevel( applyExpensiveChanges );
            yield break;
        }
    }

    [Automation( "Quality Settings/Increase Level" )]
    class IncreaseLevel : Automation {

        public bool applyExpensiveChanges;

        public override IEnumerator Execute() {
            QualitySettings.IncreaseLevel( applyExpensiveChanges );
            yield break;
        }
    }

    [Automation( "Quality Settings/Set Quality Level" )]
    class SetQualityLevel : Automation {

        public int index;
        public bool applyExpensiveChanges = true;

        public override IEnumerator Execute() {
            QualitySettings.SetQualityLevel( index, applyExpensiveChanges );
            yield break;
        }
    }

#pragma warning restore 0649
}
