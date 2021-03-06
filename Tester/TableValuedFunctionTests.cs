﻿using System.Linq;
using NUnit.Framework;

namespace Tester
{
    [TestFixture]
    public class TableValuedFunctionTests
    {
        [Test]
        public void Standard_test()
        {
            // Arrange
            var db = new TestDatabaseStandard.TestDbContext();

            // Act
            var data = db.CsvToInt("123,456", "").ToList();

            // Assert
            Assert.AreEqual(2, data.Count);
            Assert.AreEqual(123, data[0].IntValue);
            Assert.AreEqual(456, data[1].IntValue);
        }

        [Test]
        public void DataAnnotation_test()
        {
            // Arrange
            var db = new TestDatabaseDataAnnotation.TestDbContext();

            // Act
            var data = db.CsvToInt("123,456", "").ToList();

            // Assert
            Assert.AreEqual(2, data.Count);
            Assert.AreEqual(123, data[0].IntValue);
            Assert.AreEqual(456, data[1].IntValue);
        }
    }
}
