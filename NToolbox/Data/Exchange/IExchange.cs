namespace NToolbox.Data.Exchange
{
	/// <summary>
	/// Provides a interface to exchange data.
	/// </summary>
	/// <typeparam name="TRead">The type of object that is readed.</typeparam>
	/// <typeparam name="TWrite">The type of object that is written.</typeparam>
	public interface IExchange<TRead, TWrite>
	{
		#region Properties
		/// <summary>
		/// Gets the data converter.
		/// </summary>
		IConverter<TRead, TWrite> Converter { get; }

		/// <summary>
		/// Gets the data reader.
		/// </summary>
		IReader<TRead> Reader { get; }

		/// <summary>
		/// Gets the data writer.
		/// </summary>
		IWriter<TWrite> Writer { get; }
		#endregion
	}
}