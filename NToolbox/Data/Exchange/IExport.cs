namespace NToolbox.Data.Exchange
{
	/// <summary>
	/// Provides a interface to export data.
	/// </summary>
	/// <typeparam name="TRead">The type of object that is readed.</typeparam>
	/// <typeparam name="TWrite">The type of object that is written.</typeparam>
	public interface IExport<TRead, TWrite> : IExchange<TRead, TWrite>
	{
		#region Methods
		/// <summary>
		/// Starts the export process.
		/// </summary>
		void Export();
		#endregion
	}
}