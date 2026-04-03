using System;
class Quadratic{
  static double[] FindRoots(double a,double b,double c){
    if(a==0) return new double[0];
	double delta=Math.Pow(b,2)-4*a*c;
	if(delta>0){
	  double root1=(-b+Math.Sqrt(delta))/(2*a);
	  double root2=(-b-Math.Sqrt(delta))/(2*a);
	  return new double[]{root1,root2};
	}
	else if(delta==0){
	 double root=-b/(2*a);
	 return new double[]{root};
	}
	else{
	  return new double[0];
	}
  }
  static void Main(){
    double a=double.Parse(Console.ReadLine());
	double b=double.Parse(Console.ReadLine());
	double c=double.Parse(Console.ReadLine());
	double[] roots=FindRoots(a,b,c);
	if(roots.Length==2){
	  Console.WriteLine($"roots are {roots[0]} and {roots[1]}");
	}
	else if(roots.Length==1){
	  Console.WriteLine($"One root : {roots[0]}");
	}
	else{
	 Console.WriteLine("no real roots exists");
	}
  }
}