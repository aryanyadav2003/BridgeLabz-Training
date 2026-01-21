using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ProductDiscountSort.SmartCheckout
{
    internal class Items
    {
        public string Name;
        public int Price;
        public int Stock;
        public Items(string name,int price,int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
