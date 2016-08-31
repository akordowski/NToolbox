using NToolbox.Globalization;
using NUnit.Framework;
using System;
using System.Globalization;
using System.Threading;

namespace NToolbox.NUnit
{
	public abstract class NUnitTestBase
	{
		#region Protected Methods
		protected void AssertThrowsNothing(Action method)
		{
			Assert.That(() => method(), Throws.Nothing);
		}

		protected void AssertThrowsException<T>(Action method, string expectedParameter) where T : Exception
		{
			Assert.That(() => method(),
				Throws.InstanceOf<T>()
				.And.Property("ParamName").EqualTo(expectedParameter));
		}

		protected void AssertThrowsException<T>(Culture culture, Action method, string expectedParameter, string expectedMessage, Exception expectedInnerException) where T : Exception
		{
			SetCulture(culture);

			Assert.That(() => method(),
				Throws.InstanceOf<T>()
				.And.Property("ParamName").EqualTo(expectedParameter)
				.And.Message.StartsWith(expectedMessage)
				.And.InnerException.EqualTo(expectedInnerException));
		}

		protected virtual void SetCulture(Culture culture)
		{
			CultureInfo cultureInfo = new CultureInfo((int)culture);

			CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
			CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = cultureInfo;
		}
		#endregion
	}
}