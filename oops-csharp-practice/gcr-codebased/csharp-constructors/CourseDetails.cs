using System;
class Course{
    public string CourseName;
    public int Duration;     
    public double Fee;

    public static string InstituteName = "Courseera";

    public Course(string courseName, int duration, double fee){
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration (months): " + Duration);
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Institute: " + InstituteName);
    }

    public static void UpdateInstituteName(string newName){
        InstituteName = newName;
    }
}
class CourseDetails{
    static void Main(){
        Course c1 = new Course("C# Full Stack", 6, 45000);
        Course c2 = new Course("Java Backend", 5, 40000);

        Console.WriteLine("Course 1 Details:");
        c1.DisplayCourseDetails();

        Console.WriteLine();

        Console.WriteLine("Course 2 Details:");
        c2.DisplayCourseDetails();

        Console.WriteLine();

        Course.UpdateInstituteName("MyCourse");

        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();
    }
}
