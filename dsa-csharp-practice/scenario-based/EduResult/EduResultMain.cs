using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.EduResults
{
    internal class EduResultMain
    {
        static void Main()
        {
            StateResult state = new StateResult();
            while (true)
            {
                Console.WriteLine("--- EDU RESULT SYSTEM ---");
                Console.WriteLine("1. Add District");
                Console.WriteLine("2. Display State Rank List");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        state.AddDistrict();
                        break;
                    case 2:
                        DisplayRankList(state);
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                }

            }
            static void DisplayRankList(StateResult state) 
            {
                Student[] rankList = state.GetStateRankList();
                Console.WriteLine("-----STATE WISE RANK LIST-----");

                foreach (Student s in rankList)
                    s.Display();

            }
        }
    }
}
