using System.ComponentModel;

namespace NToolbox.Data
{
	/// <summary>
	/// Notifies clients that a property value is changing and has changed.
	/// </summary>
	public interface INotifyObject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Properties
		/// <summary>
		/// Suppress the events.
		/// </summary>
		bool SuppressEvents { get; set; }
		#endregion
	}
}