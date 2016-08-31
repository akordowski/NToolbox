using NToolbox.Data.Common;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Data
{
	[TestFixture]
	public class NotifyObjectTest
	{
		#region Tests
		[Test]
		public void NotifyObject_Implements_Interface()
		{
			Assert.That(new NotifyObjectImpl(), Is.InstanceOf<INotifyObject>());
		}

		[Test]
		public void NotifyObject_Throws_Nothing()
		{
			NotifyObjectImpl obj = new NotifyObjectImpl();

			Assert.That(() => obj.Number = 100, Throws.Nothing);
		}

		[Test]
		public void NotifyObject_Trigger_Events()
		{
			bool propertyChangedEventTriggered = false;
			bool propertyChangingEventTriggered = false;

			string propertyChangedEventPropertyName = null;
			string propertyChangingEventPropertyName = null;

			NotifyObjectImpl obj = new NotifyObjectImpl();
			obj.PropertyChanged += (sender, e) =>
			{
				propertyChangedEventTriggered = true;
				propertyChangedEventPropertyName = e.PropertyName;
			};

			obj.PropertyChanging += (sender, e) =>
			{
				propertyChangingEventTriggered = true;
				propertyChangingEventPropertyName = e.PropertyName;
			};
			obj.Number = 100;

			Assert.That(propertyChangedEventTriggered, Is.True);
			Assert.That(propertyChangingEventTriggered, Is.True);
			Assert.That(propertyChangedEventPropertyName, Is.Not.Null.And.EqualTo("Number"));
			Assert.That(propertyChangingEventPropertyName, Is.Not.Null.And.EqualTo("Number"));
		}

		[Test]
		public void NotifyObject_Suppress_Events()
		{
			bool propertyChangedEventTriggered = false;
			bool propertyChangingEventTriggered = false;

			NotifyObjectImpl obj = new NotifyObjectImpl();
			obj.PropertyChanged += (sender, e) => propertyChangedEventTriggered = true;
			obj.PropertyChanging += (sender, e) => propertyChangingEventTriggered = true;
			obj.SuppressEvents = true;
			obj.Number = 100;

			Assert.That(propertyChangedEventTriggered, Is.False);
			Assert.That(propertyChangingEventTriggered, Is.False);
		}
		#endregion

		#region Private Class
		private class NotifyObjectImpl : NotifyObject
		{
			private int _number;

			public int Number
			{
				get { return _number; }
				set
				{
					OnPropertyChanging();
					_number = value;
					OnPropertyChanged();
				}
			}
		}
		#endregion
	}
}