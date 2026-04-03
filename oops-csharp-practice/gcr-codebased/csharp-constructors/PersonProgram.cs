using System;
class Person{
    public string Name;
    public int Age;
    public string City;

    public Person(string name, int age, string city){
        Name = name;
        Age = age;
        City = city;
    }
    // Copy constructor
    public Person(Person p)
    {
        Name = p.Name;
        Age = p.Age;
        City = p.City;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("City: " + City);
    }
}

class PersonProgram
{
    static void Main()
    {
        // Original object
        Person p1 = new Person("Aryan", 22, "Lucknow");

        // Copying object using copy constructor
        Person p2 = new Person(p1);

        Console.WriteLine("Original Person:");
        p1.ShowDetails();

        Console.WriteLine("Copied Person:");
		p2.ShowDetails();
		}
		
		}
