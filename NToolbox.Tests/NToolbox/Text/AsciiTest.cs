using NToolbox.Tests.TestCaseSources;
using NToolbox.Text;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Text
{
	[TestFixture]
	public class AsciiTest
	{
		#region Tests
		[TestCaseSource(typeof(AsciiTestCaseSource), "Ascii_TestCases")]
		public void Ascii_Contains_Valid_Value(Ascii ascii, int expectedHex, char? expectedChar)
		{
			Assert.That((int)ascii, Is.EqualTo(expectedHex));

			if (expectedChar != null)
			{
				Assert.That((char)ascii, Is.EqualTo(expectedChar));
			}
		}
		#endregion
	}
}