using System;
class SI{
    static double CalculateSI(double p,double r,double t){
        return (p*r*t)/100;
    }
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p=double.Parse(Console.ReadLine());
        Console.Write("Enter Rate : ");
        double r=double.Parse(Console.ReadLine());
        Console.Write("Enter Time: ");
        double t=double.Parse(Console.ReadLine());
        double si = CalculateSI(p,r,t);
        Console.WriteLine( $"The Simple Interest is {si}");
    }
}
