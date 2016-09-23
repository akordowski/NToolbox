using System;

namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a class to convert an serialized object into an deserialized object.
	/// </summary>
	/// <typeparam name="TIn">The type of the serialized object.</typeparam>
	/// <typeparam name="TOut">The type of the deserialized object.</typeparam>
	public class DeserializeConverter<TIn, TOut>
		: IConverter<TIn, TOut>
	{
		#region Public Properties
		/// <summary>
		/// Gets an instance of a <see cref="IDeserializer{TIn, TOut}"/>.
		/// </summary>
		public IDeserializer<TIn, TOut> Deserializer { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="DeserializeConverter{TIn, TOut}"/> class.
		/// </summary>
		/// <param name="deserializer">An instance of a
		/// <see cref="IDeserializer{TIn, TOut}"/>.</param>
		/// <exception cref="ArgumentNullException"><em>serializer</em> is
		/// <strong>null</strong>.</exception>
		public DeserializeConverter(IDeserializer<TIn, TOut> deserializer)
		{
			Precondition.IsNotNull(deserializer, nameof(deserializer));

			this.Deserializer = deserializer;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Converts an serialized object into an deserialized object.
		/// </summary>
		/// <param name="data">The serialized object to convert.</param>
		/// <returns>The deserialized object that represents the serialized object.</returns>
		/// <exception cref="ArgumentNullException"><em>data</em> is
		/// <strong>null</strong>.</exception>
		public virtual TOut Convert(TIn data)
		{
			Precondition.IsNotNull(data, nameof(data));

			return Deserializer.Deserialize(data);
		}
		#endregion
	}
}