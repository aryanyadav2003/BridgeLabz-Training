using System;
class ChocolateDistribution{
    static void Main(){
        Console.Write("Enter number of chocolates: ");
        int nc = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of children: ");
        int nchild = Convert.ToInt32(Console.ReadLine());
        int chocolatesEach = nc / nchild;
        int remainingChocolates = nc % nchild;
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesEach + " and the number of remaining chocolates is " + remainingChocolates );
    }
}
