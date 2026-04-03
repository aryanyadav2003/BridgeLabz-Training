using System;
class FactorProblem{
  static int[] factors(int n){
     int cnt=0;
	 for(int i=1;i<=n;i++){
	  if(n%i==0){
	   cnt++;
	  }
	 }
	 int[] fact=new int[cnt];
	 int idx=0;
	 for(int i=1;i<=n;i++){
	  if(n%i==0){
	    fact[idx++];
	  }
	 }
	 return fact;
  }
  static int sum(int[] factors){
   int sum=0;
   for(int i=0;i<factors.Length;i++){
     sum+=factors[i];
   }
   return sum;
  }
  static long sumOfSquares(int[] factors){
    long sum=0;
	for(int i=0;i<factors.Length;i++){
	  sum+=Math.Pow(factors[i],2);
	}
	return sum;
  }
  static long productFactors(int[] factors){
    product=1;
	for(int i=0;i<factors.Length;i++){
	  product*=factors[i];
	}
	return product;
  }
  static void Main(){
   int n=int.Parse(Console.ReadLine());
   int[] fact=factors(n);
   Console.Write("Factors are : ")
   foreach(int f in fact){
     Console.Write(f+" ");
   }
   Console.WriteLine();
   Console.WriteLine(sum(fact));
   Console.WriteLine(sumOfSquares(fact));
   Console.WriteLine(productFactors(fact));
  }
}