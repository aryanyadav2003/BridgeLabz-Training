using System;
interface IRentable{
    double CalculateRent(int days);
}
abstract class Vehicle{
   protected string vehicleNumber;
   protected string brand;
   protected int rentPerDay;
   public void SetVehicleDetails(string number, string brandName, int rent)
    {
        vehicleNumber = number;
        brand = brandName;
        rentPerDay = rent;
    }
   public virtual void DisplayDetails(){
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Rent Per Day: " + rentPerDay);
    }
}
class Bike : Vehicle, IRentable
{
    public double CalculateRent(int days)
    {
        return rentPerDay*days;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine("Vehicle type : Bike");
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Rent Per Day: " + rentPerDay);
    }
}
class Car : Vehicle, IRentable
{
    public double CalculateRent(int days)
    {
        return rentPerDay * days + 500;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Vehicle Type: Car");
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Rent Per Day: " + rentPerDay);
    }
}
class Truck : Vehicle, IRentable
{
    public double CalculateRent(int days)
    {
        return rentPerDay*days+1000;
    }
    public override void DisplayDetails()
    {
        Console.WriteLine("Vehicle type : Truck");
        Console.WriteLine("Vehicle Number : " + vehicleNumber);
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Rent per day: " + rentPerDay);
    }
}
class Customer
{
    public string name;
    public void RentVehicle(Vehicle v,IRentable r,int days)
    {
        Console.WriteLine("Customer Name: " + name);
        v.DisplayDetails();
        Console.WriteLine("Total rent for " + days + "days:" + r.CalculateRent(days));
    }
}
class VehicleRentalApplication
{
    static void Main()
    {
        Customer c=new Customer();
        c.name = "Aryan";

        Bike b = new Bike();
        b.SetVehicleDetails("AS060001", "BMW", 300);

        Car car=new Car();
        car.SetVehicleDetails("AS060002", "Fortuner", 10000);

        Truck t = new Truck();
        t.SetVehicleDetails("AS060003", "Tata", 1500);

        c.RentVehicle(b,b,3);
        Console.WriteLine();
        c.RentVehicle(car,car,2);
        Console.WriteLine();
        c.RentVehicle(t,t,1);
    }
}

