namespace NToolbox.Data
{
	/// <summary>
	/// Provides a interface to write data.
	/// </summary>
	/// <typeparam name="T">The type of object that is written.</typeparam>
	public interface IWriter<T>
	{
		#region Methods
		/// <summary>
		/// Writes data.
		/// </summary>
		/// <param name="data">The object to write.</param>
		void Write(T data);
		#endregion
	}
}