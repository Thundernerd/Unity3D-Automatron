using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Short/Get Max Value" )]
	class UInt16MaxValueGet0 : Automation {

		[ReadOnly]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Short/Get Min Value" )]
	class UInt16MinValueGet1 : Automation {

		[ReadOnly]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.MinValue;
			yield break;
		}

	}

	[Automation( "Unsigned Short/Parse" )]
	class UInt16Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.UInt16 Result;

		public override IEnumerator Execute() {
			Result = System.UInt16.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Short/To String" )]
	class UInt16ToString1 : Automation {

		public System.UInt16 Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
