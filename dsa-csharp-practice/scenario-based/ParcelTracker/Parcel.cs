using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.ParcelTracker
{
    internal class Parcel
    {
        public int ParcelId;
        public string ProductName;
        public DeliveryChain Chain;
        public Parcel(int parcelId,string productName)
        {
            ParcelId = parcelId;
            ProductName = productName;
            Chain = new DeliveryChain();
        }
        public void Display()
        {
            Console.WriteLine("Parcel Id : " + ParcelId + " Product Name : " + ProductName);
            Chain.TrackParcel();
        }
    }
}
