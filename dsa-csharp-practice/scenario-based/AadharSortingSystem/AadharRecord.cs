using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.AadharSortingSystem
{
    internal class AadharRecord
    {
        public long AadharNumber;
        public string Name;
        public AadharRecord(long aadharNumber,string name)
        {
            AadharNumber = aadharNumber;
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine(AadharNumber + " " + Name);
        }
    }
}
