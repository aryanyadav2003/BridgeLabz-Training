using System;
class Reverse{
   static void Main(){
     int n=int.Parse(Console.ReadLine());
	 int temp=n;
	 int cnt=0;
	 while(temp!=0){
	  cnt++;
	  temp=temp/10;
	 }
	 int[] digits=new int[cnt];
	 temp=n;
	 for(int i=0;i<cnt;i++){
	  digits[i]=temp%10;
	  temp=temp/10;
	 }
	// int[] reverse=new int[cnt];
	 //for(int i=0;i<cnt;i++){
	   //reverse[i]=digits[cnt-i-1];
	 //}
	 for(int i=0;i<cnt;i++){
	  Console.Write(digits[i]);
	 }
   }
}