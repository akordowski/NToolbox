namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a interface to serialize and deserialize data.
	/// </summary>
	/// <typeparam name="TDeserialized">The type of the deserialized object.</typeparam>
	/// <typeparam name="TSerialized">The type of the serialized object.</typeparam>
	public interface ISerializer<TDeserialized, TSerialized>
	{
		/// <summary>
		/// Deserialize an object from one type to another type.
		/// </summary>
		/// <param name="obj">The object to deserialize.</param>
		/// <returns>The <em>TDeserialized</em> that represents the serialized
		/// <em>TSerialized</em>.</returns>
		TDeserialized Deserialize(TSerialized obj);

		/// <summary>
		/// Serialize an object from one type to another type.
		/// </summary>
		/// <param name="obj">The object to serialize.</param>
		/// <returns>The <em>TSerialized</em> that represents the deserialized
		/// <em>TDeserialized</em>.</returns>
		TSerialized Serialize(TDeserialized obj);
	}
}