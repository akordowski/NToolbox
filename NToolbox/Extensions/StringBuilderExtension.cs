using System;
using System.Text;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains <see cref="StringBuilder"/> extension methods.
	/// </summary>
	public static class StringBuilderExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of a single argument using a
		/// specified format provider.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="provider">An object that supplies culture-specific formatting
		/// information.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The object to format.</param>
		/// <returns>A reference to this instance after the append operation has completed. After
		/// the append operation, this instance contains any data that existed before the
		/// operation, suffixed by a copy of <em>format</em> in which any format specification is
		/// replaced by the string representation of <em>arg0</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to
		/// one(1).</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			IFormatProvider provider,
			string format,
			object arg0)
		{
			stringBuilder.AppendFormat(provider, format, arg0);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of either of two arguments
		/// using a specified format provider.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="provider">An object that supplies culture-specific formatting
		/// information.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to format.</param>
		/// <param name="arg1">The second object to format.</param>
		/// <returns>A reference to this instance after the append operation has completed. After
		/// the append operation, this instance contains any data that existed before the
		/// operation, suffixed by a copy of <em>format</em> where any format specification is
		/// replaced by the string representation of the corresponding object argument.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to 2
		/// (two).</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			IFormatProvider provider,
			string format,
			object arg0,
			object arg1)
		{
			stringBuilder.AppendFormat(provider, format, arg0, arg1);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of either of three arguments
		/// using a specified format provider.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="provider">An object that supplies culture-specific formatting
		/// information.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to format.</param>
		/// <param name="arg1">The second object to format.</param>
		/// <param name="arg2">The third object to format.</param>
		/// <returns>A reference to this instance after the append operation has completed. After
		/// the append operation, this instance contains any data that existed before the
		/// operation, suffixed by a copy of <em>format</em> where any format specification is
		/// replaced by the string representation of the corresponding object argument. </returns>
		/// <exception cref="ArgumentNullException"><em>format</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to 3
		/// (three).</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			IFormatProvider provider,
			string format,
			object arg0,
			object arg1,
			object arg2)
		{
			stringBuilder.AppendFormat(provider, format, arg0, arg1, arg2);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of a corresponding argument
		/// in a parameter array using a specified format provider.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="provider">An object that supplies culture-specific formatting
		/// information.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An array of objects to format.</param>
		/// <returns>A reference to this instance after the append operation has completed. After
		/// the append operation, this instance contains any data that existed before the
		/// operation, suffixed by a copy of <em>format</em> where any format specification is
		/// replaced by the string representation of the corresponding object argument.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> or <em>args</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to the
		/// length of the <em>args</em> array.</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			IFormatProvider provider,
			string format,
			params object[] args)
		{
			stringBuilder.AppendFormat(provider, format, args);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of a single argument.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">An object to format.</param>
		/// <returns>A reference to this instance with <em>format</em> appended. Each format item
		/// in format is replaced by the string representation of <em>arg0</em>.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to
		/// 1.</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			string format,
			object arg0)
		{
			stringBuilder.AppendFormat(format, arg0);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of either of two arguments.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to format.</param>
		/// <param name="arg1">The second object to format.</param>
		/// <returns>A reference to this instance with <em>format</em> appended. Each
		/// <em>format</em> item in format is replaced by the string representation of the
		/// corresponding object argument.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to
		/// 2.</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			string format,
			object arg0,
			object arg1)
		{
			stringBuilder.AppendFormat(format, arg0, arg1);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of either of three arguments.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="arg0">The first object to format.</param>
		/// <param name="arg1">The second object to format.</param>
		/// <param name="arg2">The third object to format.</param>
		/// <returns>A reference to this instance with <em>format</em> appended. Each
		/// <em>format</em> item in format is replaced by the string representation of the
		/// corresponding object argument.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to
		/// 3.</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			string format,
			object arg0,
			object arg1,
			object arg2)
		{
			stringBuilder.AppendFormat(format, arg0, arg1, arg2);
			stringBuilder.AppendLine();

			return stringBuilder;
		}

		/// <summary>
		/// Appends the string returned by processing a composite format string followed by the
		/// default line terminator, which contains zero or more format items, to this instance.
		/// Each format item is replaced by the string representation of a corresponding argument
		/// in a parameter array.
		/// </summary>
		/// <param name="stringBuilder">A instance of <see cref="StringBuilder"/>.</param>
		/// <param name="format">A composite format string.</param>
		/// <param name="args">An array of objects to format.</param>
		/// <returns>A reference to this instance with <em>format</em> appended. Each
		/// <em>format</em> item in format is replaced by the string representation of the
		/// corresponding object argument.</returns>
		/// <exception cref="ArgumentNullException"><em>format</em> or <em>args</em> is
		/// <strong>null</strong>.</exception>
		/// <exception cref="FormatException"><p><em>format</em> is invalid.</p>
		/// <p>-or-</p>
		/// <p>The index of a format item is less than 0 (zero), or greater than or equal to the
		/// length of the <em>args</em> array.</p></exception>
		/// <exception cref="ArgumentOutOfRangeException">The length of the expanded string would
		/// exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendLineFormat(this StringBuilder stringBuilder,
			string format,
			params object[] args)
		{
			stringBuilder.AppendFormat(format, args);
			stringBuilder.AppendLine();

			return stringBuilder;
		}
		#endregion
	}
}