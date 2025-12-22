using System;
class Counter{
  static void Main(){
  Console.WriteLine("Enter a number: ");
  int n=Convert.ToInt32(Console.ReadLine());
  while(n>=1){
    Console.WriteLine(n);
	n--;
  }
  Console.WriteLine("Rocket Launched!!!");
  }
}