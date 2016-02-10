using System;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains Numeric extension methods.
	/// </summary>
	public static class NumericExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Returns the smallest integral value that is greater than or equal to the specified decimal number.
		/// </summary>
		/// <param name="value">A decimal number.</param>
		/// <returns>The smallest integral value that is greater than or equal to <em>value</em>.</returns>
		public static decimal Ceiling(this decimal value)
		{
			return Math.Ceiling(value);
		}

		/// <summary>
		/// Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
		/// </summary>
		/// <param name="value">A double-precision floating-point number.</param>
		/// <returns>The smallest integral value that is greater than or equal to <em>value</em>.</returns>
		public static double Ceiling(this double value)
		{
			return Math.Ceiling(value);
		}

		/// <summary>
		/// Returns the largest integer less than or equal to the specified decimal number.
		/// </summary>
		/// <param name="value">A decimal number.</param>
		/// <returns>The largest integer less than or equal to <em>value</em>.</returns>
		public static decimal Floor(this decimal value)
		{
			return Math.Floor(value);
		}

		/// <summary>
		/// Returns the largest integer less than or equal to the specified double-precision floating-point number.
		/// </summary>
		/// <param name="value">A double-precision floating-point number.</param>
		/// <returns>The largest integer less than or equal to <em>value</em>.</returns>
		public static double Floor(this double value)
		{
			return Math.Floor(value);
		}

		/// <summary>
		/// Indicates whether the byte is even.
		/// </summary>
		/// <param name="value">A byte to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this byte value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the decimal is even.
		/// </summary>
		/// <param name="value">A decimal to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this decimal value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the double is even.
		/// </summary>
		/// <param name="value">A double to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this double value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the float is even.
		/// </summary>
		/// <param name="value">A float to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this float value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the int is even.
		/// </summary>
		/// <param name="value">A int to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this int value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the long is even.
		/// </summary>
		/// <param name="value">A long to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this long value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the sbyte is even.
		/// </summary>
		/// <param name="value">A sbyte to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this sbyte value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the short is even.
		/// </summary>
		/// <param name="value">A short to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this short value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the uint is even.
		/// </summary>
		/// <param name="value">A uint to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this uint value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the ulong is even.
		/// </summary>
		/// <param name="value">A ulong to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this ulong value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the ushort is even.
		/// </summary>
		/// <param name="value">A ushort to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is even; otherwise, <strong>false</strong>.</returns>
		public static bool IsEven(this ushort value)
		{
			return value % 2 == 0;
		}

		/// <summary>
		/// Indicates whether the byte is odd.
		/// </summary>
		/// <param name="value">A byte to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this byte value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the decimal is odd.
		/// </summary>
		/// <param name="value">A decimal to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this decimal value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the double is odd.
		/// </summary>
		/// <param name="value">A double to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this double value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the float is odd.
		/// </summary>
		/// <param name="value">A float to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this float value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the int is odd.
		/// </summary>
		/// <param name="value">A int to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this int value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the long is odd.
		/// </summary>
		/// <param name="value">A long to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this long value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the sbyte is odd.
		/// </summary>
		/// <param name="value">A sbyte to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this sbyte value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the short is odd.
		/// </summary>
		/// <param name="value">A short to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this short value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the uint is odd.
		/// </summary>
		/// <param name="value">A uint to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this uint value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the ulong is odd.
		/// </summary>
		/// <param name="value">A ulong to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this ulong value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Indicates whether the ushort is odd.
		/// </summary>
		/// <param name="value">A ushort to test.</param>
		/// <returns><strong>true</strong> if the <em>value</em> is odd; otherwise, <strong>false</strong>.</returns>
		public static bool IsOdd(this ushort value)
		{
			return value % 2 != 0;
		}

		/// <summary>
		/// Calculates the integral part of a specified decimal number.
		/// </summary>
		/// <param name="value">A number to truncate.</param>
		/// <returns>The integral part of the <em>value</em>; that is, the number that remains after any fractional digits have been discarded.</returns>
		public static decimal Truncate(this decimal value)
		{
			return Math.Truncate(value);
		}

		/// <summary>
		/// Calculates the integral part of a specified double-precision floating-point number.
		/// </summary>
		/// <param name="value">A number to truncate.</param>
		/// <returns>The integral part of the <em>value</em>; that is, the number that remains after any fractional digits have been discarded.</returns>
		public static double Truncate(this double value)
		{
			return Math.Truncate(value);
		}
		#endregion
	}
}