using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace nunit.tests
{
    internal class UnitTestNumUtils
    {
        private NumUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new NumUtils();
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_TestMultipleValues(int number, bool expected)
        {
            bool result = utils.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }
}
