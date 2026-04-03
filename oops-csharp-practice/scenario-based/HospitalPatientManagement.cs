using System;
interface IPayable{
  double CalculateBill();
}
abstract class Patient{
  public string patientId;
  public string name;
  public int age;
  
  public abstract void DisplayInfo();
}
class InPatient:Patient,IPayable{
  public int numberOfDays;
  public int dailyCharge;
  
  public override void DisplayInfo(){
    Console.WriteLine("Patient id : " + patientId);
	Console.WriteLine("Name : " + name);
	Console.WriteLine("Age : " + age);
	Console.WriteLine("Number Of days admitted :" + numberOfDays);
	Console.WriteLine("Total Bill : " + CalculateBill());
  }
  public double CalculateBill(){
    return numberOfDays*dailyCharge;
  }
}
class OutPatient:Patient,IPayable{
   public int consultationFee;
   
   public override void DisplayInfo(){
      Console.WriteLine("Patient id : " + patientId);
	  Console.WriteLine("Name : " + name);
	  Console.WriteLine("Age : " + age);
	  Console.WriteLine("Consultation fees : " + consultationFee);
	  Console.WriteLine("Total Bill : " + CalculateBill());
   }
   public double CalculateBill(){
     return consultationFee;
   }
}
class Doctor{
   public string name;
   public string specialization;
   
   public void DisplayDoctor(){
    Console.WriteLine("Name : " + name);
	Console.WriteLine("Specialization : " + specialization);
   }
}
class HospitalPatientManagement{
   static void Main(){
     Doctor d=new Doctor();
	 d.name="Mr Harsh";
	 d.specialization="ENT";
	 
	 InPatient p1=new InPatient();
	 p1.numberOfDays = 3;
	 p1.dailyCharge = 2000;
	 p1.patientId = "101";
	 p1.name = "Kartik";
	 p1.age = 20;
	 
	 
	 OutPatient p2=new OutPatient();
	 p2.consultationFee = 500;
	 p2.patientId = "102";
	 p2.name = "Rahul";
	 p2.age = 22;
	 
	 d.DisplayDoctor();
	 Console.WriteLine();
	 p1.DisplayInfo();
	 Console.WriteLine();
	 p2.DisplayInfo();
   }
}