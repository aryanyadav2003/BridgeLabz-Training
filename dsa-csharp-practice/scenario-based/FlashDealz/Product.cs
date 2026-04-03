using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.FlashDealz
{
    internal class Product
    {
        public string Name;
        public int Discount;
        public Product(string name, int discount)
        {
            Name = name;
            Discount = discount;
        }
    }
}
