using System;
using System.Collections.Generic;

class AddressBook : IContact
{
    public string Name;

    private List<Contact> contacts = new List<Contact>();

    // UC-9 dictionaries using List
    public Dictionary<string, List<Contact>> CityDict = new Dictionary<string, List<Contact>>();
    public Dictionary<string, List<Contact>> StateDict = new Dictionary<string, List<Contact>>();

    public AddressBook(string name)
    {
        Name = name;
    }

    private bool IsDuplicate(Contact newContact)
    {
        foreach (var c in contacts)
        {
            if (c.Equals(newContact))
                return true;
        }
        return false;
    }

    public void AddContact()
    {
        Contact contact = new Contact();

        Console.Write("First Name: ");
        contact.FirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        contact.LastName = Console.ReadLine();

        if (IsDuplicate(contact))
        {
            Console.WriteLine("Duplicate contact not allowed");
            return;
        }

        Console.Write("Address: ");
        contact.Address = Console.ReadLine();
        Console.Write("City: ");
        contact.City = Console.ReadLine();
        Console.Write("State: ");
        contact.State = Console.ReadLine();
        Console.Write("Zip: ");
        contact.Zip = Console.ReadLine();
        Console.Write("Phone: ");
        contact.PhoneNumber = Console.ReadLine();
        Console.Write("Email: ");
        contact.Email = Console.ReadLine();

        contacts.Add(contact);

        AddToDictionary(CityDict, contact.City, contact);
        AddToDictionary(StateDict, contact.State, contact);

        Console.WriteLine("Contact added to " + Name);
    }

    private void AddToDictionary(Dictionary<string, List<Contact>> dict, string key, Contact c)
    {
        if (!dict.ContainsKey(key))
            dict[key] = new List<Contact>();

        dict[key].Add(c);
    }

    public void EditContact()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts available to edit");
            return;
        }

        Console.Write("Enter First Name of contact to edit: ");
        string name = Console.ReadLine();

        foreach (var c in contacts)
        {
            if (c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("New Address: ");
                c.Address = Console.ReadLine();
                Console.Write("New City: ");
                c.City = Console.ReadLine();
                Console.Write("New State: ");
                c.State = Console.ReadLine();
                Console.Write("New Zip: ");
                c.Zip = Console.ReadLine();
                Console.Write("New Phone: ");
                c.PhoneNumber = Console.ReadLine();
                Console.Write("New Email: ");
                c.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully");
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }

    public void DeleteContact()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts to delete");
            return;
        }

        Console.Write("Enter First Name of contact to delete: ");
        string name = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                contacts.RemoveAt(i);
                Console.WriteLine("Contact deleted successfully");
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }

    public void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found");
            return;
        }

        Console.WriteLine("\n--- Address Book ---");
        foreach (var c in contacts)
        {
            Console.WriteLine(c.ToString());
        }
    }

    // Sorting using List
    public void SortContactByName()
    {
        contacts.Sort((a, b) =>
            string.Compare(a.FirstName, b.FirstName, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("--- Sorted by Name ---");
        DisplayContacts();
    }

    public void SortByCity()
    {
        contacts.Sort((a, b) =>
            string.Compare(a.City, b.City, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("--- Sorted by City ---");
        DisplayContacts();
    }

    public void SortByState()
    {
        contacts.Sort((a, b) =>
            string.Compare(a.State, b.State, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("--- Sorted by State ---");
        DisplayContacts();
    }

    public void SortByZip()
    {
        contacts.Sort((a, b) =>
            string.Compare(a.Zip, b.Zip));

        Console.WriteLine("--- Sorted by Zip ---");
        DisplayContacts();
    }
}
