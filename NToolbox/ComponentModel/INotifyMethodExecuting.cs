namespace NToolbox.ComponentModel
{
	/// <summary>
	/// Notifies clients that a method is executing.
	/// </summary>
	public interface INotifyMethodExecuting
	{
		/// <summary>
		/// Occurs when a method is executing.
		/// </summary>
		event MethodExecutingEventHandler MethodExecuting;
	}
}