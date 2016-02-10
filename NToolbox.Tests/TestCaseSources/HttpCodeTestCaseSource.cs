using NToolbox.Net;
using NUnit.Framework;
using System.Collections;

namespace NToolbox.Tests.TestCaseSources
{
	public static class HttpCodeTestCaseSource
	{
		#region Test Case Sources
		public static IEnumerable HttpCode_TestCases()
		{
			yield return new TestCaseData(HttpCode.Continue, 100);
			yield return new TestCaseData(HttpCode.SwitchingProtocols, 101);
			yield return new TestCaseData(HttpCode.Processing, 102);
			yield return new TestCaseData(HttpCode.OK, 200);
			yield return new TestCaseData(HttpCode.Created, 201);
			yield return new TestCaseData(HttpCode.Accepted, 202);
			yield return new TestCaseData(HttpCode.NonAuthoritativeInformation, 203);
			yield return new TestCaseData(HttpCode.NoContent, 204);
			yield return new TestCaseData(HttpCode.ResetContent, 205);
			yield return new TestCaseData(HttpCode.PartialContent, 206);
			yield return new TestCaseData(HttpCode.MultiStatus, 207);
			yield return new TestCaseData(HttpCode.AlreadyReported, 208);
			yield return new TestCaseData(HttpCode.IMUsed, 226);
			yield return new TestCaseData(HttpCode.MultipleChoices, 300);
			yield return new TestCaseData(HttpCode.MovedPermanently, 301);
			yield return new TestCaseData(HttpCode.Found, 302);
			yield return new TestCaseData(HttpCode.SeeOther, 303);
			yield return new TestCaseData(HttpCode.NotModified, 304);
			yield return new TestCaseData(HttpCode.UseProxy, 305);
			yield return new TestCaseData(HttpCode.SwitchProxy, 306);
			yield return new TestCaseData(HttpCode.TemporaryRedirect, 307);
			yield return new TestCaseData(HttpCode.PermanentRedirect, 308);
			yield return new TestCaseData(HttpCode.ResumeIncomplete, 308);
			yield return new TestCaseData(HttpCode.BadRequest, 400);
			yield return new TestCaseData(HttpCode.Unauthorized, 401);
			yield return new TestCaseData(HttpCode.PaymentRequired, 402);
			yield return new TestCaseData(HttpCode.Forbidden, 403);
			yield return new TestCaseData(HttpCode.NotFound, 404);
			yield return new TestCaseData(HttpCode.MethodNotAllowed, 405);
			yield return new TestCaseData(HttpCode.NotAcceptable, 406);
			yield return new TestCaseData(HttpCode.ProxyAuthenticationRequired, 407);
			yield return new TestCaseData(HttpCode.RequestTimeout, 408);
			yield return new TestCaseData(HttpCode.Conflict, 409);
			yield return new TestCaseData(HttpCode.Gone, 410);
			yield return new TestCaseData(HttpCode.LengthRequired, 411);
			yield return new TestCaseData(HttpCode.PreconditionFailed, 412);
			yield return new TestCaseData(HttpCode.PayloadTooLarge, 413);
			yield return new TestCaseData(HttpCode.RequestUriTooLong, 414);
			yield return new TestCaseData(HttpCode.UnsupportedMediaType, 415);
			yield return new TestCaseData(HttpCode.RequestedRangeNotSatisfiable, 416);
			yield return new TestCaseData(HttpCode.ExpectationFailed, 417);
			yield return new TestCaseData(HttpCode.ImATeapot, 418);
			yield return new TestCaseData(HttpCode.AuthenticationTimeout, 419);
			yield return new TestCaseData(HttpCode.MethodFailure, 420);
			yield return new TestCaseData(HttpCode.EnhanceYourCalm, 420);
			yield return new TestCaseData(HttpCode.MisdirectedRequest, 421);
			yield return new TestCaseData(HttpCode.UnprocessableEntity, 422);
			yield return new TestCaseData(HttpCode.Locked, 423);
			yield return new TestCaseData(HttpCode.FailedDependency, 424);
			yield return new TestCaseData(HttpCode.UpgradeRequired, 426);
			yield return new TestCaseData(HttpCode.PreconditionRequired, 428);
			yield return new TestCaseData(HttpCode.TooManyRequests, 429);
			yield return new TestCaseData(HttpCode.RequestHeaderFieldsTooLarge, 431);
			yield return new TestCaseData(HttpCode.LoginTimeout, 440);
			yield return new TestCaseData(HttpCode.NoResponse, 444);
			yield return new TestCaseData(HttpCode.RetryWith, 449);
			yield return new TestCaseData(HttpCode.BlockedByWindowsParentalControls, 450);
			yield return new TestCaseData(HttpCode.UnavailableForLegalReasons, 451);
			yield return new TestCaseData(HttpCode.Redirect, 451);
			yield return new TestCaseData(HttpCode.RequestHeaderTooLarge, 494);
			yield return new TestCaseData(HttpCode.CertError, 495);
			yield return new TestCaseData(HttpCode.NoCert, 496);
			yield return new TestCaseData(HttpCode.HttpToHttps, 497);
			yield return new TestCaseData(HttpCode.TokenExpiredInvalid, 498);
			yield return new TestCaseData(HttpCode.ClientClosedRequest, 499);
			yield return new TestCaseData(HttpCode.TokenRequired, 499);
			yield return new TestCaseData(HttpCode.InternalServerError, 500);
			yield return new TestCaseData(HttpCode.NotImplemented, 501);
			yield return new TestCaseData(HttpCode.BadGateway, 502);
			yield return new TestCaseData(HttpCode.ServiceUnavailable, 503);
			yield return new TestCaseData(HttpCode.GatewayTimeout, 504);
			yield return new TestCaseData(HttpCode.HttpVersionNotSupported, 505);
			yield return new TestCaseData(HttpCode.VariantAlsoNegotiates, 506);
			yield return new TestCaseData(HttpCode.InsufficientStorage, 507);
			yield return new TestCaseData(HttpCode.LoopDetected, 508);
			yield return new TestCaseData(HttpCode.BandwidthLimitExceeded, 509);
			yield return new TestCaseData(HttpCode.NotExtended, 510);
			yield return new TestCaseData(HttpCode.NetworkAuthenticationRequired, 511);
			yield return new TestCaseData(HttpCode.UnknownError, 520);
			yield return new TestCaseData(HttpCode.OriginConnectionTimeout, 522);
			yield return new TestCaseData(HttpCode.NetworkReadTimeoutError, 598);
			yield return new TestCaseData(HttpCode.NetworkConnectTimeoutError, 599);
		}
		#endregion
	}
}