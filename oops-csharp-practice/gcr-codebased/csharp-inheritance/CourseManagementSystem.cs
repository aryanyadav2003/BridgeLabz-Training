using System;
class Course{
  public string CourseName;
  public int Duration;
  public virtual void DisplayDetails(){
    Console.WriteLine("Course Name : " + CourseName);
	Console.WriteLine("Duration: " + Duration + "hours");
  }
}
class OnlineCourse:Course{
  public string Platform;
  public bool IsRecorded;
  public override void DisplayDetails(){
   Console.WriteLine("Course Name: " + CourseName);
   Console.WriteLine("Duration: " + Duration + " hours");
   Console.WriteLine("Platform: " + Platform);
   Console.WriteLine("Is Recorded: " + IsRecorded);
  }
}
class PaidOnlineCourse : OnlineCourse{
    public double Fee;
    public double Discount;

    public override void DisplayDetails(){
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " hours");
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Is Recorded: " + IsRecorded);
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}
class CourseManagementSystem{
    static void Main(){
        Course c1 = new Course{
            CourseName = "C# Basics",
            Duration = 40
        };

        Course c2 = new OnlineCourse{
            CourseName = "OOP with C#",
            Duration = 60,
            Platform = "Udemy",
            IsRecorded = true
        };

        Course c3 = new PaidOnlineCourse{
            CourseName = "Full Stack .NET",
            Duration = 120,
            Platform = "Coursera",
            IsRecorded = true,
            Fee = 5000,
            Discount = 20
        };

        c1.DisplayDetails();
        Console.WriteLine();

        c2.DisplayDetails();
        Console.WriteLine();

        c3.DisplayDetails();
    }
}