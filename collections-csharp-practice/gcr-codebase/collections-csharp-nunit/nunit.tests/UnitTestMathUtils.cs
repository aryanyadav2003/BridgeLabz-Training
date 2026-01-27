using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit.tests
{
    internal class UnitTestMathUtils
    {
        private MathUtils math;

        [SetUp]
        public void Setup()
        {
            math = new MathUtils();
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
        }

        [Test]
        public void Divide_ValidNumbers_ReturnsResult()
        {
            Assert.AreEqual(5, math.Divide(10, 2));
        }
    }
}
