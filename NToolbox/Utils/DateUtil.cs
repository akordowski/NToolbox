using System;

namespace NToolbox.Utils
{
	/// <summary>
	/// Contains date methods.
	/// </summary>
	public static class DateUtil
	{
		#region Public Static Methods
		/// <summary>
		/// Converts a Unix timestamp to a date.
		/// </summary>
		/// <param name="unixTimestamp">A Unix timestamp to convert.</param>
		/// <returns>A date represents the Unix timestamp.</returns>
		public static DateTime GetDate(int unixTimestamp)
		{
			TimeSpan timespan = new TimeSpan(0, 0, unixTimestamp);
			DateTime date = new DateTime(1970, 1, 1, 0, 0, 0);
			date = date.Add(timespan);

			return date;
		}
		#endregion
	}
}