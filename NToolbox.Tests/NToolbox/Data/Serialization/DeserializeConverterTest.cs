using Moq;
using NToolbox.Data.Serialization;
using NToolbox.NUnit;
using NUnit.Framework;

namespace NToolbox.Tests.NToolbox.Data.Serialization
{
	[TestFixture]
	public class DeserializeConverterTest : NUnitTestBase
	{
		#region Private Fields
		private DeserializeConverter<int?, string> _converter;
		private Mock<IDeserializer<int?, string>> _deserializerMock;
		#endregion

		#region SetUp
		[SetUp]
		public void SetUp()
		{
			_deserializerMock = new Mock<IDeserializer<int?, string>>();
			_deserializerMock.Setup(obj => obj.Deserialize(It.IsAny<int?>())).Returns((int? value) => value.ToString());

			_converter = new DeserializeConverter<int?, string>(_deserializerMock.Object);
		}
		#endregion

		#region Tests
		[Test]
		public void Initialize_With_Null_Serializer_Throws_ArgumentNullException()
		{
			AssertThrowsArgumentNullException(() => new DeserializeConverter<int?, string>(null), "deserializer");
		}

		[Test]
		public void Initialize_With_Valid_Serializer_Throws_Nothing()
		{
			AssertThrowsNothing(() => new DeserializeConverter<int?, string>(_deserializerMock.Object));
		}

		[Test]
		public void Convert_With_Null_Data_Throws_ArgumentNullException()
		{
			AssertThrowsArgumentNullException(() => _converter.Convert(null), "data");
		}

		[Test]
		public void Convert_With_Valid_Data_Returns_Valid_Result()
		{
			Assert.That(() => _converter.Convert(100), Is.EqualTo("100"));
		}
		#endregion
	}
}