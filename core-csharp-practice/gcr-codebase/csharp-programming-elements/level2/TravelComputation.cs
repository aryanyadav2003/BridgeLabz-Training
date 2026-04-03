using System;
class TravelComputation{
    static void Main(){
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter From City: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter Via City: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter To City: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter distance from FromCity to ViaCity: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter distance from ViaCity to ToCity : ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter total time taken (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;
        Console.WriteLine("The results of the trip are: " + name + ", " + totalDistance + " miles, and " + timeTaken + " hours" );
    }
}
