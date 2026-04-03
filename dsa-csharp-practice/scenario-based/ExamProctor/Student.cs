using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.ExamProctor
{
    internal class Student
    {
        public int StudentId;
        public string Name;
        public CustomStack NavigationStack;
        public Dictionary<int, string> Answers;
        public Student(int id,string name,int totalQuestions)
        {
            StudentId = id;
            Name = name;
            NavigationStack = new CustomStack(totalQuestions);
            Answers = new Dictionary<int, string>();
        }
        public void VisitQuestion(int qid)
        {
            NavigationStack.Push(qid);
        }
        public void AnswerQuestion(int qid,string answer)
        {
            Answers[qid] = answer;
        }
    }
}
