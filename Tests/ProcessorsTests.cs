using NUnit.Framework;
using Optimum_Tech.Model.Products;
using System;

namespace Test_OptimumTech.Tests
{
    [TestFixture]
    public class ProcessorTests
    {
        [Test]
        public void SetManufacturer_ValidValue_ShouldSetManufacturerProperty()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);
            string expectedManufacturer = "Intel";  

            // Act
            processor.Manufacturer = expectedManufacturer;

            // Assert
            Assert.AreEqual(expectedManufacturer, processor.Manufacturer);
        }

        [Test]
        public void SetManufacturer_NullOrEmptyValue_ThrowsArgumentNullException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => processor.Manufacturer = null);
            Assert.Throws<ArgumentNullException>(() => processor.Manufacturer = string.Empty);
        }

        [Test]
        public void SetSocket_ValidValue_ShouldSetSocketProperty()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);
            string expectedSocket = "LGA1151";

            // Act
            processor.Socket = expectedSocket;

            // Assert
            Assert.AreEqual(expectedSocket, processor.Socket);
        }

        [Test]
        public void SetSocket_NullOrEmptyValue_ThrowsArgumentNullException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => processor.Socket = null);
            Assert.Throws<ArgumentNullException>(() => processor.Socket = string.Empty);
        }

        [Test]
        public void SetCores_ValidRange_ShouldSetCoresProperty()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);
            int expectedCores = 8;

            // Act
            processor.Cores = expectedCores;

            // Assert
            Assert.AreEqual(expectedCores, processor.Cores);
        }

        [Test]
        public void SetCores_OutOfRange_ThrowsException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<Exception>(() => processor.Cores = 0);
            Assert.Throws<Exception>(() => processor.Cores = 65);
        }

        [Test]
        public void SetThreads_ValidRange_ShouldSetThreadsProperty()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);
            int expectedThreads = 16;

            // Act
            processor.Threads = expectedThreads;

            // Assert
            Assert.AreEqual(expectedThreads, processor.Threads);
        }

        [Test]
        public void SetThreads_OutOfRange_ThrowsException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<Exception>(() => processor.Threads = 0);
            Assert.Throws<Exception>(() => processor.Threads = 129);
        }

        [Test]
        public void SetClockSpeedDefault_ValidRange_ShouldSetClockSpeedDefaultProperty()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);
            double expectedClockSpeedDefault = 2.6;

            // Act
            processor.ClockSpeedDefault = expectedClockSpeedDefault;

            // Assert
            Assert.AreEqual(expectedClockSpeedDefault, processor.ClockSpeedDefault);
        }

        [Test]
        public void SetClockSpeedDefault_OutOfRange_ThrowsException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<Exception>(() => processor.ClockSpeedDefault = 0.05);
            Assert.Throws<Exception>(() => processor.ClockSpeedDefault = 6.5);
        }

        [Test]
        public void SetClockSpeedBoost_ValidRange_ShouldSetClockSpeedBoostProperty()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);
            double expectedClockSpeedBoost = 3.2;

            // Act
            processor.ClockSpeedBoost = expectedClockSpeedBoost;

            // Assert
            Assert.AreEqual(expectedClockSpeedBoost, processor.ClockSpeedBoost);
        }

        [Test]
        public void SetClockSpeedBoost_OutOfRange_ThrowsException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<Exception>(() => processor.ClockSpeedBoost = 0.05);
            Assert.Throws<Exception>(() => processor.ClockSpeedBoost = 6.5);
        }

        [Test]
        public void SetCores_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<FormatException>(() => processor.Cores = int.Parse("invalid"));
        }

        [Test]
        public void SetThreads_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<FormatException>(() => processor.Threads = int.Parse("invalid"));
        }

        [Test]
        public void SetClockSpeedDefault_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<FormatException>(() => processor.ClockSpeedDefault = double.Parse("invalid"));
        }

        [Test]
        public void SetClockSpeedBoost_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var processor = new Processor(Guid.Parse("21a3a3f3-131d-47ac-a06e-925af6b8f7df"), "Intel Core i9 13900KF", 539, 41, 5, "Intel", "1700", 16, 32, 3.5, 5.0);

            // Act & Assert
            Assert.Throws<FormatException>(() => processor.ClockSpeedBoost = double.Parse("invalid"));
        }
    }
}
