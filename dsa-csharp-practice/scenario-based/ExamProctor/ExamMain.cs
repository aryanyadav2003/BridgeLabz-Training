using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.ExamProctor
{
    internal class ExamMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number of students : ");
            int n=int.Parse(Console.ReadLine());
            int totalQuestions = 10;
            Student[] students=new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student id : ");
                int id=int.Parse(Console.ReadLine()) ;
                Console.WriteLine("Enter student name : ");
                string name=Console.ReadLine();
                students[i] = new Student(id, name, totalQuestions);
            }
            ExamEvaluator evaluator=new ExamEvaluator();
            foreach(Student s in students)
            {
                Console.WriteLine("Exam for " +  s.Name);
                for(int q = 1; q <= totalQuestions; q++)
                {
                    s.VisitQuestion(1);
                    Console.WriteLine("Question " + q);
                    Console.WriteLine("A) Option A");
                    Console.WriteLine("B) Option B");
                    Console.WriteLine("C) Option C");
                    Console.WriteLine("D) Option D");
                    Console.WriteLine("Enter answer : ");
                    string ans=Console.ReadLine().ToUpper();
                    s.AnswerQuestion(q, ans);
                }
            }
            Console.WriteLine("---Exam Results---");
            foreach (Student s in students)
            {
                Console.WriteLine("Student " + s.Name);
                Console.Write("Navigation Order (Last Visited First): ");
                s.NavigationStack.Display();
                int score = evaluator.CalculateScore(s.Answers);
                Console.WriteLine("\nScore: " + score + "/" + totalQuestions);
            }
        }
    }
}
