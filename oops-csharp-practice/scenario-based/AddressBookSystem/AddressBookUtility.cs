using System;
class AddressBook : IContact
{
    private Contact[] contacts=new Contact[0];
    private int count=0;
    public void AddContacts()
    {
        bool addMore=true;
        while (addMore)
        {
            Contact contact=new Contact();
            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();
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
            AddContact(contact);
            Console.Write("Add another contact? (y/n): ");
            string choice=Console.ReadLine();
            if(choice!="y" && choice != "Y")
            {
                addMore=false;
            }
        }
    }
    private void AddContact(Contact contact)
    {
        Contact[] temp=new Contact[count+1];
        for(int i = 0; i < count; i++)
        {
            temp[i]=contacts[i];
        }
        temp[count]=contact;
        contacts=temp;
        count++;
        Console.WriteLine("Contact added");
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
