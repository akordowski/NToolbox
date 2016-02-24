using System;
using System.Collections.Generic;
using System.Text;
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
		/// Converts an string with base-64 digits to its equivalent decoded string representation. Default character encoding UTF-8.
		/// </summary>
		/// <param name="str">A base-64 string to convert.</param>
		/// <returns>The string representation of a base-64 encoded string.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		/// <exception cref="FormatException">The format of <em>str</em> is invalid. <em>str</em> contains a non-base-64 character.</exception>
		public static string Base64Decode(this string str)
		{
			return Base64Decode(str, Encoding.UTF8);
		}

		/// <summary>
		/// Converts an string with base-64 digits to its equivalent decoded string representation.
		/// </summary>
		/// <param name="str">A base 64 string to convert.</param>
		/// <param name="encoding">Represents the string character encoding.</param>
		/// <returns>The string representation of a base 64 encoded string.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> or <em>encoding</em> is <strong>null</strong>.</exception>
		/// <exception cref="FormatException">The format of <em>str</em> is invalid. <em>str</em> contains a non-base-64 character.</exception>
		public static string Base64Decode(this string str, Encoding encoding)
		{
			Precondition.IsNotNull(str, nameof(str));
			Precondition.IsNotNull(encoding, nameof(encoding));

			byte[] bytes = Convert.FromBase64String(str);
			return encoding.GetString(bytes);
		}

		/// <summary>
		/// Converts an string to its equivalent string representation that is encoded with base-64 digits. Default character encoding UTF-8.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>The string representation, in base 64, of the contents of <em>str</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		public static string Base64Encode(this string str)
		{
			return Base64Encode(str, Encoding.UTF8);
		}

		/// <summary>
		/// Converts an string to its equivalent string representation that is encoded with base-64 digits.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <param name="encoding">Represents the string character encoding.</param>
		/// <returns>The string representation, in base 64, of the contents of <em>str</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> or <em>encoding</em> is <strong>null</strong>.</exception>
		public static string Base64Encode(this string str, Encoding encoding)
		{
			Precondition.IsNotNull(str, nameof(str));
			Precondition.IsNotNull(encoding, nameof(encoding));

			byte[] bytes = encoding.GetBytes(str);
			return Convert.ToBase64String(bytes);
		}

		/// <summary>
		/// Indicates whether the string is an base-64 encoded string.
		/// </summary>
		/// <param name="str">A string to test.</param>
		/// <returns><strong>true</strong> if the <em>str</em> parameter is an base-64 encoded string; otherwise, <strong>false</strong>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		/// <remarks>This method is based on an example from <a href="http://stackoverflow.com/questions/6309379/how-to-check-for-a-valid-base-64-encoded-string-in-c-sharp" target="_blank">StackOverflow</a>.</remarks>
		public static bool IsBase64(this string str)
		{
			Precondition.IsNotNull(str, nameof(str));

			str = str.Trim();
			return (str.Length % 4 == 0) && Regex.IsMatch(str, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
		}

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
		/// Splits a string into substrings based on the characters in an array.
		/// </summary>
		/// <param name="str">A string to split.</param>
		/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <strong>null</strong>.</param>
		/// <returns>An array whose elements contain the substrings in this instance that are delimited by one or more characters in <em>separator</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		public static string[] ToArray(this string str, params char[] separator)
		{
			Precondition.IsNotNull(str, nameof(str));

			return str.Split(separator);
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
		/// Converts the string representation of a number to an equivalent 8-bit unsigned integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>An 8-bit unsigned integer that is equivalent to <em>str</em>, or zero if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Byte.MinValue"/> or greater than <see cref="Byte.MaxValue"/>.</exception>
		public static byte ToByte(this string str)
		{
			return Convert.ToByte(str);
		}

		/// <summary>
		/// Converts the first character of the string to a Unicode character.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A Unicode character that is equivalent to the first and only character in <em>str</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		/// <exception cref="FormatException">The length of <em>str</em> is not 1.</exception>
		public static char ToChar(this string str)
		{
			Precondition.IsNotNull(str, nameof(str));

			return Convert.ToChar(str);
		}

		/// <summary>
		/// Converts the string representation of a date and time to an equivalent date and time value.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>The date and time equivalent of the value of <em>str</em>, or the date and time equivalent of <see cref="DateTime.MinValue"/> if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> is not a properly formatted date and time string.</exception>
		public static DateTime ToDateTime(this string str)
		{
			return Convert.ToDateTime(str);
		}

		/// <summary>
		/// Converts the string representation of a number to an equivalent decimal number.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A decimal number that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> is not a number in a valid format.</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Decimal.MinValue"/> or greater than <see cref="Decimal.MaxValue"/>.</exception>
		public static decimal ToDecimal(this string str)
		{
			return Convert.ToDecimal(str);
		}

		/// <summary>
		/// Converts the string representation of a number to an equivalent double-precision floating-point number.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A double-precision floating-point number that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> is not a number in a valid format.</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Double.MinValue"/> or greater than <see cref="Double.MaxValue"/>.</exception>
		public static double ToDouble(this string str)
		{
			return Convert.ToDouble(str);
		}

		/// <summary>
		/// Converts the string representation of a number to an equivalent 16-bit signed integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 16-bit signed integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Int16.MinValue"/> or greater than <see cref="Int16.MaxValue"/>.</exception>
		public static short ToInt16(this string str)
		{
			return Convert.ToInt16(str);
		}

		/// <summary>
		/// Converts the string representation of a number to an equivalent 32-bit signed integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 32-bit signed integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Int32.MinValue"/> or greater than <see cref="Int32.MaxValue"/>.</exception>
		public static int ToInt32(this string str)
		{
			return Convert.ToInt32(str);
		}

		/// <summary>
		/// Converts the specified string representation of a number to an equivalent 64-bit signed integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 64-bit signed integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9). </exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Int64.MinValue"/> or greater than <see cref="Int64.MaxValue"/>.</exception>
		public static long ToInt64(this string str)
		{
			return Convert.ToInt64(str);
		}

		/// <summary>
		/// Splits a string into substrings based on the characters in an array.
		/// </summary>
		/// <param name="str">A string to split.</param>
		/// <param name="separator">A character array that delimits the substrings in this string, an empty array that contains no delimiters, or <strong>null</strong>.</param>
		/// <returns>An list whose elements contain the substrings in this instance that are delimited by one or more characters in <em>separator</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>str</em> is <strong>null</strong>.</exception>
		public static List<string> ToList(this string str, params char[] separator)
		{
			Precondition.IsNotNull(str, nameof(str));

			return new List<string>(str.Split(separator));
		}

		/// <summary>
		/// Converts the specified string representation of a number to an equivalent 8-bit signed integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 8-bit signed integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="SByte.MinValue"/> or greater than <see cref="SByte.MaxValue"/>.</exception>
		public static sbyte ToSByte(this string str)
		{
			return Convert.ToSByte(str);
		}

		/// <summary>
		/// Converts the specified string representation of a number to an equivalent single-precision floating-point number.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A single-precision floating-point number that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> is not a number in a valid format.</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="Single.MinValue"/> or greater than <see cref="Single.MaxValue"/>.</exception>
		public static float ToSingle(this string str)
		{
			return Convert.ToSingle(str);
		}

		/// <summary>
		/// Converts the specified string representation of a number to an equivalent 16-bit unsigned integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 16-bit unsigned integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="UInt16.MinValue"/> or greater than <see cref="UInt16.MaxValue"/>.</exception>
		public static ushort ToUInt16(this string str)
		{
			return Convert.ToUInt16(str);
		}

		/// <summary>
		/// Converts the specified string representation of a number to an equivalent 32-bit unsigned integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 32-bit unsigned integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="UInt32.MinValue"/> or greater than <see cref="UInt32.MaxValue"/>.</exception>
		public static uint ToUInt32(this string str)
		{
			return Convert.ToUInt32(str);
		}

		/// <summary>
		/// Converts the specified string representation of a number to an equivalent 64-bit unsigned integer.
		/// </summary>
		/// <param name="str">A string to convert.</param>
		/// <returns>A 64-bit unsigned integer that is equivalent to the number in <em>str</em>, or 0 (zero) if <em>str</em> is <strong>null</strong>.</returns>
		/// <exception cref="FormatException"><em>str</em> does not consist of an optional sign followed by a sequence of digits (0 through 9).</exception>
		/// <exception cref="OverflowException"><em>str</em> represents a number that is less than <see cref="UInt64.MinValue"/> or greater than <see cref="UInt64.MaxValue"/>.</exception>
		public static ulong ToUInt64(this string str)
		{
			return Convert.ToUInt64(str);
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