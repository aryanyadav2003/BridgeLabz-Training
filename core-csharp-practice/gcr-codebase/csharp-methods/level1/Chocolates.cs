using System;
class Chocolates{
   static int[] FindRemainderAndQuotient(int number, int divisor){
     int quotient=number/divisor;
	 int remainder=number%divisor;
	 return new int[]{quotient,remainder};
   }
   static void Main(){
     int number=int.Parse(Console.ReadLine());
	 int divisor=int.Parse(Console.ReadLine());
	 int[] ans=FindRemainderAndQuotient(number,divisor);
	 Console.WriteLine("Number of chocolates each student gets :" +ans[0]);
	 Console.WriteLine("Remaining chocolates :" +ans[1]);
   }
}