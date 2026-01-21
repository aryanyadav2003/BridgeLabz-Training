using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.EduResults
{
    internal class Student
    {
        public string Name;
        public int Score;
        public Student(string name,int score)
        {
            Name = name;
            Score = score;
        }
        public void Display()
        {
            Console.WriteLine("Name : " + Name + " | " + " Score "+ Score);
        }
    }
}
