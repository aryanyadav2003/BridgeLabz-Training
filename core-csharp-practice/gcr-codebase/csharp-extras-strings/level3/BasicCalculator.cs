using System;
class BasicCalculator{
    static double Add(double a,double b){
        return a+b;
    }
    static double Subtract(double a,double b){
        return a-b;
    }
    static double Multiply(double a,double b){
        return a*b;
    }
    static double Divide(double a,double b){
        if(b==0){
            Console.WriteLine("Division by zero not allowed");
            return 0;
        }
        return a/b;
    }
    static void Main(){
        Console.Write("Enter first number: ");
        double num1=double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2=double.Parse(Console.ReadLine());
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter choice (1-4): ");
        int choice=int.Parse(Console.ReadLine());
        double res;
        switch(choice){
            case 1:
                res=Add(num1,num2);
                break;
            case 2:
                res=Subtract(num1,num2);
                break;
            case 3:
                res=Multiply(num1,num2);
                break;
            case 4:
                res=Divide(num1,num2);
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }
        Console.WriteLine("Result: " + res);
    }
}
