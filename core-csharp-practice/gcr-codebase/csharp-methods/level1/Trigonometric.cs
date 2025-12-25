using System;
class Trigonometric{
    static double[] CalculateT(double angle){
      double radians=angle*Math.PI/180;
	  double sin=Math.Sin(radians);
	  double cos=Math.Cos(radians);
	  double tan=Math.Tan(radians);
	  return new double[]{sin,cos,tan};
   }
   static void Main(){
     double angle=double.Parse(Console.ReadLine());
	 double[] ans=CalculateT(angle);
	 Console.Write($"sin :{ans[0]} cos :{ans[1]} tan:{ans[2]}");
   }
}