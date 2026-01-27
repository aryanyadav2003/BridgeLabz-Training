using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace ms.tests
{
    internal class MSTestPassWordValidator
    {
        private PassWordValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new PassWordValidator();
        }

        [DataTestMethod]
        [DataRow("Password1", true)]
        [DataRow("StrongPass9", true)]
        [DataRow("password1", false)]
        [DataRow("Password", false)]
        [DataRow("Pass1", false)]
        [DataRow("", false)]
        public void PasswordValidation_TestCases(string password, bool expected)
        {
            bool result = validator.IsValid(password);
            Assert.AreEqual(expected, result);
        }
    }
}
