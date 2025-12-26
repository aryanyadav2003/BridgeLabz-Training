using System;
class MissingNumberInArray{
   static void Main(){
     int n=int.Parse(Console.ReadLine());
	 int[] arr=new int[n];
	 for(int i=0;i<n;i++){
	  arr[i]=int.Parse(Console.ReadLine());
	 }
	 int sumOfArray=0;
	 for(int i=0;i<n;i++){
	  sumOfArray+=arr[i];
	 }
	 int max=0;
	 for(int i=0;i<n;i++){
	   if(arr[i]>max){
	    max=arr[i];
	   }
	 }
	 int sum=(max*(max+1))/2;
	 int missingNo=sum-sumOfArray;
	 Console.WriteLine("missing number :" + missingNo);
   }
}