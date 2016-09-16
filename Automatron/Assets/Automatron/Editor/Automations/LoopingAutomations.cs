using System.Collections;
using System;
using TNRD.Automatron.Editor.Serialization;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Loop/Array" )]
    class LoopArray : LoopableAutomation {

        [IgnoreSerialization]
        public Array Array;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public object Value;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            Value = null;
            index = 0;
        }

        public override IEnumerator Execute() {
            if ( Array.Length == 0 ) {
                Progress = 1;
                yield break;
            }

            if ( index < Array.Length ) {
                Value = Array.GetValue( index );
            }

            Progress = (float)index / Array.Length;

            yield break;
        }

        public override void MoveNext() {
            index++;
        }

        public override bool IsDone() {
            return index >= Array.Length;
        }
    }

    [Automation( "Loop/List" )]
    class LoopList : LoopableAutomation {

        [IgnoreSerialization]
        public IList Array;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
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

            Progress = (float)index / Array.Count;

            yield break;
        }

        public override void MoveNext() {
            index++;
        }

        public override bool IsDone() {
            return index >= Array.Count;
        }
    }

    [Automation( "Loop/Count" )]
    class LoopCount : LoopableAutomation {

        [IgnoreSerialization]
        public int Times;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public int Result;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = 0;
        }

        public override IEnumerator Execute() {
            Result = index;
            Progress = (float)index / Times;
            yield break;
        }

        public override void MoveNext() {
            index++;
        }

        public override bool IsDone() {
            return index == Times;
        }
    }


#pragma warning restore 0649
}
