// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        IContact addressBook=new AddressBook();
        addressBook.AddContacts();
        addressBook.DisplayContacts();
    }
}
