using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.tests
{
    internal class MSTestListManager
    {
        private ListManager manager;
        private List<int> numbers;

        [TestInitialize]
        public void Setup()
        {
            manager = new ListManager();
            numbers = new List<int>();
        }

        [TestMethod]
        public void AddElement_AddsItemToList()
        {
            manager.AddElement(numbers, 10);

            Assert.AreEqual(1, manager.GetSize(numbers));
            CollectionAssert.Contains(numbers, 10);
        }

        [TestMethod]
        public void RemoveElement_RemovesItemFromList()
        {
            numbers.Add(5);
            numbers.Add(10);

            manager.RemoveElement(numbers, 5);

            Assert.AreEqual(1, manager.GetSize(numbers));
            CollectionAssert.DoesNotContain(numbers, 5);
        }

        [TestMethod]
        public void GetSize_ReturnsCorrectSize()
        {
            manager.AddElement(numbers, 1);
            manager.AddElement(numbers, 2);
            manager.AddElement(numbers, 3);

            Assert.AreEqual(3, manager.GetSize(numbers));
        }
    }
}
