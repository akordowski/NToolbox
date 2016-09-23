namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a interface to deserialize an serialized object.
	/// </summary>
	public interface IDeserializer<TIn, TOut>
	{
		/// <summary>
		/// Deserialize an serialized object.
		/// </summary>
		/// <param name="obj">The object to deserialize.</param>
		/// <returns>A serialized object that represents the deserialized object.</returns>
		TOut Deserialize(TIn obj);
	}
}