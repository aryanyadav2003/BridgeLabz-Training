using System;
namespace ProductDiscountSort.ParcelTracker
{
    internal class StageMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of parcels: ");
            int n = int.Parse(Console.ReadLine());

            Parcel[] parcels = new Parcel[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter parcel id: ");
                int parcelId = int.Parse(Console.ReadLine());

                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();

                parcels[i] = new Parcel(parcelId, productName);

                Console.Write("How many stages? ");
                int stages = int.Parse(Console.ReadLine());

                for (int s = 0; s < stages; s++)
                {
                    Console.Write("Enter stage " + (s + 1) + ": ");
                    parcels[i].Chain.AddStage(Console.ReadLine());
                }
            }

            while (true)
            {
                Console.WriteLine("---- Parcel Tracker Menu ----");
                Console.WriteLine("1. Track a parcel");
                Console.WriteLine("2. Add checkpoint");
                Console.WriteLine("3. Mark parcel as lost");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Parcel p = GetParcel(parcels);
                        if (p != null)
                            p.Chain.TrackParcel();
                        break;

                    case 2:
                        p = GetParcel(parcels);
                        if (p != null)
                        {
                            Console.Write("Add after stage: ");
                            string afterStage = Console.ReadLine();

                            Console.Write("New checkpoint name: ");
                            string newStage = Console.ReadLine();

                            p.Chain.AddCheckPoints(afterStage, newStage);
                        }
                        break;

                    case 3:
                        p = GetParcel(parcels);
                        if (p != null)
                            p.Chain.MarkLost();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static Parcel GetParcel(Parcel[] parcels)
        {
            Console.Write("Enter parcel id: ");
            int id = int.Parse(Console.ReadLine());

            foreach (Parcel p in parcels)
            {
                if (p.ParcelId == id)
                    return p;
            }

            Console.WriteLine("Parcel not found.");
            return null;
        }
    }
}
