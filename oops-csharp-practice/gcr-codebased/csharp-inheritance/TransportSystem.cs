using System;
class Vehicle{
  public int MaxSpeed;
  public string FuelType;
  public virtual void DisplayInfo(){
    Console.WriteLine("Maximum speed :" + MaxSpeed);
	Console.WriteLine("Fuel Type : " + FuelType);
  }
}
class Car:Vehicle{
  public int SeatCapacity;
  public override void DisplayInfo(){
    Console.WriteLine("Maximum speed :" + MaxSpeed);
	Console.WriteLine("Fuel Type : " + FuelType);
	Console.WriteLine("Seat Capacity :" + SeatCapacity);
  }
}
class Truck:Vehicle{
  public int PayloadCapacity;
  public override void DisplayInfo(){
    Console.WriteLine("Maximum speed :" + MaxSpeed);
	Console.WriteLine("Fuel Type : " + FuelType);
	Console.WriteLine("Payload Capacity :" + PayloadCapacity);
  }
}
class Motorcycle:Vehicle{
  public bool HasSideCar;
  public override void DisplayInfo(){
    Console.WriteLine("Maximum speed :" + MaxSpeed);
	Console.WriteLine("Fuel Type : " + FuelType);
	Console.WriteLine("Has Side Car :" + HasSideCar);
  }
}
class TransportSystem{
  static void Main(){
    Vehicle[] vehicles=new Vehicle[3];
	vehicles[0]=new Car{ MaxSpeed = 180,FuelType = "Petrol",SeatCapacity = 5};
	vehicles[1]=new Truck{MaxSpeed = 120,FuelType = "Diesel",PayloadCapacity = 5000};
	vehicles[2]=new Motorcycle{MaxSpeed = 130,FuelType = "Diesel",HasSideCar=false};
	for(int i=0;i<vehicles.Length;i++){
	  vehicles[i].DisplayInfo();
	  Console.WriteLine();
	}
  }
}