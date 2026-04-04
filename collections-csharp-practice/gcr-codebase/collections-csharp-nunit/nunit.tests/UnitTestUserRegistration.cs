using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace nunit.tests
{
    internal class UnitTestUserRegistration
    {
        private UserRegistration registration;

        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInput_ReturnsTrue()
        {
            bool result = registration.RegisterUser("aryan123","aryan@example.com","Password1");

            Assert.IsTrue(result);
        }

        [Test]
        public void RegisterUser_InvalidUsername_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser("", "test@example.com", "Password1")
            );
        }

        [Test]
        public void RegisterUser_InvalidEmail_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser("user1", "invalidemail", "Password1")
            );
        }

        [Test]
        public void RegisterUser_InvalidPassword_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser("user1", "test@example.com", "pass")
            );
        }
    }
}
