using System.Globalization;

namespace NToolbox.Globalization
{
	/// <summary>
	/// Contains Culture extension methods.
	/// </summary>
	public static class CultureExtension
	{
		#region Public Static Methods
		/// <summary>
		/// 
		/// </summary>
		/// <param name="culture">A Culture Enum to convert.</param>
		/// <returns></returns>
		public static CultureInfo GetCultureInfo(this Culture culture)
		{
			return new CultureInfo((int)culture);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="culture">A Culture Enum to convert.</param>
		/// <returns></returns>
		public static string GetCultureName(this Culture culture)
		{
			return culture.ToString().Replace("_", "-");
		}
		#endregion
	}
}