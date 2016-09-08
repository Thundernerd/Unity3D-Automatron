using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Enum/Get Values" )]
	class EnumGetValues0 : Automation {

		public System.Type enumType;
		[ReadOnly]
		public System.Array Result;

		public override IEnumerator Execute() {
			Result = System.Enum.GetValues(enumType);
			yield break;
		}

	}

	[Automation( "Enum/Get Names" )]
	class EnumGetNames1 : Automation {

		public System.Type enumType;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = System.Enum.GetNames(enumType);
			yield break;
		}

	}

	[Automation( "Enum/Get Name" )]
	class EnumGetName2 : Automation {

		public System.Type enumType;
		public System.Object value;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = System.Enum.GetName(enumType,value);
			yield break;
		}

	}

	[Automation( "Enum/Is Defined" )]
	class EnumIsDefined3 : ConditionalAutomation {

		public System.Type enumType;
		public System.Object value;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.Enum.IsDefined(enumType,value);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Enum/Get Underlying Type" )]
	class EnumGetUnderlyingType4 : Automation {

		public System.Type enumType;
		[ReadOnly]
		public System.Type Result;

		public override IEnumerator Execute() {
			Result = System.Enum.GetUnderlyingType(enumType);
			yield break;
		}

	}

	[Automation( "Enum/Parse" )]
	class EnumParse5 : Automation {

		public System.Type enumType;
		public System.String value;
		public System.Boolean ignoreCase;
		[ReadOnly]
		public System.Object Result;

		public override IEnumerator Execute() {
			Result = System.Enum.Parse(enumType,value,ignoreCase);
			yield break;
		}

	}

	[Automation( "Enum/To String" )]
	class EnumToString6 : Automation {

		public System.Enum Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}


#pragma warning restore 0649
}
