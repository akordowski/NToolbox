namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a interface to serialize an deserialized object.
	/// </summary>
	public interface ISerializer<TIn, TOut>
	{
		/// <summary>
		/// Serialize an deserialized object.
		/// </summary>
		/// <param name="obj">The object to serialize.</param>
		/// <returns>A deserialized object that represents the serialized object.</returns>
		TOut Serialize(TIn obj);
	}
}