using System;
class ArraySum{
  static void Main(){
     double[] arr=new double[10];
	 double total=0.0;
	 int idx=0;
	 while(true){
	  double input=Convert.ToDouble(Console.ReadLine());
	  if(input<=0){
	   break;
	  }
	  if(idx==10){
	   break;
	  }
	  arr[idx]=input;
	  idx++;
	 }
	 for(int i=0;i<arr.Length;i++){
	   total+=arr[i];
	 }
	 Console.WriteLine(total);
	 }
}