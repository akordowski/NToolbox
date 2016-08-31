namespace NToolbox.Data.Exchange
{
	/// <summary>
	/// Provides a interface to import data.
	/// </summary>
	/// <typeparam name="TRead">The type of object that is readed.</typeparam>
	/// <typeparam name="TWrite">The type of object that is written.</typeparam>
	public interface IImport<TRead, TWrite> : IExchange<TRead, TWrite>
	{
		#region Methods
		/// <summary>
		/// Starts the import process.
		/// </summary>
		void Import();
		#endregion
	}
}