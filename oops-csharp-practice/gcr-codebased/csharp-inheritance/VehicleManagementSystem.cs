using System;

interface Refuelable{
   void Refuel();
}
class Vehicle{
   public int MaxSpeed;
   public string model;
}
class ElectricVehicle : Vehicle{

   public string type;
   public int distancePerCharge;
   public void Charge(){
     Console.WriteLine("Vehicle is charging.");
   }
   public void DisplayDetails(){
     Console.WriteLine("Model : " + model);
	 Console.WriteLine("Vehicle type: " + type);
	 Console.WriteLine("Maximum speed: " + MaxSpeed);
	 Console.WriteLine("Distance per charge : " + distancePerCharge + " km");
   }
}
class PetrolVehicle : Vehicle , Refuelable{

   public string type;
   public int mileage;
   
   public void Refuel(){
     Console.WriteLine("The Vehicle is refueling");
   }
   public void DisplayDetails(){
     Console.WriteLine("Model : " + model);
	 Console.WriteLine("Vehicle type : " + type);
	 Console.WriteLine("Mileage : " + mileage + "km per litre");
   }
}
class VehicleManagementSystem{
   static void Main(){
     ElectricVehicle v1=new ElectricVehicle{model="Tata electric",type="SUV",MaxSpeed=210 ,distancePerCharge=80};
	 v1.Charge();
	 v1.DisplayDetails();
	 
	 PetrolVehicle v2=new PetrolVehicle{model="Mahindra XUV 700" ,type="SUV",MaxSpeed=210,mileage=10};
	 v2.Refuel();
	 v2.DisplayDetails();
	 
   }
}