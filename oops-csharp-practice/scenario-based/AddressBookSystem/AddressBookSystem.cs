using System;
class AddressBookSystem
{
    private AddressBook[] books=new AddressBook[0];
    private int count=0;
    public void AddAddressBook()
    {
        Console.Write("Enter Address Book name : ");
        string name=Console.ReadLine();
        if (IsDuplicate(name))
        {
            Console.WriteLine("Address Book already exists");
            return;
        }
        AddressBook[] temp=new AddressBook[count+1];
        for(int i = 0; i < count; i++)
        {
            temp[i]=books[i];
        }
        temp[count] = new AddressBook(name);
        books = temp;
        count++;
        Console.WriteLine("Address Book created");
    }
    public AddressBook SelectAddressBook()
    {
        if (count == 0)
        {
            Console.WriteLine("No Address Books available");
            return null;
        }
        Console.Write("Enter Address Book name : ");
        string name=Console.ReadLine();
        for(int i = 0; i < count; i++)
        {
            if (books[i].Name == name)
            {
                return books[i];
            }
        }
        Console.WriteLine("Address Book not found");
        return null;
    }
    private bool IsDuplicate(string name)
    {
        for (int i = 0; i < count; i++)
            if (books[i].Name == name)
                return true;
        return false;
    }
}