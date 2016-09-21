using NToolbox.Extensions;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class TypeExtensionTest
	{
		#region Tests
		[TestCaseSource("IsFloatingPoint_Returns_False_TestCases")]
		public void IsFloatingPoint_Returns_False(Type type)
		{
			Assert.That(type.IsFloatingPoint(), Is.False);
		}

		[TestCaseSource("IsFloatingPoint_Returns_True_TestCases")]
		public void IsFloatingPoint_Returns_True(Type type)
		{
			Assert.That(type.IsFloatingPoint(), Is.True);
		}

		[TestCaseSource("IsIntegral_Returns_False_TestCases")]
		public void IsIntegral_Returns_False(Type type)
		{
			Assert.That(type.IsIntegral(), Is.False);
		}

		[TestCaseSource("IsIntegral_Returns_True_TestCases")]
		public void IsIntegral_Returns_True(Type type)
		{
			Assert.That(type.IsIntegral(), Is.True);
		}

		[TestCaseSource("IsNumeric_Returns_False_TestCases")]
		public void IsNumeric_Returns_False(Type type)
		{
			Assert.That(type.IsNumeric(), Is.False);
		}

		[TestCaseSource("IsNumeric_Returns_True_TestCases")]
		public void IsNumeric_Returns_True(Type type)
		{
			Assert.That(type.IsNumeric(), Is.True);
		}
		#endregion

		#region TestCaseSources
		public static IEnumerable IsFloatingPoint_Returns_False_TestCases()
		{
			yield return new TestCaseData(typeof(Object));
			yield return new TestCaseData(typeof(DBNull));
			yield return new TestCaseData(typeof(Boolean));
			yield return new TestCaseData(typeof(Char));
			yield return new TestCaseData(typeof(SByte));
			yield return new TestCaseData(typeof(Byte));
			yield return new TestCaseData(typeof(Int16));
			yield return new TestCaseData(typeof(UInt16));
			yield return new TestCaseData(typeof(Int32));
			yield return new TestCaseData(typeof(UInt32));
			yield return new TestCaseData(typeof(Int64));
			yield return new TestCaseData(typeof(UInt64));
			yield return new TestCaseData(typeof(Decimal));
			yield return new TestCaseData(typeof(DateTime));
			yield return new TestCaseData(typeof(String));
		}

		public static IEnumerable IsFloatingPoint_Returns_True_TestCases()
		{
			yield return new TestCaseData(typeof(Single));
			yield return new TestCaseData(typeof(Double));
		}

		public static IEnumerable IsIntegral_Returns_False_TestCases()
		{
			yield return new TestCaseData(typeof(Object));
			yield return new TestCaseData(typeof(DBNull));
			yield return new TestCaseData(typeof(Boolean));
			yield return new TestCaseData(typeof(Char));
			yield return new TestCaseData(typeof(Single));
			yield return new TestCaseData(typeof(Double));
			yield return new TestCaseData(typeof(Decimal));
			yield return new TestCaseData(typeof(DateTime));
			yield return new TestCaseData(typeof(String));
		}

		public static IEnumerable IsIntegral_Returns_True_TestCases()
		{
			yield return new TestCaseData(typeof(SByte));
			yield return new TestCaseData(typeof(Byte));
			yield return new TestCaseData(typeof(Int16));
			yield return new TestCaseData(typeof(UInt16));
			yield return new TestCaseData(typeof(Int32));
			yield return new TestCaseData(typeof(UInt32));
			yield return new TestCaseData(typeof(Int64));
			yield return new TestCaseData(typeof(UInt64));
		}

		public static IEnumerable IsNumeric_Returns_False_TestCases()
		{
			yield return new TestCaseData(typeof(Object));
			yield return new TestCaseData(typeof(Boolean));
			yield return new TestCaseData(typeof(Char));
			yield return new TestCaseData(typeof(DateTime));
			yield return new TestCaseData(typeof(String));
		}

		public static IEnumerable IsNumeric_Returns_True_TestCases()
		{
			yield return new TestCaseData(typeof(SByte));
			yield return new TestCaseData(typeof(Byte));
			yield return new TestCaseData(typeof(Int16));
			yield return new TestCaseData(typeof(UInt16));
			yield return new TestCaseData(typeof(Int32));
			yield return new TestCaseData(typeof(UInt32));
			yield return new TestCaseData(typeof(Int64));
			yield return new TestCaseData(typeof(UInt64));
			yield return new TestCaseData(typeof(Single));
			yield return new TestCaseData(typeof(Double));
			yield return new TestCaseData(typeof(Decimal));
		}
		#endregion
	}
}