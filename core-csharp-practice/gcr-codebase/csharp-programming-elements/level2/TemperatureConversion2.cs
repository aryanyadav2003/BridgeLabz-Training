using System;
class TemperatureConversion2{
	static void Main(){
    double fh=Convert.ToDouble(Console.ReadLine());
	double cel=(fh-32)*5/9;
	Console.WriteLine("The " + fh + " fahrenheit is " + cel + " Celsius");
}
}