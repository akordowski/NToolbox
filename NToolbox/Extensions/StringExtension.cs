using System;
using System.Text.RegularExpressions;
using System.Web;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains String extension methods.
	/// </summary>
	public static class StringExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Indicates whether the string is an lower case string.
		/// </summary>
		/// <param name="str">A string to test.</param>
		/// <returns><strong>true</strong> if the <em>str</em> parameter is an lower case string; otherwise, <strong>false</strong>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		public static bool IsLowerCase(this string str)
		{
			Precondition.IsNotNull(str, nameof(str));

			return Regex.IsMatch(str, @"^[a-z]+$");
		}

		/// <summary>
		/// Indicates whether the string is null or an empty string.
		/// </summary>
		/// <param name="str">A string to test.</param>
		/// <returns><strong>true</strong> if the <em>str</em> parameter is <strong>null</strong> or an empty string; otherwise, <strong>false</strong>.</returns>
		public static bool IsNullOrEmpty(this string str)
		{
			return string.IsNullOrEmpty(str);
		}

		/// <summary>
		/// Indicates whether the string is null, an empty string, or consists only of white-space characters.
		/// </summary>
		/// <param name="str">A string to test.</param>
		/// <returns><strong>true</strong> if the <em>str</em> parameter is <strong>null</strong> or an empty string, or if <em>str</em> consists only of white-space characters; otherwise, <strong>false</strong>.</returns>
		public static bool IsNullOrWhiteSpace(this string str)
		{
			return string.IsNullOrWhiteSpace(str);
		}

		/// <summary>
		/// Indicates whether the string is an upper case string. 
		/// </summary>
		/// <param name="str">A string to test.</param>
		/// <returns><strong>true</strong> if the <em>str</em> parameter is an upper case string; otherwise, <strong>false</strong>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		public static bool IsUpperCase(this string str)
		{
			Precondition.IsNotNull(str, nameof(str));

			return Regex.IsMatch(str, @"^[A-Z]+$");
		}

		/// <summary>
		/// Converts the string representation of a logical value to its Boolean equivalent.
		/// </summary>
		/// <param name="str">A string containing a boolean to convert.</param>
		/// <returns><strong>true</strong> if <em>str</em> is a representation of a <em>true</em> Boolean value,
		/// or <strong>false</strong> if <em>str</em> is a representation of a <em>false</em> Boolean value.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><em>str</em> is not a representation of a Boolean value.</exception>
		public static bool ToBoolean(this string str)
		{
			Precondition.IsNotNull(str, nameof(str));

			bool result;

			switch (str.ToLower())
			{
				case "0":
				case "no":
				case "false":
					result = false;
					break;

				case "1":
				case "yes":
				case "true":
					result = true;
					break;

				default:
					result = Convert.ToBoolean(str);
					break;
			}

			return result;
		}

		/// <summary>
		/// Converts a string that has been HTML-encoded into a decoded string.
		/// </summary>
		/// <param name="str">The string to decode.</param>
		/// <returns>A decoded string.</returns>
		public static string UrlDecode(this string str)
		{
			return HttpUtility.UrlDecode(str);
		}

		/// <summary>
		/// Converts a string to an HTML-encoded string.
		/// </summary>
		/// <param name="str">The string to encode.</param>
		/// <returns>A encoded string.</returns>
		public static string UrlEncode(this string str)
		{
			return HttpUtility.UrlEncode(str);
		}
		#endregion
	}
}