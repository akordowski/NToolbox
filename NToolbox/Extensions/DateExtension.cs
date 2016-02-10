using System;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains Date extension methods.
	/// </summary>
	public static class DateExtension
	{
		#region Public Static Methods
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
		#endregion
	}
}