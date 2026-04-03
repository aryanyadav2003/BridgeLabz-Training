using System;
class TemperatureConversion{
    static void Main(){ 
	  double cel=Convert.ToDouble(Console.ReadLine());
	  double fh=(cel*9/5)+32;
	  Console.WriteLine("The" + cel + " Celsius is " + fh + " Fahrenheit");
	}
}