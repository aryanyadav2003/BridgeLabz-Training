using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.AmbulanceRoute
{
    internal class Unit
    {
        public string Name;
        public bool IsAvailable;
        public Unit Next;
        public Unit(String name)
        {
            Name = name;
            IsAvailable = true;
            Next = null;
        }
    }
}
