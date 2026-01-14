// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        IContact addressBook=new AddressBook();
        while (true)
        {
            Console.WriteLine("===== Address Book Menu =====");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    addressBook.AddContact();   // UC-1 & UC-2
                    break;

                case 2:
                    addressBook.EditContact();   // UC-3
                    break;

                case 3:
                    addressBook.DeleteContact();   // UC-4
                    break;

                case 4:
                    addressBook.DisplayContacts();
                    break;

                case 5:
                    Console.WriteLine("Exiting Address Book...");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
