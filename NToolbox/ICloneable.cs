using System;

namespace NToolbox
{
	/// <summary>
	/// Supports cloning, which creates a new instance of a class with the same value as an
	/// existing instance.
	/// </summary>
	/// <typeparam name="T">The type of the class.</typeparam>
	public interface ICloneable<T> : System.ICloneable
	{
		#region Methods
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		new T Clone();
		#endregion
	}
}