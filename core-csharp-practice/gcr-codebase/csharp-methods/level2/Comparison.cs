using System;
class Comparison{
  static int FindYoungest(int[] ages){
   int minidx=0;
   for(int i=1;i<ages.Length;i++){
    if(ages[i]<ages[minidx]){
	  minidx=i;
   }}
	return minidx;
  }
   static int FindTallest(double[] heights){
     int maxidx=0;
     for(int i=0;i<heights.Length;i++){
	  if(heights[i]>heights[maxidx]){
	    maxidx=i;
	  }
	 }
	 return maxidx;
  }
  static void Main(){
   string[] names={"Amar","Akbar","Anthony"};
   int[] ages=new int[3];
   double[] heights=new double[3];
   for(int i=0;i<3;i++){
    Console.Write($"Enter age of {names[i]}:");
	ages[i]=int.Parse(Console.ReadLine());
	Console.Write($"Enter height of {names[i]}:");
	heights[i]=double.Parse(Console.ReadLine());
   }
   int yidx=FindYoungest(ages);
   int tidx=FindTallest(heights);
   Console.WriteLine("Youngest friend is: " + names[yidx]);
   Console.WriteLine("Tallest friend is: " + names[tidx]);
  }
}