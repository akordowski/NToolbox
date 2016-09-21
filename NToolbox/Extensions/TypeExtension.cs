using System;
using System.Reflection;

namespace NToolbox.Extensions
{
	/// <summary>
	/// Contains <see cref="Type"/> extension methods.
	/// </summary>
	public static class TypeExtension
	{
		#region Public Static Methods
		/// <summary>
		/// Indicates whether the Type has the definied operator.
		/// </summary>
		/// <param name="type">The <see cref="Type"/> to test.</param>
		/// <param name="operatorName">The name of the operator.</param>
		/// <returns><strong>true</strong> if the <see cref="Type"/> has the definied operator
		/// type; otherwise, <strong>false</strong>.</returns>
		public static bool HasOperator(this Type type, OperatorName operatorName)
		{
			string operatorMethodName = $"op_{operatorName}";
			MethodInfo methodInfo = type.GetMethod(operatorMethodName);

			return methodInfo != null && methodInfo.IsSpecialName;
		}

		/// <summary>
		/// Indicates whether the Type is one of the floating point types.
		/// </summary>
		/// <param name="type">The <see cref="Type"/> to test.</param>
		/// <returns><strong>true</strong> if the <see cref="Type"/> is one of the floating point
		/// types; otherwise, <strong>false</strong>.</returns>
		public static bool IsFloatingPoint(this Type type)
		{
			TypeCode typeCode = Type.GetTypeCode(type);
			string operatorMethodName = $"op_{typeCode}";

			switch (typeCode)
			{
				case TypeCode.Single:
				case TypeCode.Double:
					return true;
				default:
					return false;
			}
		}

		/// <summary>
		/// Indicates whether the Type is one of the integral types.
		/// </summary>
		/// <param name="type">The <see cref="Type"/> to test.</param>
		/// <returns><strong>true</strong> if the <see cref="Type"/> is one of the integral types;
		/// otherwise, <strong>false</strong>.</returns>
		public static bool IsIntegral(this Type type)
		{
			TypeCode typeCode = Type.GetTypeCode(type);

			switch (typeCode)
			{
				case TypeCode.SByte:
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
					return true;
				default:
					return false;
			}
		}

		/// <summary>
		/// Indicates whether the Type is one of the numeric types.
		/// </summary>
		/// <param name="type">The <see cref="Type"/> to test.</param>
		/// <returns><strong>true</strong> if the <see cref="Type"/> is one of the numeric types;
		/// otherwise, <strong>false</strong>.</returns>
		public static bool IsNumeric(this Type type)
		{
			TypeCode typeCode = Type.GetTypeCode(type);

			switch (typeCode)
			{
				case TypeCode.SByte:
				case TypeCode.Byte:
				case TypeCode.Int16:
				case TypeCode.UInt16:
				case TypeCode.Int32:
				case TypeCode.UInt32:
				case TypeCode.Int64:
				case TypeCode.UInt64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				default:
					return false;
			}
		}
		#endregion
	}
}