using System;
class SmallestOfThree{
   static void Main(){
    Console.WriteLine("Enter first number: ");   
    int n1=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter second number: ");
	int n2=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter third number: ");
	int n3=Convert.ToInt32(Console.ReadLine());
	if(n1<n2 && n1<n3){ 
	 Console.WriteLine("First number is the smallest of three numbers");
	}
   }
}