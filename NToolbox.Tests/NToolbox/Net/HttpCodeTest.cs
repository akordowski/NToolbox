using NToolbox.Net;
using NToolbox.Tests.TestCaseSources;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Net
{
	[TestFixture]
	public class HttpCodeTest
	{
		#region Tests
		[TestCaseSource(typeof(HttpCodeTestCaseSource), "HttpCode_TestCases")]
		public void HttpCode_Contains_Valid_Value(HttpCode httpCode, int expectedHttpCode)
		{
			Assert.That((int)httpCode, Is.EqualTo(expectedHttpCode));
		}
		#endregion
	}
}