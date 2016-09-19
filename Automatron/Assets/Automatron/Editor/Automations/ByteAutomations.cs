#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Byte/Get Min Value" )]
	class ByteMinValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = System.Byte.MinValue;
			yield break;
		}

	}

	[Automation( "Byte/Get Max Value" )]
	class ByteMaxValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = System.Byte.MaxValue;
			yield break;
		}

	}

	[Automation( "Byte/Equals" )]
	class ByteEquals0 : ConditionalAutomation {

		public System.Byte Instance;
		public System.Object obj;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = Instance.Equals(obj);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Byte/Parse" )]
	class ByteParse1 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Byte Result;

		public override IEnumerator Execute() {
			Result = System.Byte.Parse(s);
			yield break;
		}

	}

	[Automation( "Byte/Try Parse" )]
	class ByteTryParse2 : ConditionalAutomation {

		public System.String s;
		public System.Byte result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.Byte.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}


#pragma warning restore 0649
}

#endif