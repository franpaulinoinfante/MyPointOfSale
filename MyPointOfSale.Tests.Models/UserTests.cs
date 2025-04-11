using MyPointOfSale.Models;
using NUnit.Framework;

namespace MyPointOfSale.Tests.Models
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void User_ShouldAssignPropertiesCorrectly()
        {
            // Arrange
            DocumentType documentType = new DocumentType { DocumentID = 1, DocumentName = "Passport" };
            Position position = new Position { PositionId = 1, PositionName = "Manager" };

            // Act
            User user = new User
            {
                UserId = 1,
                Username = "johndoe",
                Password = "securepassword",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                DocumentType = documentType,
                DocumentNumber = "123456",
                Position = position
            };

            // Assert
            Assert.That(user.UserId, Is.EqualTo(1));
            Assert.That(user.Username, Is.EqualTo("johndoe"));
            Assert.That(user.Password, Is.EqualTo("securepassword"));
            Assert.That(user.FirstName, Is.EqualTo("John"));
            Assert.That(user.LastName, Is.EqualTo("Doe"));
            Assert.That(user.Email, Is.EqualTo("john.doe@example.com"));
            Assert.That(user.DocumentType, Is.EqualTo(documentType));
            Assert.That(user.DocumentNumber, Is.EqualTo("123456"));
            Assert.That(user.Position, Is.EqualTo(position));
        }

        [Test]
        public void User_ShouldHandleNullValues()
        {
            // Act
            User user = new User
            {
                UserId = 0,
                Username = null,
                Password = null,
                FirstName = null,
                LastName = null,
                Email = null,
                DocumentType = null,
                DocumentNumber = null,
                Position = null
            };

            // Assert
            Assert.That(user.UserId, Is.EqualTo(0));
            Assert.That(user.Username, Is.Null);
            Assert.That(user.Password, Is.Null);
            Assert.That(user.FirstName, Is.Null);
            Assert.That(user.LastName, Is.Null);
            Assert.That(user.Email, Is.Null);
            Assert.That(user.DocumentType, Is.Null);
            Assert.That(user.DocumentNumber, Is.Null);
            Assert.That(user.Position, Is.Null);
        }
    }
}
