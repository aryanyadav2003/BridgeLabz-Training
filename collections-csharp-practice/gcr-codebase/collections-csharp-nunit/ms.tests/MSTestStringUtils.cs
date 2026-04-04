using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace ms.tests
{
    internal class MSTestStringUtils
    {
        private StringUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [TestMethod]
        public void Reverse_ValidString_ReturnsReversed()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        [TestMethod]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            Assert.IsTrue(utils.IsPalindrome("madam"));
        }

        [TestMethod]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        [TestMethod]
        public void ToUpperCase_ValidString_ReturnsUppercase()
        {
            Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
        }
    }
}
