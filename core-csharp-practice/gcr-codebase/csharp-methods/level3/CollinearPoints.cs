using System;
class CollinearPoints{
  public static bool BySlope(double x1,double y1,double x2,double y2,double x3,double y3){
    double slopeAB=(y2-y1)/(x2-x1);
	double slopeBC=(y3-y2)/(x3-x2);
	double slopeAC=(y3-y1)/(x3-x1);
	return slopeAB==slopeBC && slopeBC==slopeAC;
  }
  public static bool ByArea(double x1,double y1,double x2,double y2,double x3,double y3){
   double area=0.5*(x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2));
   return area==0;
  }
  static void Main(){
    double x1=2,y1=4,x2=4,y2=6,x3=6,y3=8;
	bool slopeResult=BySlope(x1,y1,x2,y2,x3,y3);
	bool areaResult=ByArea(x1,y1,x2,y2,x3,y3);
	Console.WriteLine("Using slope method:" +slopeResult);
	Console.WriteLine("Using area method:" +areaResult);
  }
}