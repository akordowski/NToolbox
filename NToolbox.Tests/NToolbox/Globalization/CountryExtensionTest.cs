using NToolbox.Globalization;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Globalization
{
	[TestFixture]
	public class CountryExtensionTest
	{
		#region Tests
		[TestCaseSource(typeof(CountryExtensionTestCaseSource), "CountryExtension_TestCases")]
		public void GetCultureInfo_Returns_Valid_Result(Country country, string countryIsoCode)
		{
			string isoCode = null;

			Assert.That(() => isoCode = country.GetIsoCode(), Throws.Nothing);
			Assert.That(isoCode, Is.Not.Null);
			Assert.That(isoCode, Is.EqualTo(countryIsoCode));
		}
		#endregion
	}
}