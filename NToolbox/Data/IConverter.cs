namespace NToolbox.Data
{
	/// <summary>
	/// Provides a interface to convert data.
	/// </summary>
	/// <typeparam name="TIn">The type of object that is to be converted.</typeparam>
	/// <typeparam name="TOut">The type the input object is to be converted to.</typeparam>
	public interface IConverter<TIn, TOut>
	{
		#region Methods
		/// <summary>
		/// Converts an object from one type to another type.
		/// </summary>
		/// <param name="data">The object to convert.</param>
		/// <returns>The <em>TOut</em> that represents the converted <em>TIn</em>.</returns>
		TOut Convert(TIn data);
		#endregion
	}
}