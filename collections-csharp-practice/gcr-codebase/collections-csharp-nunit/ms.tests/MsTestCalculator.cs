using class_library;

namespace ms.tests
{
    [TestClass]
    public sealed class Test1
    {
        private Calculator calculator;
        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.AreEqual(10, calculator.Add(5, 5));
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.AreEqual(3, calculator.Subtract(8, 5));
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.AreEqual(20, calculator.Multiply(4, 5));
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
        }

        // BONUS: Exception test
        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
