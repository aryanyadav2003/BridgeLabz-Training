using System;
class Factors{
  static void Main(){
     int n=Convert.ToInt32(Console.ReadLine());
	 int maxFactor=10;
	 int[] arr=new int[maxFactor];
	 int idx=0;
	 for(int i=1;i<=n;i++){
	   if(n%i==0){
	     if(idx==maxFactor){
		   maxFactor=2*maxFactor;
		   int[] temp=new int[maxFactor];
		   for(int j=0;j<arr.Length;j++){
		     temp[j]=arr[j];
		   }
		   arr=temp;
		 }
		 arr[idx]=i;
		 idx++;
	   }
	 }
	 for(int i=0;i<idx;i++){
	 Console.Write(arr[i] + " ");
	 }
   }
}