using System.Collections;
using System;
using TNRD.Automatron.Editor.Serialization;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "For Each" )]
    class ForEachLoop : LoopableAutomation {

        public Array Collection;
        public object Value;

        private int index = 0;

        public override void PreExecute() {
            index = 0;
        }

        public override IEnumerator Execute() {
            if ( Collection.Length == 0 ) {
                Progress = 1;
                yield break;
            }

            if ( index < Collection.Length ) {
                Value = Collection.GetValue( index );
            }

            Progress = (float)index / Collection.Length;

            yield break;
        }

        public override bool IsDone() {
            return index == Collection.Length;
        }

        public override void MoveNext() {
            index++;
        }
    }

    [Automation( "For" )]
    class ForLoop : LoopableAutomation {

        public int start = 0;
        public int end = 1;
        public int step = 1;
        [ReadOnly]
        public int current = 0;

        public override void PreExecute() {
            current = start;
        }

        public override IEnumerator Execute() {
            if ( step == 0 ) {
                throw new Exception( "Step is 0 which would cause an infite loop" );
            } else if ( end > start && step < 0 ) {
                throw new Exception( "End is higher than start and your step is negative" );
            } else if ( end < start && step > 0 ) {
                throw new Exception( "End is lower than start and your step is positve" );
            }

            Progress = (float)( current - start ) / ( end - start );
            yield break;
        }

        public override bool IsDone() {
            return current == end;
        }

        public override void MoveNext() {
            current += step;
        }
    }

    [Automation( "For F" )]
    class ForFLoop : LoopableAutomation {

        public float start = 0;
        public float end = 1;
        public float step = 1;
        [ReadOnly]
        public float current = 0;

        public override void PreExecute() {
            current = start;
        }

        public override IEnumerator Execute() {
            if ( step == 0 ) {
                throw new Exception( "Step is 0 which would cause an infite loop" );
            } else if ( end > start && step < 0 ) {
                throw new Exception( "End is higher than start and your step is negative" );
            } else if ( end < start && step > 0 ) {
                throw new Exception( "End is lower than start and your step is positve" );
            }

            Progress = ( current - start ) / ( end - start );
            yield break;
        }

        public override bool IsDone() {
            return current == end;
        }

        public override void MoveNext() {
            current += step;
        }
    }

#pragma warning restore 0649
}
