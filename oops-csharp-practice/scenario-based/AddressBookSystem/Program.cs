using System;

class Program
{
    static void Main()
    {
        AddressBookSystem system = new AddressBookSystem();
        bool exitSystem = false;

        while (!exitSystem)
        {
            Console.WriteLine("\n===== Address Book System =====");
            Console.WriteLine("1. Add Address Book");
            Console.WriteLine("2. Open Address Book");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    system.AddAddressBook();
                    break;

                case 2:
                    AddressBook addressBook = system.SelectAddressBook();
                    if (addressBook != null)
                    {
                        AddressBookMenu(addressBook); // 🔑 important
                    }
                    break;

                case 3:
                    exitSystem = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    // 🔹 CONTACT MENU FOR EACH ADDRESS BOOK
    static void AddressBookMenu(AddressBook addressBook)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n===== Address Book: " + addressBook.Name + " =====");
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Edit Person");
            Console.WriteLine("3. Delete Person");
            Console.WriteLine("4. Display All");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();   // UC-5
                    break;

                case 2:
                    addressBook.EditContact();  // UC-3
                    break;

                case 3:
                    addressBook.DeleteContact(); // UC-4
                    break;

                case 4:
                    addressBook.DisplayContacts();
                    break;

                case 5:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
