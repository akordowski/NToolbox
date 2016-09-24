namespace NToolbox.ComponentModel
{
	/// <summary>
	/// Represents the method that will handle the
	/// <see cref="INotifyMethodExecuted.MethodExecuted"/> event of an
	/// <see cref="INotifyMethodExecuted"/> interface.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="MethodExecutedEventArgs"/> that contains the event
	/// data.</param>
	public delegate void MethodExecutedEventHandler(object sender, MethodExecutedEventArgs e);
}