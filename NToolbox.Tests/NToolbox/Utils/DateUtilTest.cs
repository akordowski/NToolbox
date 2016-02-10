using NToolbox.Utils;
using NUnit.Framework;
using System;

namespace NToolbox.Tests.NToolbox.Utils
{
	[TestFixture]
	public class DateUtilUnitTest
	{
		#region Tests
		[TestCase(0, 1970, 1, 1, 0, 0, 0)]
		[TestCase(int.MinValue, 1901, 12, 13, 20, 45, 52)]
		[TestCase(int.MaxValue, 2038, 1, 19, 3, 14, 7)]
		public void GetDate_Returns_Valid_Result(int unixTimestamp, int year, int month, int day, int hour, int minute, int second)
		{
			DateTime date = DateTime.MinValue;
			DateTime expectedDate = new DateTime(year, month, day, hour, minute, second);

			Assert.That(() => date = DateUtil.GetDate(unixTimestamp), Throws.Nothing);
			Assert.That(date, Is.EqualTo(expectedDate));
		}
		#endregion
	}
}