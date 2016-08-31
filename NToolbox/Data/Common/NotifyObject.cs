using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NToolbox.Data.Common
{
	/// <summary>
	/// Notifies clients that a property value is changing and has changed.
	/// </summary>
	public abstract class NotifyObject : INotifyObject
	{
		#region Public Events
		/// <summary>
		/// Occurs when a property value has changed.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Occurs when a property value change is a pending.
		/// </summary>
		public event PropertyChangingEventHandler PropertyChanging;
		#endregion

		#region Public Properties
		/// <summary>
		/// Suppress the events.
		/// </summary>
		public bool SuppressEvents { get; set; }
		#endregion

		#region Protected Methods
		/// <summary>
		/// Raises the PropertyChanged event.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null && SuppressEvents == false)
			{
				PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
				PropertyChanged(this, args);
			}
		}

		/// <summary>
		/// Raises the PropertyChanging event.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanging != null && SuppressEvents == false)
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(propertyName);
				PropertyChanging(this, args);
			}
		}
		#endregion
	}
}