using System;
public class Menu
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        bool run = true;

        while (run)
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Creator Name:");
                    string name = Console.ReadLine();

                    double[] likes = new double[4];
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                    for (int i = 0; i < 4; i++)
                    {
                        likes[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    CreatorStats creator = new CreatorStats
                    {
                        CreatorName = name,
                        WeeklyLikes = likes
                    };

                    program.RegisterCreator(creator);
                    Console.WriteLine("Creator registered successfully");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = Convert.ToDouble(Console.ReadLine());

                    Dictionary<string, int> result =
                        program.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    double avg = program.CalculateAverageLikes();
                    Console.WriteLine("Overall average weekly likes: " + avg);
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    run = false;
                    break;
            }
        }
    }
}
