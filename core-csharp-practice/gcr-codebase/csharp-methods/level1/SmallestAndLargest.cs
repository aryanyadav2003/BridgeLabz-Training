using System;
class SmallestAndLargest{
   static int[] FindSmallestAndLargest(int n1,int n2,int n3){
     int largest=n1;
	 int smallest=n1;
	 if(n2<smallest){
	   smallest=n2;
	 }
	 if(n3<smallest){
	   smallest=n3;
	 }
	 if(n2>largest){
	   largest=n2;
	 }
	 if(n3>largest){
	   largest=n3;
	 }
	 return new int[]{smallest,largest};
   }
   static void Main(){
     int n1=int.Parse(Console.ReadLine());
	 int n2=int.Parse(Console.ReadLine());
	 int n3=int.Parse(Console.ReadLine());
	 int[] ans=FindSmallestAndLargest(n1,n2,n3);
	 Console.WriteLine("Smallest:" +ans[0]);
	 Console.Write("Largest:" +ans[1]); 
   }
}