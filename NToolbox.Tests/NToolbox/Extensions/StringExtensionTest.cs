using NToolbox.Extensions;
using NToolbox.NUnit;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class StringExtensionTest : NUnitTestBase
	{
		#region Private Constants
		private const string LowerCaseString = "string";
		private const string MixedCaseString = "sTrInG";
		private const string UpperCaseString = "STRING";
		private const string DefaultText = "This is ^a^ string <that> contains /special characters.";
		private const string Base64EncodedText = "VGhpcyBpcyBeYV4gc3RyaW5nIDx0aGF0PiBjb250YWlucyAvc3BlY2lhbCBjaGFyYWN0ZXJzLg==";
		private const string UrlEncodedText = "This+is+%5ea%5e+string+%3cthat%3e+contains+%2fspecial+characters.";
		private const string SpaceSeparatedString = "abc def ghi jkl mno";
		private const string CommaSeparatedString = "abc,def,ghi,jkl,mno";
		private const string SemicolonSeparatedString = "abc;def;ghi;jkl;mno";
		#endregion

		#region Tests
		[TestCase(Base64EncodedText, DefaultText)]
		public void Base64Decode_Returns_Valid_Result(string base64Text, string expectedValue)
		{
			Assert.That(base64Text.Base64Decode(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, null, "str")]
		[TestCase(Base64EncodedText, null, "encoding")]
		public void Base64Decode_Throws_ArgumentNullException(string value, Encoding encoding, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.Base64Decode(encoding), expectedParameter);
		}

		[TestCase(DefaultText, Base64EncodedText)]
		public void Base64Encode_Returns_Valid_Result(string defaultText, string expectedValue)
		{
			Assert.That(defaultText.Base64Encode(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, null, "str")]
		[TestCase(DefaultText, null, "encoding")]
		public void Base64Encode_Throws_ArgumentNullException(string value, Encoding encoding, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.Base64Encode(encoding), expectedParameter);
		}

		[TestCase(DefaultText, false)]
		[TestCase(Base64EncodedText, true)]
		public void IsBase64_Returns_Valid_Result(string base64Text, bool expectedValue)
		{
			Assert.That(base64Text.IsBase64(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, "str")]
		public void IsBase64_Throws_ArgumentNullException(string value, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsBase64(), expectedParameter);
		}

		[TestCase(null, ExpectedResult = false)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = false)]
		public bool IsEmpty_Return_Valid_Result(string value)
		{
			return value.IsEmpty();
		}

		[TestCase(null, ExpectedResult = false)]
		[TestCase("str", ExpectedResult = false)]
		[TestCase(" str ", ExpectedResult = false)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = true)]
		public bool IsEmptyOrWhiteSpace_Return_Valid_Result(string value)
		{
			return value.IsEmptyOrWhiteSpace();
		}

		[TestCase(null, ExpectedResult = true)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = false)]
		[TestCase(" str ", ExpectedResult = false)]
		public bool IsNullOrEmpty_Returns_Valid_Result(string value)
		{
			return value.IsNullOrEmpty();
		}

		[TestCase(null, ExpectedResult = true)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = true)]
		[TestCase(" str ", ExpectedResult = false)]
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

		[TestCase(null, ExpectedResult = false)]
		[TestCase("", ExpectedResult = true)]
		[TestCase("  ", ExpectedResult = true)]
		public bool IsWhiteSpace_Return_Valid_Result(string value)
		{
			return value.IsWhiteSpace();
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

		[TestCase(null, (byte)0)]
		[TestCase("1", (byte)1)]
		public void ToByte_Returns_Valid_Result(string value, byte expectedValue)
		{
			Assert.That(value.ToByte(), Is.EqualTo(expectedValue));
		}

		[TestCase("a", 'a')]
		public void ToChar_Returns_Valid_Result(string value, char expectedValue)
		{
			Assert.That(value.ToChar(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, "str")]
		public void ToChar_Throws_ArgumentNullException(string value, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.ToChar(), expectedParameter);
		}

		[TestCaseSource("ToDateTime_TestCases")]
		public void ToDateTime_Returns_Valid_Result(string value, DateTime expectedValue)
		{
			Assert.That(value.ToDateTime(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, 0)]
		[TestCase("1", 1)]
		public void ToDecimal_Returns_Valid_Result(string value, decimal expectedValue)
		{
			Assert.That(value.ToDecimal(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (double)0)]
		[TestCase("1", (double)1)]
		public void ToDouble_Returns_Valid_Result(string value, double expectedValue)
		{
			Assert.That(value.ToDouble(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (short)0)]
		[TestCase("1", (short)1)]
		public void ToInt16_Returns_Valid_Result(string value, short expectedValue)
		{
			Assert.That(value.ToInt16(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (int)0)]
		[TestCase("1", (int)1)]
		public void ToInt32_Returns_Valid_Result(string value, int expectedValue)
		{
			Assert.That(value.ToInt32(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (long)0)]
		[TestCase("1", (long)1)]
		public void ToInt64_Returns_Valid_Result(string value, long expectedValue)
		{
			Assert.That(value.ToInt64(), Is.EqualTo(expectedValue));
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

		[TestCase(null, (sbyte)0)]
		[TestCase("1", (sbyte)1)]
		public void ToSByte_Returns_Valid_Result(string value, sbyte expectedValue)
		{
			Assert.That(value.ToSByte(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (float)0)]
		[TestCase("1", (float)1)]
		public void ToSingle_Returns_Valid_Result(string value, float expectedValue)
		{
			Assert.That(value.ToSingle(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (ushort)0)]
		[TestCase("1", (ushort)1)]
		public void ToUInt16_Returns_Valid_Result(string value, ushort expectedValue)
		{
			Assert.That(value.ToUInt16(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (uint)0)]
		[TestCase("1", (uint)1)]
		public void ToUInt32_Returns_Valid_Result(string value, uint expectedValue)
		{
			Assert.That(value.ToUInt32(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, (ulong)0)]
		[TestCase("1", (ulong)1)]
		public void ToUInt64_Returns_Valid_Result(string value, ulong expectedValue)
		{
			Assert.That(value.ToUInt64(), Is.EqualTo(expectedValue));
		}

		[TestCase(null, null)]
		[TestCase(UrlEncodedText, DefaultText)]
		public void UrlDecode_Returns_Valid_Result(string text, string urlDecodedText)
		{
			Assert.That(() => text.UrlDecode(), Is.EqualTo(urlDecodedText));
		}

		[TestCase(null, null)]
		[TestCase(DefaultText, UrlEncodedText)]
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

		public static IEnumerable ToDateTime_TestCases()
		{
			yield return new TestCaseData(null, DateTime.MinValue);
			yield return new TestCaseData("01.01.2016", new DateTime(2016, 1, 1));
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