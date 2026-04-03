 using System;
 class FootballTeam{
   public static int[] generateRandom(int size){
     int[] numbers=new int[size];
	 Random r=new Random();
	 for(int i=0;i<size;i++){
	   numbers[i]=r.Next(150,250);
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
	  double mean=(double)sum/numbers.Length;
	  return new double[]{mean,min,max};
   }
   static void Main(){
     int size=11;
	 int[] randomNo=generateRandom(11);
	 foreach(int i in randomNo){
	   Console.Write(i+" ");
	 }
	 Console.WriteLine();
	 double[] ans=Helper(randomNo);
	 Console.Write($"shortest :{ans[1]} tallest :{ans[2]} mean :{ans[0]}");
   }
   
 }