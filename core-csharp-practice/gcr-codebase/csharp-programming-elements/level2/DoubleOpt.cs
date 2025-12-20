using System;
class DoubleOpt{
   static void Main(){
     int a=Convert.ToInt32(Console.ReadLine());
		double b=Convert.ToInt32(Console.ReadLine());
		double c=Convert.ToInt32(Console.ReadLine());
		double op1=a+b*c;
		double op2=a*b+c;
		double op3=c+a/b;
		Console.WriteLine("The result of three operations are " + op1 +","+ op2 +" and " + op3);
   }
}