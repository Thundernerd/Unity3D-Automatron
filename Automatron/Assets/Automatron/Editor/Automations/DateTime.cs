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

	[Automation( "Generated/Date Time/Get Date" )]
	class DateTimeDateGet0 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.Date;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Month" )]
	class DateTimeMonthGet1 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Month;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Day" )]
	class DateTimeDayGet2 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Day;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Day Of Week" )]
	class DateTimeDayOfWeekGet3 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.DayOfWeek Result;

		public override IEnumerator Execute() {
			Result = Instance.DayOfWeek;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Day Of Year" )]
	class DateTimeDayOfYearGet4 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.DayOfYear;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Time Of Day" )]
	class DateTimeTimeOfDayGet5 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.TimeSpan Result;

		public override IEnumerator Execute() {
			Result = Instance.TimeOfDay;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Hour" )]
	class DateTimeHourGet6 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Hour;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Minute" )]
	class DateTimeMinuteGet7 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Minute;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Second" )]
	class DateTimeSecondGet8 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Second;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Millisecond" )]
	class DateTimeMillisecondGet9 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Millisecond;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Now" )]
	class DateTimeNowGet10 : Automation {

		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = System.DateTime.Now;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Ticks" )]
	class DateTimeTicksGet11 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.Ticks;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Get Today" )]
	class DateTimeTodayGet12 : Automation {

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

	[Automation( "Generated/Date Time/Get Year" )]
	class DateTimeYearGet14 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int32 Result;

		public override IEnumerator Execute() {
			Result = Instance.Year;
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add" )]
	class DateTimeAdd0 : Automation {

		public System.DateTime Instance;
		public System.TimeSpan value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.Add(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Days" )]
	class DateTimeAddDays1 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddDays(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Ticks" )]
	class DateTimeAddTicks2 : Automation {

		public System.DateTime Instance;
		public System.Int64 value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddTicks(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Hours" )]
	class DateTimeAddHours3 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddHours(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Milliseconds" )]
	class DateTimeAddMilliseconds4 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddMilliseconds(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Minutes" )]
	class DateTimeAddMinutes5 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddMinutes(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Months" )]
	class DateTimeAddMonths6 : Automation {

		public System.DateTime Instance;
		public System.Int32 months;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddMonths(months);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Seconds" )]
	class DateTimeAddSeconds7 : Automation {

		public System.DateTime Instance;
		public System.Double value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddSeconds(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Add Years" )]
	class DateTimeAddYears8 : Automation {

		public System.DateTime Instance;
		public System.Int32 value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.AddYears(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Is Daylight Saving Time" )]
	class DateTimeIsDaylightSavingTime11 : ConditionalAutomation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = Instance.IsDaylightSavingTime();
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Date Time/To Binary" )]
	class DateTimeToBinary14 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.ToBinary();
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

	[Automation( "Generated/Date Time/Get Date Time Formats" )]
	class DateTimeGetDateTimeFormats23 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.String[] Result;

		public override IEnumerator Execute() {
			Result = Instance.GetDateTimeFormats();
			yield break;
		}

	}

	[Automation( "Date Time/Is Leap Year" )]
	class DateTimeIsLeapYear29 : ConditionalAutomation {

		public System.Int32 year;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.DateTime.IsLeapYear(year);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
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
	class DateTimeTryParse36 : ConditionalAutomation {

		public System.String s;
		public System.DateTime result;
		[ReadOnly]
		public System.Boolean Result;

		public override IEnumerator ExecuteCondition() {
			Result = System.DateTime.TryParse(s,out result);
			yield break;
		}

		public override bool GetConditionalResult() {
			return Result;
		}
	}

	[Automation( "Generated/Date Time/Subtract" )]
	class DateTimeSubtract40 : Automation {

		public System.DateTime Instance;
		public System.DateTime value;
		[ReadOnly]
		public System.TimeSpan Result;

		public override IEnumerator Execute() {
			Result = Instance.Subtract(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/Subtract (TimeSpan)" )]
	class DateTimeSubtract41 : Automation {

		public System.DateTime Instance;
		public System.TimeSpan value;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.Subtract(value);
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To File Time" )]
	class DateTimeToFileTime42 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.ToFileTime();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To File Time Utc" )]
	class DateTimeToFileTimeUtc43 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Int64 Result;

		public override IEnumerator Execute() {
			Result = Instance.ToFileTimeUtc();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To Long Date String" )]
	class DateTimeToLongDateString44 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLongDateString();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To Long Time String" )]
	class DateTimeToLongTimeString45 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLongTimeString();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To OA Date" )]
	class DateTimeToOADate46 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.Double Result;

		public override IEnumerator Execute() {
			Result = Instance.ToOADate();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To Short Date String" )]
	class DateTimeToShortDateString47 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToShortDateString();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To Short Time String" )]
	class DateTimeToShortTimeString48 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToShortTimeString();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To String" )]
	class DateTimeToString49 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To String" )]
	class DateTimeToString51 : Automation {

		public System.DateTime Instance;
		public System.String format;
		[ReadOnly]
		public System.String Result;

		public override IEnumerator Execute() {
			Result = Instance.ToString(format);
			yield break;
		}

	}


	[Automation( "Generated/Date Time/To Local Time" )]
	class DateTimeToLocalTime53 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.ToLocalTime();
			yield break;
		}

	}

	[Automation( "Generated/Date Time/To Universal Time" )]
	class DateTimeToUniversalTime54 : Automation {

		public System.DateTime Instance;
		[ReadOnly]
		public System.DateTime Result;

		public override IEnumerator Execute() {
			Result = Instance.ToUniversalTime();
			yield break;
		}

	}
#pragma warning restore 0649
}
