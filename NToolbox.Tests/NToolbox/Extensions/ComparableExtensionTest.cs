using NToolbox.Extensions;
using NToolbox.NUnit;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class ComparableExtensionTest : NUnitTestBase
	{
		#region Tests
		[TestCase(0, 0, 10, true)]
		[TestCase(5, 0, 10, true)]
		[TestCase(10, 0, 10, true)]
		[TestCase(-1, 0, 10, false)]
		[TestCase(11, 0, 10, false)]
		public void IsBetween_Returns_Valid_Result(int value, int min, int max, bool expectedResult)
		{
			Assert.That(value.IsBetween(min, max), Is.EqualTo(expectedResult));
		}

		[TestCase(null, null, null, "value")]
		[TestCase(1, null, null, "min")]
		[TestCase(1, 1, null, "max")]
		public void IsBetween_Throws_ArgumentNullException(IComparable value, IComparable min, IComparable max, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsBetween(min, max), expectedParameter);
		}

		[TestCase(0, 1, false)]
		[TestCase(1, 1, true)]
		public void IsEqual_Returns_Valid_Result(int value, int referenceValue, bool expectedResult)
		{
			Assert.That(value.IsEqual(referenceValue), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("Comparable_TestCases")]
		public void IsEqual_Throws_ArgumentNullException(IComparable value, IComparable referenceValue, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsEqual(referenceValue), expectedParameter);
		}

		[TestCase(1, 0, true)]
		[TestCase(1, 1, true)]
		[TestCase(1, 2, false)]
		public void IsGreaterOrEqual_Returns_Valid_Result(int value, int referenceValue, bool expectedResult)
		{
			Assert.That(value.IsGreaterOrEqual(referenceValue), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("Comparable_TestCases")]
		public void IsGreaterOrEqual_Throws_ArgumentNullException(IComparable value, IComparable referenceValue, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsGreaterOrEqual(referenceValue), expectedParameter);
		}

		[TestCase(1, 0, true)]
		[TestCase(1, 2, false)]
		public void IsGreater_Returns_Valid_Result(int value, int referenceValue, bool expectedResult)
		{
			Assert.That(value.IsGreater(referenceValue), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("Comparable_TestCases")]
		public void IsGreater_Throws_ArgumentNullException(IComparable value, IComparable referenceValue, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsGreater(referenceValue), expectedParameter);
		}

		[TestCase(2, 3, true)]
		[TestCase(2, 2, true)]
		[TestCase(2, 1, false)]
		public void IsSmallerOrEqual_Returns_Valid_Result(int value, int referenceValue, bool expectedResult)
		{
			Assert.That(value.IsSmallerOrEqual(referenceValue), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("Comparable_TestCases")]
		public void IsSmallerOrEqual_Throws_ArgumentNullException(IComparable value, IComparable referenceValue, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsSmallerOrEqual(referenceValue), expectedParameter);
		}

		[TestCase(1, 0, false)]
		[TestCase(1, 2, true)]
		public void IsSmaller_Returns_Valid_Result(int value, int referenceValue, bool expectedResult)
		{
			Assert.That(value.IsSmaller(referenceValue), Is.EqualTo(expectedResult));
		}

		[TestCaseSource("Comparable_TestCases")]
		public void IsSmaller_Throws_ArgumentNullException(IComparable value, IComparable referenceValue, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => value.IsSmaller(referenceValue), expectedParameter);
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable Comparable_TestCases()
		{
			yield return new TestCaseData(null, null, "value");
			yield return new TestCaseData(1, null, "referenceValue");
		}
		#endregion
	}
}