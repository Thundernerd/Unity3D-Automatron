using System.Collections;

namespace TNRD.Automatron.Automations {
#pragma warning disable 0649

	[Automation( "Date Time/Get Max Value" )]
	class DateTimeMaxValueGet0 : Automation {

		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.MaxValue;
			yield break;
		}

	}

	[Automation( "Date Time/Get Min Value" )]
	class DateTimeMinValueGet1 : Automation {

		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.MinValue;
			yield break;
		}

	}

	[Automation( "Date Time/Get Now" )]
	class DateTimeNowGet0 : Automation {

		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Now;
			yield break;
		}

	}

	[Automation( "Date Time/Get Today" )]
	class DateTimeTodayGet1 : Automation {

		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Today;
			yield break;
		}

	}

	[Automation( "Date Time/Get Utc Now" )]
	class DateTimeUtcNowGet2 : Automation {

		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.UtcNow;
			yield break;
		}

	}

	[Automation( "Date Time/From Binary" )]
	class DateTimeFromBinary1 : Automation {

		public System.Int64 dateData;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.FromBinary(dateData);
			yield break;
		}

	}

	[Automation( "Date Time/Specify Kind" )]
	class DateTimeSpecifyKind2 : Automation {

		public System.DateTime value;
		public System.DateTimeKind kind;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.SpecifyKind(value,kind);
			yield break;
		}

	}

	[Automation( "Date Time/Days In Month" )]
	class DateTimeDaysInMonth3 : Automation {

		public System.Int32 year;
		public System.Int32 month;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.DaysInMonth(year,month);
			yield break;
		}

	}

	[Automation( "Date Time/From File Time" )]
	class DateTimeFromFileTime5 : Automation {

		public System.Int64 fileTime;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.FromFileTime(fileTime);
			yield break;
		}

	}

	[Automation( "Date Time/From File Time Utc" )]
	class DateTimeFromFileTimeUtc6 : Automation {

		public System.Int64 fileTime;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.FromFileTimeUtc(fileTime);
			yield break;
		}

	}

	[Automation( "Date Time/From OA Date" )]
	class DateTimeFromOADate7 : Automation {

		public System.Double d;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.FromOADate(d);
			yield break;
		}

	}

	[Automation( "Date Time/Is Leap Year" )]
	class DateTimeIsLeapYear8 : Automation {

		public System.Int32 year;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.IsLeapYear(year);
			yield break;
		}

	}

	[Automation( "Date Time/Parse" )]
	class DateTimeParse9 : Automation {

		public System.String s;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Parse(s);
			yield break;
		}

	}

	[Automation( "Date Time/Parse Exact" )]
	class DateTimeParseExact12 : Automation {

		public System.String s;
		public System.String format;
		public System.IFormatProvider provider;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.ParseExact(s,format,provider);
			yield break;
		}

	}

	[Automation( "Date Time/Try Parse" )]
	class DateTimeTryParse15 : Automation {

		public System.String s;
		public System.DateTime result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.TryParse(s,out result);
			yield break;
		}

	}

	[Automation( "Date Time/Try Parse" )]
	class DateTimeTryParse16 : Automation {

		public System.String s;
		public System.IFormatProvider provider;
		public System.Globalization.DateTimeStyles styles;
		public System.DateTime result;
		[ReadOnly]
		public System.Boolean ParseResult;

		public override IEnumerator Execute() {
			ParseResult = System.DateTime.TryParse(s,provider,styles,out result);
			yield break;
		}

	}


#pragma warning restore 0649
}
