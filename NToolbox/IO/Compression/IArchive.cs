using System.Collections.ObjectModel;

namespace NToolbox.IO.Compression
{
	/// <summary>
	/// A interface for a package of compressed files in a archive.
	/// </summary>
	public interface IArchive
	{
		#region Properties
		/// <summary>
		/// Gets the collection of entries that are currently in the archive.
		/// </summary>
		/// <value>The collection of entries that are currently in the archive.</value>
		ReadOnlyCollection<IArchiveEntry> Entries { get; }
		#endregion

		#region Methods
		/// <summary>
		/// Creates an empty entry that has the specified path and entry name in the archive.
		/// </summary>
		/// <param name="entryName">A path, relative to the root of the archive, that specifies the
		/// name of the entry to be created.</param>
		/// <returns>An empty entry in the archive.</returns>
		IArchiveEntry CreateEntry(string entryName);

		/// <summary>
		/// Retrieves a wrapper for the specified entry in the archive.
		/// </summary>
		/// <param name="entryName">A path, relative to the root of the archive, that identifies
		/// the entry to retrieve.</param>
		/// <returns>A wrapper for the specified entry in the archive; <strong>null</strong> if the
		/// entry does not exist in the archive.</returns>
		IArchiveEntry GetEntry(string entryName);
		#endregion
	}
}