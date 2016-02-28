using System.Collections.Generic;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains IDictionary extension methods.
	/// </summary>
	public static class DictionaryExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Determines whether the <see cref="IDictionary&lt;TKey, TValue&gt;"/> contains an <see cref="KeyValuePair&lt;TKey, TValue&gt;"/> with the specified key and value.
		/// </summary>
		/// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
		/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
		/// <param name="dictionary"></param>
		/// <param name="key">The key to locate in the <see cref="IDictionary&lt;TKey, TValue&gt;"/>.</param>
		/// <param name="value">The value to locate in the <see cref="IDictionary&lt;TKey, TValue&gt;"/>. The value can be <strong>null</strong> for reference types.</param>
		/// <returns><strong>true</strong> if the <see cref="IDictionary&lt;TKey, TValue&gt;"/> contains an <see cref="KeyValuePair&lt;TKey, TValue&gt;"/> with the specified key and value; otherwise, <strong>false</strong>.</returns>
		public static bool Contains<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,  TKey key, TValue value)
		{
			return dictionary.Contains(new KeyValuePair<TKey, TValue>(key, value));
		}
		#endregion
	}
}