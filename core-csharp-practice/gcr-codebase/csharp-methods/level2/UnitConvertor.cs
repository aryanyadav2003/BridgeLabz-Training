using System;
class UnitConvertor{
   static double KmToMiles(double km){
     return km*0.621371;
   }
   static double MilesToKm(double miles){
     return miles*1.60934;
   }
   static double MtrToFeet(double meter){
     return meter*3.28084;
   }
   static double FeetToMeter(double feet){
     return feet*0.3048;
   }
   static void Main(){
     Console.Write("Enter distance in kilometer :");
	 double n=double.Parse(Console.ReadLine());
	 //Console.WriteLine();
	 Console.WriteLine("Distance in miles :" + KmToMiles(n));
	 
	 Console.Write("Enter distance in miles :");
	 double m=double.Parse(Console.ReadLine());
	// Console.WriteLine();
	 Console.WriteLine("Distance in Kilometer :" + MilesToKm(m));
	 
	 Console.Write("Enter height in meter :");
	 double a=double.Parse(Console.ReadLine());
	 //Console.WriteLine();
	 Console.WriteLine("Height in feet :" + MtrToFeet(a));
	 
	 Console.Write("Enter height in feet :");
	 double b=double.Parse(Console.ReadLine());
	 //Console.WriteLine();
	 Console.WriteLine("Height in meter :" + FeetToMeter(b));
   }
}