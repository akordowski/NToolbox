namespace NToolbox.ComponentModel
{
	/// <summary>
	/// Notifies clients that a method is executed.
	/// </summary>
	public interface INotifyMethodExecuted
	{
		/// <summary>
		/// Occurs when a method is executed.
		/// </summary>
		event MethodExecutedEventHandler MethodExecuted;
	}
}