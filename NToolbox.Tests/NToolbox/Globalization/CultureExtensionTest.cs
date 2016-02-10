using NToolbox.Globalization;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;
using System.Globalization;

namespace NToolbox.Tests.NToolbox.Globalization
{
	[TestFixture]
	public class CultureExtensionTest
	{
		#region Tests
		[TestCaseSource(typeof(CultureTestCaseSource), "Culture_TestCases")]
		public void GetCultureInfo_Returns_Valid_Result(Culture culture, string cultureName, int cultureLcid)
		{
			CultureInfo cultureInfo = null;

			Assert.That(() => cultureInfo = culture.GetCultureInfo(), Throws.Nothing);
			Assert.That(cultureInfo, Is.Not.Null);
			Assert.That(cultureInfo.LCID, Is.EqualTo(cultureLcid));
			Assert.That(cultureInfo.Name, Is.EqualTo(cultureName));
		}

		[TestCaseSource(typeof(CultureTestCaseSource), "Culture_TestCases")]
		public void GetCultureName_Returns_Valid_Result(Culture culture, string cultureName, int cultureLcid)
		{
			string name = null;

			Assert.That(() => name = culture.GetCultureName(), Throws.Nothing);
			Assert.That(name, Is.Not.Null);
			Assert.That(name, Is.EqualTo(cultureName));
		}
		#endregion
	}
}