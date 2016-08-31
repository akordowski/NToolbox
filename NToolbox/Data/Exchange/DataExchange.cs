using System;

namespace NToolbox.Data.Exchange
{
	/// <summary>
	/// Provides a abstract class to exchange data.
	/// </summary>
	/// <typeparam name="TRead">The type of object that is readed.</typeparam>
	/// <typeparam name="TWrite">The type of object that is written.</typeparam>
	public abstract class DataExchange<TRead, TWrite> : IExchange<TRead, TWrite>
	{
		#region Public Properties
		/// <inheritdoc/>
		public IConverter<TRead, TWrite> Converter { get; private set; }

		/// <inheritdoc/>
		public IReader<TRead> Reader { get; private set; }

		/// <inheritdoc/>
		public IWriter<TWrite> Writer { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="DataExchange{TRead, TWrite}"/> class.
		/// </summary>
		/// <param name="reader">The reader to read data.</param>
		/// <param name="writer">The writer to write data.</param>
		/// <exception cref="ArgumentNullException">The <em>reader</em> or <em>writer</em> is
		/// <strong>null</strong>.</exception>
		protected DataExchange(IReader<TRead> reader, IWriter<TWrite> writer)
		{
			Precondition.IsNotNull(reader, nameof(reader));
			Precondition.IsNotNull(writer, nameof(writer));

			this.Reader = reader;
			this.Writer = writer;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DataExchange{TRead, TWrite}"/> class.
		/// </summary>
		/// <param name="reader">The reader to read data.</param>
		/// <param name="writer">The writer to write data.</param>
		/// <param name="converter">The converter to convert data.</param>
		/// <exception cref="ArgumentNullException">The <em>reader</em>, <em>writer</em> or
		/// <em>converter</em> is <strong>null</strong>.</exception>
		protected DataExchange(IReader<TRead> reader, IWriter<TWrite> writer, IConverter<TRead, TWrite> converter)
			: this(reader, writer)
		{
			Precondition.IsNotNull(converter, nameof(converter));

			this.Converter = converter;
		}
		#endregion

		#region Protected Methods
		/// <summary>
		/// Starts the exchange process.
		/// </summary>
		protected void Exchange()
		{
			object data = Reader.Read();

			if (Converter != null)
			{
				data = Converter.Convert((TRead)data);
			}

			Writer.Write((TWrite)data);
		}
		#endregion
	}
}