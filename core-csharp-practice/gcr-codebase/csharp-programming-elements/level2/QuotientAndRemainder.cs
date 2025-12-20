using System;
class QuotientAndRemainder{
    static void Main()
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int q = num1 / num2;
        int r = num1 % num2;
        Console.WriteLine(
            "The Quotient is " + q +
            " and Remainder is " + r +
            " of two numbers " + num1 +
            " and " + num2);
    }
}
