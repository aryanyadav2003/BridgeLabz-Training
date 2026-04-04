using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit.tests
{
    internal class UnitTestPassWordValidator
    {
        private PassWordValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new PassWordValidator();
        }

        [TestCase("Password1", true)]
        [TestCase("StrongPass9", true)]
        [TestCase("password1", false)]   
        [TestCase("Password", false)]    
        [TestCase("Pass1", false)]       
        [TestCase("", false)]          
        public void PasswordValidation_TestCases(string password, bool expected)
        {
            bool result = validator.IsValid(password);
            Assert.AreEqual(expected, result);
        }
    }
}
