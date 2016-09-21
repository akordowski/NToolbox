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
		private Mock<ISerializer<string, int?>> _serializerMock;
		#endregion

		#region SetUp
		[SetUp]
		public void SetUp()
		{
			_serializerMock = new Mock<ISerializer<string, int?>>();
			_serializerMock.Setup(obj => obj.Deserialize(It.IsAny<int?>())).Returns((int? value) => value.ToString());

			_converter = new DeserializeConverter<int?, string>(_serializerMock.Object);
		}
		#endregion

		#region Tests
		[Test]
		public void Initialize_With_Null_Serializer_Throws_ArgumentNullException()
		{
			AssertThrowsArgumentNullException(() => new DeserializeConverter<int?, string>(null), "serializer");
		}

		[Test]
		public void Initialize_With_Valid_Serializer_Throws_Nothing()
		{
			AssertThrowsNothing(() => new DeserializeConverter<int?, string>(_serializerMock.Object));
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