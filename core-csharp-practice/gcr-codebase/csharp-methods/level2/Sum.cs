using System;
class Sum{
  static int RecursiveSum(int n){
    if(n==0) return 0;
	return n+RecursiveSum(n-1);
  }
  static int FormulaSum(int n){
   return n*(n+1)/2;
  }
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	int rsum=RecursiveSum(n);
	int fsum=FormulaSum(n);
	if(rsum==fsum){
	  Console.WriteLine("Both sum are equal");
	}
	else{
	  Console.WriteLine("not equal");
	}
  } 
}