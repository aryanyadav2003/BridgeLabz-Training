using System;
class Calculator{
  static void Main(){
    int first=Convert.ToInt32(Console.ReadLine());
	int second=Convert.ToInt32(Console.ReadLine());
	string op=Console.ReadLine();
	switch(op){
	  case "+":
	   Console.WriteLine(first+second);
	   break;
	  case "-":
	   Console.WriteLine(first-second);
	   break;
	  case "*":
	   Console.WriteLine(first*second);
	   break;
	  case "/":
	  if(second!=0)
	   Console.WriteLine(first/second);
	  else
	   Console.WriteLine("cannot be divided by 0");
	   break;
	  default:
	   Console.WriteLine("Invalid Operator");
	   break;
	}
	
  }
}