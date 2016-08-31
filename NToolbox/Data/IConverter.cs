namespace NToolbox.Data
{
	/// <summary>
	/// Provides a interface to convert data.
	/// </summary>
	/// <typeparam name="TInput">The type of object that is to be converted.</typeparam>
	/// <typeparam name="TOutput">The type the input object is to be converted to.</typeparam>
	public interface IConverter<TInput, TOutput>
	{
		#region Methods
		/// <summary>
		/// Converts an object from one type to another type.
		/// </summary>
		/// <param name="data">The object to convert.</param>
		/// <returns>The <em>TOutput</em> that represents the converted <em>TIn</em>.</returns>
		TOutput Convert(TInput data);
		#endregion
	}
}