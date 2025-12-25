using System;
class UnitConvertor2{
   static double yards2feet(double yards){
     return yards*3;
   }
   static double feet2yard(double feet){
     return feet*0.333333;
   }
   static double MtrToInches(double meter){
     return meter*39.3701;
   }
   static double InchesToMeter(double inches){
     return inches*0.0254;
   }
   static double InchesToCenitmeter(double inches){
     return inches*2.54;
   }
   
   static void Main(){
     Console.Write("Enter value in yards :");
	 double n=double.Parse(Console.ReadLine());
	 Console.WriteLine("Value in feet :" + yards2feet(n));
	 
	 Console.Write("Enter value in feet :");
	 double m=double.Parse(Console.ReadLine());
	 Console.WriteLine("Value in yard :" + feet2yard(m));
	 
	 Console.Write("Enter height in meter :");
	 double a=double.Parse(Console.ReadLine());
	 Console.WriteLine("Height in inches :" + MtrToInches(a));
	 
	 Console.Write("Enter height in inches :");
	 double b=double.Parse(Console.ReadLine());
	 Console.WriteLine("Height in meter :" + InchesToMeter(b));
	 
	 Console.Write("Enter height in inches :");
	 double c=double.Parse(Console.ReadLine());
	 Console.WriteLine("Height in centimeter :" + InchesToCenitmeter(c));
   }
}