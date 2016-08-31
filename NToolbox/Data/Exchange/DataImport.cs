using System;

namespace NToolbox.Data.Exchange
{
	/// <summary>
	/// Provides a generic class to import data.
	/// </summary>
	/// <typeparam name="TRead">The type of object that is readed.</typeparam>
	/// <typeparam name="TWrite">The type of object that is written.</typeparam>
	public class DataImport<TRead, TWrite> : DataExchange<TRead, TWrite>, IImport<TRead, TWrite>
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="DataImport{TRead, TWrite}"/> class.
		/// </summary>
		/// <param name="reader">The reader to read data.</param>
		/// <param name="writer">The writer to write data.</param>
		/// <exception cref="ArgumentNullException">The <em>reader</em> or <em>writer</em> is
		/// <strong>null</strong>.</exception>
		public DataImport(IReader<TRead> reader, IWriter<TWrite> writer)
			: base(reader, writer)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DataImport{TRead, TWrite}"/> class.
		/// </summary>
		/// <param name="reader">The reader to read data.</param>
		/// <param name="writer">The writer to write data.</param>
		/// <param name="converter">The converter to convert data.</param>
		/// <exception cref="ArgumentNullException">The <em>reader</em>, <em>writer</em> or
		/// <em>converter</em> is <strong>null</strong>.</exception>
		public DataImport(IReader<TRead> reader, IWriter<TWrite> writer, IConverter<TRead, TWrite> converter)
			: base(reader, writer, converter)
		{
		}
		#endregion

		#region Public Methods
		/// <inheritdoc/>
		public void Import()
		{
			base.Exchange();
		}
		#endregion
	}
}