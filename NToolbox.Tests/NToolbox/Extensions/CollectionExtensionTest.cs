using NToolbox.Extensions;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class CollectionExtensionTest
	{
		#region Tests
		[TestCaseSource("IsNullOrEmpty_TestCases")]
		public void IsNullOrEmpty(ICollection col, bool expectedResult)
		{
			Assert.That(col.IsNullOrEmpty(), Is.EqualTo(expectedResult));
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable IsNullOrEmpty_TestCases()
		{
			yield return new TestCaseData(null, true);
			yield return new TestCaseData(new List<string>(), true);
			yield return new TestCaseData(new List<string>(new[] { "abc" }), false);
		}
		#endregion
	}
}