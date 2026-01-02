using System;
class Vehicle{
    public string OwnerName;
    public string VehicleType;

    public static double RegistrationFee = 5000;
	
    public Vehicle(string ownerName, string vehicleType){
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails(){
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
    }
	
    public static void UpdateRegistrationFee(double newFee){
        RegistrationFee = newFee;
    }
}
class VehicleRegistrationProgram{
    static void Main(){
        Vehicle v1 = new Vehicle("Aryan", "Car");
        Vehicle v2 = new Vehicle("Rahul", "Bike");

        Console.WriteLine("Vehicle 1 Details:");
        v1.DisplayVehicleDetails();

        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Details:");
        v2.DisplayVehicleDetails();

        Console.WriteLine();

    
        Vehicle.UpdateRegistrationFee(6500);

        v1.DisplayVehicleDetails();
        Console.WriteLine();
        v2.DisplayVehicleDetails();
    }
}
