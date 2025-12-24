using System;
class MeanHeight{
  static void Main(){
     double[] height=new double[11];
	 for(int i=0;i<11;i++){
	   height[i]=Convert.ToDouble(Console.ReadLine());
	   
	 }
	 double sum=0.0;
	 for(int i=0;i<11;i++){
	   sum+=height[i];
	 }
	 double mean=sum/11.0;
	 Console.WriteLine(mean);
  }
}