using NToolbox.NUnit.Data;
using NToolbox.NUnit.Utils;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Tests.TestCaseSources
{
	public static class PreconditionTestCaseSource
	{
		#region Test Case Sources
		public static IEnumerable IsNotNullOrEmpty_Throws_Nothing_1()
		{
			yield return new TestCaseData(new Object());
		}

		public static IEnumerable IsNotNullOrEmpty_Throws_Nothing_2()
		{
			yield return new TestCaseData(new Object(), ExceptionData.Parameter);
		}

		public static IEnumerable IsNotNullOrEmpty_Throws_Nothing_3()
		{
			yield return new TestCaseData(new Object(), ExceptionData.Parameter, ExceptionData.Message);
		}

		public static IEnumerable IsNotNull_Throws_ArgumentNullException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<object>(
				new object[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable IsNotNull_Throws_ArgumentNullException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<object>(
				new object[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable IsNotNull_Throws_ArgumentNullException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<object>(
				new object[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_Nothing_1()
		{
			yield return new TestCaseData(new List<object>(new[] { new Object() }));
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_Nothing_2()
		{
			yield return new TestCaseData(new List<object>(new[] { new Object() }), ExceptionData.Parameter);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_Nothing_3()
		{
			yield return new TestCaseData(new List<object>(new[] { new Object() }), ExceptionData.Parameter, ExceptionData.Message);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<ICollection>(
				new ICollection[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<ICollection>(
				new ICollection[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<ICollection>(
				new ICollection[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<ICollection>(
				new ICollection[] { new List<object>() },
				ExceptionData.ArgumentEmptyExceptionMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<ICollection>(
				new ICollection[] { new List<object>() },
				ExceptionData.ArgumentEmptyExceptionMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<ICollection>(
				new ICollection[] { new List<object>() },
				ExceptionData.ArgumentEmptyExceptionMessage,
				ExceptionData.ArgumentEmptyExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_Nothing_1()
		{
			yield return new TestCaseData(" ");
			yield return new TestCaseData("abc");
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_Nothing_2()
		{
			yield return new TestCaseData(" ", ExceptionData.Parameter);
			yield return new TestCaseData("abc", ExceptionData.Parameter);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_Nothing_3()
		{
			yield return new TestCaseData(" ", ExceptionData.Parameter, ExceptionData.Message);
			yield return new TestCaseData("abc", ExceptionData.Parameter, ExceptionData.Message);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_ArgumentNullException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { "" },
				ExceptionData.ArgumentEmptyExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { "" },
				ExceptionData.ArgumentEmptyExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_Throws_ArgumentEmptyException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { "" },
				ExceptionData.ArgumentEmptyExceptionMessage,
				ExceptionData.ArgumentEmptyExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_Nothing_1()
		{
			yield return new TestCaseData("abc");
			yield return new TestCaseData(" abc ");
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_Nothing_2()
		{
			yield return new TestCaseData("abc", ExceptionData.Parameter);
			yield return new TestCaseData(" abc ", ExceptionData.Parameter);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_Nothing_3()
		{
			yield return new TestCaseData("abc", ExceptionData.Parameter, ExceptionData.Message);
			yield return new TestCaseData(" abc ", ExceptionData.Parameter, ExceptionData.Message);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_ArgumentNullException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_ArgumentNullException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_ArgumentNullException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException_TestCases_1()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { "", " " },
				ExceptionData.ArgumentWhiteSpaceExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException_TestCases_2()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { "", " " },
				ExceptionData.ArgumentWhiteSpaceExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_Throws_ArgumentWhiteSpaceException_TestCases_3()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { "", " " },
				ExceptionData.ArgumentWhiteSpaceExceptionMessage,
				ExceptionData.ArgumentWhiteSpaceExceptionDefaultMessage);
		}
		#endregion
	}
}