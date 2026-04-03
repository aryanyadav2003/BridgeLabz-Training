using System;
class Student{
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;
    public readonly int RollNumber;
    public string Name;
    public char Grade;
    public Student(int RollNumber, string Name, char Grade){
        this.RollNumber = RollNumber; 
        this.Name = Name;            
        this.Grade = Grade;
        totalStudents++;
    }
    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    public void UpdateGrade(char newGrade){
        this.Grade = newGrade;
    }
    public void DisplayStudentDetails(){
        Console.WriteLine("University: " + UniversityName);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Grade: " + Grade);
    }
}

class UniversityStudentManagement{
    static void Main(){
        Student s1 = new Student(101, "Aryan", 'A');
        Student s2 = new Student(102, "Rohit", 'B');

        Student.DisplayTotalStudents();
        if (s1 is Student){
            Console.WriteLine("\nStudent 1 Details:");
            s1.DisplayStudentDetails();
            s1.UpdateGrade('O');
			s1.DisplayStudentDetails();
        }
        if (s2 is Student){
            Console.WriteLine("\nStudent 2 Details:");
            s2.DisplayStudentDetails();
        }
    }
}
