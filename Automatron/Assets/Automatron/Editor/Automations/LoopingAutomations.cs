using System.Collections;
using System;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Loop/Array" )]
    class LoopArray : LoopableAutomation {

        public Array Array;
        [ReadOnly]
        public object Value;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            Value = null;
            index = 0;
        }

        public override IEnumerator Execute() {
            if ( index < Array.Length ) {
                Value = Array.GetValue( index );
            }

            index++;
            yield break;
        }

        public override bool IsDone() {
            return index == Array.Length;
        }
    }

    [Automation( "Loop/List" )]
    class LoopList : LoopableAutomation {

        public IList Array;
        [ReadOnly]
        public object Value;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            Value = null;
            index = 0;
        }

        public override IEnumerator Execute() {
            if ( index < Array.Count ) {
                Value = Array[index];
            }

            index++;
            yield break;
        }

        public override bool IsDone() {
            return index == Array.Count;
        }
    }

    [Automation( "Loop/Count" )]
    class LoopCount : LoopableAutomation {

        public int Times;
        [ReadOnly]
        public int Result;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = index;
            index++;
            Progress = (float)index / Times;
            yield break;
        }

        public override bool IsDone() {
            return index == Times;
        }
    }


#pragma warning restore 0649
}
