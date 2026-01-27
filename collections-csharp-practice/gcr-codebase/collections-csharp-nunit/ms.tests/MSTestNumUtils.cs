using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace ms.tests
{
    internal class MSTestNumUtils
    {
        private NumUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new NumUtils();
        }

        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void IsEven_TestMultipleValues(int number, bool expected)
        {
            bool result = utils.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }
}
