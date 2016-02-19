using NToolbox.Media;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Media
{
	[TestFixture]
	public class BitrateTest
	{
		#region Tests
		[TestCaseSource(typeof(BitrateTestCaseSource), "Bitrate_TestCases")]
		public void Bitrate_Contains_Valid_Value(Bitrate bitrate, int expectedResult)
		{
			Assert.That((int)bitrate, Is.EqualTo(expectedResult));
		}
		#endregion
	}
}