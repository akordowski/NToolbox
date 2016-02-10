using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Globalization
{
	public class LangaugeTest
	{
		#region Tests
		[TestCaseSource(typeof(LanguageAlpha2TestCaseSource), "LanguageAlpha2_TestCases")]
		public void LanguageAlpha2_Contains_Valid_Value(string languageAlpha2, string expectedLanguageAlpha2)
		{
			Assert.That(languageAlpha2, Is.EqualTo(expectedLanguageAlpha2));
		}

		[TestCaseSource(typeof(LanguageAlpha3BTestCaseSource), "LanguageAlpha3B_TestCases")]
		public void LanguageAlpha3B_Contains_Valid_Value(string languageAlpha3B, string expectedLanguageAlpha3B)
		{
			Assert.That(languageAlpha3B, Is.EqualTo(expectedLanguageAlpha3B));
		}

		[TestCaseSource(typeof(LanguageAlpha3TTestCaseSource), "LanguageAlpha3T_TestCases")]
		public void LanguageAlpha3T_Contains_Valid_Value(string languageAlpha3T, string LanguageAlpha3TCountryNumeric)
		{
			Assert.That(languageAlpha3T, Is.EqualTo(LanguageAlpha3TCountryNumeric));
		}
		#endregion
	}
}