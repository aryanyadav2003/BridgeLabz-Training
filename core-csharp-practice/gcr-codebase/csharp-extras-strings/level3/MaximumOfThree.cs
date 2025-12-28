using System;
class MaximumOfThree{
    static int GetInput(string message){
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }
    static int FindMaximum(int a, int b, int c){
        int max=a;
        if(b>max)
            max=b;
        if(c>max)
            max=c;
        return max;
    }
    static void Main(){
        int num1=GetInput("Enter first number: ");
        int num2=GetInput("Enter second number: ");
        int num3=GetInput("Enter third number: ");
        int maximum = FindMaximum(num1, num2, num3);
        Console.WriteLine("Maximum of the three numbers is: " + maximum);
    }
}
