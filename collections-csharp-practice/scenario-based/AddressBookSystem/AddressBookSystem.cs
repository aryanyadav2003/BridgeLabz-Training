using System;
using System.Collections.Generic;
class AddressBookSystem
{
    private Dictionary<string, AddressBook> books = new Dictionary<string, AddressBook>();

    public void AddAddressBook()
    {
        Console.Write("Enter Address Book name: ");
        string name = Console.ReadLine();

        if (books.ContainsKey(name))
        {
            Console.WriteLine("Address Book already exists");
            return;
        }

        books[name] = new AddressBook(name);
        Console.WriteLine("Address Book created");
    }

    public AddressBook SelectAddressBook()
    {
        Console.Write("Enter Address Book name: ");
        string name = Console.ReadLine();

        if (books.ContainsKey(name))
            return books[name];

        Console.WriteLine("Address Book not found");
        return null;
    }

    public void ViewByCityOrState()
    {
        Console.Write("Enter City or State: ");
        string key = Console.ReadLine();

        bool found = false;

        foreach (var book in books.Values)
        {
            if (book.CityDict.ContainsKey(key))
            {
                Console.WriteLine("\nCity: " + key);
                foreach (var c in book.CityDict[key])
                {
                    Console.WriteLine(c.FirstName + " " + c.LastName);
                }
                found = true;
            }

            if (book.StateDict.ContainsKey(key))
            {
                Console.WriteLine("\nState: " + key);
                foreach (var c in book.StateDict[key])
                {
                    Console.WriteLine(c.FirstName + " " + c.LastName);
                }
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No persons found");
    }

    public void CountByCityOrState()
    {
        Console.Write("Enter City or State: ");
        string key = Console.ReadLine();

        int total = 0;

        foreach (var book in books.Values)
        {
            if (book.CityDict.ContainsKey(key))
                total += book.CityDict[key].Count;

            if (book.StateDict.ContainsKey(key))
                total += book.StateDict[key].Count;
        }

        Console.WriteLine("Total Contacts: " + total);
    }
}
