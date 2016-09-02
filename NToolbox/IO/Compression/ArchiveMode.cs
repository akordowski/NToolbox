namespace NToolbox.IO.Compression
{
	/// <summary>
	/// Specifies values for interacting with archive entries.
	/// </summary>
	public enum ArchiveMode
	{
		/// <summary>
		/// Only creating new archive entries is permitted.
		/// </summary>
		Create,

		/// <summary>
		/// Only reading archive entries is permitted.
		/// </summary>
		Read,

		/// <summary>
		/// Both read and write operations are permitted for archive entries.
		/// </summary>
		Write
	}
}