using System;
class SpringSeason{
  static void Main(){
    Console.WriteLine("enter month :");
	int month=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("enter day :");
	int day=Convert.ToInt32(Console.ReadLine());
	if( (month==3 && day>=20) || month==4 || month==5 || (month==6 && day<=20)){
	 Console.WriteLine("Spring Season");
	}
	else{
	 Console.WriteLine("Not a spring season");
	}
  }
}