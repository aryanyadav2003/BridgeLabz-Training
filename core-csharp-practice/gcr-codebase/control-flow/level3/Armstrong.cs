using System;
class Armstrong{
  static void Main(){
   int n=Convert.ToInt32(Console.ReadLine());
   int temp=n;
   int sum=0;
   while(temp>0){
     int digit=temp%10;
	 sum+=(digit*digit*digit);
	 temp=temp/10;
   }
   if(sum==n){
   Console.WriteLine("Armstrong Number");
   }
   else{
   Console.WriteLine("Not an Armstrong Number");
   }
  }
}