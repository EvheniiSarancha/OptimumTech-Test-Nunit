using Optimum_Tech.Models;

namespace Test_OptimumTech.Tests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Email_ValidFormat_ShouldNotThrowException()
        {
            // Arrange
            string email = "john.doe@example.com";
            Order order = new Order(email, "123 Main St", "+1234567890", 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.DoesNotThrow(() => order.Email = email);
        }

        [Test]
        public void Email_InvalidFormat_ShouldThrowException()
        {
            // Arrange
            string email = "invalid email format";
            Order order = new Order("john.doe@example.com", "123 Main St", "+1234567890", 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => order.Email = email);
        }

        [Test]
        public void Address_NullOrEmpty_ShouldThrowException()
        {
            // Arrange
            Order order = new Order("john.doe@example.com", "123 Main St", "+1234567890", 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => order.Address = null);
        }

        [Test]
        public void PhoneNumber_ValidFormat_ShouldNotThrowException()
        {
            // Arrange
            string phoneNumber = "+1234567890";
            Order order = new Order("john.doe@example.com", "123 Main St", phoneNumber, 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.DoesNotThrow(() => order.PhoneNumber = phoneNumber);
        }

        [Test]
        public void PhoneNumber_InvalidFormat_ShouldThrowException()
        {
            // Arrange
            string phoneNumber = "invalid phone number format";
            Order order = new Order("john.doe@example.com", "123 Main St", "+1234567890", 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => order.PhoneNumber = phoneNumber);
        }

        [Test]
        public void TotalPrice_NegativeValue_ShouldThrowException()
        {
            // Arrange
            Order order = new Order("john.doe@example.com", "123 Main St", "+1234567890", 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => order.TotalPrice = -100.0m);
        }

        [Test]
        public void TotalAmount_NegativeValue_ShouldThrowException()
        {
            // Arrange
            Order order = new Order("john.doe@example.com", "123 Main St", "+1234567890", 100.0m, 1, DeliverType.LocalPostOffice);

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => order.TotalAmount = -1);
        }

        [Test]
        public void DateSetter_ShouldSetDateToCurrentDateTime()
        {
            // Arrange
            Order order = new Order("test@test.com", "123 Main St", "+1234567890", 10.99m, 2, DeliverType.AtTheAddress);

            // Act
            DateTime expectedDate = DateTime.Now;
            DateTime actualDate = order.Date;

            // Assert
            Assert.That(actualDate, Is.EqualTo(expectedDate).Within(1).Seconds);
        }

        [Test]
        public void DeliveryTypeSetter_ValidDeliveryType_ShouldSetDeliveryType()
        {
            // Arrange
            Order order = new Order("test@test.com", "123 Main St", "+1234567890", 10.99m, 2, DeliverType.AtTheAddress);

            // Act
            order.DeliveryType = DeliverType.AtTheAddress;

            // Assert
            Assert.That(order.DeliveryType, Is.EqualTo(DeliverType.AtTheAddress));
        }

        [Test]
        public void IdGetter_ShouldReturnGuid()
        {
            // Arrange
            Order order = new Order("test@test.com", "123 Main St", "+1234567890", 10.99m, 2, DeliverType.AtTheAddress);

            // Act
            Guid id = order.Id;

            // Assert
            Assert.That(id, Is.TypeOf<Guid>());
        }
    }
}
