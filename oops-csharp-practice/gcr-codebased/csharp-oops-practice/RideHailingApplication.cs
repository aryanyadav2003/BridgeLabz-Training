using System;
interface IGPS
{
    void GetCurrentLocation();
    void UpdateLocation(string location);
}
abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;
    public int VehicleId
    {
        get{return vehicleId;}
        set {vehicleId=value;}
    }
     public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }
    public double RatePerKm
    {
        get{return ratePerKm;}
        set{ratePerKm=value;}
    }
    public abstract double CalculateFare(double distance);
    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID : " + vehicleId);
        Console.WriteLine("Driver Name : " + driverName);
        Console.WriteLine("Rate per Km : " + ratePerKm);
    }
}
class Car : Vehicle, IGPS
{
    private string location;
    public override double CalculateFare(double distance)
    {
        return distance*RatePerKm+50;
    }
    public void GetCurrentLocation()
    {
        Console.WriteLine("Car Location: " + location);
    }
    public void UpdateLocation(string location)
    {
        this.location=location;
    }
}
class Bike:Vehicle, IGPS
{
    private string location;
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
    public void GetCurrentLocation()
    {
        Console.WriteLine("Bike Location : " + location);
    }

    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}
class Auto : Vehicle, IGPS
{
    private string location;
    public override double CalculateFare(double distance)
    {
        return distance*RatePerKm+20;
    }
    public void GetCurrentLocation()
    {
        Console.WriteLine("Auto Location : " + location);
    }
    public void UpdateLocation(string location)
    {
        this.location = location;
    }
}
class RailHailingApp
{
    static void Main()
    {
         Vehicle v1 = new Car();
        v1.VehicleId = 101;
        v1.DriverName = "Rahul";
        v1.RatePerKm = 15;
        Vehicle v2 = new Bike();
        v2.VehicleId = 102;
        v2.DriverName = "Amit";
        v2.RatePerKm = 8;
        Vehicle v3 = new Auto();
        v3.VehicleId = 103;
        v3.DriverName = "Suresh";
        v3.RatePerKm = 10;

        DisplayRide(v1,10);
        Console.WriteLine();
        DisplayRide(v2,10);
        Console.WriteLine();
        DisplayRide(v3,10);
    }
    static void DisplayRide(Vehicle v,double distance)
    {
        v.GetVehicleDetails();
        Console.WriteLine("Distance : " + distance + " km");
        Console.WriteLine("Total Fare : " + v.CalculateFare(distance));
        Console.WriteLine();
    }
}