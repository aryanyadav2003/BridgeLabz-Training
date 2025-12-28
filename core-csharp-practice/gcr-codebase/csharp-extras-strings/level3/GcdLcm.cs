using System;
class GcdLcm{
  static int GCD(int a,int b){
   while(b!=0){
     int temp=b;
	 b=a%b;
	 a=temp;
   }
   return a;
  }
  static int LCM(int a,int b){
   return (a*b)/GCD(a,b);
  }
  static void Main(){
    int n1=int.Parse(Console.ReadLine());
	int n2=int.Parse(Console.ReadLine());
	int gcd=GCD(n1,n2);
	int lcm=LCM(n1,n2);
	Console.WriteLine("GCD = " + gcd);
    Console.WriteLine("LCM = " + lcm);
  }
}