using class_library;

namespace nunit.tests
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.AreEqual(10, calculator.Add(5, 5));
        }
        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.AreEqual(3, calculator.Subtract(8, 5));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.AreEqual(20, calculator.Multiply(4, 5));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.AreEqual(5, calculator.Divide(10, 2));
        }

        // BONUS: Exception test
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}