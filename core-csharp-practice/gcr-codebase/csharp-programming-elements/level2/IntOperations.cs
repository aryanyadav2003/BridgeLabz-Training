using System;
class IntOperations{
     static void Main(){
	    int a=Convert.ToInt32(Console.ReadLine());
		int b=Convert.ToInt32(Console.ReadLine());
		int c=Convert.ToInt32(Console.ReadLine());
		int op1=a+b*c;
		int op2=a*b+c;
		int op3=c+a/b;
		Console.WriteLine("The result of three operations are " + op1 +","+ op2 +" and " + op3);
	 }
}