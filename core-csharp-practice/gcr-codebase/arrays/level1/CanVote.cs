using System;
class CanVote{
  static void Main(){
   // int n=int.Parse(Console.ReadLine());
	int[] arr=new int[10];
	for(int i=0;i<10;i++){
	 arr[i]=int.Parse(Console.ReadLine());
	}
	for(int i=0;i<arr.Length;i++){
	  if(arr[i]<0){
	   Console.WriteLine("Enter Valid Age");
	  }
	  else if(arr[i]<=18){
       Console.WriteLine("not eligible for vote");
	  }
	  else{
	    Console.WriteLine("eligible for vote");
	  }
	}
  }
}