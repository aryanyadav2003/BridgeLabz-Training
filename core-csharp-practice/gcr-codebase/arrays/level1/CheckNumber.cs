using System;
class CheckNumber{
  static void Main(){
    int[] arr=new int[5];
	for(int i=0;i<5;i++){
	  arr[i]=int.Parse(Console.ReadLine());
	}
	for(int i=0;i<5;i++){
	  if(arr[i]>0){
	     if(arr[i]%2==0){
		   Console.WriteLine("Even");
		 }
		 else{
		  Console.WriteLine("Odd");
		 }
	  }
	  else{
	    Console.WriteLine("negative number");
	  }
	}
  }
}