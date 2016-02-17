using NToolbox.Extensions;
using NToolbox.NUnit;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class StringExtensionTest : NUnitTestBase
	{
		#region Private Constants
		private const string LowerCaseString = "string";
		private const string MixedCaseString = "sTrInG";
		private const string UpperCaseString = "STRING";
		private const string UrlDecodedText = "This is ^a^ string <that> contains /special characters.";
		private const string UrlEncodedText = "This+is+%5ea%5e+string+%3cthat%3e+contains+%2fspecial+characters.";
		private const string SpaceSeparatedString = "abc def ghi jkl mno";
		private const string CommaSeparatedString = "abc,def,ghi,jkl,mno";
		private const string SemicolonSeparatedString = "abc;def;ghi;jkl;mno";
		#endregion

		#region Tests
		[TestCase(null, ExpectedResult = true)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = false)]
		[TestCase(" string ", ExpectedResult = false)]
		public bool IsNullOrEmpty_Returns_Valid_Result(string value)
		{
			return value.IsNullOrEmpty();
		}

		[TestCase(null, ExpectedResult = true)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = true)]
		[TestCase(" string ", ExpectedResult = false)]
		public bool IsNullOrWhiteSpace_Returns_Valid_Result(string value)
		{
			return value.IsNullOrWhiteSpace();
		}

		[TestCase(LowerCaseString, ExpectedResult = true)]
		[TestCase(MixedCaseString, ExpectedResult = false)]
		[TestCase(UpperCaseString, ExpectedResult = false)]
		public bool IsLowerCase_Returns_Valid_Result(string value)
		{
			return value.IsLowerCase();
		}

		[TestCase(null, "str")]
		public void IsLowerCase_Throws_ArgumentNullException(string value, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsLowerCase(), expectedParameter);
		}

		[TestCase(UpperCaseString, ExpectedResult = true)]
		[TestCase(MixedCaseString, ExpectedResult = false)]
		[TestCase(LowerCaseString, ExpectedResult = false)]
		public bool IsUpperCase_Returns_Valid_Result(string value)
		{
			return value.IsUpperCase();
		}

		[TestCase(null, "str")]
		public void IsUpperCase_Throws_ArgumentNullException(string value, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsUpperCase(), expectedParameter);
		}

		[TestCaseSource("ToArray_TestCases")]
		public void ToArray_Returns_Valid_Result(string str, char separator, string[] expectedResult)
		{
			Assert.That(() => str.ToArray(separator), Is.EqualTo(expectedResult));
		}

		[Test]
		public void ToArray_Throws_ArgumentNullException()
		{
			AssertThrowsException<ArgumentNullException>(() => ((string)null).ToArray(' '), "str");
		}

		[TestCaseSource("ToBoolean_TestCases")]
		public bool ToBoolean_Returns_Valid_Result(string value)
		{
			return value.ToBoolean();
		}

		[TestCase(null, "str")]
		public void ToBoolean_Throws_ArgumentNullException(string value, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.ToBoolean(), expectedParameter);
		}

		[TestCase("")]
		[TestCase("str")]
		public void ToBoolean_Throws_FormatException(string value)
		{
			Assert.That(() => value.ToBoolean(), Throws.InstanceOf<FormatException>());
		}

		[TestCaseSource("ToList_TestCases")]
		public void ToList_Returns_Valid_Result(string str, char separator, List<string> expectedResult)
		{
			Assert.That(() => str.ToList(separator), Is.EqualTo(expectedResult));
		}

		[Test]
		public void ToList_Throws_ArgumentNullException()
		{
			AssertThrowsException<ArgumentNullException>(() => ((string)null).ToList(' '), "str");
		}

		[TestCase(null, null)]
		[TestCase(UrlEncodedText, UrlDecodedText)]
		public void UrlDecode_Returns_Valid_Result(string text, string urlDecodedText)
		{
			Assert.That(() => text.UrlDecode(), Is.EqualTo(urlDecodedText));
		}

		[TestCase(null, null)]
		[TestCase(UrlDecodedText, UrlEncodedText)]
		public void UrlEncode_Returns_Valid_Result(string text, string urlEncodedText)
		{
			Assert.That(() => text.UrlEncode(), Is.EqualTo(urlEncodedText));
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable ToArray_TestCases()
		{
			string[] arr1 = new string[] { SpaceSeparatedString };
			string[] arr2 = new string[] { "abc", "def", "ghi", "jkl", "mno" };

			yield return new TestCaseData(SpaceSeparatedString, null, arr1);
			yield return new TestCaseData(SpaceSeparatedString, ' ', arr2);
			yield return new TestCaseData(CommaSeparatedString, ',', arr2);
			yield return new TestCaseData(SemicolonSeparatedString, ';', arr2);
		}

		public static IEnumerable ToBoolean_TestCases()
		{
			yield return new TestCaseData("0").Returns(false);
			yield return new TestCaseData("1").Returns(true);
			yield return new TestCaseData("no").Returns(false);
			yield return new TestCaseData("yes").Returns(true);
			yield return new TestCaseData("false").Returns(false);
			yield return new TestCaseData("true").Returns(true);
			yield return new TestCaseData(Boolean.FalseString).Returns(false);
			yield return new TestCaseData(Boolean.TrueString).Returns(true);
		}

		public static IEnumerable ToList_TestCases()
		{
			List<string> list1 = new List<string> { SpaceSeparatedString };
			List<string> list2 = new List<string> { "abc", "def", "ghi", "jkl", "mno" };

			yield return new TestCaseData(SpaceSeparatedString, null, list1);
			yield return new TestCaseData(SpaceSeparatedString, ' ', list2);
			yield return new TestCaseData(CommaSeparatedString, ',', list2);
			yield return new TestCaseData(SemicolonSeparatedString, ';', list2);
		}
		#endregion
	}
}