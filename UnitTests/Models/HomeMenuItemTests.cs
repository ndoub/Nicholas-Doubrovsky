using System;
using System.Collections.Generic;
using System.Text;
using Mine.Models;
using NUnit.Framework;

namespace UnitTests.Models
{
    [TestFixture]
    class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItem_Constructor_Valid()
        {
            //Arrange

            //Act
            var result = new HomeMenuItem();
            //Reset

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeMenuItem_Set_Get_Valid_Default_Should_Pass()
        {
            //Arrange

            //Act
            var result = new HomeMenuItem();
            result.Description = "Description";
            result.Id = "ID";
            result.Text = "Text";
            result.Value = 1;

            //Reset

            //Assert
            Assert.AreEqual("Description", result.Description);
            Assert.AreEqual("ID", result.Id);
            Assert.AreEqual("Text", result.Text);
            Assert.AreEqual(1, result.Value);
        }
    }
}
