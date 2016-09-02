using System.IO.Compression;

namespace NToolbox.IO.Compression
{
	/// <summary>
	/// Provides extension methods for the IArchive and IArchiveEntry classes.
	/// </summary>
	public static class ArchiveFileExtensions
	{
		#region Public Static Methods
		/// <summary>
		/// Archives a file by compressing it and adding it to the archive.
		/// </summary>
		/// <param name="destination">The archive to add the file to.</param>
		/// <param name="sourceFileName">The path to the file to be archived. You can specify
		/// either a relative or an absolute path. A relative path is interpreted as relative to
		/// the current working directory.</param>
		/// <param name="entryName">The name of the entry to create in the archive.</param>
		/// <returns>A wrapper for the new entry in the archive.</returns>
		public static IArchiveEntry CreateEntryFromFile(
			this IArchive destination,
			string sourceFileName,
			string entryName)
		{
			return null;
		}

		/// <summary>
		/// Archives a file by compressing it using the specified compression level and adding it
		/// to the archive.
		/// </summary>
		/// <param name="destination">The archive to add the file to.</param>
		/// <param name="sourceFileName">The path to the file to be archived. You can specify
		/// either a relative or an absolute path. A relative path is interpreted as relative to
		/// the current working directory.</param>
		/// <param name="entryName">The name of the entry to create in the archive.</param>
		/// <param name="compressionLevel">One of the enumeration values that indicates whether to
		/// emphasize speed or compression effectiveness when creating the entry.</param>
		/// <returns>A wrapper for the new entry in the archive.</returns>
		public static IArchiveEntry CreateEntryFromFile(
			this IArchive destination,
			string sourceFileName,
			string entryName,
			CompressionLevel compressionLevel)
		{
			return null;
		}

		/// <summary>
		/// Extracts all the files in the archive to a directory on the file system.
		/// </summary>
		/// <param name="source">The archive to extract files from.</param>
		/// <param name="destinationDirectoryName">The path to the directory to place the extracted
		/// files in. You can specify either a relative or an absolute path. A relative path is
		/// interpreted as relative to the current working directory.</param>
		public static void ExtractToDirectory(this IArchive source, string destinationDirectoryName)
		{
		}

		/// <summary>
		/// Extracts an entry in the archive to a file.
		/// </summary>
		/// <param name="source">The archive entry to extract a file from.</param>
		/// <param name="destinationFileName">The path of the file to create from the contents of
		/// the entry. You can specify either a relative or an absolute path. A relative path is
		/// interpreted as relative to the current working directory.</param>
		public static void ExtractToFile(this IArchiveEntry source, string destinationFileName)
		{
		}

		/// <summary>
		/// Extracts an entry in the archive to a file, and optionally overwrites an existing file
		/// that has the same name.
		/// </summary>
		/// <param name="source">The archive entry to extract a file from.</param>
		/// <param name="destinationFileName">The path of the file to create from the contents of
		/// the entry. You can specify either a relative or an absolute path. A relative path is
		/// interpreted as relative to the current working directory.</param>
		/// <param name="overwrite"><strong>true</strong> to overwrite an existing file that has
		/// the same name as the destination file; otherwise, <strong>false</strong>.</param>
		public static void ExtractToFile(
			this IArchiveEntry source,
			string destinationFileName,
			bool overwrite)
		{
		}
		#endregion
	}
}