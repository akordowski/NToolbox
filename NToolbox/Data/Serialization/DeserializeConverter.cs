using System;

namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a class to convert a serialized object into a deserialized object.
	/// </summary>
	/// <typeparam name="TSerialized">The type of the serialized object.</typeparam>
	/// <typeparam name="TDeserialized">The type of the deserialized object.</typeparam>
	public class DeserializeConverter<TSerialized, TDeserialized> : IConverter<TSerialized, TDeserialized>
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
		/// <see cref="DeserializeConverter{TDeserialized, TSerialized}"/> class.
		/// </summary>
		/// <param name="serializer">An instance of a
		/// <see cref="ISerializer{TDeserialized, TSerialized}"/>.</param>
		/// <exception cref="ArgumentNullException"><em>serializer</em> is
		/// <strong>null</strong>.</exception>
		public DeserializeConverter(ISerializer<TDeserialized, TSerialized> serializer)
		{
			Precondition.IsNotNull(serializer, nameof(serializer));

			this.Serializer = serializer;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Converts a serialized object into a deserialized object.
		/// </summary>
		/// <param name="data">The serialized object to convert.</param>
		/// <returns>The deserialized object that represents the serialized object.</returns>
		/// <exception cref="ArgumentNullException"><em>data</em> is
		/// <strong>null</strong>.</exception>
		public virtual TDeserialized Convert(TSerialized data)
		{
			Precondition.IsNotNull(data, nameof(data));

			return Serializer.Deserialize(data);
		}
		#endregion
	}
}