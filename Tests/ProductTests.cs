using NUnit.Framework;
using Optimum_Tech.Models;
using System;

namespace Test_OptimumTech.Tests
{
    // A concrete class that inherits from the abstract Product class for testing purposes
    public class TestProduct : Product
    {
    }

    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void SetId_EmptyGuid_ThrowsArgumentException()
        {
            // Arrange
            var product = new TestProduct();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.Id = Guid.Empty);
        }

        [Test]
        public void SetName_NullOrEmptyValue_ThrowsArgumentNullException()
        {
            // Arrange
            var product = new TestProduct();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => product.Name = null);
            Assert.Throws<ArgumentNullException>(() => product.Name = string.Empty);
        }

        [Test]
        public void SetName_ExceedsMaxLength_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var product = new TestProduct();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Name = "This name exceeds the maximum allowed length...");
        }

        [Test]
        public void SetPrice_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var product = new TestProduct();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Price = -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Price = 100000);
        }

        [Test]
        public void SetResponses_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var product = new TestProduct();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Responses = -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Responses = 1000);
        }

        [Test]
        public void SetRating_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var product = new TestProduct();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Rating = -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => product.Rating = 6);
        }
        [Test]
        public void SetIsAvailable_SetsIsAvailableProperty()
        {
            // Arrange
            var product = new TestProduct();

            // Act
            product.IsAvailable = true;

            // Assert
            Assert.IsTrue(product.IsAvailable);
        }

        [Test]
        public void SetIsAvailable_DefaultValueIsFalse()
        {
            // Arrange
            var product = new TestProduct();

            // Assert
            Assert.IsFalse(product.IsAvailable);
        }
        [Test]
        public void SetPrice_ValidRange_SetsPriceProperty()
        {
            // Arrange
            var product = new TestProduct();
            decimal expectedPrice = 99.99m;

            // Act
            product.Price = expectedPrice;

            // Assert
            Assert.AreEqual(expectedPrice, product.Price);
        }

        [Test]
        public void SetResponses_ValidRange_SetsResponsesProperty()
        {
            // Arrange
            var product = new TestProduct();
            int expectedResponses = 10;

            // Act
            product.Responses = expectedResponses;

            // Assert
            Assert.AreEqual(expectedResponses, product.Responses);
        }

        [Test]
        public void SetRating_ValidRange_SetsRatingProperty()
        {
            // Arrange
            var product = new TestProduct();
            int expectedRating = 4;

            // Act
            product.Rating = expectedRating;

            // Assert
            Assert.AreEqual(expectedRating, product.Rating);
        }
    }
}
