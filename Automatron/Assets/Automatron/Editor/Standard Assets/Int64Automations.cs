using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Long/Get Max Value" )]
	class Int64MaxValueGet0 : Automation {

		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = System.Int64.MaxValue;
			yield break;
		}

	}

	[Automation( "Long/Get Min Value" )]
	class Int64MinValueGet1 : Automation {

		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = System.Int64.MinValue;
			yield break;
		}

	}

	[Automation( "Long/Parse" )]
	class Int64Parse0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = System.Int64.Parse(s);
			yield break;
		}

	}

	[Automation( "Long/To String" )]
	class Int64ToString1 : Automation {

		public System.Int64 Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
