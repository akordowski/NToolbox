using NToolbox.Media;
using NUnit.Framework;
using System.Collections;

namespace NToolbox.Tests.TestCaseSources
{
	public static class BitrateTestCaseSource
	{
		#region Test Case Sources
		public static IEnumerable Bitrate_TestCases()
		{
			yield return new TestCaseData(Bitrate.Kbps_6, 6);
			yield return new TestCaseData(Bitrate.Kbps_8, 8);
			yield return new TestCaseData(Bitrate.Kbps_10, 10);
			yield return new TestCaseData(Bitrate.Kbps_12, 12);
			yield return new TestCaseData(Bitrate.Kbps_16, 16);
			yield return new TestCaseData(Bitrate.Kbps_20, 20);
			yield return new TestCaseData(Bitrate.Kbps_22, 22);
			yield return new TestCaseData(Bitrate.Kbps_24, 24);
			yield return new TestCaseData(Bitrate.Kbps_28, 28);
			yield return new TestCaseData(Bitrate.Kbps_32, 32);
			yield return new TestCaseData(Bitrate.Kbps_40, 40);
			yield return new TestCaseData(Bitrate.Kbps_48, 48);
			yield return new TestCaseData(Bitrate.Kbps_56, 56);
			yield return new TestCaseData(Bitrate.Kbps_64, 64);
			yield return new TestCaseData(Bitrate.Kbps_80, 80);
			yield return new TestCaseData(Bitrate.Kbps_96, 96);
			yield return new TestCaseData(Bitrate.Kbps_112, 112);
			yield return new TestCaseData(Bitrate.Kbps_128, 128);
			yield return new TestCaseData(Bitrate.Kbps_144, 144);
			yield return new TestCaseData(Bitrate.Kbps_160, 160);
			yield return new TestCaseData(Bitrate.Kbps_192, 192);
			yield return new TestCaseData(Bitrate.Kbps_224, 224);
			yield return new TestCaseData(Bitrate.Kbps_256, 256);
			yield return new TestCaseData(Bitrate.Kbps_320, 320);
		}
		#endregion
	}
}