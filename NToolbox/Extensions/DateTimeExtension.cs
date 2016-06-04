using System;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains <see cref="DateTime"/> extension methods.
	/// </summary>
	public static class DateTimeExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Returns the number of days in the month and year of this instance.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <returns>The number of days in month and year represented by this instance.</returns>
		public static int DaysInMonth(this DateTime date)
		{
			return DateTime.DaysInMonth(date.Year, date.Month);
		}

		/// <summary>
		/// Returns a new <see cref="DateTime"/> that represents the first day of month of this
		/// instance.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <returns>An object whose value is the first day of month represented by this
		/// instance.</returns>
		public static DateTime FirstDayOfMonth(this DateTime date)
		{
			return new DateTime(date.Year, date.Month, 1);
		}

		/// <summary>
		/// Returns a new <see cref="DateTime"/> that represents the first day of year of this
		/// instance.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <returns>An object whose value is the first day of year represented by this
		/// instance.</returns>
		public static DateTime FirstDayOfYear(this DateTime date)
		{
			return new DateTime(date.Year, 1, 1);
		}

		/// <summary>
		/// Converts a date to a Unix timestamp.
		/// </summary>
		/// <param name="date">A date to convert.</param>
		/// <returns>A Unix timestamp.</returns>
		public static int GetUnixTimestamp(this DateTime date)
		{
			DateTime date1 = new DateTime(1970, 1, 1, 0, 0, 0);
			DateTime date2 = new DateTime(date.Ticks);

			double seconds1 = new TimeSpan(date1.Ticks).TotalSeconds;
			double seconds2 = new TimeSpan(date2.Ticks).TotalSeconds;

			int timestamp = (int)(seconds2 - seconds1);

			return timestamp;
		}

		/// <summary>
		/// Returns an indication whether the year of this instance is a leap year.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <returns><strong>true</strong> if <em>year</em> of the instance is a leap year;
		/// otherwise, <strong>false</strong>.</returns>
		public static bool IsLeapYear(this DateTime date)
		{
			return DateTime.IsLeapYear(date.Year);
		}

		/// <summary>
		/// Returns a new <see cref="DateTime"/> that represents the last day of month of this
		/// instance.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <returns>An object whose value is the last day of month represented by this
		/// instance.</returns>
		public static DateTime LastDayOfMonth(this DateTime date)
		{
			return FirstDayOfMonth(date).AddMonths(1).AddDays(-1);
		}

		/// <summary>
		/// Returns a new <see cref="DateTime"/> that represents the last day of year of this
		/// instance.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <returns>An object whose value is the last day of year represented by this
		/// instance.</returns>
		public static DateTime LastDayOfYear(this DateTime date)
		{
			return new DateTime(date.Year, 12, 31);
		}

		/// <summary>
		/// Creates a new <see cref="DateTime"/> object that has the same number of ticks as the
		/// specified <see cref="DateTime"/>, but is designated as either local time, Coordinated
		/// Universal Time (UTC), or neither, as indicated by the specified
		/// <see cref="DateTimeKind"/> value.
		/// </summary>
		/// <param name="date">A date and time.</param>
		/// <param name="kind">One of the enumeration values that indicates whether the new object
		/// represents local time, UTC, or neither.</param>
		/// <returns>A new object that has the same number of ticks as the object represented by
		/// the <em>date</em> parameter and the <see cref="DateTimeKind"/> value specified by the
		/// <em>kind</em> parameter.</returns>
		public static DateTime SpecifyKind(this DateTime date, DateTimeKind kind)
		{
			return DateTime.SpecifyKind(date, kind);
		}
		#endregion
	}
}