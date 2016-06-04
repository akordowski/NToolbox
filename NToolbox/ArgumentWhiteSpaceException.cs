using NToolbox.Resources;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace NToolbox
{
	/// <summary>
	/// The exception that is thrown when a white-characters only reference is passed to a method
	/// that does not accept it as a valid argument. 
	/// </summary>
	[Serializable]
	public class ArgumentWhiteSpaceException : ArgumentException
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentWhiteSpaceException"/> class.
		/// </summary>
		public ArgumentWhiteSpaceException()
			: base(Resource.GetString(ResourceName.ArgumentWhiteSpaceException_Message))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentWhiteSpaceException"/> class with
		/// the name of the parameter that causes this exception.
		/// </summary>
		/// <param name="paramName">The name of the parameter that caused the exception.</param>
		public ArgumentWhiteSpaceException(string paramName)
			: base(Resource.GetString(ResourceName.ArgumentWhiteSpaceException_Message), paramName)
		{
		}

		/// <summary>
		/// Initializes an instance of the <see cref="ArgumentWhiteSpaceException"/> class with a
		/// specified error message and the name of the parameter that causes this exception.
		/// </summary>
		/// <param name="paramName">The name of the parameter that caused the exception.</param>
		/// <param name="message">A message that describes the error.</param>
		public ArgumentWhiteSpaceException(string paramName, string message)
			: base(message, paramName)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentWhiteSpaceException"/> class with
		/// a specified error message and the exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for this
		/// exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception,
		/// or a null reference if no inner exception is specified.</param>
		public ArgumentWhiteSpaceException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ArgumentWhiteSpaceException"/> class with
		/// serialized data.
		/// </summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">An object that describes the source or destination of the
		/// serialized data.</param>
		[SecurityCritical]
		protected ArgumentWhiteSpaceException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
		#endregion
	}
}