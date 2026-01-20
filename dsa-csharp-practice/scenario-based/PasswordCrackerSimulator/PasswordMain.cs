using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.PasswordCrackerSimulator
{
    class Program
    {
        static void Main()
        {
            IPassword cracker = new PasswordCracker();
            while (true)
            {
                Console.WriteLine("--- Password Cracker Simulator ---");
                Console.WriteLine("1. Generate all strings of length n");
                Console.WriteLine("2. Set Password");
                Console.WriteLine("3. Decode Password");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.Write("Enter length: ");
                        int n = int.Parse(Console.ReadLine());
                        cracker.GenerateString(n);
                        break;

                    case 2:

                        Console.Write("Enter password: ");
                        string pwd = Console.ReadLine();
                        cracker.SetPassword(pwd);
                        break;

                    case 3:

                        cracker.DecodePassword();
                        break;

                    case 4:
                        Console.WriteLine("Existing");
                        return;

                    default:

                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
