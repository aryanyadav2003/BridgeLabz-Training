// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main(){
    Console.WriteLine("===== METAL FACTORY PIPE CUTTING SYSTEM =====");
    Console.Write("Enter total rod length: ");
    int rodLength=int.Parse(Console.ReadLine());
    MetalRod rod=new MetalRod(rodLength);
    rod.InputPrices();
    RevenueCalculator calculator=new RevenueCalculator();
    int optimizedRevenue=calculator.CalculateMaxRevenue(rod.Price,rod.Length);
    int nonOptimizedRevenue=rod.Price[rod.Length];
    Console.WriteLine("\n===== RESULT =====");
    Console.WriteLine("Optimized Maximum Revenue : " + optimizedRevenue);
    Console.WriteLine("Non-Optimized Revenue     : " + nonOptimizedRevenue);
    Console.WriteLine("Revenue Gain              : " +(optimizedRevenue - nonOptimizedRevenue));
    }
}