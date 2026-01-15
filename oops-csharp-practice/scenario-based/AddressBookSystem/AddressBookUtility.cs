using System;
class AddressBook : IContact
{
    public string Name;
    private Contact[] contacts=new Contact[0];
    private int count=0;
    public AddressBook(string name)
    {
        Name = name;
    }
    private bool IsDuplicate(Contact newContact)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Equals(newContact))
                return true;
        }
        return false;
    }
    public void AddContact()
    {
        Contact contact=new Contact();
        Console.Write("First Name: ");
        contact.FirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        contact.LastName = Console.ReadLine();
        // UC-7 duplicate check
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
        Contact[] temp=new Contact[count+1];
        for(int i = 0; i < count; i++)
        {
            temp[i]=contacts[i];
        }
        temp[count]=contact;
        contacts=temp;
        count++;
        Console.WriteLine("Contact added to " + Name);
    }
    public void EditContact()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available to edit");
            return;
        }
        Console.Write("Enter First Name of contact to edit: ");
        string name=Console.ReadLine();
        bool found=false;
        for(int i=0;i<count; i++)
        {
            if (contacts[i].FirstName.Equals(name,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Editing Contact: " + contacts[i].FirstName);
                Console.Write("New Address: ");
                contacts[i].Address = Console.ReadLine();
                Console.Write("New City: ");
                contacts[i].City = Console.ReadLine();
                Console.Write("New State: ");
                contacts[i].State = Console.ReadLine();
                Console.Write("New Zip: ");
                contacts[i].Zip = Console.ReadLine();
                Console.Write("New Phone: ");
                contacts[i].PhoneNumber = Console.ReadLine();
                Console.Write("New Email: ");
                contacts[i].Email = Console.ReadLine();
                Console.WriteLine("Contact updated successfully");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Contact not found");
        }
    }
    public void DeleteContact()
    {
    if (count == 0)
    {
        Console.WriteLine("No contacts to delete");
        return;
    }

    Console.Write("Enter First Name of contact to delete: ");
    string name = Console.ReadLine();

    int index = -1;
    for (int i = 0; i < count; i++)
    {
        if (contacts[i].FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
            index = i;
            break;
        }
    }
    if (index == -1)
    {
        Console.WriteLine("Contact not found");
        return;
    }
    Contact[] temp = new Contact[count - 1];
    for (int i = 0, j = 0; i < count; i++)
    {
        if (i != index)
        {
            temp[j] = contacts[i];
            j++;
        }
    }
    contacts = temp;
    count--;
    Console.WriteLine("Contact deleted successfully");
}

    public void DisplayContacts()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts found");
            return;
        }
        Console.WriteLine("\n--- Address Book ---");
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Contact " + (i + 1));
            Console.WriteLine("Name    : " + contacts[i].FirstName + " " + contacts[i].LastName);
            Console.WriteLine("Address : " + contacts[i].Address);
            Console.WriteLine("City    : " + contacts[i].City);
            Console.WriteLine("State   : " + contacts[i].State);
            Console.WriteLine("Zip     : " + contacts[i].Zip);
            Console.WriteLine("Phone   : " + contacts[i].PhoneNumber);
            Console.WriteLine("Email   : " + contacts[i].Email);
        }
    }
}
