using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductDiscountSort.FitnessTracker
{
    internal class UserMain
    {
        static void Main(string[] args)
        {
            int size = 20;
            Random random = new Random();
            User[] users = new User[size];
            for(int i = 0; i < size; i++)
            {
                int steps = random.Next(5000, 10001);
                users[i] = new User("Person " + (i + 1), steps);
            }
            Console.WriteLine("Initial leaderboard : ");
            BubbleSortUsers.Sort(users);
            Display(users);
            for(int sync = 1; sync <= 3; sync++)
            {
                Console.WriteLine("Step sync update " + sync);
                int index = random.Next(0,users.Length);
                int addedSteps = random.Next(500, 2501);
                users[index].Steps += addedSteps;
                Console.WriteLine(users[index].Name + "synced" + addedSteps + "steps");
                BubbleSortUsers.Sort(users);
                Display(users);
            }
        }
        static void Display(User[] users)
        {
            for(int i = 0; i < users.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + users[i].Name + "-" + users[i].Steps + " steps");
            }
        }
    }
}
