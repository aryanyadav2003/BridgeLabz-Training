using System;
class FibonacciGenerator{
  static void Fibonacci(int n){
    int a=0,b=1;
	if(n<=0){
	 Console.WriteLine("Please enter a positive number.");
	 return;
	}
	for(int i=0;i<=n;i++){
	  Console.Write(a+" ");
	  int next=a+b;
	  a=b;
	  b=next;
	}
  }
  static void Main(){
     int n=int.Parse(Console.ReadLine());
	 Fibonacci(n);
  }
}