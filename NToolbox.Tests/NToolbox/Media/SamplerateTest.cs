using NToolbox.Media;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Media
{
	[TestFixture]
	public class SamplerateTest
	{
		#region Tests
		[TestCaseSource(typeof(SamplerateTestCaseSource), "Samplerate_TestCases")]
		public void Samplerate_Contains_Valid_Value(Samplerate samplerate, int expectedResult)
		{
			Assert.That((int)samplerate, Is.EqualTo(expectedResult));
		}
		#endregion
	}
}