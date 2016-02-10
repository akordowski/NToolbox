using NToolbox.Globalization;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;
using System;

namespace NToolbox.Tests.NToolbox.Globalization
{
	[TestFixture]
	public class CultureTest
	{
		#region Tests
		[Test]
		public void Culture_Contains_All_Values()
		{
			Assert.That(Enum.GetValues(typeof(Culture)).Length, Is.EqualTo(351));
		}

		[TestCaseSource(typeof(CultureTestCaseSource), "Culture_TestCases")]
		public void Culture_Contains_Valid_Value(Culture culture, string cultureName, int cultureLcid)
		{
			Assert.That(culture.ToString().Replace("_", "-"), Is.EqualTo(cultureName));
			Assert.That((int)culture, Is.EqualTo(cultureLcid));
		}
		#endregion
	}
}