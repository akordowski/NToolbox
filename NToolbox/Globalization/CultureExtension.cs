using System.Globalization;

namespace NToolbox.Globalization
{
	/// <summary>
	/// Contains <see cref="Culture"/> extension methods.
	/// </summary>
	public static class CultureExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Converts the <see cref="Culture"/> enumeration value to a <see cref="CultureInfo"/>
		/// representation.
		/// </summary>
		/// <param name="culture">A <see cref="Culture"/> enumeration to convert.</param>
		/// <returns>The <see cref="CultureInfo"/> representation of the <see cref="Culture"/>
		/// enumeration.</returns>
		public static CultureInfo GetCultureInfo(this Culture culture)
		{
			return new CultureInfo((int)culture);
		}

		/// <summary>
		/// Gets the Culture name.
		/// </summary>
		/// <param name="culture">A <see cref="Culture"/> enumeration to convert.</param>
		/// <returns>The Culture name.</returns>
		public static string GetCultureName(this Culture culture)
		{
			return culture.ToString().Replace("_", "-");
		}
		#endregion
	}
}