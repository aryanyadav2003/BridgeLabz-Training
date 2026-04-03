using System;
class WeightConvert{
    static void Main(){
        Console.Write("Enter weight in pounds: ");
        double p = Convert.ToDouble(Console.ReadLine());
        double k = p/2.2;
        Console.WriteLine("The weight of the person in pounds is " + p + " and in kg is " + k);
    }
}
