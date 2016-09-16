using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Int/Get Max Value" )]
	class UInt32MaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Int/Get Min Value" )]
	class UInt32MinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.MinValue;
			yield break;
		}

	}

	[Automation( "Unsigned Int/Parse" )]
	class UInt32Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Int/Try Parse" )]
	class UInt32TryParse1 : ConditionalAutomation {

		public System.String s;
		public System.UInt32 result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}
