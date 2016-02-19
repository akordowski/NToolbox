using NToolbox.Media;
using NUnit.Framework;
using System.Collections;

namespace NToolbox.Tests.TestCaseSources
{
	public static class SamplerateTestCaseSource
	{
		#region Test Case Sources
		public static IEnumerable Samplerate_TestCases()
		{
			yield return new TestCaseData(Samplerate.Hz_8000, 8000);
			yield return new TestCaseData(Samplerate.Hz_11025, 11025);
			yield return new TestCaseData(Samplerate.Hz_12000, 12000);
			yield return new TestCaseData(Samplerate.Hz_16000, 16000);
			yield return new TestCaseData(Samplerate.Hz_22050, 22050);
			yield return new TestCaseData(Samplerate.Hz_24000, 24000);
			yield return new TestCaseData(Samplerate.Hz_32000, 32000);
			yield return new TestCaseData(Samplerate.Hz_44100, 44100);
			yield return new TestCaseData(Samplerate.Hz_48000, 48000);
			yield return new TestCaseData(Samplerate.Hz_96000, 96000);
			yield return new TestCaseData(Samplerate.Hz_192000, 192000);
		}
		#endregion
	}
}