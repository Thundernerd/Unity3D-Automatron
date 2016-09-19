#if UNITY_EDITOR
using System.Collections;

namespace TNRD.Automatron.Automations.Generated {
#pragma warning disable 0649

	[Automation( "Date Time/Get Max Value" )]
	class DateTimeMaxValueGet0 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.MaxValue;
			yield break;
		}

	}

	[Automation( "Date Time/Get Min Value" )]
	class DateTimeMinValueGet1 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.MinValue;
			yield break;
		}

	}

	[Automation( "Date Time/Get Date" )]
	class DateTimeDateGet0 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.Date;
			yield break;
		}

	}

	[Automation( "Date Time/Get Month" )]
	class DateTimeMonthGet1 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Month;
			yield break;
		}

	}

	[Automation( "Date Time/Get Day" )]
	class DateTimeDayGet2 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Day;
			yield break;
		}

	}

	[Automation( "Date Time/Get Day Of Week" )]
	class DateTimeDayOfWeekGet3 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DayOfWeek Result;

		public override IEnumerator Execute() {
			Result = Instance.DayOfWeek;
			yield break;
		}

	}

	[Automation( "Date Time/Get Day Of Year" )]
	class DateTimeDayOfYearGet4 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.DayOfYear;
			yield break;
		}

	}

	[Automation( "Date Time/Get Time Of Day" )]
	class DateTimeTimeOfDayGet5 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.TimeSpan Result;

		public override IEnumerator Execute() {
			Result = Instance.TimeOfDay;
			yield break;
		}

	}

	[Automation( "Date Time/Get Hour" )]
	class DateTimeHourGet6 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Hour;
			yield break;
		}

	}

	[Automation( "Date Time/Get Minute" )]
	class DateTimeMinuteGet7 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Minute;
			yield break;
		}

	}

	[Automation( "Date Time/Get Second" )]
	class DateTimeSecondGet8 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Second;
			yield break;
		}

	}

	[Automation( "Date Time/Get Millisecond" )]
	class DateTimeMillisecondGet9 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Millisecond;
			yield break;
		}

	}

	[Automation( "Date Time/Get Now" )]
	class DateTimeNowGet10 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Now;
			yield break;
		}

	}

	[Automation( "Date Time/Get Ticks" )]
	class DateTimeTicksGet11 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.Ticks;
			yield break;
		}

	}

	[Automation( "Date Time/Get Today" )]
	class DateTimeTodayGet12 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Today;
			yield break;
		}

	}

	[Automation( "Date Time/Get Utc Now" )]
	class DateTimeUtcNowGet13 : Automation {

		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.UtcNow;
			yield break;
		}

	}

	[Automation( "Date Time/Get Year" )]
	class DateTimeYearGet14 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Year;
			yield break;
		}

	}

	[Automation( "Date Time/Get Kind" )]
	class DateTimeKindGet15 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTimeKind Result;

		public override IEnumerator Execute() {
			Result = Instance.Kind;
			yield break;
		}

	}

	[Automation( "Date Time/Add" )]
	class DateTimeAdd0 : Automation {

		public System.DateTime Instance;
		public System.TimeSpan value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.Add(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Days" )]
	class DateTimeAddDays1 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddDays(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Ticks" )]
	class DateTimeAddTicks2 : Automation {

		public System.DateTime Instance;
		public System.Int64 value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddTicks(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Hours" )]
	class DateTimeAddHours3 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddHours(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Milliseconds" )]
	class DateTimeAddMilliseconds4 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddMilliseconds(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Minutes" )]
	class DateTimeAddMinutes5 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddMinutes(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Months" )]
	class DateTimeAddMonths6 : Automation {

		public System.DateTime Instance;
		public System.Int32 months;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddMonths(months);
			yield break;
		}

	}

	[Automation( "Date Time/Add Seconds" )]
	class DateTimeAddSeconds7 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddSeconds(value);
			yield break;
		}

	}

	[Automation( "Date Time/Add Years" )]
	class DateTimeAddYears8 : Automation {

		public System.DateTime Instance;
		public System.Int32 value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddYears(value);
			yield break;
		}

	}

	[Automation( "Date Time/Get Date Time Formats" )]
	class DateTimeGetDateTimeFormats9 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDateTimeFormats();
			yield break;
		}

	}

	[Automation( "Date Time/Is Leap Year" )]
	class DateTimeIsLeapYear10 : ConditionalAutomation {

		public System.Int32 year;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.IsLeapYear(year);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Date Time/Parse" )]
	class DateTimeParse11 : Automation {

		public System.String s;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Parse(s);
			yield break;
		}

	}

	[Automation( "Date Time/Try Parse" )]
	class DateTimeTryParse12 : ConditionalAutomation {

		public System.String s;
		public System.DateTime result;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Boolean Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Date Time/Subtract" )]
	class DateTimeSubtract13 : Automation {

		public System.DateTime Instance;
		public System.DateTime value;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.TimeSpan Result;

		public override IEnumerator Execute() {
			Result = Instance.Subtract(value);
			yield break;
		}

	}

	[Automation( "Date Time/To File Time" )]
	class DateTimeToFileTime14 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.ToFileTime();
			yield break;
		}

	}

	[Automation( "Date Time/To Long Date String" )]
	class DateTimeToLongDateString15 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLongDateString();
			yield break;
		}

	}

	[Automation( "Date Time/To Long Time String" )]
	class DateTimeToLongTimeString16 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLongTimeString();
			yield break;
		}

	}

	[Automation( "Date Time/To OA Date" )]
	class DateTimeToOADate17 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.ToOADate();
			yield break;
		}

	}

	[Automation( "Date Time/To Short Date String" )]
	class DateTimeToShortDateString18 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToShortDateString();
			yield break;
		}

	}

	[Automation( "Date Time/To Short Time String" )]
	class DateTimeToShortTimeString19 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToShortTimeString();
			yield break;
		}

	}

	[Automation( "Date Time/To String" )]
	class DateTimeToString20 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}

	[Automation( "Date Time/To Local Time" )]
	class DateTimeToLocalTime21 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLocalTime();
			yield break;
		}

	}

	[Automation( "Date Time/To Universal Time" )]
	class DateTimeToUniversalTime22 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		[Editor.Serialization.IgnoreSerialization]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUniversalTime();
			yield break;
		}

	}


#pragma warning restore 0649
}

#endif