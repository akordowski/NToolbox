using System;

namespace NToolbox
{
	/// <summary>
	/// Represents a generic class that contain event data.
	/// </summary>
	/// <typeparam name="T">The type of the event data object.</typeparam>
	public class EventArgs<T> : EventArgs
	{
		#region Public Properties
		/// <summary>
		/// The event data object.
		/// </summary>
		public T Object { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the EventArgs&lt;T&gt; class.
		/// </summary>
		/// <param name="obj">A event data object.</param>
		public EventArgs(T obj)
		{
			this.Object = obj;
		}
		#endregion
	}
}