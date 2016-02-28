using NToolbox.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class DictionaryExtensionTest
	{
		#region Private Properties
		private Dictionary<string, string> _dict;
		#endregion

		#region SetUp
		[SetUp]
		public void SetUp()
		{
			_dict = new Dictionary<string, string>
			{
				{ "123", "abc" },
				{ "456", "def" }
			};
		}
		#endregion

		#region Test Case Sources
		[TestCase("123", "abc", true)]
		[TestCase("123", "def", false)]
		[TestCase("456", "def", true)]
		[TestCase("456", "abc", false)]
		public void Contains_Returns_Valid_Result(string key, string value, bool expectedResult)
		{
			Assert.That(_dict.Contains(key, value), Is.EqualTo(expectedResult));
		}
		#endregion
	}
}