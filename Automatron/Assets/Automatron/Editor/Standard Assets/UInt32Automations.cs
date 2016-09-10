using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Unsigned Int/Get Max Value" )]
	class UInt32MaxValueGet0 : Automation {

		[ReadOnly]
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.MaxValue;
			yield break;
		}

	}

	[Automation( "Unsigned Int/Get Min Value" )]
	class UInt32MinValueGet1 : Automation {

		[ReadOnly]
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
		public System.UInt32 Result;

		public override IEnumerator Execute() {
			Result = System.UInt32.Parse(s);
			yield break;
		}

	}

	[Automation( "Unsigned Int/To String" )]
	class UInt32ToString1 : Automation {

		public System.UInt32 Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
