using NToolbox.NUnit;
using NToolbox.Utils;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NToolbox.Tests.NToolbox.Utils
{
	[TestFixture]
	public class ClassUtilTest : NUnitTestBase
	{
		#region Tests
		[Test]
		public void CreateInstance_Return_Valid_Result()
		{
			Exception obj = null;

			Assert.That(() => obj = ClassUtil.CreateInstance<Exception>(), Throws.Nothing);
			Assert.That(obj, Is.Not.Null);
			Assert.That(obj, Is.TypeOf<Exception>());
		}

		[Test]
		public void CreateInstance_By_Type_Return_Valid_Result()
		{
			Type type = typeof(Exception);
			Exception obj = null;

			Assert.That(() => obj = (Exception)ClassUtil.CreateInstance(type), Throws.Nothing);
			Assert.That(obj, Is.Not.Null);
			Assert.That(obj, Is.TypeOf(type));
		}

		[Test]
		public void CreateInstance_Throws_ArgumentNullException()
		{
			AssertThrowsException<ArgumentNullException>(() => ClassUtil.CreateInstance(null), "type");
		}

		[Test]
		public void CreateDictionaryInstance_Return_Valid_Result()
		{
			Dictionary<string, Exception> obj = null;

			Assert.That(() => obj = ClassUtil.CreateDictionaryInstance<string, Exception>(), Throws.Nothing);
			Assert.That(obj, Is.Not.Null);
			Assert.That(obj, Is.TypeOf<Dictionary<string, Exception>>());
		}

		[Test]
		public void CreateDictionaryInstance_By_Type_Return_Valid_Result()
		{
			Type keyType = typeof(string);
			Type valueType = typeof(Exception);
			Type expectedType = typeof(Dictionary<string, Exception>);
			Dictionary<string, Exception> obj = null;

			Assert.That(() => obj = (Dictionary<string, Exception>)ClassUtil.CreateDictionaryInstance(keyType, valueType), Throws.Nothing);
			Assert.That(obj, Is.Not.Null);
			Assert.That(obj, Is.TypeOf(expectedType));
		}

		[TestCaseSource("CreateDictionaryInstance_TestCases")]
		public void CreateDictionaryInstance_Throws_ArgumentNullException(Type keyType, Type valueType, string expectedParameter)
		{
			AssertThrowsException<ArgumentNullException>(() => ClassUtil.CreateDictionaryInstance(keyType, valueType), expectedParameter);
		}

		[Test]
		public void CreateListInstance_Return_Valid_Result()
		{
			List<Exception> obj = null;

			Assert.That(() => obj = ClassUtil.CreateListInstance<Exception>(), Throws.Nothing);
			Assert.That(obj, Is.Not.Null);
			Assert.That(obj, Is.TypeOf<List<Exception>>());
		}

		[Test]
		public void CreateListInstance_By_Type_Return_Valid_Result()
		{
			Type type = typeof(Exception);
			Type expectedType = typeof(List<Exception>);
			List<Exception> obj = null;

			Assert.That(() => obj = (List<Exception>)ClassUtil.CreateListInstance(type), Throws.Nothing);
			Assert.That(obj, Is.Not.Null);
			Assert.That(obj, Is.TypeOf(expectedType));
		}

		[Test]
		public void CreateListInstance_Throws_ArgumentNullException()
		{
			AssertThrowsException<ArgumentNullException>(() => ClassUtil.CreateListInstance(null), "type");
		}
		#endregion

		#region Test Case Sources
		public static IEnumerable CreateDictionaryInstance_TestCases()
		{
			yield return new TestCaseData(null, null, "keyType");
			yield return new TestCaseData(typeof(string), null, "valueType");
		}
		#endregion
	}
}