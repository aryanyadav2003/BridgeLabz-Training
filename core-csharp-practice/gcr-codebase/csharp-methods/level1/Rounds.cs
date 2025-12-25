using System;
class Rounds{
   static int NumberOfRounds(int a,int b,int c){
    int p=a+b+c;
	return 5/p;	
   }
   static void Main(){
     Console.WriteLine("Enter first side :");
	 int a=int.Parse(Console.ReadLine());
	 Console.WriteLine("Enter first side :");
	 int b=int.Parse(Console.ReadLine());
	 Console.WriteLine("Enter first side :");
	 int c=int.Parse(Console.ReadLine());
	 int r=NumberOfRounds(a,b,c);
	 Console.WriteLine(c);
   }
}