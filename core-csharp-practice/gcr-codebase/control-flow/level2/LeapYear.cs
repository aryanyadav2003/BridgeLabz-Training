using System;
class LeapYear{
  static void Main(){
    int year=Convert.ToInt32(Console.ReadLine());
	if(year%400==0){
	Console.WriteLine("Leap Year");
	}
	else if(year%100==0){
	Console.WriteLine("not a Leap Year");
	}
	else if(year%4==0){
	Console.WriteLine("Leap Year");
	}
	else{
	Console.WriteLine("not a Leap Year");
	}
  }
}