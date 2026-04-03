using System;
class Handshakes{
   static void Main(){
    int n=Convert.ToInt32(Console.ReadLine());
	int total=(n*(n-1))/2;
	Console.WriteLine(total);
   }
}