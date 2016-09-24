using System;

namespace NToolbox.ComponentModel
{
	/// <summary>
	/// Provides data for the <see cref="INotifyMethodExecuted.MethodExecuted"/> event.
	/// </summary>
	public class MethodExecutedEventArgs : EventArgs
	{
		#region Public Properties
		/// <summary>
		/// Gets the name of the method which is executed.
		/// </summary>
		/// <value>The name of the method which is executed.</value>
		public string MethodName { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="MethodExecutedEventArgs"/> class.
		/// </summary>
		/// <param name="methodName">The name of the method which is executed.</param>
		public MethodExecutedEventArgs(string methodName)
		{
			this.MethodName = methodName;
		}
		#endregion
	}
}