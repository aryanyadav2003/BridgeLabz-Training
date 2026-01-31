using System;
using System.Collections.Generic;

public class UserInterface
{
    public static void Main(string[] args)
    {
        VesselUtil util = new VesselUtil();

        Console.WriteLine("Enter the number of vessels to be added");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter vessel details");
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] data = input.Split(':');

            Vessel vessel = new Vessel(
                data[0],
                data[1],
                Convert.ToDouble(data[2]),
                data[3]
            );

            util.addVesselPerformance(vessel);
        }

        Console.WriteLine("Enter the Vessel Id to check speed");
        string searchId = Console.ReadLine();

        Vessel foundVessel = util.getVesselById(searchId);

        if (foundVessel != null)
        {
            Console.WriteLine(foundVessel.vesselId + " | " +foundVessel.vesselName + " | " +foundVessel.vesselType + " | " +foundVessel.averageSpeed + " knots");
        }
        else
        {
            Console.WriteLine("Vessel Id " + searchId + " not found");
        }

        Console.WriteLine("High performance vessels are");
        List<Vessel> highPerf = util.getHighPerformanceVessels();

        foreach (Vessel v in highPerf)
        {
            Console.WriteLine(v.vesselId + " | " +v.vesselName + " | " +v.vesselType + " | " +v.averageSpeed + " knots");
        }
    }
}

