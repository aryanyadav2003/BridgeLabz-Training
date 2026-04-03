using System;
class LargestNumber{
  static void Main(){
    int n1=Convert.ToInt32(Console.ReadLine());
	int n2=Convert.ToInt32(Console.ReadLine());
	int n3=Convert.ToInt32(Console.ReadLine());
	if(n1>n2 && n1>n3){
	Console.WriteLine($"{n1} is greatest");
	}
	if(n2>n1 && n2>n3){
	Console.WriteLine($"{n2} is greatest");
	}
	if(n3>n1 && n3>n2){
	Console.WriteLine($"{n3} is greatest");
	}
  }
}