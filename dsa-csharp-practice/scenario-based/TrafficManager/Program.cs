using System;
namespace TrafficManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Roundabout roundabout = new Roundabout();
            VehicleQueue waitingQueue = new VehicleQueue(5);
            while (true)
            {
                Console.WriteLine("\n--- Smart Traffic Manager ---");
                Console.WriteLine("1. Add Vehicle to Waiting Queue");
                Console.WriteLine("2. Move Vehicle into Roundabout");
                Console.WriteLine("3. Remove Vehicle from Roundabout");
                Console.WriteLine("4. Display Roundabout");
                Console.WriteLine("5. Display Waiting Queue");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Vehicle Number: ");
                        waitingQueue.Enqueue(Console.ReadLine());
                        break;

                    case 2:
                        string vehicle = waitingQueue.Dequeue();
                        if (vehicle != null)
                            roundabout.AddVehicle(vehicle);
                        break;

                    case 3:
                        Console.Write("Enter Vehicle Number to remove: ");
                        roundabout.RemoveVehicle(Console.ReadLine());
                        break;

                    case 4:
                        roundabout.Display();
                        break;

                    case 5:
                        waitingQueue.Display();
                        break;

                    case 6:
                        Console.WriteLine("Exiting Traffic Manager...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
