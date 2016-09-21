using System;

namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a class to convert a deserialized object into a serialized object.
	/// </summary>
	/// <typeparam name="TDeserialized">The type of the deserialized object.</typeparam>
	/// <typeparam name="TSerialized">The type of the serialized object.</typeparam>
	public class SerializeConverter<TDeserialized, TSerialized> : IConverter<TDeserialized, TSerialized>
	{
		#region Public Properties
		/// <summary>
		/// Gets an instance of a <see cref="ISerializer{TDeserialized, TSerialized}"/>.
		/// </summary>
		public ISerializer<TDeserialized, TSerialized> Serializer { get; private set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="SerializeConverter{TDeserialized, TSerialized}"/> class.
		/// </summary>
		/// <param name="serializer">An instance of a
		/// <see cref="ISerializer{TDeserialized, TSerialized}"/>.</param>
		/// <exception cref="ArgumentNullException"><em>serializer</em> is
		/// <strong>null</strong>.</exception>
		public SerializeConverter(ISerializer<TDeserialized, TSerialized> serializer)
		{
			Precondition.IsNotNull(serializer, nameof(serializer));

			this.Serializer = serializer;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Converts a deserialized object into a serialized object.
		/// </summary>
		/// <param name="data">The deserialized object to convert.</param>
		/// <returns>The serialized object that represents the deserialized object.</returns>
		/// <exception cref="ArgumentNullException"><em>data</em> is
		/// <strong>null</strong>.</exception>
		public virtual TSerialized Convert(TDeserialized data)
		{
			Precondition.IsNotNull(data, nameof(data));

			return Serializer.Serialize(data);
		}
		#endregion
	}
}