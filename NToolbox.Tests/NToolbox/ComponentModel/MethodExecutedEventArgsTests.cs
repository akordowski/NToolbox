using NToolbox.ComponentModel;
using NToolbox.NUnit;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.ComponentModel
{
	[TestFixture]
	public class MethodExecutedEventArgsTests : NUnitTestBase
	{
		#region Tests
		[Test]
		public void Initialize_With_Null_MethodName_Throws_Nothing()
		{
			MethodExecutedEventArgs args = null;

			AssertThrowsNothing(() => args = new MethodExecutedEventArgs(null));
			Assert.That(args.MethodName, Is.Null);
		}

		[Test]
		public void Initialize_With_MethodName()
		{
			MethodExecutedEventArgs args = null;

			AssertThrowsNothing(() => args = new MethodExecutedEventArgs("MethodName"));
			Assert.That(args.MethodName, Is.EqualTo("MethodName"));
		}
		#endregion
	}
}