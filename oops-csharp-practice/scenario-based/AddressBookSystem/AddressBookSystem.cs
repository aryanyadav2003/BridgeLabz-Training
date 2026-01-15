using System;
using System.Collections.Generic;

class AddressBookSystem
{
    private Dictionary<string, AddressBook> books =new Dictionary<string, AddressBook>();

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

    // UC-8 & UC-9
   public void ViewByCityOrState()
   {
    Console.Write("Enter City or State: ");
    string key = Console.ReadLine();

    bool printedHeading = false;
    bool found = false;

    foreach (var book in books.Values)
    {
        if (book.CityDict.ContainsKey(key))
        {
            if (!printedHeading)
            {
                Console.WriteLine("\nCity: " + key);
                printedHeading = true;
            }

            foreach (var c in book.CityDict[key])
            {
                Console.WriteLine(c.FirstName + " " + c.LastName);
                found = true;
            }
        }
    }

    printedHeading = false;

    foreach (var book in books.Values)
    {
        if (book.StateDict.ContainsKey(key))
        {
            if (!printedHeading)
            {
                Console.WriteLine("\nState: " + key);
                printedHeading = true;
            }

            foreach (var c in book.StateDict[key])
            {
                Console.WriteLine(c.FirstName + " " + c.LastName);
                found = true;
            }
        }
    }

    if (!found)
        Console.WriteLine("No persons found");
}
    //uc=10
   public void CountByCityOrState()
    {
        Console.WriteLine("Enter City or State: ");
        string key=Console.ReadLine();
        int total=0;
        foreach(var book in books.Values)
        {
            if (book.CityDict.ContainsKey(key))
                total += book.CityDict[key].Length;

            if (book.StateDict.ContainsKey(key))
                total += book.StateDict[key].Length;
        }
         Console.WriteLine("Total Contacts: " + total);
    }

}
