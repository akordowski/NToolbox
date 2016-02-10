using NToolbox.Resources;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace NToolbox
{
	/// <summary>
	/// The exception that is thrown when a empty reference is passed to a method that does not accept it as a valid argument. 
	/// </summary>
	[Serializable]
	public class ArgumentEmptyException : ArgumentException
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentEmptyException"/> class.
		/// </summary>
		public ArgumentEmptyException()
			: base(Resource.GetString(ResourceName.ArgumentEmptyException_Message))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentEmptyException"/> class with the name of the parameter that causes this exception.
		/// </summary>
		/// <param name="paramName">The name of the parameter that caused the exception.</param>
		public ArgumentEmptyException(string paramName)
			: base(Resource.GetString(ResourceName.ArgumentEmptyException_Message), paramName)
		{
		}

		/// <summary>
		/// Initializes an instance of the <see cref="ArgumentEmptyException"/> class with a specified error message and the name of the parameter that causes this exception.
		/// </summary>
		/// <param name="paramName">The name of the parameter that caused the exception.</param>
		/// <param name="message">A message that describes the error.</param>
		public ArgumentEmptyException(string paramName, string message)
			: base(message, paramName)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentEmptyException"/> class with a specified error message and the exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for this exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
		public ArgumentEmptyException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentEmptyException"/> class with serialized data.
		/// </summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">An object that describes the source or destination of the serialized data.</param>
		[SecurityCritical]
		protected ArgumentEmptyException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
		#endregion
	}
}