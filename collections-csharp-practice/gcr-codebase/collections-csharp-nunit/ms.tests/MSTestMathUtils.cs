using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.tests
{
    internal class MSTestMathUtils
    {
        private MathUtils math;

        [TestInitialize]
        public void Setup()
        {
            math = new MathUtils();
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
        }

        [TestMethod]
        public void Divide_ValidNumbers_ReturnsResult()
        {
            Assert.AreEqual(5, math.Divide(10, 2));
        }
    }
}
