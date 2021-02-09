using System;
using System.Collections.Generic;
using System.Text;
using Mine.Models;
using NUnit.Framework;

namespace UnitTests.Models
{
    [TestFixture]
    class ItemModelTests
    {
        [Test]
        public void ItemModel_Constructor_Valid()
        {
            //Arrange

            //Act
            var result = new ItemModel();
            //Reset

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
