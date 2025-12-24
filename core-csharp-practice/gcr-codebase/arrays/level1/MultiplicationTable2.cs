using System;
class MultiplicationTable2{
  static void Main(){
     int n=Convert.ToInt32(Console.ReadLine());
	 int[] arr=new int[4];
	 for(int i=6;i<=9;i++){
	   arr[i-6]=n*i;
	 }
	 for(int i=6;i<=9;i++){
	 Console.WriteLine($"{n}*{i}=" + arr[i-6]);
	 }
  }
}