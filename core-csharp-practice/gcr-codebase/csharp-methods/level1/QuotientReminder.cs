using System;
class QuotientReminder{
   static int[] FindRemainderAndQuotient(int number, int divisor){
     int quotient=number/divisor;
	 int remainder=number%divisor;
	 return new int[]{quotient,remainder};
   }
   static void Main(){
     int number=int.Parse(Console.ReadLine());
	 int divisor=int.Parse(Console.ReadLine());
	 int[] ans=FindRemainderAndQuotient(number,divisor);
	 Console.WriteLine("Quotient :" +ans[0]);
	 Console.WriteLine("Remainder :" +ans[1]);
   }
}