using NToolbox.Globalization;
using NToolbox.NUnit;
using NToolbox.NUnit.Data;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.NToolbox
{
	[TestFixture]
	public class PreconditionTest : NUnitTestBase
	{
		#region Tests - Boolean
		[Test]
		public void IsFalse_With_Valid_Condition_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsFalse(false));
		}

		[Test]
		public void IsFalse_With_Valid_Condition_And_ParamName_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsFalse(false, ExceptionData.Parameter));
		}

		[Test]
		public void IsFalse_With_Valid_Condition_And_ParamName_And_Message_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsFalse(false, ExceptionData.Parameter, ExceptionData.Message));
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsFalse_With_Invalid_Condition_Throws_Nothing_TestCases")]
		public void IsFalse_With_Invalid_Condition_Throws_ArgumentException(Culture culture, bool value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsFalse(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsFalse_With_Invalid_Condition_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsFalse_With_Invalid_Condition_And_ParamName_Throws_ArgumentException(Culture culture, bool value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsFalse(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsFalse_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsFalse_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, bool value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsFalse(value, parameter, message), expectedParameter, expectedMessage, null);
		}

		[Test]
		public void IsFalse_With_Valid_Condition_Delegate_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsFalse(() => false));
		}

		[Test]
		public void IsFalse_With_Valid_Condition_Delegate_And_ParamName_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsFalse(() => false, ExceptionData.Parameter));
		}

		[Test]
		public void IsFalse_With_Valid_Condition_Delegate_And_ParamName_And_Message_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsFalse(() => false, ExceptionData.Parameter, ExceptionData.Message));
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsFalse_With_Invalid_Condition_Throws_Nothing_TestCases")]
		public void IsFalse_With_Invalid_Condition_Delegate_Throws_ArgumentException(Culture culture, bool value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsFalse(() => value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsFalse_With_Invalid_Condition_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsFalse_With_Invalid_Condition_Delegate_And_ParamName_Throws_ArgumentException(Culture culture, bool value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsFalse(() => value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsFalse_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsFalse_With_Invalid_Condition_Delegate_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, bool value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsFalse(() => value, parameter, message), expectedParameter, expectedMessage, null);
		}

		[Test]
		public void IsTrue_With_Valid_Condition_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsTrue(true));
		}

		[Test]
		public void IsTrue_With_Valid_Condition_And_ParamName_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsTrue(true, ExceptionData.Parameter));
		}

		[Test]
		public void IsTrue_With_Valid_Condition_And_ParamName_And_Message_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsTrue(true, ExceptionData.Parameter, ExceptionData.Message));
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsTrue_With_Invalid_Condition_Throws_Nothing_TestCases")]
		public void IsTrue_With_Invalid_Condition_Throws_ArgumentException(Culture culture, bool value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsTrue(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsTrue_With_Invalid_Condition_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsTrue_With_Invalid_Condition_And_ParamName_Throws_ArgumentException(Culture culture, bool value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsTrue(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsTrue_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsTrue_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, bool value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsTrue(value, parameter, message), expectedParameter, expectedMessage, null);
		}

		[Test]
		public void IsTrue_With_Valid_Condition_Delegate_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsTrue(() => true));
		}

		[Test]
		public void IsTrue_With_Valid_Condition_Delegate_And_ParamName_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsTrue(() => true, ExceptionData.Parameter));
		}

		[Test]
		public void IsTrue_With_Valid_Condition_Delegate_And_ParamName_And_Message_Throws_Nothing()
		{
			AssertThrowsNothing(() => Precondition.IsTrue(() => true, ExceptionData.Parameter, ExceptionData.Message));
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsTrue_With_Invalid_Condition_Throws_Nothing_TestCases")]
		public void IsTrue_With_Invalid_Condition_Delegate_Throws_ArgumentException(Culture culture, bool value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsTrue(() => value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsTrue_With_Invalid_Condition_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsTrue_With_Invalid_Condition_Delegate_And_ParamName_Throws_ArgumentException(Culture culture, bool value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsTrue(() => value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsTrue_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsTrue_With_Invalid_Condition_Delegate_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, bool value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsTrue(() => value, parameter, message), expectedParameter, expectedMessage, null);
		}
		#endregion

		#region Tests - Object
		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_With_Valid_Object_Throws_Nothing_TestCases")]
		public void IsNotNull_With_Valid_Object_Throws_Nothing(object value)
		{
			Assert.That(() => Precondition.IsNotNull(value), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_With_Valid_Object_And_ParamName_Throws_Nothing_TestCases")]
		public void IsNotNull_With_Valid_Object_And_ParamName_Throws_Nothing(object value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNull(value, parameter), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_With_Valid_Object_And_ParamName_And_Message_Throws_Nothing_TestCases")]
		public void IsNotNull_With_Valid_Object_And_ParamName_And_Message_Throws_Nothing(object value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNull(value, parameter, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_With_Null_Object_Throws_ArgumentNullException_TestCases")]
		public void IsNotNull_With_Null_Object_Throws_ArgumentNullException(Culture culture, object value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNull(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_With_Null_Object_And_ParamName_Throws_ArgumentNullException_TestCases")]
		public void IsNotNull_With_Null_Object_And_ParamName_Throws_ArgumentNullException(Culture culture, object value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNull(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "IsNotNull_With_Null_Object_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases")]
		public void IsNotNull_With_Null_Object_And_ParamName_And_Message_Throws_ArgumentNullException(Culture culture, object value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNull(value, parameter, message), expectedParameter, expectedMessage, null);
		}
		#endregion

		#region Tests - ICollection
		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Valid_Collection_Throws_Nothing_TestCases")]
		public void IsNotNullOrEmpty_With_Valid_Collection_Throws_Nothing(ICollection value)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Valid_Collection_And_ParamName_Throws_Nothing_TestCases")]
		public void IsNotNullOrEmpty_With_Valid_Collection_And_ParamName_Throws_Nothing(ICollection value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value, parameter), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Valid_Collection_And_ParamName_And_Message_Throws_Nothing_TestCases")]
		public void IsNotNullOrEmpty_With_Valid_Collection_And_ParamName_And_Message_Throws_Nothing(ICollection value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNullOrEmpty(value, parameter, message, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Null_Collection_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrEmpty_With_Null_Collection_Throws_ArgumentNullException(Culture culture, ICollection value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Null_Collection_And_ParamName_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrEmpty_With_Null_Collection_And_ParamName_Throws_ArgumentNullException(Culture culture, ICollection value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Null_Collection_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrEmpty_With_Null_Collection_And_ParamName_And_Message_Throws_ArgumentNullException(Culture culture, ICollection value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, message, null), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Empty_Collection_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrEmpty_With_Empty_Collection_Throws_ArgumentException(Culture culture, ICollection value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Empty_Collection_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrEmpty_With_Empty_Collection_And_ParamName_Throws_ArgumentException(Culture culture, ICollection value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "Collection_IsNotNullOrEmpty_With_Empty_Collection_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrEmpty_With_Empty_Collection_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, ICollection value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, null, message), expectedParameter, expectedMessage, null);
		}
		#endregion

		#region Tests - String
		[TestCase(null)]
		[TestCase("str")]
		[TestCase(" str ")]
		public void IsNotEmptyOrWhiteSpace_With_Valid_String_Throws_Nothing(string value)
		{
			AssertThrowsNothing(() => Precondition.IsNotEmptyOrWhiteSpace(value));
		}

		[TestCase(null, ExceptionData.Parameter)]
		[TestCase("str", ExceptionData.Parameter)]
		[TestCase(" str ", ExceptionData.Parameter)]
		public void IsNotEmptyOrWhiteSpace_With_Valid_String_Throws_Nothing(string value, string parameter)
		{
			AssertThrowsNothing(() => Precondition.IsNotEmptyOrWhiteSpace(value, parameter));
		}

		[TestCase(null, ExceptionData.Parameter, ExceptionData.Message)]
		[TestCase("str", ExceptionData.Parameter, ExceptionData.Message)]
		[TestCase(" str ", ExceptionData.Parameter, ExceptionData.Message)]
		public void IsNotEmptyOrWhiteSpace_With_Valid_String_Throws_Nothing(string value, string parameter, string message)
		{
			AssertThrowsNothing(() => Precondition.IsNotEmptyOrWhiteSpace(value, parameter, message));
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotEmptyOrWhiteSpace_With_Null_String_Throws_ArgumentException_TestCases")]
		public void IsNotEmptyOrWhiteSpace_With_Null_String_Throws_ArgumentException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotEmptyOrWhiteSpace(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotEmptyOrWhiteSpace_With_Null_String_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsNotEmptyOrWhiteSpace_With_Null_String_And_ParamName_Throws_ArgumentException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotEmptyOrWhiteSpace(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotEmptyOrWhiteSpace_With_Null_String_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsNotEmptyOrWhiteSpace_With_Null_String_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotEmptyOrWhiteSpace(value, parameter, message), expectedParameter, expectedMessage, null);
		}

		[TestCase(" ")]
		[TestCase("abc")]
		public void IsNotNullOrEmpty_With_Valid_String_Throws_Nothing(string value)
		{
			AssertThrowsNothing(() => Precondition.IsNotNullOrEmpty(value));
		}

		[TestCase(" ", ExceptionData.Parameter)]
		[TestCase("abc", ExceptionData.Parameter)]
		public void IsNotNullOrEmpty_With_Valid_String_And_ParamName_Throws_Nothing(string value, string parameter)
		{
			AssertThrowsNothing(() => Precondition.IsNotNullOrEmpty(value, parameter));
		}

		[TestCase(" ", ExceptionData.Parameter, ExceptionData.Message)]
		[TestCase("abc", ExceptionData.Parameter, ExceptionData.Message)]
		public void IsNotNullOrEmpty_With_Valid_String_And_ParamName_And_Message_Throws_Nothing(string value, string parameter, string message)
		{
			AssertThrowsNothing(() => Precondition.IsNotNullOrEmpty(value, parameter, message, message));
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_With_Null_String_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrEmpty_With_Null_String_Throws_ArgumentNullException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_With_Null_String_And_ParamName_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrEmpty_With_Null_String_And_ParamName_Throws_ArgumentNullException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_With_Null_String_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrEmpty_With_Null_String_And_ParamName_And_Message_Throws_ArgumentNullException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, message, null), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_With_Empty_String_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrEmpty_With_Empty_String_Throws_ArgumentException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrEmpty(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_With_Empty_String_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrEmpty_With_Empty_String_And_ParamName_Throws_ArgumentException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrEmpty_With_Empty_String_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrEmpty_With_Empty_String_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrEmpty(value, parameter, null, message), expectedParameter, expectedMessage, null);
		}

		[TestCase("abc")]
		[TestCase(" abc ")]
		public void IsNotNullOrWhiteSpace_With_Valid_String_Throws_Nothing(string value)
		{
			Assert.That(() => Precondition.IsNotNullOrWhiteSpace(value), Throws.Nothing);
		}

		[TestCase("abc", ExceptionData.Parameter)]
		[TestCase(" abc ", ExceptionData.Parameter)]
		public void IsNotNullOrWhiteSpace_With_Valid_String_And_ParamName_Throws_Nothing(string value, string parameter)
		{
			Assert.That(() => Precondition.IsNotNullOrWhiteSpace(value, parameter), Throws.Nothing);
		}

		[TestCase("abc", ExceptionData.Parameter, ExceptionData.Message)]
		[TestCase(" abc ", ExceptionData.Parameter, ExceptionData.Message)]
		public void IsNotNullOrWhiteSpace_With_Valid_String_And_ParamName_And_Message_Throws_Nothing(string value, string parameter, string message)
		{
			Assert.That(() => Precondition.IsNotNullOrWhiteSpace(value, parameter, message, message), Throws.Nothing);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_With_Null_String_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrWhiteSpace_With_Null_String_Throws_ArgumentNullException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_With_Null_String_And_ParamName_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrWhiteSpace_With_Null_String_And_ParamName_Throws_ArgumentNullException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_With_Null_String_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases")]
		public void IsNotNullOrWhiteSpace_With_Null_String_And_ParamName_And_Message_Throws_ArgumentNullException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentNullException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter, message, null), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_With_Invalid_String_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrWhiteSpace_With_Invalid_String_Throws_ArgumentException(Culture culture, string value, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_With_Invalid_String_And_ParamName_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrWhiteSpace_With_Invalid_String_And_ParamName_Throws_ArgumentException(Culture culture, string value, string parameter, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter), expectedParameter, expectedMessage, null);
		}

		[TestCaseSource(typeof(PreconditionTestCaseSource), "String_IsNotNullOrWhiteSpace_With_Invalid_String_And_ParamName_And_Message_Throws_ArgumentException_TestCases")]
		public void IsNotNullOrWhiteSpace_With_Invalid_String_And_ParamName_And_Message_Throws_ArgumentException(Culture culture, string value, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			AssertThrowsException<ArgumentException>(culture, () => Precondition.IsNotNullOrWhiteSpace(value, parameter, null, message), expectedParameter, expectedMessage, null);
		}
		#endregion
	}
}