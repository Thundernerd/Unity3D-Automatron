using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Random/Get State" )]
	class RandomstateGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Random.State Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.state;
			yield break;
		}

	}

	[Automation( "Random/Set State" )]
	class RandomstateSet0 : Automation {

		public UnityEngine.Random.State Value;

		public override IEnumerator Execute() {
			UnityEngine.Random.state = Value;
			yield break;
		}

	}

	[Automation( "Random/Get Value" )]
	class RandomvalueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.value;
			yield break;
		}

	}

	[Automation( "Random/Get Inside Unit Sphere" )]
	class RandominsideUnitSphereGet2 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.insideUnitSphere;
			yield break;
		}

	}

	[Automation( "Random/Get Inside Unit Circle" )]
	class RandominsideUnitCircleGet3 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector2 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.insideUnitCircle;
			yield break;
		}

	}

	[Automation( "Random/Get On Unit Sphere" )]
	class RandomonUnitSphereGet4 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Vector3 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.onUnitSphere;
			yield break;
		}

	}

	[Automation( "Random/Get Rotation" )]
	class RandomrotationGet5 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.rotation;
			yield break;
		}

	}

	[Automation( "Random/Get Rotation Uniform" )]
	class RandomrotationUniformGet6 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Quaternion Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.rotationUniform;
			yield break;
		}

	}

	[Automation( "Random/Init State" )]
	class RandomInitState0 : Automation {

		public System.Int32 seed;

		public override IEnumerator Execute() {
			UnityEngine.Random.InitState(seed);
			yield break;
		}

	}

	[Automation( "Random/Range F" )]
	class RandomRange1 : Automation {

		public System.Single min;
		public System.Single max;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Single Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.Range(min,max);
			yield break;
		}

	}

	[Automation( "Random/Range" )]
	class RandomRange2 : Automation {

		public System.Int32 min;
		public System.Int32 max;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.Range(min,max);
			yield break;
		}

	}

	[Automation( "Random/Color HSV" )]
	class RandomColorHSV3 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.ColorHSV();
			yield break;
		}

	}

	[Automation( "Random/Color HSV MinMax" )]
	class RandomColorHSV4 : Automation {

		public System.Single hueMin;
		public System.Single hueMax;
		public System.Single saturationMin;
		public System.Single saturationMax;
		public System.Single valueMin;
		public System.Single valueMax;
		public System.Single alphaMin;
		public System.Single alphaMax;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Random.ColorHSV(hueMin,hueMax,saturationMin,saturationMax,valueMin,valueMax,alphaMin,alphaMax);
			yield break;
		}

	}


#pragma warning restore 0649
}
