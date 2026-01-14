using System;
class Contact : IContact
{
    public string FirstName;
    public string LastName;
    public string Address;
    public string City;
    public string State;
    public string Zip;
    public string PhoneNumber;
    public string Email;

    public void AddContact()
    {
        Console.WriteLine("Enter first name : ");
        FirstName=Console.ReadLine();
        Console.WriteLine("Enter last name : ");
        LastName=Console.ReadLine();
        Console.WriteLine("Enter address : ");
        Address=Console.ReadLine();
        Console.WriteLine("Enter City : ");
        City=Console.ReadLine();
        Console.WriteLine("Enter State :");
        State=Console.ReadLine();
        Console.WriteLine("Enter Zip :");
        Zip=Console.ReadLine();
        Console.WriteLine("Enter Phone Number :");
        PhoneNumber=Console.ReadLine();
        Console.WriteLine("Enter email :");
        Email=Console.ReadLine();

    }
    public void DisplayContact()
    {
        Console.WriteLine("--- Contact Details ---");
        Console.WriteLine("Name : " + FirstName + " " + LastName);
        Console.WriteLine("Address : " + Address);
        Console.WriteLine("City : " + City);
        Console.WriteLine("State : " + State);
        Console.WriteLine("Zip : " + Zip);
        Console.WriteLine("Phone Number : " + PhoneNumber);
        Console.WriteLine("Email : " + Email);
    }
}