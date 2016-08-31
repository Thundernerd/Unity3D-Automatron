using System.Collections;
using UnityEngine;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

    [Automation( "Random/Quaternion" )]
    class QuaternionRandom : Automation {

        [ReadOnly]
        public Quaternion Value;

        public override void Reset() {
            base.Reset();
            Value = new Quaternion();
        }

        public override IEnumerator Execute() {
            Value = Random.rotation;
            yield break;
        }
    }

    [Automation( "Random/Quaternion Uniform" )]
    class QuaternionRandomUniform : Automation {

        [ReadOnly]
        public Quaternion Value;

        public override void Reset() {
            base.Reset();
            Value = new Quaternion();
        }

        public override IEnumerator Execute() {
            Value = Random.rotationUniform;
            yield break;
        }
    }

    [Automation( "Random/Vector2" )]
    class RandomVector2 : Automation {

        public Vector2 Value;
        public float XMin;
        public float XMax;
        public float YMin;
        public float YMax;

        public override IEnumerator Execute() {
            Value = new Vector2(
                XMin == XMax ? 0 : Random.Range( XMin, XMax ),
                YMin == YMax ? 0 : Random.Range( YMin, YMax ) );
            yield break;
        }
    }

    [Automation( "Random/Vector3" )]
    class RandomVector3 : Automation {

        public Vector3 Value;
        public float XMin;
        public float XMax;
        public float YMin;
        public float YMax;
        public float ZMin;
        public float ZMax;

        public override IEnumerator Execute() {
            Value = new Vector3(
                XMin == XMax ? 0 : Random.Range( XMin, XMax ),
                YMin == YMax ? 0 : Random.Range( YMin, YMax ),
                ZMin == ZMax ? 0 : Random.Range( ZMin, ZMax ) );
            yield break;
        }
    }
    
    [Automation( "Random/Vector4" )]
    class RandomVector4 : Automation {

        public Vector4 Value;
        public float XMin;
        public float XMax;
        public float YMin;
        public float YMax;
        public float ZMin;
        public float ZMax;
        public float WMin;
        public float WMax;

        public override IEnumerator Execute() {
            Value = new Vector4(
                XMin == XMax ? 0 : Random.Range( XMin, XMax ),
                YMin == YMax ? 0 : Random.Range( YMin, YMax ),
                ZMin == ZMax ? 0 : Random.Range( ZMin, ZMax ),
                WMin == WMax ? 0 : Random.Range( WMin, WMax ) );
            yield break;
        }
    }

    [Automation( "Random/Range (float)" )]
	class RandomRange0 : Automation {

		public System.Single min;
		public System.Single max;
		[ReadOnly]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.Range(min,max);
			yield break;
		}

	}

	[Automation( "Random/Range (int)" )]
	class RandomRange1 : Automation {

		public System.Int32 min;
		public System.Int32 max;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.Range(min,max);
			yield break;
		}

	}

	[Automation( "Random/Color HSV Simple" )]
	class RandomColorHSV2 : Automation {

		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.ColorHSV();
			yield break;
		}

	}

	[Automation( "Random/Color HSV Advanced" )]
	class RandomColorHSV6 : Automation {

		public System.Single hueMin;
		public System.Single hueMax;
		public System.Single saturationMin;
		public System.Single saturationMax;
		public System.Single valueMin;
		public System.Single valueMax;
		public System.Single alphaMin;
		public System.Single alphaMax;
		[ReadOnly]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.ColorHSV(hueMin,hueMax,saturationMin,saturationMax,valueMin,valueMax,alphaMin,alphaMax);
			yield break;
		}

	}


#pragma warning restore 0649
}
