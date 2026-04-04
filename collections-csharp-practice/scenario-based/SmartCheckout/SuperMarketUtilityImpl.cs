using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.SmartCheckout
{
    internal class SuperMarketUtilityImpl
    {
        Queue<Customer> billingQueue = new Queue<Customer>();
        Dictionary<string, Items> itemMap = new Dictionary<string, Items>();
        public void AddItem(Items item)
        {
            itemMap[item.Name] = item;
            Console.WriteLine("Item added successfully.");
        }
        public void AddCustomer(Customer customer)
        {
            billingQueue.Enqueue(customer);
            Console.WriteLine("Customer added to billing queue");
        }
        public void ProcessCustomer()
        {
            if (billingQueue.Count == 0)
            {
                Console.WriteLine("No Customer in queue.");
                return;
            }
            Customer customer = billingQueue.Dequeue();
            int total = 0;
            Console.WriteLine("Billing for " + customer.Name);
            foreach(string itemName in customer.Items)
            {
                if (itemMap.ContainsKey(itemName))
                {
                    Items item = itemMap[itemName];
                    if (item.Stock > 0)
                    {
                        total += item.Price;
                        item.Stock--;
                        Console.WriteLine(item.Name + " - Rs. " + item.Price);
                    }
                    else
                    {
                        Console.WriteLine(item.Name + " is out of stock.");
                    }
                }
                else
                {
                    Console.WriteLine(itemName + " not found.");    
                }
            }
            Console.WriteLine("Total Bill: Rs. " + total);
        }
        public void DisplayItems()
        {
            Console.WriteLine("\nAvailable Items:");
            foreach (var entry in itemMap)
            {
                Items i = entry.Value;
                Console.WriteLine(i.Name + " | Price: Rs. " + i.Price + " | Stock: " + i.Stock);
            }
        }
    }
}
