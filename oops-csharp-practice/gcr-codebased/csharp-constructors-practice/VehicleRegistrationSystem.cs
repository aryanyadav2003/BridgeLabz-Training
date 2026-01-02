using System;
class Vehicle{
    public static double RegistrationFee = 1500.0;
    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string RegistrationNumber, string OwnerName, string VehicleType)
    {
        this.RegistrationNumber = RegistrationNumber;  
        this.OwnerName = OwnerName;                     
        this.VehicleType = VehicleType;
    }
    public static void UpdateRegistrationFee(double newFee){
        if (newFee > 0){
            RegistrationFee = newFee;
        }
        else{
            Console.WriteLine("Invalid registration fee");
        }
    }
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Fee: ₹" + RegistrationFee);
    }
}

class VehicleRegistrationSystem{
    static void Main(){
        Vehicle v1 = new Vehicle("AS06AB1234", "Aryan", "Car");
        Vehicle v2 = new Vehicle("AS06CD5678", "Rohit", "Bike");

        Vehicle.UpdateRegistrationFee(1800);
        if (v1 is Vehicle){
            Console.WriteLine("Vehicle 1 Details:");
            v1.DisplayVehicleDetails();
        }
        if (v2 is Vehicle){
            Console.WriteLine("Vehicle 2 Details:");
            v2.DisplayVehicleDetails();
        }
    }
}
