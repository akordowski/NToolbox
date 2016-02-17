using NToolbox.Extensions;
using NToolbox.NUnit;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class CollectionExtensionTest : NUnitTestBase
	{
		#region Tests
		[TestCaseSource("IsNullOrEmpty_TestCases")]
		public void IsNullOrEmpty(ICollection col, bool expectedResult)
		{
			Assert.That(col.IsNullOrEmpty(), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("ToString_Int_Collection_TestCases")]
		public void ToString_Int_Collection_Returns_Valid_Result(ICollection<int> col, string separator, string expectedResult)
		{
			Assert.That(() => col.ToString(separator), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("ToString_String_Collection_TestCases")]
		public void ToString_String_Collection_Returns_Valid_Result(ICollection<string> col, string separator, string expectedResult)
		{
			Assert.That(() => col.ToString(separator), Is.EqualTo(expectedResult));
		}

		[Test]
		public void ToString_Throws_ArgumentNullException()
		{
			AssertThrowsException<ArgumentNullException>(() => ((ICollection<string>)null).ToString(""), "col");
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable IsNullOrEmpty_TestCases()
		{
			yield return new TestCaseData(null, true);
			yield return new TestCaseData(new List<string>(), true);
			yield return new TestCaseData(new List<string>(new[] { "abc" }), false);
		}

		public static IEnumerable ToString_Int_Collection_TestCases()
		{
			int[] arr = new int[] { 123, 456, 789 };
			List<int> list = new List<int> { 123, 456, 789 };

			yield return new TestCaseData(arr, " ", "123 456 789");
			yield return new TestCaseData(arr, ",", "123,456,789");
			yield return new TestCaseData(arr, ";", "123;456;789");
			yield return new TestCaseData(list, " ", "123 456 789");
			yield return new TestCaseData(list, ",", "123,456,789");
			yield return new TestCaseData(list, ";", "123;456;789");

		}

		public static IEnumerable ToString_String_Collection_TestCases()
		{
			string[] arr = new string[] { "abc", "def", "ghi", "jkl", "mno" };
			List<string> list = new List<string> { "abc", "def", "ghi", "jkl", "mno" };

			yield return new TestCaseData(arr, " ", "abc def ghi jkl mno");
			yield return new TestCaseData(arr, ",", "abc,def,ghi,jkl,mno");
			yield return new TestCaseData(arr, ";", "abc;def;ghi;jkl;mno");
			yield return new TestCaseData(list, " ", "abc def ghi jkl mno");
			yield return new TestCaseData(list, ",", "abc,def,ghi,jkl,mno");
			yield return new TestCaseData(list, ";", "abc;def;ghi;jkl;mno");

		}
		#endregion
	}
}