using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Globalization
{
	public class CountryTest
	{
		#region Tests
		[TestCaseSource(typeof(CountryAlpha2TestCaseSource), "CountryAlpha2_TestCases")]
		public void CountryAlpha2_Contains_Valid_Value(string countryAlpha2, string expectedCountryAlpha2)
		{
			Assert.That(countryAlpha2, Is.EqualTo(expectedCountryAlpha2));
		}

		[TestCaseSource(typeof(CountryAlpha3TestCaseSource), "CountryAlpha3_TestCases")]
		public void CountryAlpha3_Contains_Valid_Value(string countryAlpha3, string expectedCountryAlpha3)
		{
			Assert.That(countryAlpha3, Is.EqualTo(expectedCountryAlpha3));
		}

		[TestCaseSource(typeof(CountryNumericTestCaseSource), "CountryNumeric_TestCases")]
		public void CountryNumeric_Contains_Valid_Value(string countryNumeric, string expectedCountryNumeric)
		{
			Assert.That(countryNumeric, Is.EqualTo(expectedCountryNumeric));
		}
		#endregion
	}
}