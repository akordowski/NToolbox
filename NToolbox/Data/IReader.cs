namespace NToolbox.Data
{
	/// <summary>
	/// Provides a interface to read data.
	/// </summary>
	/// <typeparam name="T">The type of object that is readed.</typeparam>
	public interface IReader<T>
	{
		#region Methods
		/// <summary>
		/// Reads data.
		/// </summary>
		/// <returns>A object that is readed.</returns>
		T Read();
		#endregion
	}
}