using NToolbox.Globalization;
using NToolbox.NUnit.Data;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.NUnit.Utils
{
	public static class TestCaseDataUtil
	{
		#region Public Static Methods
		public static IEnumerable CreateTestCaseDataException<T>(T[] values, IDictionary<Culture, string> exceptionMessages)
		{
			foreach (KeyValuePair<Culture, string> item in exceptionMessages)
			{
				foreach (T value in values)
				{
					yield return new TestCaseData(item.Key, value, null, item.Value);
				}
			}
		}

		public static IEnumerable CreateTestCaseDataExceptionWithParameter<T>(T[] values, IDictionary<Culture, string> exceptionMessages)
		{
			foreach (KeyValuePair<Culture, string> item in exceptionMessages)
			{
				foreach (T value in values)
				{
					yield return new TestCaseData(item.Key, value, null, null, item.Value);
					yield return new TestCaseData(item.Key, value, ExceptionData.Parameter, ExceptionData.Parameter, item.Value);
				}
			}
		}

		public static IEnumerable CreateTestCaseDataExceptionWithParameterAndMessage<T>(T[] values, IDictionary<Culture, string> exceptionMessages, IDictionary<Culture, string> exceptionDefaultMessages)
		{
			foreach (KeyValuePair<Culture, string> item in exceptionMessages)
			{
				foreach (T value in values)
				{
					yield return new TestCaseData(item.Key, value, null, ExceptionData.Message, null, ExceptionData.Message);
					yield return new TestCaseData(item.Key, value, ExceptionData.Parameter, ExceptionData.Message, ExceptionData.Parameter, ExceptionData.Message);
				}
			}

			foreach (KeyValuePair<Culture, string> item in exceptionDefaultMessages)
			{
				foreach (T value in values)
				{
					yield return new TestCaseData(item.Key, value, null, null, null, item.Value);
					yield return new TestCaseData(item.Key, value, ExceptionData.Parameter, null, ExceptionData.Parameter, item.Value);
				}
			}
		}
		#endregion
	}
}