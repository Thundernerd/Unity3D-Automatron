using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Byte/Get Min Value" )]
	class ByteMinValueGet0 : Automation {

		[ReadOnly]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = System.Byte.MinValue;
			yield break;
		}

	}

	[Automation( "Byte/Get Max Value" )]
	class ByteMaxValueGet1 : Automation {

		[ReadOnly]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = System.Byte.MaxValue;
			yield break;
		}

	}

	[Automation( "Byte/Parse" )]
	class ByteParse0 : Automation {

		public System.String s;
		[ReadOnly]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = System.Byte.Parse(s);
			yield break;
		}

	}

	[Automation( "Byte/To String" )]
	class ByteToString1 : Automation {

		public System.Byte Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
