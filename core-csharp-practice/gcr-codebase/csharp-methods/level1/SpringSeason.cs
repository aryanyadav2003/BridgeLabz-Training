using System;
class SpringSeason{
   static void CheckSpring(int month,int day){
	if((month==3 && day>=20) || month==4 || month==5 || (month==6 && day<=20)){
	 Console.WriteLine("Spring Season");
	}
	else{
	 Console.WriteLine("Not a spring season");
	}
  }
  static void Main(){
    Console.Write("enter month :");
	int month=Convert.ToInt32(Console.ReadLine());
	Console.Write("enter day :");
	int day=Convert.ToInt32(Console.ReadLine());
	CheckSpring(month,day);
  }
}