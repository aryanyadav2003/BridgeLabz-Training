using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace nunit.tests
{
    internal class UnitTestStringUtils
    {
        private StringUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [Test]
        public void Reverse_ValidString_ReturnsReversed()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            Assert.IsTrue(utils.IsPalindrome("madam"));
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        [Test]
        public void ToUpperCase_ValidString_ReturnsUppercase()
        {
            Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
        }
    }
}
