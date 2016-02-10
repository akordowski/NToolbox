namespace NToolbox.Net
{
	/// <summary>
	/// Hypertext Transfer Protocol (HTTP) response status codes.
	/// </summary>
	public enum HttpCode
	{
		// --------------------------------------------------
		// 1xx Informational
		// --------------------------------------------------

		/// <summary>
		/// Continue
		/// </summary>
		Continue = 100,

		/// <summary>
		/// Switching Protocols
		/// </summary>
		SwitchingProtocols = 101,

		/// <summary>
		/// Processing (WebDAV; RFC 2518)
		/// </summary>
		Processing = 102,

		// --------------------------------------------------
		// 2xx Success
		// --------------------------------------------------

		/// <summary>
		/// OK
		/// </summary>
		OK = 200,

		/// <summary>
		/// Created
		/// </summary>
		Created = 201,

		/// <summary>
		/// Accepted
		/// </summary>
		Accepted = 202,

		/// <summary>
		/// Non-Authoritative Information (since HTTP/1.1)
		/// </summary>
		NonAuthoritativeInformation = 203,

		/// <summary>
		/// No Content
		/// </summary>
		NoContent = 204,

		/// <summary>
		/// Reset Content
		/// </summary>
		ResetContent = 205,

		/// <summary>
		/// Partial Content (RFC 7233)
		/// </summary>
		PartialContent = 206,

		/// <summary>
		/// Multi-Status (WebDAV; RFC 4918)
		/// </summary>
		MultiStatus = 207,

		/// <summary>
		/// Already Reported (WebDAV; RFC 5842)
		/// </summary>
		AlreadyReported = 208,

		/// <summary>
		/// IM Used (RFC 3229)
		/// </summary>
		IMUsed = 226,

		// --------------------------------------------------
		// 3xx Redirection
		// --------------------------------------------------

		/// <summary>
		/// Multiple Choices
		/// </summary>
		MultipleChoices = 300,

		/// <summary>
		/// Moved Permanently
		/// </summary>
		MovedPermanently = 301,

		/// <summary>
		/// Found
		/// </summary>
		Found = 302,

		/// <summary>
		/// See Other (since HTTP/1.1)
		/// </summary>
		SeeOther = 303,

		/// <summary>
		/// Not Modified (RFC 7232)
		/// </summary>
		NotModified = 304,

		/// <summary>
		/// Use Proxy (since HTTP/1.1)
		/// </summary>
		UseProxy = 305,

		/// <summary>
		/// Switch Proxy
		/// </summary>
		SwitchProxy = 306,

		/// <summary>
		/// Temporary Redirect (since HTTP/1.1)
		/// </summary>
		TemporaryRedirect = 307,

		/// <summary>
		/// Permanent Redirect (RFC 7538)
		/// </summary>
		PermanentRedirect = 308,

		/// <summary>
		/// Resume Incomplete (Google)
		/// </summary>
		ResumeIncomplete = 308,

		// --------------------------------------------------
		// 4xx Client Error
		// --------------------------------------------------

		/// <summary>
		/// Bad Request
		/// </summary>
		BadRequest = 400,

		/// <summary>
		/// Unauthorized (RFC 7235)
		/// </summary>
		Unauthorized = 401,

		/// <summary>
		/// Payment Required
		/// </summary>
		PaymentRequired = 402,

		/// <summary>
		/// Forbidden
		/// </summary>
		Forbidden = 403,

		/// <summary>
		/// Not Found
		/// </summary>
		NotFound = 404,

		/// <summary>
		/// Method Not Allowed
		/// </summary>
		MethodNotAllowed = 405,

		/// <summary>
		/// Not Acceptable
		/// </summary>
		NotAcceptable = 406,

		/// <summary>
		/// Proxy Authentication Required (RFC 7235)
		/// </summary>
		ProxyAuthenticationRequired = 407,

		/// <summary>
		/// Request Timeout
		/// </summary>
		RequestTimeout = 408,

		/// <summary>
		/// Conflict
		/// </summary>
		Conflict = 409,

		/// <summary>
		/// Gone
		/// </summary>
		Gone = 410,

		/// <summary>
		/// Length Required
		/// </summary>
		LengthRequired = 411,

		/// <summary>
		/// Precondition Failed (RFC 7232)
		/// </summary>
		PreconditionFailed = 412,

		/// <summary>
		/// Payload Too Large (RFC 7231)
		/// </summary>
		PayloadTooLarge = 413,

		/// <summary>
		/// Request-URI Too Long
		/// </summary>
		RequestUriTooLong = 414,

		/// <summary>
		/// Unsupported Media Type
		/// </summary>
		UnsupportedMediaType = 415,

		/// <summary>
		/// Requested Range Not Satisfiable (RFC 7233)
		/// </summary>
		RequestedRangeNotSatisfiable = 416,

		/// <summary>
		/// Expectation Failed
		/// </summary>
		ExpectationFailed = 417,

		/// <summary>
		/// I'm a teapot (RFC 2324)
		/// </summary>
		ImATeapot = 418,

		/// <summary>
		/// Authentication Timeout (not in RFC 2616)
		/// </summary>
		AuthenticationTimeout = 419,

		/// <summary>
		/// Method Failure (Spring Framework)
		/// </summary>
		MethodFailure = 420,

		/// <summary>
		/// Enhance Your Calm (Twitter)
		/// </summary>
		EnhanceYourCalm = 420,

		/// <summary>
		/// Misdirected Request (HTTP/2)
		/// </summary>
		MisdirectedRequest = 421,

		/// <summary>
		/// Unprocessable Entity (WebDAV; RFC 4918)
		/// </summary>
		UnprocessableEntity = 422,

		/// <summary>
		/// Locked (WebDAV; RFC 4918)
		/// </summary>
		Locked = 423,

		/// <summary>
		/// Failed Dependency (WebDAV; RFC 4918)
		/// </summary>
		FailedDependency = 424,

		/// <summary>
		/// Upgrade Required
		/// </summary>
		UpgradeRequired = 426,

		/// <summary>
		/// Precondition Required (RFC 6585)
		/// </summary>
		PreconditionRequired = 428,

		/// <summary>
		/// Too Many Requests (RFC 6585)
		/// </summary>
		TooManyRequests = 429,

		/// <summary>
		/// Request Header Fields Too Large (RFC 6585)
		/// </summary>
		RequestHeaderFieldsTooLarge = 431,

		/// <summary>
		/// Login Timeout (Microsoft)
		/// </summary>
		LoginTimeout = 440,

		/// <summary>
		/// No Response (Nginx)
		/// </summary>
		NoResponse = 444,

		/// <summary>
		/// Retry With (Microsoft)
		/// </summary>
		RetryWith = 449,

		/// <summary>
		/// Blocked by Windows Parental Controls (Microsoft)
		/// </summary>
		BlockedByWindowsParentalControls = 450,

		/// <summary>
		/// Unavailable For Legal Reasons (Internet draft)
		/// </summary>
		UnavailableForLegalReasons = 451,

		/// <summary>
		/// Redirect (Microsoft)
		/// </summary>
		Redirect = 451,

		/// <summary>
		/// Request Header Too Large (Nginx)
		/// </summary>
		RequestHeaderTooLarge = 494,

		/// <summary>
		/// Cert Error (Nginx)
		/// </summary>
		CertError = 495,

		/// <summary>
		/// No Cert (Nginx)
		/// </summary>
		NoCert = 496,

		/// <summary>
		/// HTTP to HTTPS (Nginx)
		/// </summary>
		HttpToHttps = 497,

		/// <summary>
		/// Token expired/invalid (Esri)
		/// </summary>
		TokenExpiredInvalid = 498,

		/// <summary>
		/// Client Closed Request (Nginx)
		/// </summary>
		ClientClosedRequest = 499,

		/// <summary>
		/// Token required (Esri)
		/// </summary>
		TokenRequired = 499,

		// --------------------------------------------------
		// 5xx Server Error
		// --------------------------------------------------

		/// <summary>
		/// Internal Server Error
		/// </summary>
		InternalServerError = 500,

		/// <summary>
		/// Not Implemented
		/// </summary>
		NotImplemented = 501,

		/// <summary>
		/// Bad Gateway
		/// </summary>
		BadGateway = 502,

		/// <summary>
		/// Service Unavailable
		/// </summary>
		ServiceUnavailable = 503,

		/// <summary>
		/// Gateway Timeout
		/// </summary>
		GatewayTimeout = 504,

		/// <summary>
		/// HTTP Version Not Supported
		/// </summary>
		HttpVersionNotSupported = 505,

		/// <summary>
		/// Variant Also Negotiates (RFC 2295)
		/// </summary>
		VariantAlsoNegotiates = 506,

		/// <summary>
		/// Insufficient Storage (WebDAV; RFC 4918)
		/// </summary>
		InsufficientStorage = 507,

		/// <summary>
		/// Loop Detected (WebDAV; RFC 5842)
		/// </summary>
		LoopDetected = 508,

		/// <summary>
		/// Bandwidth Limit Exceeded (Apache bw/limited extension)
		/// </summary>
		BandwidthLimitExceeded = 509,

		/// <summary>
		/// Not Extended (RFC 2774)
		/// </summary>
		NotExtended = 510,

		/// <summary>
		/// Network Authentication Required (RFC 6585)
		/// </summary>
		NetworkAuthenticationRequired = 511,

		/// <summary>
		/// Unknown Error
		/// </summary>
		UnknownError = 520,

		/// <summary>
		/// Origin Connection Time-out
		/// </summary>
		OriginConnectionTimeout = 522,

		/// <summary>
		/// Network read timeout error
		/// </summary>
		NetworkReadTimeoutError = 598,

		/// <summary>
		/// Network connect timeout error
		/// </summary>
		NetworkConnectTimeoutError = 599
	}
}