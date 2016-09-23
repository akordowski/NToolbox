namespace NToolbox.Data.Serialization
{
	/// <summary>
	/// Provides a interface to serialize and deserialize data.
	/// </summary>
	public interface ISerialize<TDeserializeIn, TDeserializeOut, TSerializeIn, TSerializeOut> :
		IDeserializer<TDeserializeIn, TDeserializeOut>,
		ISerializer<TSerializeIn, TSerializeOut>
	{
	}
}