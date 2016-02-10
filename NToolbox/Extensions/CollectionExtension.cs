using System.Collections;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains ICollection extension methods.
	/// </summary>
	public static class CollectionExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Indicates whether the instance is null or an empty collection.
		/// </summary>
		/// <param name="value">The collection to test.</param>
		/// <returns><strong>true</strong> if the instance is <strong>null</strong> or an empty collection; otherwise, <strong>false</strong>.</returns>
		public static bool IsNullOrEmpty(this ICollection value)
		{
			return (value == null || value.Count == 0) ? true : false;
		}
		#endregion
	}
}