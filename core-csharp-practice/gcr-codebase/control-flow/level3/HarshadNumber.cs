using System;
class HarshadNumber{
   static void Main(){
     int n=Convert.ToInt32(Console.ReadLine());
	 int sum=0;
	 int temp=n;
	 while(temp>0){
	  int digit=temp%10;
	  sum+=digit;
	  temp=temp/10;
	 }
	 if(n%sum==0){
	   Console.WriteLine("Harshad Number");
	 }
	 else{
	 Console.WriteLine("Not a Harshad Number");
	 }
   }
}