using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Utils
{
	/// <summary>
	/// Contains methods to create types of objects.
	/// </summary>
	public static class ClassUtil
	{
		#region Public Static Methods
		/// <summary>
		/// Creates an instance of a dictionary designated by the specified generic key and value type parameters, using the parameterless constructor.
		/// </summary>
		/// <typeparam name="TKey">The type of dictionary key to create.</typeparam>
		/// <typeparam name="TValue">The type of dictionary value to create.</typeparam>
		/// <returns>A reference to the newly created dictionary.</returns>
		public static Dictionary<TKey, TValue> CreateDictionaryInstance<TKey, TValue>()
		{
			return (Dictionary<TKey, TValue>)Activator.CreateInstance<Dictionary<TKey, TValue>>();
		}

		/// <summary>
		/// Creates an instance of a dictionary designated by the specified key and value type parameters, using the parameterless constructor.
		/// </summary>
		/// <param name="keyType">The type of dictionary key to create.</param>
		/// <param name="valueType">The type of dictionary value to create.</param>
		/// <returns>A reference to the newly created dictionary.</returns>
		public static IDictionary CreateDictionaryInstance(Type keyType, Type valueType)
		{
			Precondition.IsNotNull(keyType, nameof(keyType));
			Precondition.IsNotNull(valueType, nameof(valueType));

			Type dictionaryType = typeof(Dictionary<,>).MakeGenericType(keyType, valueType);

			return (IDictionary)Activator.CreateInstance(dictionaryType);
		}

		/// <summary>
		/// Creates an instance of the type designated by the specified generic type parameter, using the parameterless constructor.
		/// </summary>
		/// <typeparam name="T">The type to create.</typeparam>
		/// <returns>A reference to the newly created object.</returns>
		public static T CreateInstance<T>()
		{
			return Activator.CreateInstance<T>();
		}

		/// <summary>
		/// Creates an instance of the type designated by the specified type parameter, using the parameterless constructor.
		/// </summary>
		/// <param name="type">The type of object to create.</param>
		/// <returns>A reference to the newly created object.</returns>
		public static object CreateInstance(Type type)
		{
			Precondition.IsNotNull(type, nameof(type));

			return Activator.CreateInstance(type);
		}

		/// <summary>
		/// Creates an instance of a list designated by the specified generic type parameter, using the parameterless constructor.
		/// </summary>
		/// <typeparam name="T">The type of list object to create.</typeparam>
		/// <returns>A reference to the newly created list.</returns>
		public static List<T> CreateListInstance<T>()
		{
			return (List<T>)Activator.CreateInstance<List<T>>();
		}

		/// <summary>
		/// Creates an instance of a list designated by the specified type parameter, using the parameterless constructor.
		/// </summary>
		/// <param name="type">The type of list object to create.</param>
		/// <returns>A reference to the newly created list.</returns>
		public static IList CreateListInstance(Type type)
		{
			Precondition.IsNotNull(type, nameof(type));

			Type listType = typeof(List<>).MakeGenericType(type);

			return (IList)Activator.CreateInstance(listType);
		}
		#endregion
	}
}