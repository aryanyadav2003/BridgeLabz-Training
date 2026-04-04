using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace ms.tests
{
    internal class MSTestTemperatureConverter
    {
        private TemperatureConverter converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [DataTestMethod]
        [DataRow(0, 32)]
        [DataRow(100, 212)]
        [DataRow(-40, -40)]
        public void CelsiusToFahrenheit_ValidValues(double celsius, double expected)
        {
            double result = converter.CelsiusToFahrenheit(celsius);
            Assert.AreEqual(expected, result, 0.01);
        }

        [DataTestMethod]
        [DataRow(32, 0)]
        [DataRow(212, 100)]
        [DataRow(-40, -40)]
        public void FahrenheitToCelsius_ValidValues(double fahrenheit, double expected)
        {
            double result = converter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
