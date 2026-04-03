using System;
class Factorial{
   static long factorial(int n){
     if(n==0 || n==1){
	   return 1;
	 }
	 return n*factorial(n-1);
   }
   static void Main(){
     int n=int.Parse(Console.ReadLine());
	 long fact=factorial(n);
	 Console.WriteLine($"Factorial of {n} is {fact}");
   }
}