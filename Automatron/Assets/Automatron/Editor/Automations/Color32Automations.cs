using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Color 32/Get R" )]
	class Color32rGet0 : Automation {

		public UnityEngine.Color32 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = Instance.r;
			yield break;
		}

	}

	[Automation( "Color 32/Set R" )]
	class Color32rSet0 : Automation {

		public UnityEngine.Color32 Instance;
		public System.Byte Value;

		public override IEnumerator Execute() {
			Instance.r = Value;
			yield break;
		}

	}

	[Automation( "Color 32/Get G" )]
	class Color32gGet1 : Automation {

		public UnityEngine.Color32 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = Instance.g;
			yield break;
		}

	}

	[Automation( "Color 32/Set G" )]
	class Color32gSet1 : Automation {

		public UnityEngine.Color32 Instance;
		public System.Byte Value;

		public override IEnumerator Execute() {
			Instance.g = Value;
			yield break;
		}

	}

	[Automation( "Color 32/Get B" )]
	class Color32bGet2 : Automation {

		public UnityEngine.Color32 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = Instance.b;
			yield break;
		}

	}

	[Automation( "Color 32/Set B" )]
	class Color32bSet2 : Automation {

		public UnityEngine.Color32 Instance;
		public System.Byte Value;

		public override IEnumerator Execute() {
			Instance.b = Value;
			yield break;
		}

	}

	[Automation( "Color 32/Get A" )]
	class Color32aGet3 : Automation {

		public UnityEngine.Color32 Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = Instance.a;
			yield break;
		}

	}

	[Automation( "Color 32/Set A" )]
	class Color32aSet3 : Automation {

		public UnityEngine.Color32 Instance;
		public System.Byte Value;

		public override IEnumerator Execute() {
			Instance.a = Value;
			yield break;
		}

	}

	[Automation( "Color 32/Lerp" )]
	class Color32Lerp0 : Automation {

		public UnityEngine.Color32 a;
		public UnityEngine.Color32 b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color32.Lerp(a,b,t);
			yield break;
		}

	}

	[Automation( "Color 32/Lerp Unclamped" )]
	class Color32LerpUnclamped1 : Automation {

		public UnityEngine.Color32 a;
		public UnityEngine.Color32 b;
		public System.Single t;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public UnityEngine.Color32 Result;

		public override IEnumerator Execute() {
			Result = UnityEngine.Color32.LerpUnclamped(a,b,t);
			yield break;
		}

	}


#pragma warning restore 0649
}
