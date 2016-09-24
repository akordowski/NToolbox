namespace NToolbox.ComponentModel
{
	/// <summary>
	/// Represents the method that will handle the
	/// <see cref="INotifyMethodExecuting.MethodExecuting"/> event of an
	/// <see cref="INotifyMethodExecuting"/> interface.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="MethodExecutingEventArgs"/> that contains the event
	/// data.</param>
	public delegate void MethodExecutingEventHandler(object sender, MethodExecutingEventArgs e);
}