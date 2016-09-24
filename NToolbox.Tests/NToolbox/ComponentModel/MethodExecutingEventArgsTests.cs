using NToolbox.ComponentModel;
using NToolbox.NUnit;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.ComponentModel
{
	[TestFixture]
	public class MethodExecutingEventArgsTests : NUnitTestBase
	{
		#region Tests
		[Test]
		public void Initialize_With_Null_MethodName_Throws_Nothing()
		{
			MethodExecutingEventArgs args = null;

			AssertThrowsNothing(() => args = new MethodExecutingEventArgs(null));
			Assert.That(args.MethodName, Is.Null);
		}

		[Test]
		public void Initialize_With_MethodName()
		{
			MethodExecutingEventArgs args = null;

			AssertThrowsNothing(() => args = new MethodExecutingEventArgs("MethodName"));
			Assert.That(args.MethodName, Is.EqualTo("MethodName"));
		}
		#endregion
	}
}