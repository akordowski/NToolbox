using NToolbox.Extensions;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Extensions
{
	[TestFixture]
	public class NumericExtensionTest
	{
		#region Tests
		[TestCase(0.123, 1)]
		[TestCase(1.234, 2)]
		[TestCase(2.345, 3)]
		[TestCase(3.456, 4)]
		[TestCase(4.567, 5)]
		public void Ceiling(decimal value, decimal expectedResult)
		{
			Assert.That(value.Ceiling(), Is.EqualTo(expectedResult));
		}

		[TestCase((double)0.123, 1)]
		[TestCase((double)1.234, 2)]
		[TestCase((double)2.345, 3)]
		[TestCase((double)3.456, 4)]
		[TestCase((double)4.567, 5)]
		public void Ceiling(double value, double expectedResult)
		{
			Assert.That(value.Ceiling(), Is.EqualTo(expectedResult));
		}

		[TestCase(0.123, 0)]
		[TestCase(1.234, 1)]
		[TestCase(2.345, 2)]
		[TestCase(3.456, 3)]
		[TestCase(4.567, 4)]
		public void Floor(decimal value, decimal expectedResult)
		{
			Assert.That(value.Floor(), Is.EqualTo(expectedResult));
		}

		[TestCase((double)0.123, 0)]
		[TestCase((double)1.234, 1)]
		[TestCase((double)2.345, 2)]
		[TestCase((double)3.456, 3)]
		[TestCase((double)4.567, 4)]
		public void Floor(double value, double expectedResult)
		{
			Assert.That(value.Floor(), Is.EqualTo(expectedResult));
		}

		[TestCase((byte)10, true)]
		[TestCase((byte)11, false)]
		public void IsEven(byte value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase(10, true)]
		[TestCase(11, false)]
		public void IsEven(decimal value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((double)10.0, true)]
		[TestCase((double)11.0, false)]
		public void IsEven(double value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((float)10.0, true)]
		[TestCase((float)11.0, false)]
		public void IsEven(float value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((int)10, true)]
		[TestCase((int)11, false)]
		public void IsEven(int value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((long)10, true)]
		[TestCase((long)11, false)]
		public void IsEven(long value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((sbyte)10, true)]
		[TestCase((sbyte)11, false)]
		public void IsEven(sbyte value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((short)10, true)]
		[TestCase((short)11, false)]
		public void IsEven(short value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((uint)10, true)]
		[TestCase((uint)11, false)]
		public void IsEven(uint value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((ulong)10, true)]
		[TestCase((ulong)11, false)]
		public void IsEven(ulong value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((ushort)10, true)]
		[TestCase((ushort)11, false)]
		public void IsEven(ushort value, bool expectedResult)
		{
			Assert.That(value.IsEven(), Is.EqualTo(expectedResult));
		}

		[TestCase((byte)10, false)]
		[TestCase((byte)11, true)]
		public void IsOdd(byte value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase(10, false)]
		[TestCase(11, true)]
		public void IsOdd(decimal value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((double)10.0, false)]
		[TestCase((double)11.0, true)]
		public void IsOdd(double value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((float)10.0, false)]
		[TestCase((float)11.0, true)]
		public void IsOdd(float value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((int)10, false)]
		[TestCase((int)11, true)]
		public void IsOdd(int value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((long)10, false)]
		[TestCase((long)11, true)]
		public void IsOdd(long value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((sbyte)10, false)]
		[TestCase((sbyte)11, true)]
		public void IsOdd(sbyte value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((short)10, false)]
		[TestCase((short)11, true)]
		public void IsOdd(short value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((uint)10, false)]
		[TestCase((uint)11, true)]
		public void IsOdd(uint value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((ulong)10, false)]
		[TestCase((ulong)11, true)]
		public void IsOdd(ulong value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase((ushort)10, false)]
		[TestCase((ushort)11, true)]
		public void IsOdd(ushort value, bool expectedResult)
		{
			Assert.That(value.IsOdd(), Is.EqualTo(expectedResult));
		}

		[TestCase(12.345, 12)]
		public void Truncate(decimal value, decimal expectedResult)
		{
			Assert.That(value.Truncate(), Is.EqualTo(expectedResult));
		}

		[TestCase((double)12.345, 12)]
		public void Truncate(double value, double expectedResult)
		{
			Assert.That(value.Truncate(), Is.EqualTo(expectedResult));
		}
		#endregion
	}
}