using System;
class DateArithmetic{
  static void Main(){
    Console.Write("Enter a date (yyyy-mm-dd)");
	DateTime inputDate=DateTime.Parse(Console.ReadLine());
	DateTime updateDate=inputDate.AddDays(7).AddMonths(1).AddYears(2);
	updateDate=updateDate.AddDays(-21);
	Console.WriteLine("\nOriginal Date : " + inputDate.ToShortDateString());
    Console.WriteLine("Final Date    : " + updateDate.ToShortDateString());
  }
}