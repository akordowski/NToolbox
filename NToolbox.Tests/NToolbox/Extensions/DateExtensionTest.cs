using NToolbox.Extensions;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class DateExtensionTest
	{
		#region Tests
		[TestCaseSource("GetUnixTimestamp_TestCases")]
		public void GetUnixTimestamp(DateTime date, int expectedResult)
		{
			Assert.That(date.GetUnixTimestamp(), Is.EqualTo(expectedResult));
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable GetUnixTimestamp_TestCases()
		{
			yield return new TestCaseData(new DateTime(1970, 1, 1, 0, 0, 0), 0);
			yield return new TestCaseData(new DateTime(1990, 1, 2, 3, 4, 5), 631249445);
			yield return new TestCaseData(new DateTime(1950, 12, 11, 10, 9, 8), -601393852);
		}
		#endregion
	}
}