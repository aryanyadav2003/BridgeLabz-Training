namespace TrafficManager
{
    class Vehicle
    {
        public string VehicleNumber;
        public Vehicle Next;

        public Vehicle(string vehicleNumber)
        {
            VehicleNumber = vehicleNumber;
            Next = null;
        }
    }
}
