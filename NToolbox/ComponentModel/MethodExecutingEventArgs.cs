using System;

namespace NToolbox.ComponentModel
{
	/// <summary>
	/// Provides data for the <see cref="INotifyMethodExecuting.MethodExecuting"/> event.
	/// </summary>
	public class MethodExecutingEventArgs : EventArgs
	{
		#region Public Properties
		/// <summary>
		/// Gets the name of the method which is executing.
		/// </summary>
		/// <value>The name of the method which is executing.</value>
		public string MethodName { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="MethodExecutingEventArgs"/> class.
		/// </summary>
		/// <param name="methodName">The name of the method which is executing.</param>
		public MethodExecutingEventArgs(string methodName)
		{
			this.MethodName = methodName;
		}
		#endregion
	}
}