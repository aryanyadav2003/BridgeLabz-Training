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
    public void SearchPersonByCityOrState()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No address books availaable");
            return;
        }
        Console.Write("Enter city or state : ");
        string key=Console.ReadLine();
        bool found=false;
        foreach(var book in books)
        {
            Contact[] contacts=book.Value.GetContacts();
            for(int i=0;i<contacts.Length;i++){
           
            if(contacts[i].City.Equals(key,StringComparison.OrdinalIgnoreCase) || contacts[i].State.Equals(key, StringComparison.OrdinalIgnoreCase))
            {
                 Console.WriteLine(contacts[i].FirstName + " " + contacts[i].LastName +" | " + contacts[i].City + ", " + contacts[i].State + " | Address Book: " + book.Key);
                 found=true;
            }
            }
        }
         if (!found){
            Console.WriteLine("No person found");
         }
    }
}
