using System;
class SumUntilZero2{ 
  static void Main(){
   double total=0.0;
   //double number=Convert.ToDouble(Console.ReadLine());
   while(true){
    
	double number=Convert.ToDouble(Console.ReadLine());
	if(number<=0){
	  break;
  }
  total+=number;
  }
  Console.WriteLine($"The total sum is {total}");
}}