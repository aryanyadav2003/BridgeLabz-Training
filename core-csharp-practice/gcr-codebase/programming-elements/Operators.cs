using System;
class Operators{
  static void Main(){
    //Arithmetic Operator
     int a=15;
	 int b=10;
	 Console.WriteLine("Addition: " + (a + b)); 
     Console.WriteLine("Subtraction: " + (a - b)); 
     Console.WriteLine("Multiplication: " + (a * b));
     Console.WriteLine("Division: " + (a / b)); 
     Console.WriteLine("Modulus: " + (a % b)); 
	 
	 //Relational Operator
	 Console.WriteLine("a == b: " + (a == b)); 
     Console.WriteLine("a != b: " + (a != b)); 
     Console.WriteLine("a > b: " + (a > b)); 
     Console.WriteLine("a < b: " + (a < b)); 
     Console.WriteLine("a >= b: " + (a >= b)); 
     Console.WriteLine("a <= b: " + (a <= b));
	 
	 //Logical operator
	 bool x=true;
	 bool y=false;
	 Console.WriteLine("x && y: " + (x && y));
     Console.WriteLine("x || y: " + (x || y)); 
     Console.WriteLine("!x: " + (!x));
     Console.WriteLine("!y: " + (!y));
	 
	 //Assignment Operator
	 a += b;
	 Console.WriteLine("a += b: " + a);
	 a -= b;
	 Console.WriteLine("a -= b: " + a);
	 a *= b;
     Console.WriteLine("a *= b: " + a);
	 a /= b;
	 Console.WriteLine("a /= b: " + a);
	 a %= b;
	 Console.WriteLine("a %= b: " + a);
	 
	 //Unary operator
	 int u=10;
	 Console.WriteLine("a: " + a);
     Console.WriteLine("++a: " + ++a); 
     Console.WriteLine("a++: " + a++); 
     Console.WriteLine("a: " + a); 
     Console.WriteLine("--a: " + --a);
	 Console.WriteLine("a--:" + a--);
	 Console.WriteLine("a: " + a);
	 
	 //Bitwise Operator
	  int c=5;
	  int d=7;
	  Console.WriteLine("c&d:" + (c&d));
	  Console.WriteLine("c|d:" + (c|d));
	  Console.WriteLine("c^d:" + (c^d));
	  Console.WriteLine("c<<1:" + (c<<1));
	  Console.WriteLine("c>>d:" + (c>>d));
	  
	  //is Operator
	  object obj = "Hello World";
      Console.WriteLine("obj is string: " + (obj is string));
      Console.WriteLine("obj is int: " + (obj is int));
	  
  }
}