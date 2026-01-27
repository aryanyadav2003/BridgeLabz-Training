using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace nunit.tests
{
    internal class UnitTestTemperatureConverter
    {
        private TemperatureConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [TestCase(0, 32)]
        [TestCase(100, 212)]
        [TestCase(-40, -40)]
        public void CelsiusToFahrenheit_ValidValues(double celsius, double expected)
        {
            double result = converter.CelsiusToFahrenheit(celsius);
            Assert.AreEqual(expected, result, 0.01);
        }

        [TestCase(32, 0)]
        [TestCase(212, 100)]
        [TestCase(-40, -40)]
        public void FahrenheitToCelsius_ValidValues(double fahrenheit, double expected)
        {
            double result = converter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
