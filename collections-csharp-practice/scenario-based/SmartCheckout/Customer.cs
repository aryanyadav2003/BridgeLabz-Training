using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.SmartCheckout
{
    internal class Customer
    {
        public string Name;
        public List<string> Items;
        public Customer(string name,List<string> items)
        {
            Name = name;
            Items = items;
        }
    }
}
