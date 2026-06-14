using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmailValidator;
namespace EmailValidator.Tests
{
    [TestFixture]
    public class EmailValidatorTests
    {
        [Test]
        public void IsValid_ValidEmail_ReturnsTrue()
        {
            var validator = new Validator();//arrange
            bool result =validator.IsValid("test@example.com");//Act
            Assert.That(result, Is.True);//Assert
        }
    }
}
