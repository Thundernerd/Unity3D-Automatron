using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Quaternion/Multiply" )]
    class QuaternionMultiplyQ : Automation {
        
        public Quaternion InOut;
        public Quaternion Rhs;

        public override IEnumerator Execute() {
            InOut *= Rhs;
            yield break;
        }
    }

    [Automation( "Quaternion/Multiply (V3)" )]
    class QuaternionMultiplyV : Automation {
        
        public Quaternion Rotation;
        public Vector3 Point;
        [ReadOnly]
        public Vector3 Value;

        public override void Reset() {
            Value = new Vector3();
        }

        public override IEnumerator Execute() {
            Value = Rotation * Point;
            yield break;
        }
    }

    [Automation( "Quaternion/Random" )]
    class QuaternionRandom : Automation {

        [ReadOnly]
        public Quaternion Value;

        public override void Reset() {
            Value = new Quaternion();
        }

        public override IEnumerator Execute() {
            Value = Random.rotation;
            yield break;
        }
    }

    [Automation( "Quaternion/Random Uniform" )]
    class QuaternionRandomUniform : Automation {

        [ReadOnly]
        public Quaternion Value;

        public override void Reset() {
            Value = new Quaternion();
        }

        public override IEnumerator Execute() {
            Value = Random.rotationUniform;
            yield break;
        }
    }

    [Automation( "Quaternion/Euler" )]
    class QuaternionEuler : Automation {

        public Vector3 Euler;
        [ReadOnly]
        public Quaternion Value;

        public override void Reset() {
            Value = new Quaternion();
        }

        public override IEnumerator Execute() {
            Value = Quaternion.Euler( Euler );
            yield break;
        }
    }

#pragma warning restore 0649
}