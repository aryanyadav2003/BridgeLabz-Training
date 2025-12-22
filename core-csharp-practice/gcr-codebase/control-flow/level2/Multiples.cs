using System;
class Multiples{
 static void Main(){
   int n=Convert.ToInt32(Console.ReadLine());
   for(int i=100;i>=1;i--){
     if(i%n==0){
	   Console.WriteLine(i);
	 }
   }
 }
}