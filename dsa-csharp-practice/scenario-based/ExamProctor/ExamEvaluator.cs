using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.ExamProctor
{
    internal class ExamEvaluator
    {
        private Dictionary<int, string> correctAnswer = new Dictionary<int, string>()
        {
             {1, "A"}, {2, "B"},{3, "C"},{4, "D"}, {5, "A"},{6,"a"},{7, "A"}, {8, "B"},{9, "C"},{10, "D"}
        };
        public int CalculateScore(Dictionary<int, string> studentAnswers)
        {
            int score = 0;
            foreach (var q in correctAnswer)
            {
                if (studentAnswers.ContainsKey(q.Key) && studentAnswers[q.Key] == q.Value)
                {
                    score++;
                }
            }
            return score;
        }
    }
}
