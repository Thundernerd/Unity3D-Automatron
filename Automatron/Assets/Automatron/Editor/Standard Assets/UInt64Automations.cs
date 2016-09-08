using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Long/Get Max Value" )]
	class UInt64MaxValueGet0 : Automation {

		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Long/Get Min Value" )]
	class UInt64MinValueGet1 : Automation {

		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.MinValue;
			yield break;
		}

	}

	[Automation( "Unsigned Long/Parse" )]
	class UInt64Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.UInt64 Result;

		public override IEnumerator Execute() {
			Result = System.UInt64.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Long/To String" )]
	class UInt64ToString1 : Automation {

		public System.UInt64 Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
