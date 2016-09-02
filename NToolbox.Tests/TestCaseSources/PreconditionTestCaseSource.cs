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
		#region Test Case Sources - Boolean
		public static IEnumerable IsFalse_With_Invalid_Condition_Throws_Nothing_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<bool>(
				new bool[] { true },
				ExceptionData.ArgumentExceptionIsTrueMessage);
		}

		public static IEnumerable IsFalse_With_Invalid_Condition_And_ParamName_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<bool>(
				new bool[] { true },
				ExceptionData.ArgumentExceptionIsTrueMessage);
		}

		public static IEnumerable IsFalse_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<bool>(
				new bool[] { true },
				ExceptionData.ArgumentExceptionIsTrueMessage,
				ExceptionData.ArgumentExceptionDefaultMessage);
		}

		public static IEnumerable IsTrue_With_Invalid_Condition_Throws_Nothing_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<bool>(
				new bool[] { false },
				ExceptionData.ArgumentExceptionIsTrueMessage);
		}

		public static IEnumerable IsTrue_With_Invalid_Condition_And_ParamName_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<bool>(
				new bool[] { false },
				ExceptionData.ArgumentExceptionIsTrueMessage);
		}

		public static IEnumerable IsTrue_With_Invalid_Condition_And_ParamName_And_Message_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<bool>(
				new bool[] { false },
				ExceptionData.ArgumentExceptionIsTrueMessage,
				ExceptionData.ArgumentExceptionDefaultMessage);
		}
		#endregion

		#region Test Case Sources - Object
		public static IEnumerable IsNotNull_With_Valid_Object_Throws_Nothing_TestCases()
		{
			yield return new TestCaseData(new Object());
		}

		public static IEnumerable IsNotNull_With_Valid_Object_And_ParamName_Throws_Nothing_TestCases()
		{
			yield return new TestCaseData(new Object(), ExceptionData.Parameter);
		}

		public static IEnumerable IsNotNull_With_Valid_Object_And_ParamName_And_Message_Throws_Nothing_TestCases()
		{
			yield return new TestCaseData(new Object(), ExceptionData.Parameter, ExceptionData.Message);
		}

		public static IEnumerable IsNotNull_With_Null_Object_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<object>(
				new object[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable IsNotNull_With_Null_Object_And_ParamName_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<object>(
				new object[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable IsNotNull_With_Null_Object_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<object>(
				new object[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}
		#endregion

		#region Test Case Sources - ICollection
		public static IEnumerable Collection_IsNotNullOrEmpty_With_Valid_Collection_Throws_Nothing_TestCases()
		{
			yield return new TestCaseData(new List<object>(new[] { new Object() }));
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Valid_Collection_And_ParamName_Throws_Nothing_TestCases()
		{
			yield return new TestCaseData(new List<object>(new[] { new Object() }), ExceptionData.Parameter);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Valid_Collection_And_ParamName_And_Message_Throws_Nothing_TestCases()
		{
			yield return new TestCaseData(new List<object>(new[] { new Object() }), ExceptionData.Parameter, ExceptionData.Message);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Null_Collection_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<ICollection>(
				new ICollection[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Null_Collection_And_ParamName_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<ICollection>(
				new ICollection[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Null_Collection_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<ICollection>(
				new ICollection[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Empty_Collection_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<ICollection>(
				new ICollection[] { new List<object>() },
				ExceptionData.ArgumentExceptionEmptyMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Empty_Collection_And_ParamName_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<ICollection>(
				new ICollection[] { new List<object>() },
				ExceptionData.ArgumentExceptionEmptyMessage);
		}

		public static IEnumerable Collection_IsNotNullOrEmpty_With_Empty_Collection_And_ParamName_And_Message_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<ICollection>(
				new ICollection[] { new List<object>() },
				ExceptionData.ArgumentExceptionEmptyMessage,
				ExceptionData.ArgumentExceptionDefaultMessage);
		}
		#endregion

		#region Test Case Sources - String
		public static IEnumerable String_IsNotEmptyOrWhiteSpace_With_Null_String_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { "", "  " },
				ExceptionData.ArgumentExceptionEmptyOrWhiteSpaceMessage);
		}

		public static IEnumerable String_IsNotEmptyOrWhiteSpace_With_Null_String_And_ParamName_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { "", "  " },
				ExceptionData.ArgumentExceptionEmptyOrWhiteSpaceMessage);
		}

		public static IEnumerable String_IsNotEmptyOrWhiteSpace_With_Null_String_And_ParamName_And_Message_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { "", "  " },
				ExceptionData.ArgumentExceptionEmptyOrWhiteSpaceMessage,
				ExceptionData.ArgumentExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_With_Null_String_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_With_Null_String_And_ParamName_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_With_Null_String_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_With_Empty_String_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { "" },
				ExceptionData.ArgumentExceptionEmptyMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_With_Empty_String_And_ParamName_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { "" },
				ExceptionData.ArgumentExceptionEmptyMessage);
		}

		public static IEnumerable String_IsNotNullOrEmpty_With_Empty_String_And_ParamName_And_Message_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { "" },
				ExceptionData.ArgumentExceptionEmptyMessage,
				ExceptionData.ArgumentExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_With_Null_String_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_With_Null_String_And_ParamName_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_With_Null_String_And_ParamName_And_Message_Throws_ArgumentNullException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { null },
				ExceptionData.ArgumentNullExceptionMessage,
				ExceptionData.ArgumentNullExceptionDefaultMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_With_Invalid_String_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataException<string>(
				new string[] { "", " " },
				ExceptionData.ArgumentExceptionWhiteSpaceMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_With_Invalid_String_And_ParamName_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameter<string>(
				new string[] { "", " " },
				ExceptionData.ArgumentExceptionWhiteSpaceMessage);
		}

		public static IEnumerable String_IsNotNullOrWhiteSpace_With_Invalid_String_And_ParamName_And_Message_Throws_ArgumentException_TestCases()
		{
			return TestCaseDataUtil.CreateTestCaseDataExceptionWithParameterAndMessage<string>(
				new string[] { "", " " },
				ExceptionData.ArgumentExceptionWhiteSpaceMessage,
				ExceptionData.ArgumentExceptionDefaultMessage);
		}
		#endregion
	}
}