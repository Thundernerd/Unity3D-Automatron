using System;
using System.Collections;
using System.Collections.Generic;
using TNRD.Editor.Serialization;
using UnityEngine;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

    [Automation( "Loop/Game Objects" )]
    class LoopGameObjects : LoopableAutomation {

        [ReadOnly]
        public GameObject Result;
        public GameObject[] GameObjects;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = null;
        }

        public override IEnumerator Execute() {
            Result = GameObjects[index];
            index++;
            Progress = (float)index / GameObjects.Length;
            yield break;
        }

        public override bool IsDone() {
            return index == GameObjects.Length;
        }
    }

    [Automation( "Loop/Strings" )]
    class LoopString : LoopableAutomation {

        [ReadOnly]
        public string Result;
        public string[] Values;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = "";
        }

        public override IEnumerator Execute() {
            Result = Values[index];
            index++;
            Progress = (float)index / Values.Length;
            yield break;
        }

        public override bool IsDone() {
            return index == Values.Length;
        }
    }

    [Automation( "Loop/Count" )]
    class LoopInt : LoopableAutomation {

        public int Times;
        [ReadOnly]
        [IgnoreSerialization]
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

    [Automation( "Loop/Array" )]
    class LoopArray : LoopableAutomation {

        [ReadOnly]
        [IgnoreSerialization]
        public object Result;
        [IgnoreSerialization]
        public Array Items;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = null;
        }

        public override IEnumerator Execute() {
            Result = Items.GetValue( index );
            index++;
            Progress = (float)index / Items.Length;
            yield break;
        }

        public override bool IsDone() {
            return index == Items.Length;
        }
    }

    [Automation( "Loop/List" )]
    class LoopList : LoopableAutomation {

        [ReadOnly]
        [IgnoreSerialization]
        public object Result;
        [IgnoreSerialization]
        public List<object> Items;

        private int index = 0;

        public override void Reset() {
            base.Reset();
            index = 0;
            Result = null;
        }

        public override IEnumerator Execute() {
            Result = Items[index];
            index++;
            Progress = (float)index / Items.Count;
            yield break;
        }

        public override bool IsDone() {
            return index == Items.Count;
        }
    }

#pragma warning restore 0649
}
