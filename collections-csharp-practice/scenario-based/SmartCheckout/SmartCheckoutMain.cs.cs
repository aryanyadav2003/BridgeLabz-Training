using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.SmartCheckout
{
    internal class SmartCheckoutMain
    {
        static void Main()
        {
            SuperMarketUtilityImpl market = new SuperMarketUtilityImpl();
            while (true)
            {
                Console.WriteLine("\n=== Smart Checkout ===");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Process Customer");
                Console.WriteLine("4. View Items");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Item Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Price: ");
                        int price = int.Parse(Console.ReadLine());

                        Console.Write("Stock: ");
                        int stock = int.Parse(Console.ReadLine());

                        market.AddItem(new Items(name, price, stock));
                        break;
                    case 2:
                        Console.Write("Customer Name: ");
                        string cname = Console.ReadLine();

                        Console.Write("Number of items: ");
                        int n = int.Parse(Console.ReadLine());

                        List<string> items = new List<string>();
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Enter item name: ");
                            items.Add(Console.ReadLine());
                        }

                        market.AddCustomer(new Customer(cname, items));
                        break;
                    case 3:
                        market.ProcessCustomer();
                        break;
                    case 4:
                        market.DisplayItems();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
