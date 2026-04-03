using System;
class RandomNumber{
  public static int[] GenerateRandom(int size){
    int[] numbers=new int[size];
	Random r=new Random();
	for(int i=0;i<size;i++){
	  numbers[i]=r.Next(1000,10000);
	}
	return numbers;
  }
  public static double[] Helper(int[] numbers){
    int min=numbers[0];
	int max=numbers[0];
	int sum=0;
	for(int i=0;i<numbers.Length;i++){
	 sum+=numbers[i];
	 min=Math.Min(min,numbers[i]);
	 max=Math.Max(max,numbers[i]);
	}
	double average=(double)sum/numbers.Length;
	return new double[]{average,min,max};
  }
  static void Main(){
    int size=5;
	int[] randomNo=GenerateRandom(size);
	foreach(int i in randomNo){
	 Console.Write(i+" ");
	}
	Console.WriteLine();
	double[] ans=Helper(randomNo);
	Console.WriteLine($"Average value : {ans[0]} Minimum value :{ans[1]} Maximum value :{ans[2]}");
  }
}