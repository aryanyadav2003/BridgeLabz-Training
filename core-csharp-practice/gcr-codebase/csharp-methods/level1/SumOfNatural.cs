using System;
class SumOfNatural{
  static int Sum(int n){
    int s=0;
    for(int i=n;i>=1;i--){
	  s+=i;
	}
	return s;
  }
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	Console.WriteLine(Sum(n));
  }
}