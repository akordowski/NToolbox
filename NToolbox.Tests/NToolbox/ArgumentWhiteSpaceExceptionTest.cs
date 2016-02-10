using NToolbox.Globalization;
using NToolbox.NUnit;
using NToolbox.NUnit.Data;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Tests.NToolbox
{
	[TestFixture]
	public class ArgumentWhiteSpaceExceptionTest : NUnitTestBase
	{
		#region Tests
		[Test]
		public void Class_IsSerializable()
		{
			Assert.That(typeof(ArgumentWhiteSpaceException).IsSerializable, Is.True);
		}

		[TestCaseSource("Constructor_TestCases")]
		public void Initialize_Constructor(Culture culture, string expectedParameter, string expectedMessage)
		{
			SetCulture(culture);

			ArgumentWhiteSpaceException ex = null;

			Assert.That(() => ex = new ArgumentWhiteSpaceException(), Throws.Nothing);
			Assert.That(ex.ParamName, Is.EqualTo(expectedParameter));
			Assert.That(ex.Message, Is.EqualTo(expectedMessage));
			Assert.That(ex.InnerException, Is.EqualTo(null));
		}

		[TestCaseSource("Constructor_With_Parameter_TestCases")]
		public void Initialize_Constructor_With_Parameter(Culture culture, string parameter, string expectedParameter, string expectedMessage)
		{
			SetCulture(culture);

			ArgumentWhiteSpaceException ex = null;

			Assert.That(() => ex = new ArgumentWhiteSpaceException(parameter), Throws.Nothing);
			Assert.That(ex.ParamName, Is.EqualTo(expectedParameter));
			Assert.That(ex.Message, Does.StartWith(expectedMessage));
			Assert.That(ex.InnerException, Is.EqualTo(null));
		}

		[TestCaseSource("Constructor_With_Parameter_And_Message_TestCases")]
		public void Initialize_Constructor_With_Parameter(Culture culture, string parameter, string message, string expectedParameter, string expectedMessage)
		{
			SetCulture(culture);

			ArgumentWhiteSpaceException ex = null;

			Assert.That(() => ex = new ArgumentWhiteSpaceException(parameter, message), Throws.Nothing);
			Assert.That(ex.ParamName, Is.EqualTo(expectedParameter));
			Assert.That(ex.Message, Does.StartWith(expectedMessage));
			Assert.That(ex.InnerException, Is.EqualTo(null));
		}

		[TestCaseSource("Constructor_With_Message_And_InnerException_TestCases")]
		public void Initialize_Constructor_With_Parameter(Culture culture, string message, Exception innerException, string expectedMessage, Exception expectedInnerException)
		{
			SetCulture(culture);

			ArgumentWhiteSpaceException ex = null;

			Assert.That(() => ex = new ArgumentWhiteSpaceException(message, innerException), Throws.Nothing);
			Assert.That(ex.ParamName, Is.EqualTo(null));
			Assert.That(ex.Message, Does.StartWith(expectedMessage));
			Assert.That(ex.InnerException, Is.EqualTo(expectedInnerException));
		}
		#endregion

		#region Test Cases
		public static IEnumerable Constructor_TestCases()
		{
			foreach (KeyValuePair<Culture, string> item in ExceptionData.ArgumentWhiteSpaceExceptionMessage)
			{
				yield return new TestCaseData(item.Key, null, item.Value);
			}
		}

		public static IEnumerable Constructor_With_Parameter_TestCases()
		{
			string parameter = ExceptionData.Parameter;

			foreach (KeyValuePair<Culture, string> item in ExceptionData.ArgumentWhiteSpaceExceptionMessage)
			{
				yield return new TestCaseData(item.Key, null, null, item.Value);
				yield return new TestCaseData(item.Key, parameter, parameter, item.Value);
			}
		}

		public static IEnumerable Constructor_With_Parameter_And_Message_TestCases()
		{
			string message = ExceptionData.Message;
			string parameter = ExceptionData.Parameter;

			foreach (KeyValuePair<Culture, string> item in ExceptionData.ArgumentWhiteSpaceExceptionMessage)
			{
				yield return new TestCaseData(item.Key, null, message, null, message);
				yield return new TestCaseData(item.Key, parameter, message, parameter, message);
			}

			foreach (KeyValuePair<Culture, string> item in ExceptionData.ArgumentWhiteSpaceExceptionDefaultMessage)
			{
				yield return new TestCaseData(item.Key, null, null, null, item.Value);
				yield return new TestCaseData(item.Key, parameter, null, parameter, item.Value);
			}
		}

		public static IEnumerable Constructor_With_Message_And_InnerException_TestCases()
		{
			string message = ExceptionData.Message;
			Exception innerException = new Exception();

			foreach (KeyValuePair<Culture, string> item in ExceptionData.ArgumentWhiteSpaceExceptionMessage)
			{
				yield return new TestCaseData(item.Key, message, null, message, null);
				yield return new TestCaseData(item.Key, message, innerException, message, innerException);
			}

			foreach (KeyValuePair<Culture, string> item in ExceptionData.ArgumentWhiteSpaceExceptionDefaultMessage)
			{
				yield return new TestCaseData(item.Key, null, null, item.Value, null);
				yield return new TestCaseData(item.Key, null, innerException, item.Value, innerException);
			}
		}
		#endregion
	}
}