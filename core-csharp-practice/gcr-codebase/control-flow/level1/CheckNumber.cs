using System;
class CheckNumber{
  static void Main(){
   Console.WriteLine("Enter a number:");
   int n=Convert.ToInt32(Console.ReadLine());
   if(n>0){
     Console.WriteLine("positive");
   }
   else if(n==0){
     Console.WriteLine("zero");
   }
   else{
     Console.WriteLine("negative");
   }
  }
}