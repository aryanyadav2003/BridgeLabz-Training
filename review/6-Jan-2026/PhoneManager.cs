using System;

class User
{
    public string name;
    public string phone;
    public string gender;

    public void Display()
    {
        Console.WriteLine("Name   : " + name);
        Console.WriteLine("Phone  : " + phone);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("-------------------");
    }
}

class PhoneNumberSearch
{
    private User[] users = new User[3];
    private int count = 0;

    public void AddUser()
    {
        if (count >= users.Length)
        {
            Console.WriteLine("Contact list full");
            return;
        }

        User u = new User();

        Console.Write("Enter name   : ");
        u.name = Console.ReadLine();

        Console.Write("Enter phone  : ");
        u.phone = Console.ReadLine();

        Console.Write("Enter gender : ");
        u.gender = Console.ReadLine();

        users[count] = u;
        count++;

        Console.WriteLine("Contact added successfully");
    }

    public void Search()
    {
        Console.Write("Enter phone to search: ");
        string phone = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (users[i].phone == phone)
            {
                users[i].Display();
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }

    public void Update()
    {
        Console.Write("Enter phone to update: ");
        string phone = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (users[i].phone == phone)
            {
                Console.Write("Enter new name   : ");
                users[i].name = Console.ReadLine();

                Console.Write("Enter new gender : ");
                users[i].gender = Console.ReadLine();

                Console.WriteLine("Contact updated");
                return;
            }
        }

        Console.WriteLine("Contact not found");
    }
}

class PhoneManager
{
    static void Main()
    {
        PhoneNumberSearch manager = new PhoneNumberSearch();


        while (true)
        {
            {
                Console.WriteLine("\n--- Phone Manager ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Search Contact");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddUser();
                        break;

                    case 2:
                        manager.Search();
                        break;

                    case 3:
                        manager.Update();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
        }
    }
}
