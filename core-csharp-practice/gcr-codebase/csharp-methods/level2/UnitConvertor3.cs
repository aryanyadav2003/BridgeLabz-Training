using System;
class UnitConvertor3{
   static double FahrenheitToCelcius(double f){
     return (f-32)*5/9;
   }
   static double CelciusToFahrenheit(double c){
     return (c*9/5)+32;
   }
   static double PoundsToKg(double p){
     return p*0.453592;
   }
   static double KgToPounds(double kg){
     return kg*2.20462;
   }
   static double GallonsToLiters(double g){
     return g*3.78541;
   }
   static double LitersToGallons(double l){
     return l*0.264172;
   }
   
   static void Main(){
     Console.Write("Enter value in fahrenheit :");
	 double n=double.Parse(Console.ReadLine());
	 Console.WriteLine("Value in celcius :" + FahrenheitToCelcius(n));
	 
	 Console.Write("Enter value in celcius :");
	 double m=double.Parse(Console.ReadLine());
	 Console.WriteLine("Value in fahrenheit :" + CelciusToFahrenheit(m));
	 
	 Console.Write("Enter value in pounds :");
	 double a=double.Parse(Console.ReadLine());
	 Console.WriteLine("value in kg :" + PoundsToKg(a));
	 
	 Console.Write("Enter value in kg :");
	 double b=double.Parse(Console.ReadLine());
	 Console.WriteLine("Value in pounds :" + KgToPounds(b));
	 
	 Console.Write("Enter value in gallons :");
	 double c=double.Parse(Console.ReadLine());
	 Console.WriteLine("value in liters :" + GallonsToLiters(c));
	 
	 Console.Write("Enter value in liters :");
	 double d=double.Parse(Console.ReadLine());
	 Console.WriteLine("value in gallons :" + LitersToGallons(d));
   }
}