using System;
using System.Collections.Generic;
abstract class CourseType
{
    public string CourseName{get;set;}
    public abstract void Evaluate();
}
class ExamCourse : CourseType
{
    public override void Evaluate() =>
        Console.WriteLine($"{CourseName} evaluated by exam");
}

class AssignmentCourse : CourseType
{
    public override void Evaluate() =>
        Console.WriteLine($"{CourseName} evaluated by assignments");
}

class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course) => courses.Add(course);

    public void EvaluateAll()
    {
        foreach (var course in courses)
            course.Evaluate();
    }
}
class Program
{
    static void Main()
    {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        examCourses.AddCourse(new ExamCourse { CourseName = "Maths" });

        examCourses.EvaluateAll();
    }
}