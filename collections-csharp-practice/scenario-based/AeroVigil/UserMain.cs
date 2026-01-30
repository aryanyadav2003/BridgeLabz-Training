// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class UserMain
{
    static void Main(string[] args)
    {
        FlightUtil util = new FlightUtil();
        try
        {
            Console.WriteLine("1. Enter flight details");
            Console.WriteLine("2. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter flight details");
                    Console.WriteLine("Format: FlightNumber:FlightName:PassengerCount:CurrentFuelLevel");

                    string input = Console.ReadLine();
                    string[] details = input.Split(':');
                    string flightNumber = details[0];
                    string flightName = details[1];
                    int passengerCount = int.Parse(details[2]);
                    double currentFuelLevel = double.Parse(details[3]);
                    util.ValidateFlightNumber(flightNumber);
                    util.ValidateFlightName(flightName);
                    util.ValidatePassengerCount(passengerCount, flightName);
                    double fuelRequired =
                        util.CalculateFuelToFillTank(flightName, currentFuelLevel);
                    break;

                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        catch (InvalidFlightException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input format");
        }
    }
}
