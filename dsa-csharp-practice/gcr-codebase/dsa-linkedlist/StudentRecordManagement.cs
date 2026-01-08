using System;
class Student
{
    public int RollNo;
    public string Name;
    public int Age;
    public string Grade;
    public Student Next;
    public Student(int rollNo, string name, int age, string grade)
    {
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private Student head;
    public void AddAtBeginning(int rollNo, string name, int age, string grade)
    {
        Student newNode = new Student(rollNo, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }
    public void AddAtEnd(int rollNo, string name, int age, string grade)
    {
        Student newNode = new Student(rollNo, name, age, grade);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Student temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }
    public void AddAtPosition(int position, int rollNo, string name, int age, string grade)
    {
        if (position == 1)
        {
            AddAtBeginning(rollNo, name, age, grade);
            return;
        }
        Student temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.Next;
        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        Student newNode = new Student(rollNo, name, age, grade);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }
    public void DeleteByRollNo(int rollNo)
    {
        if (head == null) return;

        if (head.RollNo == rollNo)
        {
            head = head.Next;
            Console.WriteLine("Student deleted");
            return;
        }
        Student temp = head;
        while (temp.Next != null && temp.Next.RollNo != rollNo)
            temp = temp.Next;

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found");
            return;
        }

        temp.Next = temp.Next.Next;
        Console.WriteLine("Student deleted");
    }
    public void Search(int rollNo)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                DisplayStudent(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }
    public void UpdateGrade(int rollNo, string newGrade)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No records available");
            return;
        }

        Student temp = head;
        while (temp != null)
        {
            DisplayStudent(temp);
            temp = temp.Next;
        }
    }

    private void DisplayStudent(Student s)
    {
        Console.WriteLine($"RollNo: {s.RollNo}, Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}");
    }
}
class StudentRecordManagement
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        list.AddAtBeginning(1, "Aryan", 20, "A");
        list.AddAtEnd(2, "Rahul", 21, "B");
        list.AddAtPosition(2, 3, "Neha", 19, "A");

        Console.WriteLine("All Students:");
        list.DisplayAll();

        Console.WriteLine("\nSearch Roll No 2:");
        list.Search(2);

        Console.WriteLine("\nUpdate Grade Roll No 3:");
        list.UpdateGrade(3, "A+");

        Console.WriteLine("\nDelete Roll No 1:");
        list.DeleteByRollNo(1);

        Console.WriteLine("\nFinal List:");
        list.DisplayAll();
    }
}
