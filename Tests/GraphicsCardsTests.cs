using Optimum_Tech.Model.Products;

namespace Test_OptimumTech.Tests
{
    [TestFixture]
    public class GraphicsCardTests
    {
        [Test]
        public void SetManufacturer_ValidValue_ShouldSetManufacturerProperty()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);
            string expectedManufacturer = "NVIDIA";

            // Act
            graphicsCard.Manufacturer = expectedManufacturer;

            // Assert
            Assert.AreEqual(expectedManufacturer, graphicsCard.Manufacturer);
        }

        [Test]
        public void SetManufacturer_NullOrEmptyValue_ThrowsArgumentNullException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => graphicsCard.Manufacturer = null);
            Assert.Throws<ArgumentNullException>(() => graphicsCard.Manufacturer = string.Empty);
        }

        [Test]
        public void SetVRAM_ValidRange_ShouldSetVRAMProperty()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);
            int expectedVRAM = 8;

            // Act
            graphicsCard.VRAM = expectedVRAM;

            // Assert
            Assert.AreEqual(expectedVRAM, graphicsCard.VRAM);
        }

        [Test]
        public void SetVRAM_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.VRAM = 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.VRAM = 27);
        }

        [Test]
        public void SetMemoryInterface_ValidRange_ShouldSetMemoryInterfaceProperty()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);
            int expectedMemoryInterface = 256;

            // Act
            graphicsCard.MemoryInterface = expectedMemoryInterface;

            // Assert
            Assert.AreEqual(expectedMemoryInterface, graphicsCard.MemoryInterface);
        }

        [Test]
        public void SetMemoryInterface_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.MemoryInterface = 31);
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.MemoryInterface = 1025);
        }

        [Test]
        public void SetMemoryType_ValidValue_ShouldSetMemoryTypeProperty()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);
            string expectedMemoryType = "GDDR6";

            // Act
            graphicsCard.MemoryType = expectedMemoryType;

            // Assert
            Assert.AreEqual(expectedMemoryType, graphicsCard.MemoryType);
        }
                [Test]
        public void SetMemoryType_NullOrEmptyValue_ThrowsArgumentNullException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => graphicsCard.MemoryType = null);
            Assert.Throws<ArgumentNullException>(() => graphicsCard.MemoryType = string.Empty);
        }

        [Test]
        public void SetClockSpeed_ValidRange_ShouldSetClockSpeedProperty()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);
            double expectedClockSpeed = 1.2;

            // Act
            graphicsCard.ClockSpeed = expectedClockSpeed;

            // Assert
            Assert.AreEqual(expectedClockSpeed, graphicsCard.ClockSpeed);
        }

        [Test]
        public void SetClockSpeed_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.ClockSpeed = 0.05);
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.ClockSpeed = 6.5);
        }

        [Test]
        public void SetMinimumWattage_ValidRange_ShouldSetMinimumWattageProperty()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);
            int expectedMinimumWattage = 500;

            // Act
            graphicsCard.MinimumWattage = expectedMinimumWattage;

            // Assert
            Assert.AreEqual(expectedMinimumWattage, graphicsCard.MinimumWattage);
        }

        [Test]
        public void SetMinimumWattage_OutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.MinimumWattage = 99);
            Assert.Throws<ArgumentOutOfRangeException>(() => graphicsCard.MinimumWattage = 2001);
        }

        [Test]
        public void SetVRAM_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<FormatException>(() => graphicsCard.VRAM = int.Parse("invalid"));
        }

        [Test]
        public void SetMemoryInterface_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<FormatException>(() => graphicsCard.MemoryInterface = int.Parse("invalid"));
        }

        [Test]
        public void SetClockSpeed_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745, 700);

            // Act & Assert
            Assert.Throws<FormatException>(() => graphicsCard.ClockSpeed = double.Parse("invalid"));
        }

        [Test]
        public void SetMinimumWattage_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var graphicsCard = new GraphicsCard(Guid.Parse("b2b4e251-ac26-4af3-9c60-b1887195206f"), "MSI Gaming RTX 4070", 579, 17, 5, "MSI", 12, 192, "GDDR6", 2.745 , 700);

            // Act & Assert
            Assert.Throws<FormatException>(() => graphicsCard.MinimumWattage = int.Parse("invalid"));
        }
    }
}
