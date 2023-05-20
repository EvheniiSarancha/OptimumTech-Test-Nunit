using NUnit.Framework;
using Optimum_Tech.Controls.Managers;
using Optimum_Tech.Model;
using Optimum_Tech.Models;

namespace Test_OptimumTech.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Login_Set_ValidValue_ShouldSetLogin()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act
            user.Login = "newlogin";

            // Assert
            Assert.AreEqual("newlogin", user.Login);
        }

        [Test]
        public void Login_Set_LongValue_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => user.Login = "thisloginisverylongandexceedsthemaximumallowedlength");
        }

        [Test]
        public void Login_Set_ShortValue_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => user.Login = "bob");
        }

        [Test]
        public void Password_Set_ValidValue_ShouldSetPassword()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act
            user.Password = "newpassword";

            // Assert
            Assert.AreEqual("newpassword", user.Password);
        }

        [Test]
        public void Password_Set_LongValue_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => user.Password = "thispasswordisverylongandexceedsthemaximumallowedlength");
        }

        [Test]
        public void Password_Set_ShortValue_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => user.Password = "bob");
        }

        [Test]
        public void Login_Set_NullValue_ShouldThrowArgumentNullException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => user.Login = null);
        }

        [Test]
        public void Password_Set_NullValue_ShouldThrowArgumentNullException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => user.Password = null);
        }

        [Test]
        public void Login_Set_EmptyValue_ShouldThrowArgumentException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => user.Login = string.Empty);
        }

        [Test]
        public void Password_Set_EmptyValue_ShouldThrowArgumentException()
        {
            // Arrange
            string login = "testuser";
            string password = "password";
            var user = new User(login, password);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => user.Password = string.Empty);
        }

        [Test]
        public void SetUsername_ValidInput_UsernameSet()
        {
            // Arrange
            Order order = new Order("test@test.com", "123 Main St", "+1234567890", 100.00m, 2, DeliverType.AtTheAddress);

            // Act
            order.Username = "testuser";

            // Assert
            Assert.AreEqual("testuser", order.Username);
        }

        [Test]
        public void SetUsername_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            Order order = new Order("test@test.com", "123 Main St", "+1234567890", 100.00m, 2, DeliverType.AtTheAddress);

            // Act and assert
            Assert.Throws<ArgumentNullException>(() => order.Username = null);
        }

        [Test]
        public void SetUsername_EmptyInput_ThrowsArgumentNullException()
        {
            // Arrange
            Order order = new Order("test@test.com", "123 Main St", "+1234567890", 100.00m, 2, DeliverType.AtTheAddress);

            // Act and assert
            Assert.Throws<ArgumentNullException>(() => order.Username = string.Empty);
        }

        [Test]
        public void AccessProperty_DefaultValue_IsUser()
        {
            // Arrange
            var user = new User("testuser", "testpassword");

            // Assert
            Assert.AreEqual(Access.User, user.Access);
        }

        [Test]
        public void AccessProperty_CanSetAndGetAccess()
        {
            // Arrange
            var user = new User("testuser", "testpassword");

            // Act
            user.Access = Access.Admin;

            // Assert
            Assert.AreEqual(Access.Admin, user.Access);
        }

        [Test]
        public void Dispose_SetsDisposedToTrue()
        {
            // Arrange
            User user = new User("testuser", "password");

            // Act
            user.Dispose();

            // Assert
            Assert.IsTrue(user.disposed);
        }

        [Test]
        public void CompareTo_ReturnsZero_WhenLoginsAreEqual()
        {
            // Arrange
            User user1 = new User("testuser", "password");
            User user2 = new User("testuser", "password");

            // Act
            int result = user1.CompareTo(user2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GrantAccessUser_UpdatesAccessToUser()
        {
            // Arrange
            User user = new User("testuser", "password");
            UserManager.CurrentUser = user;

            // Act
            user.GrantAccessUser();

            // Assert
            Assert.AreEqual(Access.User, UserManager.CurrentUser.Access);
        }

        [Test]
        public void GrantAccessGuest_UpdatesAccessToGuest()
        {
            // Arrange
            User user = new User("testuser", "password");
            UserManager.CurrentUser = user;

            // Act
            user.GrantAccessGuest();

            // Assert
            Assert.AreEqual(Access.Guest, UserManager.CurrentUser.Access);
        }

        [Test]
        public void GrantAccessAdmin_UpdatesAccessToAdmin()
        {
            // Arrange
            User user = new User("testuser", "password");
            UserManager.CurrentUser = user;

            // Act
            user.GrantAccessAdmin();

            // Assert
            Assert.AreEqual(Access.Admin, UserManager.CurrentUser.Access);
        }
    }
}
