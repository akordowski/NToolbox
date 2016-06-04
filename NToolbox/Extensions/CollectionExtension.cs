using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains <see cref="ICollection"/> extension methods.
	/// </summary>
	public static class CollectionExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Indicates whether the instance is <strong>null</strong> or an empty collection.
		/// </summary>
		/// <param name="col">The collection to test.</param>
		/// <returns><strong>true</strong> if the instance is <strong>null</strong> or an empty
		/// collection; otherwise, <strong>false</strong>.</returns>
		public static bool IsNullOrEmpty(this ICollection col)
		{
			return (col == null || col.Count == 0);
		}

		/// <summary>
		/// Concatenates the members of a collection, using the specified separator between each
		/// member.
		/// </summary>
		/// <typeparam name="T">The type of the collection.</typeparam>
		/// <param name="col">A collection that contains the objects to concatenate.</param>
		/// <param name="separator">The string to use as a separator. <em>separator</em> is
		/// included in the returned string only if <em>col</em> has more than one element.</param>
		/// <returns>A string that consists of the members of <em>col</em> delimited by the
		/// <em>separator</em> string. If <em>col</em> has no members, the method returns
		/// <see cref="String.Empty"/>.</returns>
		/// <exception cref="ArgumentNullException"><em>col</em> is
		/// <strong>null</strong>.</exception>
		public static string ToString<T>(this ICollection<T> col, string separator)
		{
			Precondition.IsNotNull(col, nameof(col));

			return string.Join(separator, col);
		}
		#endregion
	}
}