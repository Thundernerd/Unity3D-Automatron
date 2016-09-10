using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Short/Get Max Value" )]
	class Int16MaxValueGet0 : Automation {

		[ReadOnly]
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.MaxValue;
			yield break;
		}

	}

	[Automation( "Short/Get Min Value" )]
	class Int16MinValueGet1 : Automation {

		[ReadOnly]
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
		public System.Int16 Result;

		public override IEnumerator Execute() {
			Result = System.Int16.Parse(s);
			yield break;
		}

	}

	[Automation( "Short/To String" )]
	class Int16ToString1 : Automation {

		public System.Int16 Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
