using NUnit.Framework;

namespace NToolbox.Tests.NToolbox
{
	[TestFixture]
	public class EventArgsTests
	{
		#region Tests
		[TestCase(null)]
		[TestCase("Hello World")]
		public void Initialize_Constructor(string str)
		{
			EventArgs<string> args = null;

			Assert.That(() => args = new EventArgs<string>(str), Throws.Nothing);
			Assert.That(args.Object, Is.EqualTo(str));
			Assert.That(args, Is.InstanceOf<EventArgs<string>>());
		}
		#endregion
	}
}