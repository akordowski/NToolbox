using NToolbox.Globalization;
using NToolbox.NUnit;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.NToolbox
{
	[TestFixture]
	public class PreconditionTest : NUnitTestBase
	{
		#region Tests
		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNullOrEmpty_Throws_Nothing_1")]
		public void IsNotNull_Throws_Nothing(object value)
		{
			Assert.That(() => Precondition.IsNotNull(value), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNullOrEmpty_Throws_Nothing_2")]
		public void IsNotNull_Throws_Nothing(object value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNull(value, parameter), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNullOrEmpty_Throws_Nothing_3")]
		public void IsNotNull_Throws_Nothing(object value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNull(value, parameter, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_Throws_ArgumentNullException_TestCases_1")]
		public void IsNotNull_Throws_ArgumentNullException(Culture culture, object value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNull(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_Throws_ArgumentNullException_TestCases_2")]
		public void IsNotNull_Throws_ArgumentNullException(Culture culture, object value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNull(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_Throws_ArgumentNullException_TestCases_3")]
		public void IsNotNull_Throws_ArgumentNullException(Culture culture, object value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNull(value, parameter, message), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_Nothing_1")]
		public void IsNotNullOrEmpty_Throws_Nothing(ICollection value)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_Nothing_2")]
		public void IsNotNullOrEmpty_Throws_Nothing(ICollection value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value, parameter), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_Nothing_3")]
		public void IsNotNullOrEmpty_Throws_Nothing(ICollection value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value, parameter, message, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_1")]
		public void IsNotNullOrEmpty_Throws_ArgumentNullException(Culture culture, ICollection value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_2")]
		public void IsNotNullOrEmpty_Throws_ArgumentNullException(Culture culture, ICollection value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_3")]
		public void IsNotNullOrEmpty_Throws_ArgumentNullException(Culture culture, ICollection value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, message, null), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_1")]
		public void IsNotNullOrEmpty_Throws_ArgumentEmptyException(Culture culture, ICollection value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentEmptyException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_2")]
		public void IsNotNullOrEmpty_Throws_ArgumentEmptyException(Culture culture, ICollection value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentEmptyException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_3")]
		public void IsNotNullOrEmpty_Throws_ArgumentEmptyException(Culture culture, ICollection value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentEmptyException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, null, message), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_Nothing_1")]
		public void IsNotNullOrEmpty_Throws_Nothing(string value)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_Nothing_2")]
		public void IsNotNullOrEmpty_Throws_Nothing(string value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value, parameter), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_Nothing_3")]
		public void IsNotNullOrEmpty_Throws_Nothing(string value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value, parameter, message, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_1")]
		public void IsNotNullOrEmpty_Throws_ArgumentNullException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_2")]
		public void IsNotNullOrEmpty_Throws_ArgumentNullException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_3")]
		public void IsNotNullOrEmpty_Throws_ArgumentNullException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, message, null), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_1")]
		public void IsNotNullOrEmpty_Throws_ArgumentEmptyException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentEmptyException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_2")]
		public void IsNotNullOrEmpty_Throws_ArgumentEmptyException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentEmptyException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_3")]
		public void IsNotNullOrEmpty_Throws_ArgumentEmptyException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentEmptyException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, null, message), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_Nothing_1")]
		public void IsNotNullOrWhiteSpace_Throws_Nothing(string value)
		{
			Assert.That(() => Precondition.IsNotNullOrWhiteSpace(value), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_Nothing_2")]
		public void IsNotNullOrWhiteSpace_Throws_Nothing(string value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNullOrWhiteSpace(value, parameter), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_Nothing_3")]
		public void IsNotNullOrWhiteSpace_Throws_Nothing(string value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNullOrWhiteSpace(value, parameter, message, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_ArgumentNullException_TestCases_1")]
		public void IsNotNullOrWhiteSpace_Throws_ArgumentNullException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_ArgumentNullException_TestCases_2")]
		public void IsNotNullOrWhiteSpace_Throws_ArgumentNullException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_ArgumentNullException_TestCases_3")]
		public void IsNotNullOrWhiteSpace_Throws_ArgumentNullException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter, message, null), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException_TestCases_1")]
		public void IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentWhiteSpaceException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException_TestCases_2")]
		public void IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentWhiteSpaceException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException_TestCases_3")]
		public void IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentWhiteSpaceException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter, null, message), expectedParameter, expectedMessage, null);
		}
		#endregion
	}
}