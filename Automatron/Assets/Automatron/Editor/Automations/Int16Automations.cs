#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Short/Get Max Value" )]
	class Int16MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.MaxValue;
			yield break;
		}

	}

	[Automation( "Short/Get Min Value" )]
	class Int16MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.MinValue;
			yield break;
		}

	}

	[Automation( "Short/Parse" )]
	class Int16Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.Parse(s);
			yield break;
		}

	}

	[Automation( "Short/Try Parse" )]
	class Int16TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.Int16 result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Int16.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}

#endif