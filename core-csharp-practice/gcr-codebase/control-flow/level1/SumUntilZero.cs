using System;
class SumUntilZero{ 
  static void Main(){
   double total=0.0;
   double number=Convert.ToDouble(Console.ReadLine());
   while(number!=0){
    total+=number;
	number=Convert.ToDouble(Console.ReadLine());
  }
  Console.WriteLine($"The total sum is {total}");
}}