using NToolbox.Extensions;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class DateTimeExtensionTest
	{
		#region Tests
		[TestCaseSource("DaysInMonth_TestCases")]
		public void DaysInMonth_Returns_Valid_Result(DateTime date, int expectedResult)
		{
			Assert.That(date.DaysInMonth(), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("FirstDayOfMonth_TestCases")]
		public void FirstDayOfMonth_Returns_Valid_Result(DateTime date, DateTime expectedDate)
		{
			Assert.That(date.FirstDayOfMonth(), Is.EqualTo(expectedDate));
		}

		[TestCaseSource("FirstDayOfYear_TestCases")]
		public void FirstDayOfYear_Returns_Valid_Result(DateTime date, DateTime expectedDate)
		{
			Assert.That(date.FirstDayOfYear(), Is.EqualTo(expectedDate));
		}

		[TestCaseSource("GetUnixTimestamp_TestCases")]
		public void GetUnixTimestamp(DateTime date, int expectedResult)
		{
			Assert.That(date.GetUnixTimestamp(), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("IsLeapYear_TestCases")]
		public void IsLeapYear_Returns_Valid_Result(DateTime date, bool expectedResult)
		{
			Assert.That(date.IsLeapYear(), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("LastDayOfMonth_TestCases")]
		public void LastDayOfMonth_Returns_Valid_Result(DateTime date, DateTime expectedDate)
		{
			Assert.That(date.LastDayOfMonth(), Is.EqualTo(expectedDate));
		}

		[TestCaseSource("LastDayOfYear_TestCases")]
		public void LastDayOfYear_Returns_Valid_Result(DateTime date, DateTime expectedDate)
		{
			Assert.That(date.LastDayOfYear(), Is.EqualTo(expectedDate));
		}

		[TestCaseSource("SpecifyKind_TestCases")]
		public void SpecifyKind_Returns_Valid_Result(DateTimeKind kind)
		{
			DateTime date = new DateTime(2016, 1, 11);
			date = date.SpecifyKind(kind);

			Assert.That(date.Kind, Is.EqualTo(kind));
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable DaysInMonth_TestCases()
		{
			yield return new TestCaseData(new DateTime(2016, 1, 1), 31);
			yield return new TestCaseData(new DateTime(2016, 2, 1), 29);
			yield return new TestCaseData(new DateTime(2016, 3, 1), 31);
			yield return new TestCaseData(new DateTime(2016, 4, 1), 30);
			yield return new TestCaseData(new DateTime(2016, 5, 1), 31);
			yield return new TestCaseData(new DateTime(2016, 6, 1), 30);
			yield return new TestCaseData(new DateTime(2016, 7, 1), 31);
			yield return new TestCaseData(new DateTime(2016, 8, 1), 31);
			yield return new TestCaseData(new DateTime(2016, 9, 1), 30);
			yield return new TestCaseData(new DateTime(2016, 10, 1), 31);
			yield return new TestCaseData(new DateTime(2016, 11, 1), 30);
			yield return new TestCaseData(new DateTime(2016, 12, 1), 31);
		}

		public static IEnumerable FirstDayOfMonth_TestCases()
		{
			yield return new TestCaseData(new DateTime(2016, 1, 15), new DateTime(2016, 1, 1));
			yield return new TestCaseData(new DateTime(2016, 2, 15), new DateTime(2016, 2, 1));
			yield return new TestCaseData(new DateTime(2016, 3, 15), new DateTime(2016, 3, 1));
			yield return new TestCaseData(new DateTime(2016, 4, 15), new DateTime(2016, 4, 1));
			yield return new TestCaseData(new DateTime(2016, 5, 15), new DateTime(2016, 5, 1));
			yield return new TestCaseData(new DateTime(2016, 6, 15), new DateTime(2016, 6, 1));
			yield return new TestCaseData(new DateTime(2016, 7, 15), new DateTime(2016, 7, 1));
			yield return new TestCaseData(new DateTime(2016, 8, 15), new DateTime(2016, 8, 1));
			yield return new TestCaseData(new DateTime(2016, 9, 15), new DateTime(2016, 9, 1));
			yield return new TestCaseData(new DateTime(2016, 10, 15), new DateTime(2016, 10, 1));
			yield return new TestCaseData(new DateTime(2016, 11, 15), new DateTime(2016, 11, 1));
			yield return new TestCaseData(new DateTime(2016, 12, 15), new DateTime(2016, 12, 1));
		}

		public static IEnumerable FirstDayOfYear_TestCases()
		{
			yield return new TestCaseData(new DateTime(2016, 7, 15), new DateTime(2016, 1, 1));
		}

		public static IEnumerable GetUnixTimestamp_TestCases()
		{
			yield return new TestCaseData(new DateTime(1970, 1, 1, 0, 0, 0), 0);
			yield return new TestCaseData(new DateTime(1990, 1, 2, 3, 4, 5), 631249445);
			yield return new TestCaseData(new DateTime(1950, 12, 11, 10, 9, 8), -601393852);
		}

		public static IEnumerable IsLeapYear_TestCases()
		{
			yield return new TestCaseData(new DateTime(2011, 1, 1), false);
			yield return new TestCaseData(new DateTime(2012, 1, 1), true);
			yield return new TestCaseData(new DateTime(2015, 1, 1), false);
			yield return new TestCaseData(new DateTime(2016, 1, 1), true);
		}

		public static IEnumerable LastDayOfMonth_TestCases()
		{
			yield return new TestCaseData(new DateTime(2016, 1, 15), new DateTime(2016, 1, 31));
			yield return new TestCaseData(new DateTime(2016, 2, 15), new DateTime(2016, 2, 29));
			yield return new TestCaseData(new DateTime(2016, 3, 15), new DateTime(2016, 3, 31));
			yield return new TestCaseData(new DateTime(2016, 4, 15), new DateTime(2016, 4, 30));
			yield return new TestCaseData(new DateTime(2016, 5, 15), new DateTime(2016, 5, 31));
			yield return new TestCaseData(new DateTime(2016, 6, 15), new DateTime(2016, 6, 30));
			yield return new TestCaseData(new DateTime(2016, 7, 15), new DateTime(2016, 7, 31));
			yield return new TestCaseData(new DateTime(2016, 8, 15), new DateTime(2016, 8, 31));
			yield return new TestCaseData(new DateTime(2016, 9, 15), new DateTime(2016, 9, 30));
			yield return new TestCaseData(new DateTime(2016, 10, 15), new DateTime(2016, 10, 31));
			yield return new TestCaseData(new DateTime(2016, 11, 15), new DateTime(2016, 11, 30));
			yield return new TestCaseData(new DateTime(2016, 12, 15), new DateTime(2016, 12, 31));
		}

		public static IEnumerable LastDayOfYear_TestCases()
		{
			yield return new TestCaseData(new DateTime(2016, 7, 15), new DateTime(2016, 12, 31));
		}

		public static IEnumerable SpecifyKind_TestCases()
		{
			yield return new TestCaseData(DateTimeKind.Local);
			yield return new TestCaseData(DateTimeKind.Unspecified);
			yield return new TestCaseData(DateTimeKind.Utc);
		}
		#endregion
	}
}