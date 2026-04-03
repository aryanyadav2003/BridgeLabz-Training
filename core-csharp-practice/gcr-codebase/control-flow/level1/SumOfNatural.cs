using System;
class SumOfNatural{
  static void Main(){
    Console.WriteLine("Enter a number: ");
    int n=Convert.ToInt32(Console.ReadLine());
	if(n>=0){
	  int sum=n*(n+1)/2;
	  Console.WriteLine($"Sum of {n} natural numbers is {sum}");
	}
	else{
	  Console.WriteLine($"The number {n} is not a natural numbers");
	}
  }
}