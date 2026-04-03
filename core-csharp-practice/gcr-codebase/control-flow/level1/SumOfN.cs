using System;
class SumOfN{
  static void Main(){
   int n=Convert.ToInt32(Console.ReadLine());
   int sum=0;
   for(int i=n;i>=1;i--){ 
     sum+=i;
   }
   Console.WriteLine(sum);
  }
}