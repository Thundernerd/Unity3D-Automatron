using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Primitives/Double/Add" )]
    class DoubleAdd : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut += Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Subtract" )]
    class DoubleSubtract : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut -= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Multiply" )]
    class DoubleMultiply : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut *= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Divide" )]
    class DoubleDivide : Automation {

        public double InOut;
        public double Value;

        public override IEnumerator Execute() {
            InOut /= Value;
            yield break;
        }
    }

    [Automation( "Primitives/Double/Create" )]
    class DoubleCreate : Automation {

        public double InOut;

        public override IEnumerator Execute() {
            yield break;
        }
    }

#pragma warning restore 0649
}