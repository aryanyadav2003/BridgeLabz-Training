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
        books.Add(name, new AddressBook(name));
        Console.WriteLine("Address Book created");
    }
    public AddressBook SelectAddressBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No Address Books available");
            return null;
        }
        Console.Write("Enter Address Book name: ");
        string name = Console.ReadLine();
        if (books.ContainsKey(name)){
            return books[name];
        }
        Console.WriteLine("Address Book not found");
        return null;
    }
}
