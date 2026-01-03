using System;
class Person{
    public string Name;
    public int Age;
    public virtual void DisplayRole(){
        Console.WriteLine("Role: Person");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
class Teacher : Person{
    public string Subject;
    public override void DisplayRole(){
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
    }
}
class Student : Person{
    public string Grade;
    public override void DisplayRole(){
        Console.WriteLine("Role: Student");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}
class Staff : Person{
    public string Department;
    public override void DisplayRole(){
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
    }
}
class SchoolSystem{
    static void Main(){
        Person p1 = new Teacher{
            Name = "Mr. Sharma",
            Age = 40,
            Subject = "Java"
        };
        Person p2 = new Student{
            Name = "Aryan",
            Age = 18,
            Grade = "12th"
        };
        Person p3 = new Staff{
            Name = "Ramesh",
            Age = 45,
            Department = "Administration"
        };
        p1.DisplayRole();
        Console.WriteLine();
        p2.DisplayRole();
        Console.WriteLine();
        p3.DisplayRole();
    }
}
