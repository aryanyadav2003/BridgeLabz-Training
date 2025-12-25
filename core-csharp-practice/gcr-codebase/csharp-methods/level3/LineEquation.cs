using System;
class LineEquation{
   public static double FindDistance(double x1,double y1,double x2,double y2){
     return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
   }
   public static double[] FindLineEquation(double x1,double y1,double x2,double y2){
     double m=(y2-y1)/(x2-x1);
	 double b=y1-m*x1;
	 return new double[]{m,b};
   }
   static void Main(){
     double x1=double.Parse(Console.ReadLine());
	 double y1=double.Parse(Console.ReadLine());
	 double x2=double.Parse(Console.ReadLine());
	 double y2=double.Parse(Console.ReadLine());
	 double distance=FindDistance(x1,y1,x2,y2);
	 Console.WriteLine(distance);
	 double[] line=FindLineEquation(x1,y1,x2,y2);
	 Console.WriteLine($"Equation of line: y={line[0]}x+{line[1]}");
   }
}