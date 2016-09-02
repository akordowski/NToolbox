using System;
using System.IO;

namespace NToolbox.IO.Compression
{
	/// <summary>
	/// A interface for a compressed file within a archive.
	/// </summary>
	public interface IArchiveEntry
	{
		#region Properties
		/// <summary>
		/// Gets the archive that the entry belongs to.
		/// </summary>
		/// <value>The archive that the entry belongs to, or <strong>null</strong> if the entry has
		/// been deleted.</value>
		IArchive Archive { get; }

		/// <summary>
		/// Gets the compressed size of the entry in the archive.
		/// </summary>
		/// <value>The compressed size of the entry in the archive.</value>
		long CompressedLength { get; }

		/// <summary>
		/// Gets the relative path of the entry in the archive.
		/// </summary>
		/// <value>The relative path of the entry in the archive.</value>
		string FullName { get; }

		/// <summary>
		/// Gets or sets the last time the entry in the zip archive was changed.
		/// </summary>
		/// <value>The last time the entry in the archive was changed.</value>
		DateTimeOffset LastWriteTime { get; set; }

		/// <summary>
		/// Gets the uncompressed size of the entry in the archive.
		/// </summary>
		/// <value>The uncompressed size of the entry in the archive.</value>
		long Length { get; }

		/// <summary>
		/// Gets the file name of the entry in the archive.
		/// </summary>
		/// <value>The file name of the entry in the archive.</value>
		string Name { get; }
		#endregion

		#region Methods
		/// <summary>
		/// Deletes the entry from the archive.
		/// </summary>
		void Delete();

		/// <summary>
		/// Opens the entry from the archive.
		/// </summary>
		/// <returns>The stream that represents the contents of the entry.</returns>
		Stream Open();
		#endregion
	}
}