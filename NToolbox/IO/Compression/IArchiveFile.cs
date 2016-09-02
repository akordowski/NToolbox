using System.IO.Compression;
using System.Text;

namespace NToolbox.IO.Compression
{
	/// <summary>
	/// A interface for creating, extracting, and opening archives.
	/// </summary>
	public interface IArchiveFile
	{
		#region Methods
		/// <summary>
		/// Creates a archive that contains the files and directories from the specified directory.
		/// </summary>
		/// <param name="sourceDirectoryName">The path to the directory to be archived, specified
		/// as a relative or absolute path. A relative path is interpreted as relative to the
		/// current working directory.</param>
		/// <param name="destinationArchiveFileName">The path of the archive to be created,
		/// specified as a relative or absolute path. A relative path is interpreted as relative to
		/// the current working directory.</param>
		void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName);

		/// <summary>
		/// Creates a archive that contains the files and directories from the specified directory,
		/// uses the specified compression level, and optionally includes the base directory.
		/// </summary>
		/// <param name="sourceDirectoryName">The path to the directory to be archived, specified
		/// as a relative or absolute path. A relative path is interpreted as relative to the
		/// current working directory.</param>
		/// <param name="destinationArchiveFileName">The path of the archive to be created,
		/// specified as a relative or absolute path. A relative path is interpreted as relative to
		/// the current working directory.</param>
		/// <param name="compressionLevel">One of the enumeration values that indicates whether to
		/// emphasize speed or compression effectiveness when creating the entry.</param>
		/// <param name="includeBaseDirectory"><strong>true</strong> to include the directory name
		/// from <em>sourceDirectoryName</em> at the root of the archive; <strong>false</strong> to
		/// include only the contents of the directory.</param>
		void CreateFromDirectory(
			string sourceDirectoryName,
			string destinationArchiveFileName,
			CompressionLevel compressionLevel,
			bool includeBaseDirectory);

		/// <summary>
		/// Creates a archive that contains the files and directories from the specified directory,
		/// uses the specified compression level and character encoding for entry names, and
		/// optionally includes the base directory.
		/// </summary>
		/// <param name="sourceDirectoryName">The path to the directory to be archived, specified
		/// as a relative or absolute path. A relative path is interpreted as relative to the
		/// current working directory.</param>
		/// <param name="destinationArchiveFileName">The path of the archive to be created,
		/// specified as a relative or absolute path. A relative path is interpreted as relative to
		/// the current working directory.</param>
		/// <param name="compressionLevel">One of the enumeration values that indicates whether to
		/// emphasize speed or compression effectiveness when creating the entry.</param>
		/// <param name="includeBaseDirectory"><strong>true</strong> to include the directory name
		/// from <em>sourceDirectoryName</em> at the root of the archive; <strong>false</strong> to
		/// include only the contents of the directory.</param>
		/// <param name="entryNameEncoding">The encoding to use when reading or writing entry names
		/// in this archive. Specify a value for this parameter only when an encoding is required
		/// for interoperability with archive tools and libraries that do not support UTF-8
		/// encoding for entry names.</param>
		void CreateFromDirectory(
			string sourceDirectoryName,
			string destinationArchiveFileName,
			CompressionLevel compressionLevel,
			bool includeBaseDirectory,
			Encoding entryNameEncoding);

		/// <summary>
		/// Extracts all the files in the specified archive to a directory on the file system.
		/// </summary>
		/// <param name="sourceArchiveFileName">The path to the archive that is to be
		/// extracted.</param>
		/// <param name="destinationDirectoryName">The path to the directory in which to place the
		/// extracted files, specified as a relative or absolute path. A relative path is
		/// interpreted as relative to the current working directory.</param>
		void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName);

		/// <summary>
		/// Extracts all the files in the specified archive to a directory on the file system and
		/// uses the specified character encoding for entry names.
		/// </summary>
		/// <param name="sourceArchiveFileName">The path to the archive that is to be
		/// extracted.</param>
		/// <param name="destinationDirectoryName">The path to the directory in which to place the
		/// extracted files, specified as a relative or absolute path. A relative path is
		/// interpreted as relative to the current working directory.</param>
		/// <param name="entryNameEncoding">The encoding to use when reading or writing entry names
		/// in this archive. Specify a value for this parameter only when an encoding is required
		/// for interoperability with archive tools and libraries that do not support UTF-8
		/// encoding for entry names.</param>
		void ExtractToDirectory(
			string sourceArchiveFileName,
			string destinationDirectoryName,
			Encoding entryNameEncoding);

		/// <summary>
		/// Opens a archive at the specified path and in the specified mode.
		/// </summary>
		/// <param name="archiveFileName">The path to the archive to open, specified as a relative
		/// or absolute path. A relative path is interpreted as relative to the current working
		/// directory.</param>
		/// <param name="mode">One of the enumeration values that specifies the actions which are
		/// allowed on the entries in the opened archive.</param>
		/// <returns>The opened archive.</returns>
		IArchive Open(string archiveFileName, ArchiveMode mode);

		/// <summary>
		/// Opens a archive at the specified path, in the specified mode, and by using the
		/// specified character encoding for entry names.
		/// </summary>
		/// <param name="archiveFileName">The path to the archive to open, specified as a relative
		/// or absolute path. A relative path is interpreted as relative to the current working
		/// directory.</param>
		/// <param name="mode">One of the enumeration values that specifies the actions that are
		/// allowed on the entries in the opened archive.</param>
		/// <param name="entryNameEncoding">The encoding to use when reading or writing entry names
		/// in this archive. Specify a value for this parameter only when an encoding is required
		/// for interoperability with archive tools and libraries that do not support UTF-8
		/// encoding for entry names.</param>
		/// <returns>The opened zip archive.</returns>
		IArchive Open(string archiveFileName, ArchiveMode mode, Encoding entryNameEncoding);

		/// <summary>
		/// Opens a archive for reading at the specified path.
		/// </summary>
		/// <param name="archiveFileName">The path to the archive to open, specified as a relative
		/// or absolute path. A relative path is interpreted as relative to the current working
		/// directory.</param>
		/// <returns>The opened zip archive.</returns>
		IArchive OpenRead(string archiveFileName);
		#endregion
	}
}