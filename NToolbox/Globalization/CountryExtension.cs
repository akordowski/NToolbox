using System;

namespace NToolbox.Globalization
{
	/// <summary>
	/// Contains <see cref="Country"/> extension methods.
	/// </summary>
	public static class CountryExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Converts the <see cref="Country"/> enumeration value to a string.
		/// </summary>
		/// <param name="country">A <see cref="Country"/> enumeration to convert.</param>
		/// <returns>The converted <see cref="Country"/> enumeration value as string.</returns>
		/// <returns>The ISO Code as string representation of the <see cref="Country"/>
		/// enumeration.</returns>
		public static string GetIsoCode(this Country country)
		{
			return ((int)country).ToString().PadLeft(3, '0');
		}
		#endregion
	}
}