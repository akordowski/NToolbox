using System;

namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a class to convert an deserialized object into an serialized object.
	/// </summary>
	/// <typeparam name="TIn">The type of the deserialized object.</typeparam>
	/// <typeparam name="TOut">The type of the serialized object.</typeparam>
	public class SerializeConverter<TIn, TOut>
		: IConverter<TIn, TOut>
	{
		#region Public Properties
		/// <summary>
		/// Gets an instance of a <see cref="ISerializer{TIn, TOut}"/>.
		/// </summary>
		public ISerializer<TIn, TOut> Serializer { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SerializeConverter{TIn, TOut}"/> class.
		/// </summary>
		/// <param name="serializer">An instance of a <see cref="ISerializer{TIn, TOut}"/>.</param>
		/// <exception cref="ArgumentNullException"><em>serializer</em> is
		/// <strong>null</strong>.</exception>
		public SerializeConverter(ISerializer<TIn, TOut> serializer)
		{
			Precondition.IsNotNull(serializer, nameof(serializer));

			this.Serializer = serializer;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Converts an deserialized object into an serialized object.
		/// </summary>
		/// <param name="data">The deserialized object to convert.</param>
		/// <returns>The serialized object that represents the deserialized object.</returns>
		/// <exception cref="ArgumentNullException"><em>data</em> is
		/// <strong>null</strong>.</exception>
		public virtual TOut Convert(TIn data)
		{
			Precondition.IsNotNull(data, nameof(data));

			return Serializer.Serialize(data);
		}
		#endregion
	}
}