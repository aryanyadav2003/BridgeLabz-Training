using System;
class Swap{
    static void Main(){
	  int num1=Convert.ToInt32(Console.ReadLine());
	  int num2=Convert.ToInt32(Console.ReadLine());
	  int a=num1;
	  num1=num2;
	  num2=a;
	  Console.WriteLine("The swapped numbers are " + num1 + " and " +num2);
	} 
}