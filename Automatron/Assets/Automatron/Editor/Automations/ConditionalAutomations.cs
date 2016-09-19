#if UNITY_EDITOR
﻿using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Conditional/Equals" )]
    class ConditionalEquals : ConditionalAutomation {

        public object A;
        public object B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            if ( A == null ) {
                if ( B == null ) {
                    Result = true;
                } else {
                    Result = false;
                }
            }
            Result = A.Equals( B );
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Contains" )]
    class ConditionalContains : ConditionalAutomation {

        public IList List;
        public object Value;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = List.Contains( Value );
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }


    [Automation( "Conditional/Greater Than" )]
    class ConditionalGreaterThan : ConditionalAutomation {

        public int A;
        public int B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A > B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Greater or Equal" )]
    class ConditionalGreaterEqual : ConditionalAutomation {

        public int A;
        public int B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A >= B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Smaller Than" )]
    class ConditionalSmallerThan : ConditionalAutomation {

        public int A;
        public int B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A < B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Smaller or Equal" )]
    class ConditionalSmallerEqual : ConditionalAutomation {

        public int A;
        public int B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A <= B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Greater Than F" )]
    class ConditionalGreaterThanF : ConditionalAutomation {

        public float A;
        public float B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A > B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Greater or Equal F" )]
    class ConditionalGreaterEqualF : ConditionalAutomation {

        public float A;
        public float B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A >= B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Smaller Than F" )]
    class ConditionalSmallerThanF : ConditionalAutomation {

        public float A;
        public float B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A < B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Smaller or Equal F" )]
    class ConditionalSmallerEqualF : ConditionalAutomation {

        public float A;
        public float B;
        [ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
        public bool Result;

        public override IEnumerator Execute() {
            Result = A <= B;
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

    [Automation( "Conditional/Simple Condition" )]
    class ConditionalSimpleCondition : ConditionalAutomation {

        public bool Result;

        public override IEnumerator Execute() {
            yield break;
        }

        public override bool GetConditionalResult() {
            return Result;
        }
    }

#pragma warning restore 0649
}

#endif