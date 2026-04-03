using System;
class DivisibleByFive{
    static void Main(){
	 Console.WriteLine("Enter a number: ");
	 int n=Convert.ToInt32(Console.ReadLine());
	 if(n%5==0){
	  Console.WriteLine($"{n} is divisible by 5");
	 }
	 else{
	  Console.WriteLine($"{n} is not divisible by 5");
	 }
	}
}