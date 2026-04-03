using System;
class LeapYear{
  static void Main(){
    int year=Convert.ToInt32(Console.ReadLine());
	Console.Write(IsLeap(year));
	}
  static bool IsLeap(int year){	
	if(year%400==0){
	 return true;
	}
	else if(year%100==0){
	 return false;
	}
	else if(year%4==0){
	 return true;
	}
	else{
	 return false;
	}
}}